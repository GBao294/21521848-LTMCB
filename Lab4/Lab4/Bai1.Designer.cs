namespace Lab4
{
    partial class Bai1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            url = new TextBox();
            button1 = new Button();
            box = new RichTextBox();
            SuspendLayout();
            // 
            // url
            // 
            url.Location = new Point(48, 12);
            url.Name = "url";
            url.Size = new Size(474, 27);
            url.TabIndex = 0;
            url.TextChanged += url_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(635, 12);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 1;
            button1.Text = "GET";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // box
            // 
            box.Location = new Point(48, 75);
            box.Name = "box";
            box.Size = new Size(681, 425);
            box.TabIndex = 2;
            box.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 512);
            Controls.Add(box);
            Controls.Add(button1);
            Controls.Add(url);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox url;
        private Button button1;
        private RichTextBox box;
    }
}