using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Newtonsoft.Json;
using static System.Net.WebRequestMethods;

namespace Lab4
{
    public partial class Bai4 : Form
    {
        public Bai4()
        {
            InitializeComponent();
        }
        int pageNumber = 1; // Giá trị ban đầu của số
        private const string ApiUrl = "https://reqres.in/api/users?page=";

        private async void button1_Click(object sender, EventArgs e)
        {
            s();
        }
        async void s()
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync(ApiUrl + pageNumber);
                    response.EnsureSuccessStatusCode();

                    string responseContent = await response.Content.ReadAsStringAsync();
                    ApiResponse apiResponse = JsonConvert.DeserializeObject<ApiResponse>(responseContent);

                    // Hiển thị thông tin từ đối tượng JSON lên giao diện
                    PageTextBox.Text = apiResponse.Page.ToString();
                    PerPageTextBox.Text = apiResponse.PerPage.ToString();
                    TotalTextBox.Text = apiResponse.Total.ToString();
                    TotalPagesTextBox.Text = apiResponse.TotalPages.ToString();


                    // Xóa các PictureBox hiện có trong FlowLayoutPanel (nếu có)
                    flowLayoutPanel.Controls.Clear();
                    // Đặt FlowDirection của FlowLayoutPanel thành TopDown
                    flowLayoutPanel.FlowDirection = FlowDirection.TopDown;
                    foreach (User user in apiResponse.Data)
                    {


                        // Hiển thị thông tin người dùng bằng Panel
                        Panel panel = new Panel();
                        panel.Width = 800;
                        panel.Height = 200;
                        panel.BorderStyle = BorderStyle.FixedSingle;



                        PictureBox pictureBox = new PictureBox();
                        pictureBox.Load(user.Avatar);
                        pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBox.Width = 200;
                        pictureBox.Height = 200;
                        pictureBox.Top = 10;
                        pictureBox.Left = 600; // Đặt Anchor để ảnh nằm bên phải cùng

                        Label nameLabel = new Label();
                        nameLabel.Text = user.FirstName + " " + user.LastName;
                        nameLabel.Dock = DockStyle.Top;
                        nameLabel.TextAlign = ContentAlignment.TopLeft;

                        Label emailLabel = new Label();
                        emailLabel.Text = user.Email;
                        emailLabel.Dock = DockStyle.Top;
                        emailLabel.TextAlign = ContentAlignment.TopLeft;

                        panel.Controls.Add(nameLabel);
                        panel.Controls.Add(emailLabel);
                        panel.Controls.Add(pictureBox);

                        flowLayoutPanel.Controls.Add(panel);
                    }


                    // Cập nhật lại layout của FlowLayoutPanel
                    flowLayoutPanel.PerformLayout();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            pageNumber++;
            s();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (pageNumber == 1)
            {
                MessageBox.Show("Không thể lui nữa ");
            }
            else
            {
                pageNumber--;
                s();
            }
        }
    }

    public class ApiResponse
    {
        [JsonProperty("page")]
        public int Page { get; set; }

        [JsonProperty("per_page")]
        public int PerPage { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("total_pages")]
        public int TotalPages { get; set; }

        [JsonProperty("data")]
        public User[] Data { get; set; }
    }

    public class User
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("avatar")]
        public string Avatar { get; set; }

        public override string ToString()
        {
            return $"ID: {Id}, Name: {FirstName} {LastName}, Email: {Email}";
        }
    }
}