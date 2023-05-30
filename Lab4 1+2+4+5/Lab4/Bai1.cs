using System.Net;

namespace Lab4
{
    public partial class Bai1 : Form
    {
        public Bai1()
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
            box.Text = getHTML(url.Text.ToString());
        }

        private void url_TextChanged(object sender, EventArgs e)
        {

        }
    }
}