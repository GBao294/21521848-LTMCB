using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MailKit.Net.Smtp;
using MailKit;
using MimeKit;

namespace Lab05
{
    public partial class Bai1 : Form
    {
        public Bai1()
        {
            InitializeComponent();
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            var client = new SmtpClient();
            client.Connect("smtp.gmail.com", 465, true); 
            client.Authenticate(textBoxFrom.Text.Trim(), "kkxsrrdliwcedadj"); 
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("ten nguoi gui", textBoxFrom.Text.Trim()));
            message.To.Add(new MailboxAddress("", textBoxTo.Text.Trim()));
            message.Subject = textBoxSubject.Text.Trim();
            message.Body = new TextPart("plain") 
            {
                Text = richTextBoxBody.Text,
                };
            client.Send(message);
            client.Disconnect(true);
        }

        private void Bai1_Load(object sender, EventArgs e)
        {

        }
    }
}
