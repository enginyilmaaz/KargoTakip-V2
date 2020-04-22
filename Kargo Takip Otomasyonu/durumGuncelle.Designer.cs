namespace WindowsFormsApplication1
{
    partial class durumGuncelle
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
            this.lbl_cinsiyet = new System.Windows.Forms.Label();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.tb_durum = new System.Windows.Forms.TextBox();
            this.lblBaslik = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbSimdikiDurum = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_cinsiyet
            // 
            this.lbl_cinsiyet.AutoSize = true;
            this.lbl_cinsiyet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_cinsiyet.Location = new System.Drawing.Point(155, 120);
            this.lbl_cinsiyet.Name = "lbl_cinsiyet";
            this.lbl_cinsiyet.Size = new System.Drawing.Size(127, 20);
            this.lbl_cinsiyet.TabIndex = 46;
            this.lbl_cinsiyet.Text = "Şuanki Durum:";
            this.lbl_cinsiyet.Click += new System.EventHandler(this.lbl_cinsiyet_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.Location = new System.Drawing.Point(53, 273);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(326, 32);
            this.btnGuncelle.TabIndex = 45;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // tb_durum
            // 
            this.tb_durum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_durum.Location = new System.Drawing.Point(56, 214);
            this.tb_durum.Name = "tb_durum";
            this.tb_durum.Size = new System.Drawing.Size(326, 26);
            this.tb_durum.TabIndex = 44;
            this.tb_durum.TextChanged += new System.EventHandler(this.tb_durum_TextChanged);
            // 
            // lblBaslik
            // 
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslik.Location = new System.Drawing.Point(55, 41);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(327, 31);
            this.lblBaslik.TabIndex = 43;
            this.lblBaslik.Text = "Gönderi Durumu Güncelle";
            this.lblBaslik.Click += new System.EventHandler(this.lblBaslik_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(128, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 20);
            this.label1.TabIndex = 47;
            this.label1.Text = "Güncellenecek Durum:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tbSimdikiDurum
            // 
            this.tbSimdikiDurum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbSimdikiDurum.Location = new System.Drawing.Point(53, 143);
            this.tbSimdikiDurum.Name = "tbSimdikiDurum";
            this.tbSimdikiDurum.ReadOnly = true;
            this.tbSimdikiDurum.Size = new System.Drawing.Size(326, 26);
            this.tbSimdikiDurum.TabIndex = 48;
            this.tbSimdikiDurum.TextChanged += new System.EventHandler(this.tbSimdikiDurum_TextChanged);
            // 
            // durumGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 338);
            this.Controls.Add(this.tbSimdikiDurum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_cinsiyet);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.tb_durum);
            this.Controls.Add(this.lblBaslik);
            this.Name = "durumGuncelle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gönderi Durumu Güncelle";
            this.Load += new System.EventHandler(this.durumGuncelle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_cinsiyet;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.TextBox tb_durum;
        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSimdikiDurum;
    }
}