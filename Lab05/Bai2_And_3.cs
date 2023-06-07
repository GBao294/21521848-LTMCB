using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MimeKit;
using MailKit;
using MailKit.Search;
using MailKit.Net.Imap;
using MailKit.Net.Pop3;

namespace Lab05
{
    public partial class Bai2_And_3 : Form
    {
        public Bai2_And_3()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonIMAP_Click(object sender, EventArgs e)
        {
            listViewMess.Clear();
            listViewMess.Columns.Add("Email", 300);
            listViewMess.Columns.Add("From", 200);
            listViewMess.Columns.Add("Date", 100);//Tạo cột và phạm vi cột
            var client = new ImapClient();
            try
            {
                client.Connect("imap.gmail.com", 993, true);
                client.Authenticate(textBoxEmail.Text.Trim(), textBoxPass.Text.Trim());
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            var inbox = client.Inbox;
            inbox.Open(FolderAccess.ReadOnly);
            labelTotal_2.Text = inbox.Count.ToString();
            labelRecent_2.Text = inbox.Recent.ToString();

            // Tạo kết nối



            for (int i = 0; i < 4; i++)
            {
                var message = inbox.GetMessage(i);
                var item = new ListViewItem(new[] { message.Subject, message.From.ToString(), message.Date.ToString() });
                listViewMess.Items.Add(item);
            }// Add thông tin lên bảng
            client.Disconnect(true);
        }

        private void buttonPop3_Click(object sender, EventArgs e)
        {
            using (var client = new Pop3Client())
            {
                listViewMess.Clear();
                listViewMess.Columns.Add("Email", 300);
                listViewMess.Columns.Add("From", 200);
                listViewMess.Columns.Add("Date", 100);//Tạo cột và phạm vi cột
                client.Connect("pop.gmail.com", 995, true);

                client.Authenticate(textBoxEmail.Text.Trim(), textBoxPass.Text.Trim());
                labelTotal_2.Text = client.Count.ToString();//Đếm tổng số thư

                //Tạo kết nối


                for (int i = 0; i < 2; i++)
                {
                    var message = client.GetMessage(i);
                    var item = new ListViewItem(new[] { message.Subject, message.From.ToString(), message.Date.ToString() });
                    listViewMess.Items.Add(item);
                    
                }/// Add thông tin lên 

                client.Disconnect(true);
            }
        }

        private void Bai2_And_3_Load(object sender, EventArgs e)
        {

        }

        private void listViewMess_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void labelRecent_2_Click(object sender, EventArgs e)
        {

        }

        private void textBoxPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelPass_Click(object sender, EventArgs e)
        {

        }

        private void labelEmail_Click(object sender, EventArgs e)
        {

        }
    }
}
