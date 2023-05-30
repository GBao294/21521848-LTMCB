namespace Lab4
{
    partial class Bai3
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            textBox1 = new TextBox();
            pnlWeb = new Panel();
            label2 = new Label();
            fileurl = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(116, 40);
            button1.TabIndex = 0;
            button1.Text = "AddBrowser";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(134, 0);
            button2.Name = "button2";
            button2.Size = new Size(116, 40);
            button2.TabIndex = 1;
            button2.Text = "Go";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(4, 61);
            button3.Name = "button3";
            button3.Size = new Size(116, 40);
            button3.TabIndex = 2;
            button3.Text = "Download";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(134, 61);
            button4.Name = "button4";
            button4.Size = new Size(116, 40);
            button4.TabIndex = 3;
            button4.Text = "DownloadResource";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(273, 6);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(515, 27);
            textBox1.TabIndex = 4;
            // 
            // pnlWeb
            // 
            pnlWeb.Location = new Point(4, 107);
            pnlWeb.Name = "pnlWeb";
            pnlWeb.Size = new Size(1920, 1080);
            pnlWeb.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(807, 70);
            label2.Name = "label2";
            label2.Size = new Size(69, 25);
            label2.TabIndex = 10;
            label2.Text = "FileURL";
            // 
            // fileurl
            // 
            fileurl.Location = new Point(276, 68);
            fileurl.Name = "fileurl";
            fileurl.Size = new Size(512, 27);
            fileurl.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(807, 9);
            label1.Name = "label1";
            label1.Size = new Size(43, 25);
            label1.TabIndex = 11;
            label1.Text = "URL";
            // 
            // Bai3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(897, 450);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(fileurl);
            Controls.Add(pnlWeb);
            Controls.Add(textBox1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Bai3";
            Text = "Bai3";
            Load += Bai3_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private TextBox textBox1;
        private Panel pnlWeb;
        private Label label2;
        private TextBox fileurl;
        private Label label1;
    }
}