namespace Lab4
{
    partial class Bai2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            box = new RichTextBox();
            button1 = new Button();
            url = new TextBox();
            fileurl = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // box
            // 
            box.Location = new Point(54, 83);
            box.Name = "box";
            box.Size = new Size(711, 425);
            box.TabIndex = 5;
            box.Text = "";
            // 
            // button1
            // 
            button1.Location = new Point(641, 10);
            button1.Name = "button1";
            button1.Size = new Size(124, 67);
            button1.TabIndex = 4;
            button1.Text = "DOWNLOAD";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // url
            // 
            url.Location = new Point(149, 11);
            url.Name = "url";
            url.Size = new Size(474, 27);
            url.TabIndex = 3;
            // 
            // fileurl
            // 
            fileurl.Location = new Point(149, 50);
            fileurl.Name = "fileurl";
            fileurl.Size = new Size(474, 27);
            fileurl.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(54, 11);
            label1.Name = "label1";
            label1.Size = new Size(43, 25);
            label1.TabIndex = 7;
            label1.Text = "URL";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(54, 49);
            label2.Name = "label2";
            label2.Size = new Size(69, 25);
            label2.TabIndex = 8;
            label2.Text = "FileURL";
            // 
            // Bai2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(819, 520);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(fileurl);
            Controls.Add(box);
            Controls.Add(button1);
            Controls.Add(url);
            Name = "Bai2";
            Text = "Bai2";
            Load += Bai2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox box;
        private Button button1;
        private TextBox url;
        private TextBox fileurl;
        private Label label1;
        private Label label2;
    }
}