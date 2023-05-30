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
            this.labelEmail.Location = new System.Drawing.Point(70, 48);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(66, 25);
            this.labelEmail.TabIndex = 0;
            this.labelEmail.Text = "Email:";
            // 
            // labelPass
            // 
            this.labelPass.AutoSize = true;
            this.labelPass.Location = new System.Drawing.Point(70, 108);
            this.labelPass.Name = "labelPass";
            this.labelPass.Size = new System.Drawing.Size(104, 25);
            this.labelPass.TabIndex = 1;
            this.labelPass.Text = "Password:";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(195, 48);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(500, 29);
            this.textBoxEmail.TabIndex = 2;
            // 
            // textBoxPass
            // 
            this.textBoxPass.Location = new System.Drawing.Point(195, 108);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.PasswordChar = '*';
            this.textBoxPass.Size = new System.Drawing.Size(500, 29);
            this.textBoxPass.TabIndex = 3;
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(70, 196);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(62, 25);
            this.labelTotal.TabIndex = 5;
            this.labelTotal.Text = "Total:";
            // 
            // labelTotal_2
            // 
            this.labelTotal_2.AutoSize = true;
            this.labelTotal_2.Location = new System.Drawing.Point(176, 196);
            this.labelTotal_2.Name = "labelTotal_2";
            this.labelTotal_2.Size = new System.Drawing.Size(0, 25);
            this.labelTotal_2.TabIndex = 6;
            this.labelTotal_2.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelRecent
            // 
            this.labelRecent.AutoSize = true;
            this.labelRecent.Location = new System.Drawing.Point(366, 196);
            this.labelRecent.Name = "labelRecent";
            this.labelRecent.Size = new System.Drawing.Size(79, 25);
            this.labelRecent.TabIndex = 7;
            this.labelRecent.Text = "Recent:";
            // 
            // labelRecent_2
            // 
            this.labelRecent_2.AutoSize = true;
            this.labelRecent_2.Location = new System.Drawing.Point(453, 196);
            this.labelRecent_2.Name = "labelRecent_2";
            this.labelRecent_2.Size = new System.Drawing.Size(0, 25);
            this.labelRecent_2.TabIndex = 8;
            // 
            // listViewMess
            // 
            this.listViewMess.HideSelection = false;
            this.listViewMess.Location = new System.Drawing.Point(15, 253);
            this.listViewMess.Name = "listViewMess";
            this.listViewMess.Size = new System.Drawing.Size(1090, 474);
            this.listViewMess.TabIndex = 9;
            this.listViewMess.UseCompatibleStateImageBehavior = false;
            this.listViewMess.View = System.Windows.Forms.View.Details;
            // 
            // buttonIMAP
            // 
            this.buttonIMAP.Location = new System.Drawing.Point(789, 74);
            this.buttonIMAP.Name = "buttonIMAP";
            this.buttonIMAP.Size = new System.Drawing.Size(101, 52);
            this.buttonIMAP.TabIndex = 10;
            this.buttonIMAP.Text = "IMAP";
            this.buttonIMAP.UseVisualStyleBackColor = true;
            this.buttonIMAP.Click += new System.EventHandler(this.buttonIMAP_Click);
            // 
            // buttonPop3
            // 
            this.buttonPop3.Location = new System.Drawing.Point(970, 74);
            this.buttonPop3.Name = "buttonPop3";
            this.buttonPop3.Size = new System.Drawing.Size(96, 52);
            this.buttonPop3.TabIndex = 11;
            this.buttonPop3.Text = "Pop3";
            this.buttonPop3.UseVisualStyleBackColor = true;
            this.buttonPop3.Click += new System.EventHandler(this.buttonPop3_Click);
            // 
            // Bai2_And_3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 739);
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
            this.Name = "Bai2_And_3";
            this.Text = "Bai2";
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