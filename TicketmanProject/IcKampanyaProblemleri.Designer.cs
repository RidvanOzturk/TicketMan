namespace TicketmanProject
{
    partial class IcKampanyaProblemleri
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
            this.KampanyaDigerBtn = new System.Windows.Forms.Button();
            this.KampanyaProblemleri = new System.Windows.Forms.Button();
            this.KampanyaIadeProblemleriBtn = new System.Windows.Forms.Button();
            this.KampanyaSistemSenkBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // KampanyaDigerBtn
            // 
            this.KampanyaDigerBtn.Location = new System.Drawing.Point(83, 230);
            this.KampanyaDigerBtn.Name = "KampanyaDigerBtn";
            this.KampanyaDigerBtn.Size = new System.Drawing.Size(185, 43);
            this.KampanyaDigerBtn.TabIndex = 9;
            this.KampanyaDigerBtn.Text = "Diğer Problemler";
            this.KampanyaDigerBtn.UseVisualStyleBackColor = true;
            // 
            // KampanyaProblemleri
            // 
            this.KampanyaProblemleri.Location = new System.Drawing.Point(83, 157);
            this.KampanyaProblemleri.Name = "KampanyaProblemleri";
            this.KampanyaProblemleri.Size = new System.Drawing.Size(185, 43);
            this.KampanyaProblemleri.TabIndex = 8;
            this.KampanyaProblemleri.Text = "Kampanya Problemleri";
            this.KampanyaProblemleri.UseVisualStyleBackColor = true;
            // 
            // KampanyaIadeProblemleriBtn
            // 
            this.KampanyaIadeProblemleriBtn.Location = new System.Drawing.Point(83, 82);
            this.KampanyaIadeProblemleriBtn.Name = "KampanyaIadeProblemleriBtn";
            this.KampanyaIadeProblemleriBtn.Size = new System.Drawing.Size(185, 43);
            this.KampanyaIadeProblemleriBtn.TabIndex = 7;
            this.KampanyaIadeProblemleriBtn.Text = "İade Problemleri";
            this.KampanyaIadeProblemleriBtn.UseVisualStyleBackColor = true;
            // 
            // KampanyaSistemSenkBtn
            // 
            this.KampanyaSistemSenkBtn.Location = new System.Drawing.Point(83, 12);
            this.KampanyaSistemSenkBtn.Name = "KampanyaSistemSenkBtn";
            this.KampanyaSistemSenkBtn.Size = new System.Drawing.Size(185, 43);
            this.KampanyaSistemSenkBtn.TabIndex = 6;
            this.KampanyaSistemSenkBtn.Text = "Sistem/Senkronizasyon Problemleri";
            this.KampanyaSistemSenkBtn.UseVisualStyleBackColor = true;
            // 
            // IcKampanyaProblemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.KampanyaDigerBtn);
            this.Controls.Add(this.KampanyaProblemleri);
            this.Controls.Add(this.KampanyaIadeProblemleriBtn);
            this.Controls.Add(this.KampanyaSistemSenkBtn);
            this.Name = "IcKampanyaProblemleri";
            this.Text = "IcKampanyaProblemleri";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button KampanyaDigerBtn;
        private System.Windows.Forms.Button KampanyaProblemleri;
        private System.Windows.Forms.Button KampanyaIadeProblemleriBtn;
        private System.Windows.Forms.Button KampanyaSistemSenkBtn;
    }
}