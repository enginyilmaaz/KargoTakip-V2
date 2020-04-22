namespace WindowsFormsApplication1
{
    partial class durumEkrani
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
            this.lblBaslik = new System.Windows.Forms.Label();
            this.btn_yetkili_ekle = new System.Windows.Forms.Button();
            this.tb_durum = new System.Windows.Forms.TextBox();
            this.lbl_cinsiyet = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblBaslik
            // 
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslik.Location = new System.Drawing.Point(92, 52);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(273, 31);
            this.lblBaslik.TabIndex = 39;
            this.lblBaslik.Text = "Gönderi Durumu Ekle";
            this.lblBaslik.Click += new System.EventHandler(this.lblBaslik_Click);
            // 
            // btn_yetkili_ekle
            // 
            this.btn_yetkili_ekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_yetkili_ekle.Location = new System.Drawing.Point(49, 214);
            this.btn_yetkili_ekle.Name = "btn_yetkili_ekle";
            this.btn_yetkili_ekle.Size = new System.Drawing.Size(326, 32);
            this.btn_yetkili_ekle.TabIndex = 41;
            this.btn_yetkili_ekle.Text = "Ekle";
            this.btn_yetkili_ekle.UseVisualStyleBackColor = true;
            this.btn_yetkili_ekle.Click += new System.EventHandler(this.btn_yetkili_ekle_Click);
            // 
            // tb_durum
            // 
            this.tb_durum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_durum.Location = new System.Drawing.Point(49, 167);
            this.tb_durum.Name = "tb_durum";
            this.tb_durum.Size = new System.Drawing.Size(326, 26);
            this.tb_durum.TabIndex = 40;
            this.tb_durum.TextChanged += new System.EventHandler(this.tb_durum_TextChanged);
            // 
            // lbl_cinsiyet
            // 
            this.lbl_cinsiyet.AutoSize = true;
            this.lbl_cinsiyet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_cinsiyet.Location = new System.Drawing.Point(146, 134);
            this.lbl_cinsiyet.Name = "lbl_cinsiyet";
            this.lbl_cinsiyet.Size = new System.Drawing.Size(155, 20);
            this.lbl_cinsiyet.TabIndex = 42;
            this.lbl_cinsiyet.Text = "Eklenecek Durum:";
            this.lbl_cinsiyet.Click += new System.EventHandler(this.lbl_cinsiyet_Click);
            // 
            // durumEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 292);
            this.Controls.Add(this.lbl_cinsiyet);
            this.Controls.Add(this.btn_yetkili_ekle);
            this.Controls.Add(this.tb_durum);
            this.Controls.Add(this.lblBaslik);
            this.Name = "durumEkrani";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gönderi Durumu Ekle";
            this.Load += new System.EventHandler(this.durumEkrani_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.Button btn_yetkili_ekle;
        private System.Windows.Forms.TextBox tb_durum;
        private System.Windows.Forms.Label lbl_cinsiyet;
    }
}