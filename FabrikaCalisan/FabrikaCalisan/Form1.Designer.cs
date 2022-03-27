
namespace FabrikaCalisan
{
    partial class frmPanel
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.mkdtAd = new System.Windows.Forms.MaskedTextBox();
            this.mkdtSoyad = new System.Windows.Forms.MaskedTextBox();
            this.mkdtTCNo = new System.Windows.Forms.MaskedTextBox();
            this.mkdtDogumYeri = new System.Windows.Forms.MaskedTextBox();
            this.mkdtDogumTarihi = new System.Windows.Forms.MaskedTextBox();
            this.llbAd = new System.Windows.Forms.Label();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.lblTCNo = new System.Windows.Forms.Label();
            this.lblDogumyeri = new System.Windows.Forms.Label();
            this.lblDogumTarihi = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mkdtAd
            // 
            this.mkdtAd.Location = new System.Drawing.Point(183, 20);
            this.mkdtAd.Name = "mkdtAd";
            this.mkdtAd.Size = new System.Drawing.Size(182, 22);
            this.mkdtAd.TabIndex = 0;
            // 
            // mkdtSoyad
            // 
            this.mkdtSoyad.Location = new System.Drawing.Point(183, 57);
            this.mkdtSoyad.Name = "mkdtSoyad";
            this.mkdtSoyad.Size = new System.Drawing.Size(182, 22);
            this.mkdtSoyad.TabIndex = 1;
            // 
            // mkdtTCNo
            // 
            this.mkdtTCNo.Location = new System.Drawing.Point(183, 98);
            this.mkdtTCNo.Mask = "00000000000";
            this.mkdtTCNo.Name = "mkdtTCNo";
            this.mkdtTCNo.Size = new System.Drawing.Size(182, 22);
            this.mkdtTCNo.TabIndex = 2;
            // 
            // mkdtDogumYeri
            // 
            this.mkdtDogumYeri.Location = new System.Drawing.Point(183, 143);
            this.mkdtDogumYeri.Name = "mkdtDogumYeri";
            this.mkdtDogumYeri.Size = new System.Drawing.Size(182, 22);
            this.mkdtDogumYeri.TabIndex = 3;
            // 
            // mkdtDogumTarihi
            // 
            this.mkdtDogumTarihi.Location = new System.Drawing.Point(183, 186);
            this.mkdtDogumTarihi.Mask = "00/00/0000";
            this.mkdtDogumTarihi.Name = "mkdtDogumTarihi";
            this.mkdtDogumTarihi.Size = new System.Drawing.Size(182, 22);
            this.mkdtDogumTarihi.TabIndex = 4;
            this.mkdtDogumTarihi.ValidatingType = typeof(System.DateTime);
            // 
            // llbAd
            // 
            this.llbAd.AutoSize = true;
            this.llbAd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.llbAd.Location = new System.Drawing.Point(12, 18);
            this.llbAd.Name = "llbAd";
            this.llbAd.Size = new System.Drawing.Size(64, 23);
            this.llbAd.TabIndex = 6;
            this.llbAd.Text = "Adınız";
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSoyad.Location = new System.Drawing.Point(12, 57);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(91, 23);
            this.lblSoyad.TabIndex = 7;
            this.lblSoyad.Text = "Soyadınız";
            // 
            // lblTCNo
            // 
            this.lblTCNo.AutoSize = true;
            this.lblTCNo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTCNo.Location = new System.Drawing.Point(12, 97);
            this.lblTCNo.Name = "lblTCNo";
            this.lblTCNo.Size = new System.Drawing.Size(66, 23);
            this.lblTCNo.TabIndex = 8;
            this.lblTCNo.Text = "TC No";
            // 
            // lblDogumyeri
            // 
            this.lblDogumyeri.AutoSize = true;
            this.lblDogumyeri.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDogumyeri.Location = new System.Drawing.Point(12, 141);
            this.lblDogumyeri.Name = "lblDogumyeri";
            this.lblDogumyeri.Size = new System.Drawing.Size(132, 23);
            this.lblDogumyeri.TabIndex = 9;
            this.lblDogumyeri.Text = "Doğum Yeriniz";
            // 
            // lblDogumTarihi
            // 
            this.lblDogumTarihi.AutoSize = true;
            this.lblDogumTarihi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDogumTarihi.Location = new System.Drawing.Point(12, 184);
            this.lblDogumTarihi.Name = "lblDogumTarihi";
            this.lblDogumTarihi.Size = new System.Drawing.Size(148, 23);
            this.lblDogumTarihi.TabIndex = 10;
            this.lblDogumTarihi.Text = "Doğum Tarihiniz";
            // 
            // btnEkle
            // 
            this.btnEkle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.Location = new System.Drawing.Point(260, 214);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(105, 41);
            this.btnEkle.TabIndex = 11;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // frmPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 272);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.lblDogumTarihi);
            this.Controls.Add(this.lblDogumyeri);
            this.Controls.Add(this.lblTCNo);
            this.Controls.Add(this.lblSoyad);
            this.Controls.Add(this.llbAd);
            this.Controls.Add(this.mkdtDogumTarihi);
            this.Controls.Add(this.mkdtDogumYeri);
            this.Controls.Add(this.mkdtTCNo);
            this.Controls.Add(this.mkdtSoyad);
            this.Controls.Add(this.mkdtAd);
            this.Name = "frmPanel";
            this.Text = "Panel";
            this.Load += new System.EventHandler(this.frmPanel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mkdtAd;
        private System.Windows.Forms.MaskedTextBox mkdtSoyad;
        private System.Windows.Forms.MaskedTextBox mkdtTCNo;
        private System.Windows.Forms.MaskedTextBox mkdtDogumYeri;
        private System.Windows.Forms.MaskedTextBox mkdtDogumTarihi;
        private System.Windows.Forms.Label llbAd;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.Label lblTCNo;
        private System.Windows.Forms.Label lblDogumyeri;
        private System.Windows.Forms.Label lblDogumTarihi;
        private System.Windows.Forms.Button btnEkle;
    }
}

