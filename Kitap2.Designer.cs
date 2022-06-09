
namespace docentlik_puan_hesaplama
{
    partial class Kitap2
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
            this.makale_yazar_sayi = new System.Windows.Forms.NumericUpDown();
            this.btn_lisans_ekle = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_makale_doktora = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.editörlük_veya_bölüm_yazarlığı)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.makale_yazar_sayi)).BeginInit();
            this.SuspendLayout();
            // 
            // editörlük_veya_bölüm_yazarlığı
            // 
            this.editörlük_veya_bölüm_yazarlığı.Location = new System.Drawing.Point(221, 83);
            this.editörlük_veya_bölüm_yazarlığı.Name = "editörlük_veya_bölüm_yazarlığı";
            this.editörlük_veya_bölüm_yazarlığı.Size = new System.Drawing.Size(120, 23);
            this.editörlük_veya_bölüm_yazarlığı.TabIndex = 34;
            // 
            // makale_yazar_sayi
            // 
            this.makale_yazar_sayi.Location = new System.Drawing.Point(221, 133);
            this.makale_yazar_sayi.Name = "makale_yazar_sayi";
            this.makale_yazar_sayi.Size = new System.Drawing.Size(120, 23);
            this.makale_yazar_sayi.TabIndex = 33;
            // 
            // btn_lisans_ekle
            // 
            this.btn_lisans_ekle.Location = new System.Drawing.Point(81, 197);
            this.btn_lisans_ekle.Name = "btn_lisans_ekle";
            this.btn_lisans_ekle.Size = new System.Drawing.Size(75, 23);
            this.btn_lisans_ekle.TabIndex = 32;
            this.btn_lisans_ekle.Text = "Ekle";
            this.btn_lisans_ekle.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 15);
            this.label5.TabIndex = 31;
            this.label5.Text = "Yazar Sayısı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 15);
            this.label2.TabIndex = 29;
            this.label2.Text = "Kitap Sayısı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 15);
            this.label1.TabIndex = 30;
            this.label1.Text = "Doktora  Zamanı";
            // 
            // cmb_makale_doktora
            // 
            this.cmb_makale_doktora.FormattingEnabled = true;
            this.cmb_makale_doktora.Location = new System.Drawing.Point(220, 41);
            this.cmb_makale_doktora.Name = "cmb_makale_doktora";
            this.cmb_makale_doktora.Size = new System.Drawing.Size(121, 23);
            this.cmb_makale_doktora.TabIndex = 28;
            // 
            // Kitap2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 337);
            this.Controls.Add(this.editörlük_veya_bölüm_yazarlığı);
            this.Controls.Add(this.makale_yazar_sayi);
            this.Controls.Add(this.btn_lisans_ekle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_makale_doktora);
            this.Name = "Kitap2";
            this.Text = "Kitap2";
            ((System.ComponentModel.ISupportInitialize)(this.editörlük_veya_bölüm_yazarlığı)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.makale_yazar_sayi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown editörlük_veya_bölüm_yazarlığı;
        private System.Windows.Forms.NumericUpDown makale_yazar_sayi;
        private System.Windows.Forms.Button btn_lisans_ekle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_makale_doktora;
    }
}