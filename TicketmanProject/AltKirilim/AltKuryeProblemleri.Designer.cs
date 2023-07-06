namespace TicketmanProject.AltKirilim
{
    partial class AltKuryeProblemleri
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
            this.AltKuryeKuryeBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AltKuryeKuryeBtn
            // 
            this.AltKuryeKuryeBtn.Location = new System.Drawing.Point(352, 115);
            this.AltKuryeKuryeBtn.Name = "AltKuryeKuryeBtn";
            this.AltKuryeKuryeBtn.Size = new System.Drawing.Size(132, 50);
            this.AltKuryeKuryeBtn.TabIndex = 1;
            this.AltKuryeKuryeBtn.Text = "Kurye davranış problemi";
            this.AltKuryeKuryeBtn.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(352, 185);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 50);
            this.button1.TabIndex = 2;
            this.button1.Text = "Şube tarafından dağıtıma çıkarılmaması";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // AltKuryeProblemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AltKuryeKuryeBtn);
            this.Name = "AltKuryeProblemleri";
            this.Text = "AltKuryeProblemleri";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AltKuryeKuryeBtn;
        private System.Windows.Forms.Button button1;
    }
}