namespace TicketmanProject
{
    partial class IcDigerProblemler
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
            this.SepetProblemleriBtn = new System.Windows.Forms.Button();
            this.DigerDigerBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SepetProblemleriBtn
            // 
            this.SepetProblemleriBtn.Location = new System.Drawing.Point(82, 35);
            this.SepetProblemleriBtn.Name = "SepetProblemleriBtn";
            this.SepetProblemleriBtn.Size = new System.Drawing.Size(185, 43);
            this.SepetProblemleriBtn.TabIndex = 7;
            this.SepetProblemleriBtn.Text = "Sepet Problemleri";
            this.SepetProblemleriBtn.UseVisualStyleBackColor = true;
            // 
            // DigerDigerBtn
            // 
            this.DigerDigerBtn.Location = new System.Drawing.Point(82, 97);
            this.DigerDigerBtn.Name = "DigerDigerBtn";
            this.DigerDigerBtn.Size = new System.Drawing.Size(185, 43);
            this.DigerDigerBtn.TabIndex = 8;
            this.DigerDigerBtn.Text = "Diğer Problemleri";
            this.DigerDigerBtn.UseVisualStyleBackColor = true;
            // 
            // IcDigerProblemler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DigerDigerBtn);
            this.Controls.Add(this.SepetProblemleriBtn);
            this.Name = "IcDigerProblemler";
            this.Text = "IcDigerProblemler";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SepetProblemleriBtn;
        private System.Windows.Forms.Button DigerDigerBtn;
    }
}