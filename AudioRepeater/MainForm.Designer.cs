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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RecordingStatusLabel);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label RecordingStatusLabel;
    }
}

