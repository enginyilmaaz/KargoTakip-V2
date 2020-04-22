namespace WindowsFormsApplication1
{
    partial class yetkiGuncelle
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
            this.tbSimdikiYetkiAciklamasi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_cinsiyet = new System.Windows.Forms.Label();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.tb_yeniYetkiAciklamasi = new System.Windows.Forms.TextBox();
            this.lblBaslik = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbSimdikiYetkiAciklamasi
            // 
            this.tbSimdikiYetkiAciklamasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbSimdikiYetkiAciklamasi.Location = new System.Drawing.Point(31, 136);
            this.tbSimdikiYetkiAciklamasi.Name = "tbSimdikiYetkiAciklamasi";
            this.tbSimdikiYetkiAciklamasi.ReadOnly = true;
            this.tbSimdikiYetkiAciklamasi.Size = new System.Drawing.Size(326, 26);
            this.tbSimdikiYetkiAciklamasi.TabIndex = 54;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(106, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 20);
            this.label1.TabIndex = 53;
            this.label1.Text = "Güncellenecek Açıklama:";
            // 
            // lbl_cinsiyet
            // 
            this.lbl_cinsiyet.AutoSize = true;
            this.lbl_cinsiyet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_cinsiyet.Location = new System.Drawing.Point(106, 113);
            this.lbl_cinsiyet.Name = "lbl_cinsiyet";
            this.lbl_cinsiyet.Size = new System.Drawing.Size(205, 20);
            this.lbl_cinsiyet.TabIndex = 52;
            this.lbl_cinsiyet.Text = "Şuanki Yetki Açıklaması:";
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.Location = new System.Drawing.Point(31, 266);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(326, 32);
            this.btnGuncelle.TabIndex = 51;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // tb_yeniYetkiAciklamasi
            // 
            this.tb_yeniYetkiAciklamasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_yeniYetkiAciklamasi.Location = new System.Drawing.Point(34, 207);
            this.tb_yeniYetkiAciklamasi.Name = "tb_yeniYetkiAciklamasi";
            this.tb_yeniYetkiAciklamasi.Size = new System.Drawing.Size(326, 26);
            this.tb_yeniYetkiAciklamasi.TabIndex = 50;
            // 
            // lblBaslik
            // 
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslik.Location = new System.Drawing.Point(104, 37);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(189, 31);
            this.lblBaslik.TabIndex = 49;
            this.lblBaslik.Text = "Yetki Güncelle";
            // 
            // yetkiGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 333);
            this.Controls.Add(this.tbSimdikiYetkiAciklamasi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_cinsiyet);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.tb_yeniYetkiAciklamasi);
            this.Controls.Add(this.lblBaslik);
            this.Name = "yetkiGuncelle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yetki Güncelle";
            this.Load += new System.EventHandler(this.yetkiGuncelle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbSimdikiYetkiAciklamasi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_cinsiyet;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.TextBox tb_yeniYetkiAciklamasi;
        private System.Windows.Forms.Label lblBaslik;
    }
}