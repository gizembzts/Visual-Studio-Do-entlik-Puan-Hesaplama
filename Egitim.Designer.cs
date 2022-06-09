
namespace docentlik_puan_hesaplama
{
    partial class Egitim
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
            this.egitim_ders_sayi = new System.Windows.Forms.NumericUpDown();
            this.btn_toplantı_ekle = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_egitim_doktora = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.egitim_ders_sayi)).BeginInit();
            this.SuspendLayout();
            // 
            // egitim_ders_sayi
            // 
            this.egitim_ders_sayi.Location = new System.Drawing.Point(163, 135);
            this.egitim_ders_sayi.Name = "egitim_ders_sayi";
            this.egitim_ders_sayi.Size = new System.Drawing.Size(120, 23);
            this.egitim_ders_sayi.TabIndex = 27;
            // 
            // btn_toplantı_ekle
            // 
            this.btn_toplantı_ekle.Location = new System.Drawing.Point(112, 198);
            this.btn_toplantı_ekle.Name = "btn_toplantı_ekle";
            this.btn_toplantı_ekle.Size = new System.Drawing.Size(75, 23);
            this.btn_toplantı_ekle.TabIndex = 25;
            this.btn_toplantı_ekle.Text = "Ekle";
            this.btn_toplantı_ekle.UseVisualStyleBackColor = true;
            this.btn_toplantı_ekle.Click += new System.EventHandler(this.btn_toplantı_ekle_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 143);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 15);
            this.label6.TabIndex = 24;
            this.label6.Text = "Ders Sayısı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 15);
            this.label1.TabIndex = 22;
            this.label1.Text = "Doktora  Zamanı";
            // 
            // cmb_egitim_doktora
            // 
            this.cmb_egitim_doktora.FormattingEnabled = true;
            this.cmb_egitim_doktora.Location = new System.Drawing.Point(162, 90);
            this.cmb_egitim_doktora.Name = "cmb_egitim_doktora";
            this.cmb_egitim_doktora.Size = new System.Drawing.Size(121, 23);
            this.cmb_egitim_doktora.TabIndex = 21;
            // 
            // Egitim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 364);
            this.Controls.Add(this.egitim_ders_sayi);
            this.Controls.Add(this.btn_toplantı_ekle);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_egitim_doktora);
            this.Name = "Egitim";
            this.Text = "Egitim";
            this.Load += new System.EventHandler(this.Egitim_Load);
            ((System.ComponentModel.ISupportInitialize)(this.egitim_ders_sayi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown egitim_ders_sayi;
        private System.Windows.Forms.Button btn_toplantı_ekle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_egitim_doktora;
    }
}