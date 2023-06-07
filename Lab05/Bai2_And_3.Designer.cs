namespace Lab05
{
    partial class Bai2_And_3
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
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelPass = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.labelTotal = new System.Windows.Forms.Label();
            this.labelTotal_2 = new System.Windows.Forms.Label();
            this.labelRecent = new System.Windows.Forms.Label();
            this.labelRecent_2 = new System.Windows.Forms.Label();
            this.listViewMess = new System.Windows.Forms.ListView();
            this.buttonIMAP = new System.Windows.Forms.Button();
            this.buttonPop3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(51, 32);
            this.labelEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(44, 16);
            this.labelEmail.TabIndex = 0;
            this.labelEmail.Text = "Email:";
            this.labelEmail.Click += new System.EventHandler(this.labelEmail_Click);
            // 
            // labelPass
            // 
            this.labelPass.AutoSize = true;
            this.labelPass.Location = new System.Drawing.Point(51, 72);
            this.labelPass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPass.Name = "labelPass";
            this.labelPass.Size = new System.Drawing.Size(70, 16);
            this.labelPass.TabIndex = 1;
            this.labelPass.Text = "Password:";
            this.labelPass.Click += new System.EventHandler(this.labelPass_Click);
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(142, 32);
            this.textBoxEmail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(365, 22);
            this.textBoxEmail.TabIndex = 2;
            this.textBoxEmail.TextChanged += new System.EventHandler(this.textBoxEmail_TextChanged);
            // 
            // textBoxPass
            // 
            this.textBoxPass.Location = new System.Drawing.Point(142, 72);
            this.textBoxPass.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.PasswordChar = '*';
            this.textBoxPass.Size = new System.Drawing.Size(365, 22);
            this.textBoxPass.TabIndex = 3;
            this.textBoxPass.TextChanged += new System.EventHandler(this.textBoxPass_TextChanged);
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(51, 131);
            this.labelTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(41, 16);
            this.labelTotal.TabIndex = 5;
            this.labelTotal.Text = "Total:";
            // 
            // labelTotal_2
            // 
            this.labelTotal_2.AutoSize = true;
            this.labelTotal_2.Location = new System.Drawing.Point(128, 131);
            this.labelTotal_2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTotal_2.Name = "labelTotal_2";
            this.labelTotal_2.Size = new System.Drawing.Size(0, 16);
            this.labelTotal_2.TabIndex = 6;
            this.labelTotal_2.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelRecent
            // 
            this.labelRecent.AutoSize = true;
            this.labelRecent.Location = new System.Drawing.Point(266, 131);
            this.labelRecent.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRecent.Name = "labelRecent";
            this.labelRecent.Size = new System.Drawing.Size(53, 16);
            this.labelRecent.TabIndex = 7;
            this.labelRecent.Text = "Recent:";
            // 
            // labelRecent_2
            // 
            this.labelRecent_2.AutoSize = true;
            this.labelRecent_2.Location = new System.Drawing.Point(329, 131);
            this.labelRecent_2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRecent_2.Name = "labelRecent_2";
            this.labelRecent_2.Size = new System.Drawing.Size(0, 16);
            this.labelRecent_2.TabIndex = 8;
            this.labelRecent_2.Click += new System.EventHandler(this.labelRecent_2_Click);
            // 
            // listViewMess
            // 
            this.listViewMess.HideSelection = false;
            this.listViewMess.Location = new System.Drawing.Point(11, 169);
            this.listViewMess.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listViewMess.Name = "listViewMess";
            this.listViewMess.Size = new System.Drawing.Size(794, 317);
            this.listViewMess.TabIndex = 9;
            this.listViewMess.UseCompatibleStateImageBehavior = false;
            this.listViewMess.View = System.Windows.Forms.View.Details;
            this.listViewMess.SelectedIndexChanged += new System.EventHandler(this.listViewMess_SelectedIndexChanged);
            // 
            // buttonIMAP
            // 
            this.buttonIMAP.Location = new System.Drawing.Point(574, 49);
            this.buttonIMAP.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonIMAP.Name = "buttonIMAP";
            this.buttonIMAP.Size = new System.Drawing.Size(73, 35);
            this.buttonIMAP.TabIndex = 10;
            this.buttonIMAP.Text = "IMAP";
            this.buttonIMAP.UseVisualStyleBackColor = true;
            this.buttonIMAP.Click += new System.EventHandler(this.buttonIMAP_Click);
            // 
            // buttonPop3
            // 
            this.buttonPop3.Location = new System.Drawing.Point(705, 49);
            this.buttonPop3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonPop3.Name = "buttonPop3";
            this.buttonPop3.Size = new System.Drawing.Size(70, 35);
            this.buttonPop3.TabIndex = 11;
            this.buttonPop3.Text = "Pop3";
            this.buttonPop3.UseVisualStyleBackColor = true;
            this.buttonPop3.Click += new System.EventHandler(this.buttonPop3_Click);
            // 
            // Bai2_And_3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 493);
            this.Controls.Add(this.buttonPop3);
            this.Controls.Add(this.buttonIMAP);
            this.Controls.Add(this.listViewMess);
            this.Controls.Add(this.labelRecent_2);
            this.Controls.Add(this.labelRecent);
            this.Controls.Add(this.labelTotal_2);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.textBoxPass);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.labelPass);
            this.Controls.Add(this.labelEmail);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Bai2_And_3";
            this.Text = "Bai2";
            this.Load += new System.EventHandler(this.Bai2_And_3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelPass;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxPass;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label labelTotal_2;
        private System.Windows.Forms.Label labelRecent;
        private System.Windows.Forms.Label labelRecent_2;
        private System.Windows.Forms.ListView listViewMess;
        private System.Windows.Forms.Button buttonIMAP;
        private System.Windows.Forms.Button buttonPop3;
    }
}