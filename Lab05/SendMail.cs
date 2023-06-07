using MimeKit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using MailKit.Net.Smtp;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Lab05
{
    public partial class SendMail : Form
    {
        public SendMail(string From,string Pass,string addrSMTP,string portSMTP)
        {
            InitializeComponent();
            textBoxFrom.ReadOnly = true;
            textBoxOpenfile.ReadOnly = true;
            textBoxFrom.Text = From;
            this.Pass = Pass;
            this.addrSMTP = addrSMTP;
            this.portSMTP = portSMTP;
        }
        string Pass;
        string addrSMTP,portSMTP;
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = false;
            openFileDialog.Filter = "All Files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                textBoxOpenfile.Text = filePath;
            }
        }

        private void textBoxFrom_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void SendMail_Load(object sender, EventArgs e)
        {

        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            try
            {
                var client = new SmtpClient();
                client.Connect(addrSMTP, int.Parse(portSMTP), true);
                client.Authenticate(textBoxFrom.Text.Trim(), Pass);
                var message = new MimeMessage();
                message.From.Add(new MailboxAddress(textBoxName.Text, textBoxFrom.Text.Trim()));
                message.To.Add(new MailboxAddress("", textBoxSendTo.Text.Trim()));
                message.Subject = textBoxSubject.Text.Trim();
                
                message.Body = new TextPart();
                var bodyBuilder = new BodyBuilder();
                if (checkBoxHtml.Checked == true)
                {
                    bodyBuilder.HtmlBody = richTextBox1.Text;
                }
                else
                {
                    bodyBuilder.TextBody = richTextBox1.Text;
                }
                string filePath = textBoxOpenfile.Text;
                if (!string.IsNullOrEmpty(filePath))
                {
                    bodyBuilder.Attachments.Add(filePath);
                }
                message.Body = bodyBuilder.ToMessageBody();
                
                client.Send(message);
                MessageBox.Show("Email sent successfully.", "Success", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error sending email: " + ex.Message);
            }

        }
    }
}
