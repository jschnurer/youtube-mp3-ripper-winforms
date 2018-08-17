using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YoutubeMP3Ripper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void chkExpert_CheckedChanged(object sender, EventArgs e)
        {
            lblCommand.Visible = txtCommand.Visible = chkExpert.Checked;
        }

        private void btnRip_Click(object sender, EventArgs e)
        {
            LaunchYoutubeDL();
        }

        void LaunchYoutubeDL()
        {
            // Use ProcessStartInfo class
            //ProcessStartInfo startInfo = new ProcessStartInfo();
            //startInfo.CreateNoWindow = false;
            //startInfo.UseShellExecute = false;
            //startInfo.FileName = "youtube-dl.exe";
            //startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            //startInfo.Arguments = "--extract-audio --audio-format mp3 " + txtYoutubeURL.Text;

            Process process;
            process = new Process();
            process.StartInfo.FileName = Path.Combine(Directory.GetCurrentDirectory(), "Lib", "youtube-dl.exe");
            process.StartInfo.Arguments = "--extract-audio --audio-format mp3 " + txtYoutubeURL.Text;
            process.StartInfo.UseShellExecute = false;
            process.StartInfo.CreateNoWindow = true;
            process.StartInfo.RedirectStandardOutput = true;
            process.OutputDataReceived += new DataReceivedEventHandler(OutputHandler);
            process.StartInfo.RedirectStandardInput = true;
            process.EnableRaisingEvents = true;
            process.Exited += Process_Exited;

            try
            {
                process.Start();
                process.BeginOutputReadLine();
            }
            catch (Exception ex) {
                txtLog.AppendText(ex.Message + Environment.NewLine);
            }
        }

        private void Process_Exited(object sender, EventArgs e)
        {
            string line = "MP3 download complete!";

            if (txtLog.InvokeRequired)
            {
                txtLog.Invoke(new MethodInvoker(delegate {
                    txtLog.AppendText(line + Environment.NewLine);
                }));
            }
            else
            {
                txtLog.AppendText(line + Environment.NewLine);
            }

            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = Directory.GetCurrentDirectory()
            };

            Process.Start(psi);
        }

        private void OutputHandler(object sendingProcess, DataReceivedEventArgs outLine)
        {
            if (outLine.Data == null)
                return;

            string line;
            line = (outLine.Data.ToString());

            if (txtLog.InvokeRequired)
            {
                txtLog.Invoke(new MethodInvoker(delegate {
                    txtLog.AppendText(line + Environment.NewLine);
                }));
            }
            else
            {
                txtLog.AppendText(line + Environment.NewLine);
            }
        }
    }
}
