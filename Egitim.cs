using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace docentlik_puan_hesaplama
{
    public partial class Egitim : Form
    {
        public int Puan;
        Form1 ownerForm = null;        
        public Egitim(Form1 ownerForm)
        {
            InitializeComponent();
            this.ownerForm = ownerForm;
        }

        private void Egitim_Load(object sender, EventArgs e)
        {
            cmb_egitim_doktora.Items.Add("Doktora Öncesi");
            cmb_egitim_doktora.Items.Add("Doktora Sonrası");
        }

        private void btn_toplantı_ekle_Click(object sender, EventArgs e)
        {
            string result = "";
            result = (cmb_egitim_doktora.SelectedItem.ToString() + " Eğitim Faaliyeti - " + Puan.ToString());


            this.ownerForm.PassValue(result);
            this.Close();
        }
    }
}
