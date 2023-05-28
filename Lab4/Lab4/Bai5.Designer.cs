namespace Lab4
{
    partial class Bai5
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
            TokenTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            api = new TextBox();
            name = new TextBox();
            pass = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(551, 135);
            button1.Name = "button1";
            button1.Size = new Size(210, 115);
            button1.TabIndex = 0;
            button1.Text = "POST";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // TokenTextBox
            // 
            TokenTextBox.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            TokenTextBox.Location = new Point(12, 289);
            TokenTextBox.Multiline = true;
            TokenTextBox.Name = "TokenTextBox";
            TokenTextBox.Size = new Size(749, 132);
            TokenTextBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 46);
            label1.Name = "label1";
            label1.Size = new Size(66, 38);
            label1.TabIndex = 2;
            label1.Text = "URL";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(7, 135);
            label2.Name = "label2";
            label2.Size = new Size(142, 38);
            label2.TabIndex = 3;
            label2.Text = "Username";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(7, 212);
            label3.Name = "label3";
            label3.Size = new Size(132, 38);
            label3.TabIndex = 4;
            label3.Text = "Password";
            label3.Click += label3_Click;
            // 
            // api
            // 
            api.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            api.Location = new Point(204, 43);
            api.Name = "api";
            api.Size = new Size(557, 43);
            api.TabIndex = 5;
            // 
            // name
            // 
            name.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            name.Location = new Point(204, 135);
            name.Name = "name";
            name.Size = new Size(325, 43);
            name.TabIndex = 6;
            // 
            // pass
            // 
            pass.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            pass.Location = new Point(204, 207);
            pass.Name = "pass";
            pass.Size = new Size(325, 43);
            pass.TabIndex = 7;
            // 
            // Bai5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pass);
            Controls.Add(name);
            Controls.Add(api);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(TokenTextBox);
            Controls.Add(button1);
            Name = "Bai5";
            Text = "Bai5";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox TokenTextBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox api;
        private TextBox name;
        private TextBox pass;
    }
}