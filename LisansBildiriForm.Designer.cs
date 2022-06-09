
namespace docentlik_puan_hesaplama
{
    partial class LisansBildiriForm
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
            this.makale_yazar_sayi = new System.Windows.Forms.NumericUpDown();
            this.btn_lisans_ekle = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_makale_doktora = new System.Windows.Forms.ComboBox();
            this.bildiri_sayisi = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.makale_yazar_sayi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bildiri_sayisi)).BeginInit();
            this.SuspendLayout();
            // 
            // makale_yazar_sayi
            // 
            this.makale_yazar_sayi.Location = new System.Drawing.Point(191, 121);
            this.makale_yazar_sayi.Name = "makale_yazar_sayi";
            this.makale_yazar_sayi.Size = new System.Drawing.Size(120, 23);
            this.makale_yazar_sayi.TabIndex = 19;
            // 
            // btn_lisans_ekle
            // 
            this.btn_lisans_ekle.Location = new System.Drawing.Point(136, 185);
            this.btn_lisans_ekle.Name = "btn_lisans_ekle";
            this.btn_lisans_ekle.Size = new System.Drawing.Size(75, 23);
            this.btn_lisans_ekle.TabIndex = 18;
            this.btn_lisans_ekle.Text = "Ekle";
            this.btn_lisans_ekle.UseVisualStyleBackColor = true;
            this.btn_lisans_ekle.Click += new System.EventHandler(this.btn_lisans_ekle_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 15);
            this.label5.TabIndex = 16;
            this.label5.Text = "Yazar Sayısı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 15);
            this.label2.TabIndex = 14;
            this.label2.Text = "Bildiri Sayısı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "Doktora  Zamanı";
            // 
            // cmb_makale_doktora
            // 
            this.cmb_makale_doktora.FormattingEnabled = true;
            this.cmb_makale_doktora.Location = new System.Drawing.Point(190, 29);
            this.cmb_makale_doktora.Name = "cmb_makale_doktora";
            this.cmb_makale_doktora.Size = new System.Drawing.Size(121, 23);
            this.cmb_makale_doktora.TabIndex = 11;
            // 
            // bildiri_sayisi
            // 
            this.bildiri_sayisi.Location = new System.Drawing.Point(191, 71);
            this.bildiri_sayisi.Name = "bildiri_sayisi";
            this.bildiri_sayisi.Size = new System.Drawing.Size(120, 23);
            this.bildiri_sayisi.TabIndex = 20;
            // 
            // LisansBildiriForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 295);
            this.Controls.Add(this.bildiri_sayisi);
            this.Controls.Add(this.makale_yazar_sayi);
            this.Controls.Add(this.btn_lisans_ekle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_makale_doktora);
            this.Name = "LisansBildiriForm";
            this.Text = "LisansBildiriForm";
            this.Load += new System.EventHandler(this.LisansBildiriForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.makale_yazar_sayi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bildiri_sayisi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown makale_yazar_sayi;
        private System.Windows.Forms.Button btn_lisans_ekle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_makale_doktora;
        private System.Windows.Forms.NumericUpDown bildiri_sayisi;
    }
}