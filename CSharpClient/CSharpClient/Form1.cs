using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;

namespace CSharpClient
{
    public partial class FormMailer : Form
    {
        public FormMailer()
        {
            InitializeComponent();
        }

        OpenFileDialog opf = new OpenFileDialog();
        SmtpClient client = null;

        private void btnChooseFile_Click_1(object sender, EventArgs e)
        {
            if (opf.ShowDialog() == DialogResult.OK)
            {
                textFileDirection.Text = opf.FileName;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textFileDirection.Clear();
            textLogin.Clear();
            textPassword.Clear();
            textServer.Clear();
            textPort.Clear();
            textSubject.Clear();
            textMessage.Clear();
        }

        private void btnDefault_Click(object sender, EventArgs e)
        {
            textServer.Text = "smmtp.gmail.com";
            textPort.Text = "587";
            chbxUseSSL.Checked = false;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            int counter = 0;
            string email;
            System.IO.StreamReader file = new System.IO.StreamReader(textFileDirection.Text);
            while ((email = file.ReadLine()) != null)
            {
                try
                {
                    Log("Sending message to " + email);
                    MailMessage msg = new MailMessage(textLogin.Text, email);
                    msg.Subject = textSubject.Text;
                    msg.Body = textMessage.Text;
                    client.Send(msg);
                    counter++;
                }
                catch (System.Net.Mail.SmtpException)
                {
                    Log("To connect to this server SSL required. Enable it and try again.");
                    return;
                }
                catch (System.ArgumentException)
                {
                    Log("Error! Please enter email and password and try again.");
                    return;
                }
            }
            Log("All mesages was sent successfully!");

        }

        private void FormMailer_Load(object sender, EventArgs e)
        {
            lblLog.Text = "";
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            client = new SmtpClient(textServer.Text, int.Parse(textPort.Text));
            client.UseDefaultCredentials = false;
            client.Credentials = new NetworkCredential(textLogin.Text, textPassword.Text);
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            if (chbxUseSSL.Checked)
            {
                client.EnableSsl = true;
            }
            Log("Connected successfully!");
            
        }

        private void Log(string logText)
        {
            lblLog.Text = logText;
        }
    }
}
