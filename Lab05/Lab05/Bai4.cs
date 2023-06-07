using MailKit.Net.Imap;
using MailKit;
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
using MailKit.Search;

namespace Lab05
{
    public partial class Bai4 : Form
    {
        ImapClient client;
        public Bai4()
        {
            InitializeComponent();
            client = new ImapClient();
            buttonRefresh.Enabled = false;
            buttonSendMail.Enabled = false;

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        string IMAP,SMTP;
        int portIMAP, portSMTP;
        private void buttonSignIn_Click(object sender, EventArgs e)
        {
            if (buttonSignIn.Text == "đăng xuất")
            {
                try
                {
                    if (client.IsConnected)
                    {
                        client.Disconnect(true);
                        MessageBox.Show("Đã đăng xuất");
                        Bai4_Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Không có kết nối đến server");
                    }
                    buttonSignIn.Text = "Đăng nhập";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
                }
                textBoxEmail.ReadOnly = false;
                textBoxPass.ReadOnly = false;
                txtIMAP.ReadOnly = false;
                txtPortIMAP.ReadOnly = false;
                txtPortSMTP.ReadOnly = false;
                txtSMTP.ReadOnly = false;
                buttonRefresh.Enabled = false;
                buttonSendMail.Enabled = false;
                textBoxEmail.Text = "";
                textBoxPass.Text = "";
                txtIMAP.Text = "";
                txtPortIMAP.Text = "";
                txtPortSMTP.Text = "";
                txtSMTP.Text = "";
                buttonSignIn.Text = "đăng nhập";
            }
            else
            {
                if (txtIMAP.Text == "")
                {
                    txtIMAP.Text = "imap.gmail.com";
                }
                if(txtPortIMAP.Text == "")
                {
                    txtPortIMAP.Text = "993";
                }
                if (txtSMTP.Text == "")
                {
                    txtSMTP.Text = "smtp.gmail.com";
                }
                if (txtPortSMTP.Text == "")
                {
                    txtPortSMTP.Text = "465";
                }
                listViewMess.Clear();
                listViewMess.Columns.Add("Email", 300);
                listViewMess.Columns.Add("From", 200);
                listViewMess.Columns.Add("Date", 100);
                listViewMess.Columns.Add("Content", 0);
                //Tạo cột và phạm vi cột

                try
                {
                    client.Connect(txtIMAP.Text, int.Parse(txtPortIMAP.Text), true);
                    client.Authenticate(textBoxEmail.Text.Trim(), textBoxPass.Text.Trim());
                    var inbox = client.Inbox;
                    inbox.Open(FolderAccess.ReadOnly);
                    // Tạo kết nối


                    int n = 4;
                    //n = inbox.Count;
                    for (int i = 0; i < n; i++)
                    {
                        var message = inbox.GetMessage(i);
                        var item = new ListViewItem(new[] { message.Subject, message.From.ToString(), message.Date.ToString(), message.HtmlBody });
                        listViewMess.Items.Add(item);
                    }// Add thông tin lên bảng
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }
                textBoxEmail.ReadOnly = true;
                textBoxPass.ReadOnly = true;
                txtIMAP.ReadOnly = true;
                txtPortIMAP.ReadOnly = true;
                txtPortSMTP.ReadOnly = true;
                txtSMTP.ReadOnly = true;
                buttonRefresh.Enabled = true;
                buttonSendMail.Enabled = true;
                buttonSignIn.Text = "đăng xuất";
            }
        }

        private void listViewShowMail_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            

        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            Refresh_Mail(sender, e);
        }
        private void Refresh_Mail(object sender, EventArgs e)
        {
            listViewMess.Clear();
            listViewMess.Columns.Add("Email", 300);
            listViewMess.Columns.Add("From", 200);
            listViewMess.Columns.Add("Date", 100);
            listViewMess.Columns.Add("Content", 0);
            var inbox = client.Inbox;
            inbox.Open(FolderAccess.ReadOnly);
            // Tạo kết nối


            int n = 12;
            //n = inbox.Count;
            for (int i = 0; i < n; i++)
            {
                var message = inbox.GetMessage(i);
                var item = new ListViewItem(new[] { message.Subject, message.From.ToString(), message.Date.ToString(), message.HtmlBody });
                listViewMess.Items.Add(item);
            }// Add thông tin lên bảng
        }
        private void Bai4_Load(object sender, EventArgs e)
        {

        }

        private void listViewMess_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.IsSelected)
            {
                // Get the selected item
                ListViewItem selectedItem = e.Item;

                // Open Form2 and pass the selected item's data
                string subject = listViewMess.SelectedItems[0].SubItems[0].Text;
                string From = listViewMess.SelectedItems[0].SubItems[1].Text;
                string emailContent = listViewMess.SelectedItems[0].SubItems[3].Text;
                if (listViewMess.SelectedItems.Count > 0)
                {
                    // Lấy nội dung email từ SubItem 2 của mục được chọn

                    ReadMail form2 = new ReadMail(From, textBoxEmail.Text, subject, emailContent);

                    form2.Show();
                }
            }
        }

        private void buttonSendMail_Click(object sender, EventArgs e)
        {
           
            SendMail sendMail = new SendMail(textBoxEmail.Text,textBoxPass.Text,txtSMTP.Text,txtPortSMTP.Text);
            sendMail.Show();
        }

        private void textBoxPass_TextChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.TextBox textBox = (System.Windows.Forms.TextBox)sender;
            textBox.UseSystemPasswordChar = true;
        }
    }
}
