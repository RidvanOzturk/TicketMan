namespace TicketmanProject
{
    partial class IcSiparisProblemleri
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
            this.SiparisSistemSenkBtn = new System.Windows.Forms.Button();
            this.iptalBtn = new System.Windows.Forms.Button();
            this.fraudBtn = new System.Windows.Forms.Button();
            this.siparisDigerBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SiparisSistemSenkBtn
            // 
            this.SiparisSistemSenkBtn.Location = new System.Drawing.Point(81, 12);
            this.SiparisSistemSenkBtn.Name = "SiparisSistemSenkBtn";
            this.SiparisSistemSenkBtn.Size = new System.Drawing.Size(185, 43);
            this.SiparisSistemSenkBtn.TabIndex = 2;
            this.SiparisSistemSenkBtn.Text = "Sistem/Senkronizasyon Problemleri";
            this.SiparisSistemSenkBtn.UseVisualStyleBackColor = true;
            // 
            // iptalBtn
            // 
            this.iptalBtn.Location = new System.Drawing.Point(81, 82);
            this.iptalBtn.Name = "iptalBtn";
            this.iptalBtn.Size = new System.Drawing.Size(185, 43);
            this.iptalBtn.TabIndex = 3;
            this.iptalBtn.Text = "İptal Problemleri";
            this.iptalBtn.UseVisualStyleBackColor = true;
            // 
            // fraudBtn
            // 
            this.fraudBtn.Location = new System.Drawing.Point(81, 157);
            this.fraudBtn.Name = "fraudBtn";
            this.fraudBtn.Size = new System.Drawing.Size(185, 43);
            this.fraudBtn.TabIndex = 4;
            this.fraudBtn.Text = "Fraud İşlem";
            this.fraudBtn.UseVisualStyleBackColor = true;
            // 
            // siparisDigerBtn
            // 
            this.siparisDigerBtn.Location = new System.Drawing.Point(81, 230);
            this.siparisDigerBtn.Name = "siparisDigerBtn";
            this.siparisDigerBtn.Size = new System.Drawing.Size(185, 43);
            this.siparisDigerBtn.TabIndex = 5;
            this.siparisDigerBtn.Text = "Diğer Problemler";
            this.siparisDigerBtn.UseVisualStyleBackColor = true;
            // 
            // IcSiparisProblemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.siparisDigerBtn);
            this.Controls.Add(this.fraudBtn);
            this.Controls.Add(this.iptalBtn);
            this.Controls.Add(this.SiparisSistemSenkBtn);
            this.Name = "IcSiparisProblemleri";
            this.Text = "IcSiparisProblemleri";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SiparisSistemSenkBtn;
        private System.Windows.Forms.Button iptalBtn;
        private System.Windows.Forms.Button fraudBtn;
        private System.Windows.Forms.Button siparisDigerBtn;
    }
}