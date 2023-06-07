namespace Lab05
{
    partial class ReadMail
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
            this.labelFrom = new System.Windows.Forms.Label();
            this.labelTo = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.labelToMail = new System.Windows.Forms.Label();
            this.labelFromName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelFrom
            // 
            this.labelFrom.AutoSize = true;
            this.labelFrom.Location = new System.Drawing.Point(12, 18);
            this.labelFrom.Name = "labelFrom";
            this.labelFrom.Size = new System.Drawing.Size(41, 16);
            this.labelFrom.TabIndex = 0;
            this.labelFrom.Text = "From:";
            // 
            // labelTo
            // 
            this.labelTo.AutoSize = true;
            this.labelTo.Location = new System.Drawing.Point(12, 49);
            this.labelTo.Name = "labelTo";
            this.labelTo.Size = new System.Drawing.Size(27, 16);
            this.labelTo.TabIndex = 1;
            this.labelTo.Text = "To:";
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(12, 77);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(54, 25);
            this.labelTitle.TabIndex = 2;
            this.labelTitle.Text = "Title";
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(12, 126);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(591, 492);
            this.webBrowser1.TabIndex = 3;
            // 
            // labelToMail
            // 
            this.labelToMail.AutoSize = true;
            this.labelToMail.Location = new System.Drawing.Point(76, 49);
            this.labelToMail.Name = "labelToMail";
            this.labelToMail.Size = new System.Drawing.Size(49, 16);
            this.labelToMail.TabIndex = 5;
            this.labelToMail.Text = "MailTo";
            this.labelToMail.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelFromName
            // 
            this.labelFromName.AutoSize = true;
            this.labelFromName.Location = new System.Drawing.Point(76, 18);
            this.labelFromName.Name = "labelFromName";
            this.labelFromName.Size = new System.Drawing.Size(32, 16);
            this.labelFromName.TabIndex = 4;
            this.labelFromName.Text = "Mail";
            this.labelFromName.Click += new System.EventHandler(this.label2_Click);
            // 
            // ReadMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 615);
            this.Controls.Add(this.labelToMail);
            this.Controls.Add(this.labelFromName);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.labelTo);
            this.Controls.Add(this.labelFrom);
            this.Name = "ReadMail";
            this.Load += new System.EventHandler(this.ReadMail_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelFrom;
        private System.Windows.Forms.Label labelTo;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Label labelToMail;
        private System.Windows.Forms.Label labelFromName;
    }
}