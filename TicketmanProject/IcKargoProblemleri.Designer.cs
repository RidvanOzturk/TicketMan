namespace TicketmanProject
{
    partial class IcKargoProblemleri
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
            this.teslimatProblemleriBtn = new System.Windows.Forms.Button();
            this.KargoDigerBtn = new System.Windows.Forms.Button();
            this.KuryeProblemleriBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // teslimatProblemleriBtn
            // 
            this.teslimatProblemleriBtn.Location = new System.Drawing.Point(79, 12);
            this.teslimatProblemleriBtn.Name = "teslimatProblemleriBtn";
            this.teslimatProblemleriBtn.Size = new System.Drawing.Size(185, 43);
            this.teslimatProblemleriBtn.TabIndex = 0;
            this.teslimatProblemleriBtn.Text = "Teslimat Problemleri";
            this.teslimatProblemleriBtn.UseVisualStyleBackColor = true;
            this.teslimatProblemleriBtn.Click += new System.EventHandler(this.teslimatProblemleriBtn_Click);
            // 
            // KargoDigerBtn
            // 
            this.KargoDigerBtn.Location = new System.Drawing.Point(79, 163);
            this.KargoDigerBtn.Name = "KargoDigerBtn";
            this.KargoDigerBtn.Size = new System.Drawing.Size(185, 43);
            this.KargoDigerBtn.TabIndex = 1;
            this.KargoDigerBtn.Text = "Diğer Problemler";
            this.KargoDigerBtn.UseVisualStyleBackColor = true;
            // 
            // KuryeProblemleriBtn
            // 
            this.KuryeProblemleriBtn.Location = new System.Drawing.Point(79, 89);
            this.KuryeProblemleriBtn.Name = "KuryeProblemleriBtn";
            this.KuryeProblemleriBtn.Size = new System.Drawing.Size(185, 43);
            this.KuryeProblemleriBtn.TabIndex = 2;
            this.KuryeProblemleriBtn.Text = "Kurye Problemleri";
            this.KuryeProblemleriBtn.UseVisualStyleBackColor = true;
            // 
            // IcKargoProblemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.KuryeProblemleriBtn);
            this.Controls.Add(this.KargoDigerBtn);
            this.Controls.Add(this.teslimatProblemleriBtn);
            this.Name = "IcKargoProblemleri";
            this.Text = "IcKargoProblemleri";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button teslimatProblemleriBtn;
        private System.Windows.Forms.Button KargoDigerBtn;
        private System.Windows.Forms.Button KuryeProblemleriBtn;
    }
}