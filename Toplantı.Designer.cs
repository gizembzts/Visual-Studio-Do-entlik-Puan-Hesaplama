
namespace docentlik_puan_hesaplama
{
    partial class Toplantı
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
            this.toplanti_yazar_sayi = new System.Windows.Forms.NumericUpDown();
            this.toplanti_makale_sayi = new System.Windows.Forms.NumericUpDown();
            this.btn_toplantı_ekle = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_toplanti_doktora = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.toplanti_yazar_sayi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toplanti_makale_sayi)).BeginInit();
            this.SuspendLayout();
            // 
            // toplanti_yazar_sayi
            // 
            this.toplanti_yazar_sayi.Location = new System.Drawing.Point(170, 139);
            this.toplanti_yazar_sayi.Name = "toplanti_yazar_sayi";
            this.toplanti_yazar_sayi.Size = new System.Drawing.Size(120, 23);
            this.toplanti_yazar_sayi.TabIndex = 19;
            // 
            // toplanti_makale_sayi
            // 
            this.toplanti_makale_sayi.Location = new System.Drawing.Point(171, 97);
            this.toplanti_makale_sayi.Name = "toplanti_makale_sayi";
            this.toplanti_makale_sayi.Size = new System.Drawing.Size(120, 23);
            this.toplanti_makale_sayi.TabIndex = 20;
            // 
            // btn_toplantı_ekle
            // 
            this.btn_toplantı_ekle.Location = new System.Drawing.Point(115, 214);
            this.btn_toplantı_ekle.Name = "btn_toplantı_ekle";
            this.btn_toplantı_ekle.Size = new System.Drawing.Size(75, 23);
            this.btn_toplantı_ekle.TabIndex = 18;
            this.btn_toplantı_ekle.Text = "Ekle";
            this.btn_toplantı_ekle.UseVisualStyleBackColor = true;
            this.btn_toplantı_ekle.Click += new System.EventHandler(this.btn_toplanti_ekle_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 15);
            this.label5.TabIndex = 16;
            this.label5.Text = "Yazar Sayısı";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 15);
            this.label6.TabIndex = 17;
            this.label6.Text = "Makale Sayısı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "Doktora  Zamanı";
            // 
            // cmb_toplanti_doktora
            // 
            this.cmb_toplanti_doktora.FormattingEnabled = true;
            this.cmb_toplanti_doktora.Location = new System.Drawing.Point(170, 52);
            this.cmb_toplanti_doktora.Name = "cmb_toplanti_doktora";
            this.cmb_toplanti_doktora.Size = new System.Drawing.Size(121, 23);
            this.cmb_toplanti_doktora.TabIndex = 11;
            // 
            // Toplantı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 345);
            this.Controls.Add(this.toplanti_yazar_sayi);
            this.Controls.Add(this.toplanti_makale_sayi);
            this.Controls.Add(this.btn_toplantı_ekle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_toplanti_doktora);
            this.Name = "Toplantı";
            this.Text = "Toplantı";
            this.Load += new System.EventHandler(this.Toplantı_Load);
            ((System.ComponentModel.ISupportInitialize)(this.toplanti_yazar_sayi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toplanti_makale_sayi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown toplanti_yazar_sayi;
        private System.Windows.Forms.NumericUpDown toplanti_makale_sayi;
        private System.Windows.Forms.Button btn_toplantı_ekle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_toplanti_doktora;
    }
}