
namespace TicketmanProject.AltKirilim
{
    partial class AltKargoDiger
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
            this.AltDigerDigerBtn = new System.Windows.Forms.Button();
            this.AltDigerCagriBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AltDigerDigerBtn
            // 
            this.AltDigerDigerBtn.Location = new System.Drawing.Point(334, 235);
            this.AltDigerDigerBtn.Name = "AltDigerDigerBtn";
            this.AltDigerDigerBtn.Size = new System.Drawing.Size(132, 50);
            this.AltDigerDigerBtn.TabIndex = 4;
            this.AltDigerDigerBtn.Text = "Diğer";
            this.AltDigerDigerBtn.UseVisualStyleBackColor = true;
            // 
            // AltDigerCagriBtn
            // 
            this.AltDigerCagriBtn.Location = new System.Drawing.Point(334, 165);
            this.AltDigerCagriBtn.Name = "AltDigerCagriBtn";
            this.AltDigerCagriBtn.Size = new System.Drawing.Size(132, 50);
            this.AltDigerCagriBtn.TabIndex = 3;
            this.AltDigerCagriBtn.Text = "Çağrı merkezine ulaşılamaması";
            this.AltDigerCagriBtn.UseVisualStyleBackColor = true;
            this.AltDigerCagriBtn.Click += new System.EventHandler(this.AltDigerCagriBtn_Click);
            // 
            // AltKargoDiger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AltDigerDigerBtn);
            this.Controls.Add(this.AltDigerCagriBtn);
            this.Name = "AltKargoDiger";
            this.Text = "AltKargoDiger";
            this.Load += new System.EventHandler(this.AltKargoDiger_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AltDigerDigerBtn;
        private System.Windows.Forms.Button AltDigerCagriBtn;
    }
}