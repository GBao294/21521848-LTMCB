using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Net.Http;
using Newtonsoft.Json;
//using Newtonsoft.Json;


namespace Lab4
{
    public partial class Bai5 : Form
    {
        private const string ApiUrl = "https://reqres.in/api/register";
        // private const string Email = "eve.holt@reqres.in";
        // private const string Password = "pistol";
        public Bai5()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    var requestData = new { email = name.Text, password = pass.Text };
                    string jsonRequest = JsonConvert.SerializeObject(requestData);
                    HttpContent content = new StringContent(jsonRequest, System.Text.Encoding.UTF8, "application/json");

                    HttpResponseMessage response = await client.PostAsync(ApiUrl, content);
                    response.EnsureSuccessStatusCode();

                    string responseContent = await response.Content.ReadAsStringAsync();
                    ApiResult apiResult = JsonConvert.DeserializeObject<ApiResult>(responseContent);

                    TokenTextBox.Text = apiResult.Token;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
     

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }

    public class ApiResult
    {
        [JsonProperty("token")]
        public string Token { get; set; }
    }
}
