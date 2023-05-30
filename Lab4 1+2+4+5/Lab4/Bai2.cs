using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class Bai2 : Form
    {
        public Bai2()
        {
            InitializeComponent();
        }
        private string getHTML(string szURL)
        {
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



        private void button1_Click(object sender, EventArgs e)
        {
            box.Text = null;
            box.Text = getHTML(url.Text.ToString());

            WebClient myClient = new WebClient();
            Stream response = myClient.OpenRead(url.Text);
            myClient.DownloadFile(url.Text, fileurl.Text);

        }

        private void Bai2_Load(object sender, EventArgs e)
        {

        }
    }
}
