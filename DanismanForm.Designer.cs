
namespace docentlik_puan_hesaplama
{
    partial class DanismanForm
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
            this.danisman_sayisi = new System.Windows.Forms.NumericUpDown();
            this.btn_danisman_ekle = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_danisman_doktora = new System.Windows.Forms.ComboBox();
            this.cmb_danisman_seviye = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.danisman_sayisi)).BeginInit();
            this.SuspendLayout();
            // 
            // danisman_sayisi
            // 
            this.danisman_sayisi.Location = new System.Drawing.Point(181, 100);
            this.danisman_sayisi.Name = "danisman_sayisi";
            this.danisman_sayisi.Size = new System.Drawing.Size(120, 23);
            this.danisman_sayisi.TabIndex = 26;
            // 
            // btn_danisman_ekle
            // 
            this.btn_danisman_ekle.Location = new System.Drawing.Point(123, 148);
            this.btn_danisman_ekle.Name = "btn_danisman_ekle";
            this.btn_danisman_ekle.Size = new System.Drawing.Size(75, 23);
            this.btn_danisman_ekle.TabIndex = 25;
            this.btn_danisman_ekle.Text = "Ekle";
            this.btn_danisman_ekle.UseVisualStyleBackColor = true;
            this.btn_danisman_ekle.Click += new System.EventHandler(this.btn_danisman_ekle_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 15);
            this.label3.TabIndex = 23;
            this.label3.Text = "Danışmanlık Sayısı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 15);
            this.label1.TabIndex = 24;
            this.label1.Text = "Doktora  Zamanı";
            // 
            // cmb_danisman_doktora
            // 
            this.cmb_danisman_doktora.FormattingEnabled = true;
            this.cmb_danisman_doktora.Location = new System.Drawing.Point(180, 45);
            this.cmb_danisman_doktora.Name = "cmb_danisman_doktora";
            this.cmb_danisman_doktora.Size = new System.Drawing.Size(121, 23);
            this.cmb_danisman_doktora.TabIndex = 22;
            // 
            // cmb_danisman_seviye
            // 
            this.cmb_danisman_seviye.FormattingEnabled = true;
            this.cmb_danisman_seviye.Location = new System.Drawing.Point(181, 72);
            this.cmb_danisman_seviye.Name = "cmb_danisman_seviye";
            this.cmb_danisman_seviye.Size = new System.Drawing.Size(121, 23);
            this.cmb_danisman_seviye.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 15);
            this.label2.TabIndex = 24;
            this.label2.Text = "Danışmanlık Seviyesi";
            // 
            // DanismanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.danisman_sayisi);
            this.Controls.Add(this.btn_danisman_ekle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_danisman_seviye);
            this.Controls.Add(this.cmb_danisman_doktora);
            this.Name = "DanismanForm";
            this.Text = "DanismanForm";
            this.Load += new System.EventHandler(this.DanismanForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.danisman_sayisi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown danisman_sayisi;
        private System.Windows.Forms.Button btn_danisman_ekle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_danisman_doktora;
        private System.Windows.Forms.ComboBox cmb_danisman_seviye;
        private System.Windows.Forms.Label label2;
    }
}