namespace AudioRepeater
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.RecordingStatusLabel = new System.Windows.Forms.Label();
            this.HotkeyTextBox = new System.Windows.Forms.TextBox();
            this.SetHotkeyButton = new System.Windows.Forms.Button();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RecordingStatusLabel
            // 
            this.RecordingStatusLabel.AutoSize = true;
            this.RecordingStatusLabel.Location = new System.Drawing.Point(31, 26);
            this.RecordingStatusLabel.Name = "RecordingStatusLabel";
            this.RecordingStatusLabel.Size = new System.Drawing.Size(56, 13);
            this.RecordingStatusLabel.TabIndex = 0;
            this.RecordingStatusLabel.Text = "Recording";
            // 
            // HotkeyTextBox
            // 
            this.HotkeyTextBox.AcceptsReturn = true;
            this.HotkeyTextBox.AcceptsTab = true;
            this.HotkeyTextBox.Location = new System.Drawing.Point(443, 44);
            this.HotkeyTextBox.Name = "HotkeyTextBox";
            this.HotkeyTextBox.Size = new System.Drawing.Size(147, 20);
            this.HotkeyTextBox.TabIndex = 1;
            this.HotkeyTextBox.Text = "Alt + Shift + S";
            // 
            // SetHotkeyButton
            // 
            this.SetHotkeyButton.Location = new System.Drawing.Point(596, 44);
            this.SetHotkeyButton.Name = "SetHotkeyButton";
            this.SetHotkeyButton.Size = new System.Drawing.Size(75, 20);
            this.SetHotkeyButton.TabIndex = 2;
            this.SetHotkeyButton.Text = "Set Hotkey";
            this.SetHotkeyButton.UseVisualStyleBackColor = true;
            this.SetHotkeyButton.Click += new System.EventHandler(this.SetHotkeyButton_Click);
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Location = new System.Drawing.Point(443, 71);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(0, 13);
            this.StatusLabel.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.SetHotkeyButton);
            this.Controls.Add(this.HotkeyTextBox);
            this.Controls.Add(this.RecordingStatusLabel);
            this.Name = "MainForm";
            this.Text = "AudioRepeater";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label RecordingStatusLabel;
        private System.Windows.Forms.TextBox HotkeyTextBox;
        private System.Windows.Forms.Button SetHotkeyButton;
        private System.Windows.Forms.Label StatusLabel;
    }
}

