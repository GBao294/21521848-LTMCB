using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace lab4
{
    public partial class Form1 : Form
    {
        private string downloadPath = @"D:\";
        public Form1()
        {
            InitializeComponent();
            webBrowser1.ScriptErrorsSuppressed = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            NavigateToPage(txtURL.Text);
        }

        private void NavigateToPage(string url)
        {
            if (String.IsNullOrEmpty(url)) return;
            if (!url.StartsWith("http://") && !url.StartsWith("https://"))
            {
                url = "http://" + url;
            }
            webBrowser1.Navigate(new Uri(url));
        }

        private void btnDownloadHTML_Click(object sender, EventArgs e)
        {
            string html = webBrowser1.DocumentText;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Html files (*.html)|*.html|All files (*.*)|*.*";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(saveFileDialog1.OpenFile()))
                {
                    sw.Write(html);
                }
            }
        }
        private void webBrowser1_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            // Hiển thị URL trên textbox
            txtURL.Text = webBrowser1.Url.ToString();
        }
        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void btnDownloadResource_Click(object sender, EventArgs e)
        {
            if (webBrowser1.Document != null)
            {
                getresource();
            }
            else
            {
                MessageBox.Show("Không có nội dung để tải xuống HTML.");
            }
        }
        private string getHTML(string szURL)
        {
            if (!szURL.StartsWith("http://") && !szURL.StartsWith("https://"))
            {
                szURL = "http://" + szURL;
            }
            // Create a request for the URL.
            WebRequest request = WebRequest.Create(szURL);
            // Get the response.
            WebResponse response = request.GetResponse();
            // Get the stream containing content returned by the server.
            Stream dataStream = response.GetResponseStream();
            // Open the stream using a StreamReader for easy access.
            StreamReader reader = new StreamReader(dataStream);
            // Read the content.
            string responseFromServer = reader.ReadToEnd();
            // Close the response.
            response.Close();
            return responseFromServer;
        }
        private void getresource()
        {

            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    string folderPath = folderBrowserDialog.SelectedPath;
                    DownloadResources(webBrowser1.Document, folderPath);
                    MessageBox.Show("Tải xuống tài nguyên thành công.");
                }
            }
        }
        private void DownloadResources(HtmlDocument document, string folderPath)
        {
            foreach (HtmlElement imgElement in document.Images)
            {
                string src = imgElement.GetAttribute("src");
                if (!string.IsNullOrWhiteSpace(src))
                {
                    string fileName = Path.GetFileName(src);
                    string filePath = Path.Combine(folderPath, fileName);
                    using (WebClient webClient = new WebClient())
                    {
                        webClient.DownloadFile(src, filePath);
                    }
                }
            }

        }
        private string GetWebsiteDirectoryName(string url)
        {
            Uri uri = new Uri(url);
            return uri.Host;
        }

    
    private void btnViewSource_Click(object sender, EventArgs e)
        {
           
        }

        private void btnViewSource_Click_1(object sender, EventArgs e)
        {
            txtSource.Text = getHTML(txtURL.Text.ToString());
        }

        private void txtURL_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
