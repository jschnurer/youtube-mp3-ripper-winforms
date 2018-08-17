namespace YoutubeMP3Ripper
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtCommand = new System.Windows.Forms.TextBox();
            this.chkExpert = new System.Windows.Forms.CheckBox();
            this.btnRip = new System.Windows.Forms.Button();
            this.lblCommand = new System.Windows.Forms.Label();
            this.txtYoutubeURL = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtCommand
            // 
            this.txtCommand.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCommand.Location = new System.Drawing.Point(99, 33);
            this.txtCommand.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCommand.Name = "txtCommand";
            this.txtCommand.Size = new System.Drawing.Size(566, 24);
            this.txtCommand.TabIndex = 0;
            this.txtCommand.Text = "./youtube-dl.exe --extract-audio --audio-format mp3";
            this.txtCommand.Visible = false;
            // 
            // chkExpert
            // 
            this.chkExpert.AutoSize = true;
            this.chkExpert.Location = new System.Drawing.Point(13, 10);
            this.chkExpert.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkExpert.Name = "chkExpert";
            this.chkExpert.Size = new System.Drawing.Size(111, 22);
            this.chkExpert.TabIndex = 1;
            this.chkExpert.Text = "Expert Mode";
            this.chkExpert.UseVisualStyleBackColor = true;
            this.chkExpert.CheckedChanged += new System.EventHandler(this.chkExpert_CheckedChanged);
            // 
            // btnRip
            // 
            this.btnRip.Image = ((System.Drawing.Image)(resources.GetObject("btnRip.Image")));
            this.btnRip.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRip.Location = new System.Drawing.Point(235, 124);
            this.btnRip.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRip.Name = "btnRip";
            this.btnRip.Size = new System.Drawing.Size(205, 51);
            this.btnRip.TabIndex = 2;
            this.btnRip.Text = "RIP AND TEAR!";
            this.btnRip.UseVisualStyleBackColor = true;
            this.btnRip.Click += new System.EventHandler(this.btnRip_Click);
            // 
            // lblCommand
            // 
            this.lblCommand.AutoSize = true;
            this.lblCommand.Location = new System.Drawing.Point(13, 36);
            this.lblCommand.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCommand.Name = "lblCommand";
            this.lblCommand.Size = new System.Drawing.Size(78, 18);
            this.lblCommand.TabIndex = 3;
            this.lblCommand.Text = "Command";
            this.lblCommand.Visible = false;
            // 
            // txtYoutubeURL
            // 
            this.txtYoutubeURL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtYoutubeURL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYoutubeURL.Location = new System.Drawing.Point(13, 85);
            this.txtYoutubeURL.Margin = new System.Windows.Forms.Padding(4);
            this.txtYoutubeURL.Name = "txtYoutubeURL";
            this.txtYoutubeURL.Size = new System.Drawing.Size(652, 31);
            this.txtYoutubeURL.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(271, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "Youtube video URL";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtLog
            // 
            this.txtLog.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLog.Location = new System.Drawing.Point(13, 183);
            this.txtLog.Margin = new System.Windows.Forms.Padding(4);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.Size = new System.Drawing.Size(652, 132);
            this.txtLog.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 328);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtYoutubeURL);
            this.Controls.Add(this.lblCommand);
            this.Controls.Add(this.btnRip);
            this.Controls.Add(this.chkExpert);
            this.Controls.Add(this.txtCommand);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Youtube MP3 Ripper";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCommand;
        private System.Windows.Forms.CheckBox chkExpert;
        private System.Windows.Forms.Button btnRip;
        private System.Windows.Forms.Label lblCommand;
        private System.Windows.Forms.TextBox txtYoutubeURL;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLog;
    }
}

