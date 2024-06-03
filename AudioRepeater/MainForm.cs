using NAudio.Utils;
using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AudioRepeater
{
    public partial class MainForm : Form
    {
        BufferedWaveProvider buffer;
        WaveOutEvent output;
        WasapiLoopbackCapture input;
        RawSourceWaveStream stream;
        Stopwatch stopwatch = new Stopwatch();
        HotKeyWithAction hotkey;
        int totalSeconds = 5;
        int restartSeconds = 10;
        bool recording = true;

        public MainForm()
        {
            InitializeComponent();
            
            input = new WasapiLoopbackCapture();
            output = new WaveOutEvent();
            HotkeyTextBox.Text = "Alt + Shift + S";
            this.hotkey = GlobalHotKey.RegisterHotKey(HotkeyTextBox.Text, () => Play());
            buffer = new BufferedWaveProvider(input.WaveFormat);
            buffer.BufferDuration = TimeSpan.FromSeconds(totalSeconds);
            buffer.ReadFully = true;
            input.DataAvailable += RecordData;
            input.StartRecording();
        }

        private void RestartRecording()
        {
            RecordingStatusLabel.Text = "Recording";
            output.Stop();
            recording = true;
            input.StartRecording();
        }

        private void RecordData(object sender, WaveInEventArgs e)
        {
            buffer.AddSamples(e.Buffer, 0, e.BytesRecorded);
        }

        public async void Play()
        {
            RecordingStatusLabel.Text = "Playing";
            if (recording)
            {
                input.StopRecording();
                output.Stop();
                var bytes = new byte[buffer.BufferedBytes];
                buffer.Read(bytes, 0, bytes.Length);
                stream = new RawSourceWaveStream(bytes, 0, bytes.Length, input.WaveFormat);
                output.Init(stream);
                recording = false;
            }

            output.Stop();
            var s = stream;
            if(s != null)
            {
                s.Position = 0;
            }

            output.Play();
            stopwatch.Restart();
            await Task.Delay(TimeSpan.FromSeconds(restartSeconds));
            if(!recording && stopwatch.Elapsed >= TimeSpan.FromSeconds(restartSeconds))
            {
                RestartRecording();
            }
        }

        private async void SetHotkeyButton_Click(object sender, EventArgs e)
        {
            var hotkey = this.hotkey;
            if(hotkey != null)
            {
                this.hotkey = null;
                hotkey.Dispose();
            }
            try
            {
                this.hotkey = GlobalHotKey.RegisterHotKey(HotkeyTextBox.Text, () => Play());
                StatusLabel.Text = "Succeeded";
                await Task.Delay(500);
                StatusLabel.Text = "";
            }
            catch (Exception ex)
            {
                StatusLabel.Text = "Failed";
                await Task.Delay(500);
                StatusLabel.Text = "";
            }
        }
    }
}
