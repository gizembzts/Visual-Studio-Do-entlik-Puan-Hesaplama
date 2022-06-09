
namespace docentlik_puan_hesaplama
{
    partial class Makale
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
            this.cmb_makale_doktora = new System.Windows.Forms.ComboBox();
            this.cmb_makale_baslica_yazar = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_makale_ekle = new System.Windows.Forms.Button();
            this.makale_sira = new System.Windows.Forms.NumericUpDown();
            this.makale_sayi = new System.Windows.Forms.NumericUpDown();
            this.makale_yazar_sayi = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.makale_sira)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.makale_sayi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.makale_yazar_sayi)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_makale_doktora
            // 
            this.cmb_makale_doktora.FormattingEnabled = true;
            this.cmb_makale_doktora.Location = new System.Drawing.Point(178, 23);
            this.cmb_makale_doktora.Name = "cmb_makale_doktora";
            this.cmb_makale_doktora.Size = new System.Drawing.Size(121, 23);
            this.cmb_makale_doktora.TabIndex = 0;
            // 
            // cmb_makale_baslica_yazar
            // 
            this.cmb_makale_baslica_yazar.FormattingEnabled = true;
            this.cmb_makale_baslica_yazar.Location = new System.Drawing.Point(178, 70);
            this.cmb_makale_baslica_yazar.Name = "cmb_makale_baslica_yazar";
            this.cmb_makale_baslica_yazar.Size = new System.Drawing.Size(121, 23);
            this.cmb_makale_baslica_yazar.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Doktora  Zamanı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Başlıca Yazar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sıra";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Yazar Sayısı";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "Makale Sayısı";
            // 
            // btn_makale_ekle
            // 
            this.btn_makale_ekle.Location = new System.Drawing.Point(132, 240);
            this.btn_makale_ekle.Name = "btn_makale_ekle";
            this.btn_makale_ekle.Size = new System.Drawing.Size(75, 23);
            this.btn_makale_ekle.TabIndex = 9;
            this.btn_makale_ekle.Text = "Ekle";
            this.btn_makale_ekle.UseVisualStyleBackColor = true;
            this.btn_makale_ekle.Click += new System.EventHandler(this.btn_makale_ekle_Click);
            // 
            // makale_sira
            // 
            this.makale_sira.Location = new System.Drawing.Point(179, 109);
            this.makale_sira.Name = "makale_sira";
            this.makale_sira.Size = new System.Drawing.Size(120, 23);
            this.makale_sira.TabIndex = 10;
            // 
            // makale_sayi
            // 
            this.makale_sayi.Location = new System.Drawing.Point(179, 145);
            this.makale_sayi.Name = "makale_sayi";
            this.makale_sayi.Size = new System.Drawing.Size(120, 23);
            this.makale_sayi.TabIndex = 10;
            // 
            // makale_yazar_sayi
            // 
            this.makale_yazar_sayi.Location = new System.Drawing.Point(178, 187);
            this.makale_yazar_sayi.Name = "makale_yazar_sayi";
            this.makale_yazar_sayi.Size = new System.Drawing.Size(120, 23);
            this.makale_yazar_sayi.TabIndex = 10;
            // 
            // Makale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 297);
            this.Controls.Add(this.makale_yazar_sayi);
            this.Controls.Add(this.makale_sayi);
            this.Controls.Add(this.makale_sira);
            this.Controls.Add(this.btn_makale_ekle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_makale_baslica_yazar);
            this.Controls.Add(this.cmb_makale_doktora);
            this.Name = "Makale";
            this.Text = "Makale";
            this.Load += new System.EventHandler(this.Makale_Load);
            ((System.ComponentModel.ISupportInitialize)(this.makale_sira)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.makale_sayi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.makale_yazar_sayi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_makale_doktora;
        private System.Windows.Forms.ComboBox cmb_makale_baslica_yazar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_makale_ekle;
        private System.Windows.Forms.NumericUpDown makale_sira;
        private System.Windows.Forms.NumericUpDown makale_sayi;
        private System.Windows.Forms.NumericUpDown makale_yazar_sayi;
    }
}