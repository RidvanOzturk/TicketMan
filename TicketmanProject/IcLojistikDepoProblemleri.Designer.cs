namespace TicketmanProject
{
    partial class IcLojistikDepoProblemleri
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
            this.UrunProblemleriBtn = new System.Windows.Forms.Button();
            this.StokProblemleriBtn = new System.Windows.Forms.Button();
            this.SiparisProblemleriBtn = new System.Windows.Forms.Button();
            this.LojistikDigerProblemlerBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // UrunProblemleriBtn
            // 
            this.UrunProblemleriBtn.Location = new System.Drawing.Point(81, 12);
            this.UrunProblemleriBtn.Name = "UrunProblemleriBtn";
            this.UrunProblemleriBtn.Size = new System.Drawing.Size(185, 43);
            this.UrunProblemleriBtn.TabIndex = 1;
            this.UrunProblemleriBtn.Text = "Ürün Problemleri";
            this.UrunProblemleriBtn.UseVisualStyleBackColor = true;
            // 
            // StokProblemleriBtn
            // 
            this.StokProblemleriBtn.Location = new System.Drawing.Point(81, 159);
            this.StokProblemleriBtn.Name = "StokProblemleriBtn";
            this.StokProblemleriBtn.Size = new System.Drawing.Size(185, 43);
            this.StokProblemleriBtn.TabIndex = 2;
            this.StokProblemleriBtn.Text = "Stok Problemleri";
            this.StokProblemleriBtn.UseVisualStyleBackColor = true;
            // 
            // SiparisProblemleriBtn
            // 
            this.SiparisProblemleriBtn.Location = new System.Drawing.Point(81, 85);
            this.SiparisProblemleriBtn.Name = "SiparisProblemleriBtn";
            this.SiparisProblemleriBtn.Size = new System.Drawing.Size(185, 43);
            this.SiparisProblemleriBtn.TabIndex = 3;
            this.SiparisProblemleriBtn.Text = "Sipariş Problemleri";
            this.SiparisProblemleriBtn.UseVisualStyleBackColor = true;
            // 
            // LojistikDigerProblemlerBtn
            // 
            this.LojistikDigerProblemlerBtn.Location = new System.Drawing.Point(81, 230);
            this.LojistikDigerProblemlerBtn.Name = "LojistikDigerProblemlerBtn";
            this.LojistikDigerProblemlerBtn.Size = new System.Drawing.Size(185, 43);
            this.LojistikDigerProblemlerBtn.TabIndex = 4;
            this.LojistikDigerProblemlerBtn.Text = "Diğer Problemler";
            this.LojistikDigerProblemlerBtn.UseVisualStyleBackColor = true;
            // 
            // IcLojistikDepoProblemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LojistikDigerProblemlerBtn);
            this.Controls.Add(this.SiparisProblemleriBtn);
            this.Controls.Add(this.StokProblemleriBtn);
            this.Controls.Add(this.UrunProblemleriBtn);
            this.Name = "IcLojistikDepoProblemleri";
            this.Text = "IcLojistikDepoProblemleri";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button UrunProblemleriBtn;
        private System.Windows.Forms.Button StokProblemleriBtn;
        private System.Windows.Forms.Button SiparisProblemleriBtn;
        private System.Windows.Forms.Button LojistikDigerProblemlerBtn;
    }
}