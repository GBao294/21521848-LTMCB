
namespace lab4
{
    partial class Form1
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
            this.btnGo = new System.Windows.Forms.Button();
            this.btnDownloadHTML = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.btnDownloadResource = new System.Windows.Forms.Button();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.btnViewSource = new System.Windows.Forms.Button();
            this.txtSource = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(310, 32);
            this.btnGo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(81, 28);
            this.btnGo.TabIndex = 0;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // btnDownloadHTML
            // 
            this.btnDownloadHTML.Location = new System.Drawing.Point(419, 30);
            this.btnDownloadHTML.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDownloadHTML.Name = "btnDownloadHTML";
            this.btnDownloadHTML.Size = new System.Drawing.Size(129, 33);
            this.btnDownloadHTML.TabIndex = 1;
            this.btnDownloadHTML.Text = "Download HTML";
            this.btnDownloadHTML.UseVisualStyleBackColor = true;
            this.btnDownloadHTML.Click += new System.EventHandler(this.btnDownloadHTML_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(12, 80);
            this.webBrowser1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(18, 16);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(680, 372);
            this.webBrowser1.TabIndex = 2;
            this.webBrowser1.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.webBrowser1_DocumentCompleted);
            // 
            // btnDownloadResource
            // 
            this.btnDownloadResource.Location = new System.Drawing.Point(553, 30);
            this.btnDownloadResource.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDownloadResource.Name = "btnDownloadResource";
            this.btnDownloadResource.Size = new System.Drawing.Size(139, 32);
            this.btnDownloadResource.TabIndex = 3;
            this.btnDownloadResource.Text = "Download Resouce";
            this.btnDownloadResource.UseVisualStyleBackColor = true;
            this.btnDownloadResource.Click += new System.EventHandler(this.btnDownloadResource_Click);
            // 
            // txtURL
            // 
            this.txtURL.Location = new System.Drawing.Point(43, 32);
            this.txtURL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(214, 22);
            this.txtURL.TabIndex = 4;
            this.txtURL.TextChanged += new System.EventHandler(this.txtURL_TextChanged);
            // 
            // btnViewSource
            // 
            this.btnViewSource.Location = new System.Drawing.Point(756, 32);
            this.btnViewSource.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnViewSource.Name = "btnViewSource";
            this.btnViewSource.Size = new System.Drawing.Size(153, 33);
            this.btnViewSource.TabIndex = 5;
            this.btnViewSource.Text = "View Source";
            this.btnViewSource.UseVisualStyleBackColor = true;
            this.btnViewSource.Click += new System.EventHandler(this.btnViewSource_Click_1);
            // 
            // txtSource
            // 
            this.txtSource.Location = new System.Drawing.Point(698, 80);
            this.txtSource.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSource.Multiline = true;
            this.txtSource.Name = "txtSource";
            this.txtSource.Size = new System.Drawing.Size(259, 372);
            this.txtSource.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 463);
            this.Controls.Add(this.txtSource);
            this.Controls.Add(this.btnViewSource);
            this.Controls.Add(this.txtURL);
            this.Controls.Add(this.btnDownloadResource);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.btnDownloadHTML);
            this.Controls.Add(this.btnGo);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.Button btnDownloadHTML;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button btnDownloadResource;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.Button btnViewSource;
        private System.Windows.Forms.TextBox txtSource;
    }
}

