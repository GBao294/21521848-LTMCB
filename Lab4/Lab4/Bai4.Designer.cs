namespace Lab4
{
    partial class Bai4
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
            PageTextBox = new TextBox();
            PerPageTextBox = new TextBox();
            TotalTextBox = new TextBox();
            TotalPagesTextBox = new TextBox();
            flowLayoutPanel = new FlowLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            button2 = new Button();
            button3 = new Button();
            label5 = new Label();
            UserList = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(740, 30);
            button1.Name = "button1";
            button1.Size = new Size(233, 123);
            button1.TabIndex = 0;
            button1.Text = "Start";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // PageTextBox
            // 
            PageTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PageTextBox.Location = new Point(124, 30);
            PageTextBox.Name = "PageTextBox";
            PageTextBox.Size = new Size(217, 34);
            PageTextBox.TabIndex = 1;
            // 
            // PerPageTextBox
            // 
            PerPageTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PerPageTextBox.Location = new Point(124, 103);
            PerPageTextBox.Name = "PerPageTextBox";
            PerPageTextBox.Size = new Size(217, 34);
            PerPageTextBox.TabIndex = 2;
            // 
            // TotalTextBox
            // 
            TotalTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TotalTextBox.Location = new Point(504, 103);
            TotalTextBox.Name = "TotalTextBox";
            TotalTextBox.Size = new Size(217, 34);
            TotalTextBox.TabIndex = 3;
            // 
            // TotalPagesTextBox
            // 
            TotalPagesTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            TotalPagesTextBox.Location = new Point(504, 33);
            TotalPagesTextBox.Name = "TotalPagesTextBox";
            TotalPagesTextBox.Size = new Size(217, 34);
            TotalPagesTextBox.TabIndex = 4;
            // 
            // flowLayoutPanel
            // 
            flowLayoutPanel.AutoScroll = true;
            flowLayoutPanel.BorderStyle = BorderStyle.Fixed3D;
            flowLayoutPanel.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            flowLayoutPanel.Location = new Point(24, 180);
            flowLayoutPanel.Name = "flowLayoutPanel";
            flowLayoutPanel.Size = new Size(949, 470);
            flowLayoutPanel.TabIndex = 10;
            flowLayoutPanel.WrapContents = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(15, 30);
            label1.Name = "label1";
            label1.Size = new Size(54, 28);
            label1.TabIndex = 11;
            label1.Text = "Page";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(15, 103);
            label2.Name = "label2";
            label2.Size = new Size(103, 28);
            label2.TabIndex = 12;
            label2.Text = "User/page";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(375, 33);
            label3.Name = "label3";
            label3.Size = new Size(96, 28);
            label3.TabIndex = 13;
            label3.Text = "TotalPage";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(375, 107);
            label4.Name = "label4";
            label4.Size = new Size(101, 28);
            label4.TabIndex = 14;
            label4.Text = "TotalUsers";
            // 
            // button2
            // 
            button2.Location = new Point(284, 145);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 15;
            button2.Text = "Next";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(484, 145);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 16;
            button3.Text = "Back";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(0, 0);
            label5.Name = "label5";
            label5.Size = new Size(50, 20);
            label5.TabIndex = 17;
            label5.Text = "label5";
            // 
            // UserList
            // 
            UserList.AutoSize = true;
            UserList.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            UserList.Location = new Point(392, 149);
            UserList.Name = "UserList";
            UserList.Size = new Size(79, 25);
            UserList.TabIndex = 18;
            UserList.Text = "UserList";
            // 
            // Bai4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1496, 697);
            Controls.Add(UserList);
            Controls.Add(label5);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(flowLayoutPanel);
            Controls.Add(TotalPagesTextBox);
            Controls.Add(TotalTextBox);
            Controls.Add(PerPageTextBox);
            Controls.Add(PageTextBox);
            Controls.Add(button1);
            Name = "Bai4";
            Text = "Bai4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox PageTextBox;
        private TextBox PerPageTextBox;
        private TextBox TotalTextBox;
        private TextBox TotalPagesTextBox;
        private FlowLayoutPanel flowLayoutPanel;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button2;
        private Button button3;
        private Label label5;
        private Label UserList;
    }
}