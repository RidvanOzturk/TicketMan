namespace TicketmanProject
{
    partial class GirisForm
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
            this.adSoyadTxt = new System.Windows.Forms.TextBox();
            this.adSoyadLbl = new System.Windows.Forms.Label();
            this.telNoLbl = new System.Windows.Forms.Label();
            this.telNoTxt = new System.Windows.Forms.TextBox();
            this.devamBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // adSoyadTxt
            // 
            this.adSoyadTxt.Location = new System.Drawing.Point(195, 92);
            this.adSoyadTxt.Name = "adSoyadTxt";
            this.adSoyadTxt.Size = new System.Drawing.Size(145, 20);
            this.adSoyadTxt.TabIndex = 0;
            // 
            // adSoyadLbl
            // 
            this.adSoyadLbl.AutoSize = true;
            this.adSoyadLbl.Location = new System.Drawing.Point(133, 99);
            this.adSoyadLbl.Name = "adSoyadLbl";
            this.adSoyadLbl.Size = new System.Drawing.Size(56, 13);
            this.adSoyadLbl.TabIndex = 1;
            this.adSoyadLbl.Text = "Ad Soyad:";
            // 
            // telNoLbl
            // 
            this.telNoLbl.AutoSize = true;
            this.telNoLbl.Location = new System.Drawing.Point(147, 153);
            this.telNoLbl.Name = "telNoLbl";
            this.telNoLbl.Size = new System.Drawing.Size(42, 13);
            this.telNoLbl.TabIndex = 3;
            this.telNoLbl.Text = "Tel No:";
            // 
            // telNoTxt
            // 
            this.telNoTxt.Location = new System.Drawing.Point(195, 146);
            this.telNoTxt.Name = "telNoTxt";
            this.telNoTxt.Size = new System.Drawing.Size(145, 20);
            this.telNoTxt.TabIndex = 2;
            // 
            // devamBtn
            // 
            this.devamBtn.Location = new System.Drawing.Point(371, 251);
            this.devamBtn.Name = "devamBtn";
            this.devamBtn.Size = new System.Drawing.Size(86, 38);
            this.devamBtn.TabIndex = 4;
            this.devamBtn.Text = "Devam";
            this.devamBtn.UseVisualStyleBackColor = true;
            this.devamBtn.Click += new System.EventHandler(this.devamBtn_Click);
            // 
            // GirisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 326);
            this.Controls.Add(this.devamBtn);
            this.Controls.Add(this.telNoLbl);
            this.Controls.Add(this.telNoTxt);
            this.Controls.Add(this.adSoyadLbl);
            this.Controls.Add(this.adSoyadTxt);
            this.Name = "GirisForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox adSoyadTxt;
        private System.Windows.Forms.Label adSoyadLbl;
        private System.Windows.Forms.Label telNoLbl;
        private System.Windows.Forms.TextBox telNoTxt;
        private System.Windows.Forms.Button devamBtn;
    }
}

