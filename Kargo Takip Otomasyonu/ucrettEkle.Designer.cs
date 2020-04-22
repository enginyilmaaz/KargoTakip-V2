namespace WindowsFormsApplication1
{
    partial class ucretGuncelle
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
            this.label2 = new System.Windows.Forms.Label();
            this.tbMusBilgi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbMusKimlikNO = new System.Windows.Forms.TextBox();
            this.lblBaslik = new System.Windows.Forms.Label();
            this.lbl_subeAdi = new System.Windows.Forms.Label();
            this.lbl_subeNo = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.tbBirimFiyat = new System.Windows.Forms.TextBox();
            this.tbGonderiTuru = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(79, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 20);
            this.label2.TabIndex = 106;
            this.label2.Text = "Müşteri Bilgileri:";
            // 
            // tbMusBilgi
            // 
            this.tbMusBilgi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbMusBilgi.Location = new System.Drawing.Point(221, 143);
            this.tbMusBilgi.Name = "tbMusBilgi";
            this.tbMusBilgi.ReadOnly = true;
            this.tbMusBilgi.Size = new System.Drawing.Size(239, 26);
            this.tbMusBilgi.TabIndex = 105;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(61, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 20);
            this.label1.TabIndex = 104;
            this.label1.Text = "Müşteri Kimlik NO:";
            // 
            // tbMusKimlikNO
            // 
            this.tbMusKimlikNO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbMusKimlikNO.Location = new System.Drawing.Point(221, 109);
            this.tbMusKimlikNO.Name = "tbMusKimlikNO";
            this.tbMusKimlikNO.ReadOnly = true;
            this.tbMusKimlikNO.Size = new System.Drawing.Size(239, 26);
            this.tbMusKimlikNO.TabIndex = 103;
            // 
            // lblBaslik
            // 
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslik.Location = new System.Drawing.Point(215, 41);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(194, 31);
            this.lblBaslik.TabIndex = 102;
            this.lblBaslik.Text = "Ücret Güncelle";
            // 
            // lbl_subeAdi
            // 
            this.lbl_subeAdi.AutoSize = true;
            this.lbl_subeAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_subeAdi.Location = new System.Drawing.Point(117, 215);
            this.lbl_subeAdi.Name = "lbl_subeAdi";
            this.lbl_subeAdi.Size = new System.Drawing.Size(98, 20);
            this.lbl_subeAdi.TabIndex = 101;
            this.lbl_subeAdi.Text = "Birim Fiyat:";
            // 
            // lbl_subeNo
            // 
            this.lbl_subeNo.AutoSize = true;
            this.lbl_subeNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_subeNo.Location = new System.Drawing.Point(96, 177);
            this.lbl_subeNo.Name = "lbl_subeNo";
            this.lbl_subeNo.Size = new System.Drawing.Size(119, 20);
            this.lbl_subeNo.TabIndex = 100;
            this.lbl_subeNo.Text = "Gönderi Türü:";
            // 
            // btnEkle
            // 
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.Location = new System.Drawing.Point(63, 277);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(430, 35);
            this.btnEkle.TabIndex = 98;
            this.btnEkle.Text = "Ücret Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click_1);
            // 
            // tbBirimFiyat
            // 
            this.tbBirimFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbBirimFiyat.Location = new System.Drawing.Point(221, 212);
            this.tbBirimFiyat.Name = "tbBirimFiyat";
            this.tbBirimFiyat.Size = new System.Drawing.Size(239, 26);
            this.tbBirimFiyat.TabIndex = 97;
            // 
            // tbGonderiTuru
            // 
            this.tbGonderiTuru.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbGonderiTuru.Location = new System.Drawing.Point(221, 175);
            this.tbGonderiTuru.Name = "tbGonderiTuru";
            this.tbGonderiTuru.ReadOnly = true;
            this.tbGonderiTuru.Size = new System.Drawing.Size(239, 26);
            this.tbGonderiTuru.TabIndex = 107;
            // 
            // ucretGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 353);
            this.Controls.Add(this.tbGonderiTuru);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbMusBilgi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbMusKimlikNO);
            this.Controls.Add(this.lblBaslik);
            this.Controls.Add(this.lbl_subeAdi);
            this.Controls.Add(this.lbl_subeNo);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.tbBirimFiyat);
            this.Name = "ucretGuncelle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ücret Güncelle";
            this.Load += new System.EventHandler(this.ucrettEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbMusBilgi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbMusKimlikNO;
        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.Label lbl_subeAdi;
        private System.Windows.Forms.Label lbl_subeNo;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.TextBox tbBirimFiyat;
        private System.Windows.Forms.TextBox tbGonderiTuru;
    }
}