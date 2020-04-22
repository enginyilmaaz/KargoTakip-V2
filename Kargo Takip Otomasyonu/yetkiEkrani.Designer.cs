namespace WindowsFormsApplication1
{
    partial class yetkiEkrani
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
            this.btn_yetkili_ekle = new System.Windows.Forms.Button();
            this.tb_yetki = new System.Windows.Forms.TextBox();
            this.lblBaslik = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_cinsiyet
            // 
            this.lbl_cinsiyet.AutoSize = true;
            this.lbl_cinsiyet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_cinsiyet.Location = new System.Drawing.Point(123, 138);
            this.lbl_cinsiyet.Name = "lbl_cinsiyet";
            this.lbl_cinsiyet.Size = new System.Drawing.Size(145, 20);
            this.lbl_cinsiyet.TabIndex = 46;
            this.lbl_cinsiyet.Text = "Yetki Açıklaması:";
            // 
            // btn_yetkili_ekle
            // 
            this.btn_yetkili_ekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_yetkili_ekle.Location = new System.Drawing.Point(26, 218);
            this.btn_yetkili_ekle.Name = "btn_yetkili_ekle";
            this.btn_yetkili_ekle.Size = new System.Drawing.Size(326, 32);
            this.btn_yetkili_ekle.TabIndex = 45;
            this.btn_yetkili_ekle.Text = "Ekle";
            this.btn_yetkili_ekle.UseVisualStyleBackColor = true;
            this.btn_yetkili_ekle.Click += new System.EventHandler(this.btn_yetkili_ekle_Click);
            // 
            // tb_yetki
            // 
            this.tb_yetki.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tb_yetki.Location = new System.Drawing.Point(26, 171);
            this.tb_yetki.Name = "tb_yetki";
            this.tb_yetki.Size = new System.Drawing.Size(326, 26);
            this.tb_yetki.TabIndex = 44;
            // 
            // lblBaslik
            // 
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslik.Location = new System.Drawing.Point(121, 51);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(135, 31);
            this.lblBaslik.TabIndex = 43;
            this.lblBaslik.Text = "Yetki Ekle";
            // 
            // yetkiEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 306);
            this.Controls.Add(this.lbl_cinsiyet);
            this.Controls.Add(this.btn_yetkili_ekle);
            this.Controls.Add(this.tb_yetki);
            this.Controls.Add(this.lblBaslik);
            this.Name = "yetkiEkrani";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yetki Ekle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_cinsiyet;
        private System.Windows.Forms.Button btn_yetkili_ekle;
        private System.Windows.Forms.TextBox tb_yetki;
        private System.Windows.Forms.Label lblBaslik;
    }
}