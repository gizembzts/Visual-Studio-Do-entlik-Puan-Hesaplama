
namespace docentlik_puan_hesaplama
{
    partial class Kitap1
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
            this.editörlük_veya_bölüm_yazarlığı = new System.Windows.Forms.NumericUpDown();
            this.kitap_yazar_sayi = new System.Windows.Forms.NumericUpDown();
            this.btn_lisans_ekle = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_kitap_doktora = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.editörlük_veya_bölüm_yazarlığı)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitap_yazar_sayi)).BeginInit();
            this.SuspendLayout();
            // 
            // editörlük_veya_bölüm_yazarlığı
            // 
            this.editörlük_veya_bölüm_yazarlığı.Location = new System.Drawing.Point(258, 89);
            this.editörlük_veya_bölüm_yazarlığı.Name = "editörlük_veya_bölüm_yazarlığı";
            this.editörlük_veya_bölüm_yazarlığı.Size = new System.Drawing.Size(120, 23);
            this.editörlük_veya_bölüm_yazarlığı.TabIndex = 27;
            this.editörlük_veya_bölüm_yazarlığı.ValueChanged += new System.EventHandler(this.bildiri_sayisi_ValueChanged);
            // 
            // kitap_yazar_sayi
            // 
            this.kitap_yazar_sayi.Location = new System.Drawing.Point(258, 139);
            this.kitap_yazar_sayi.Name = "kitap_yazar_sayi";
            this.kitap_yazar_sayi.Size = new System.Drawing.Size(120, 23);
            this.kitap_yazar_sayi.TabIndex = 26;
            this.kitap_yazar_sayi.ValueChanged += new System.EventHandler(this.makale_yazar_sayi_ValueChanged);
            // 
            // btn_lisans_ekle
            // 
            this.btn_lisans_ekle.Location = new System.Drawing.Point(118, 203);
            this.btn_lisans_ekle.Name = "btn_lisans_ekle";
            this.btn_lisans_ekle.Size = new System.Drawing.Size(75, 23);
            this.btn_lisans_ekle.TabIndex = 25;
            this.btn_lisans_ekle.Text = "Ekle";
            this.btn_lisans_ekle.UseVisualStyleBackColor = true;
            this.btn_lisans_ekle.Click += new System.EventHandler(this.btn_lisans_ekle_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(39, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 15);
            this.label5.TabIndex = 24;
            this.label5.Text = "Yazar Sayısı";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 15);
            this.label2.TabIndex = 22;
            this.label2.Text = "Editörlük Veya Bölüm Yazarlığı";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 15);
            this.label1.TabIndex = 23;
            this.label1.Text = "Doktora  Zamanı";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cmb_kitap_doktora
            // 
            this.cmb_kitap_doktora.FormattingEnabled = true;
            this.cmb_kitap_doktora.Location = new System.Drawing.Point(257, 47);
            this.cmb_kitap_doktora.Name = "cmb_kitap_doktora";
            this.cmb_kitap_doktora.Size = new System.Drawing.Size(121, 23);
            this.cmb_kitap_doktora.TabIndex = 21;
            this.cmb_kitap_doktora.SelectedIndexChanged += new System.EventHandler(this.cmb_makale_doktora_SelectedIndexChanged);
            // 
            // Kitap1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 372);
            this.Controls.Add(this.editörlük_veya_bölüm_yazarlığı);
            this.Controls.Add(this.kitap_yazar_sayi);
            this.Controls.Add(this.btn_lisans_ekle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_kitap_doktora);
            this.Name = "Kitap1";
            this.Text = "Kitap1";
            this.Load += new System.EventHandler(this.Kitap1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.editörlük_veya_bölüm_yazarlığı)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitap_yazar_sayi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown editörlük_veya_bölüm_yazarlığı;
        private System.Windows.Forms.NumericUpDown kitap_yazar_sayi;
        private System.Windows.Forms.Button btn_lisans_ekle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_kitap_doktora;
    }
}