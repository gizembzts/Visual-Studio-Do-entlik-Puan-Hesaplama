using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace docentlik_puan_hesaplama
{
    public partial class LisansBildiriForm : Form
    {
        public int Puan;
        Form1 ownerForm = null;
        public LisansBildiriForm(Form1 ownerForm)
        {
            InitializeComponent();
            this.ownerForm = ownerForm;
        }

        private void LisansBildiriForm_Load(object sender, EventArgs e)
        {
            cmb_makale_doktora.Items.Add("Doktora Öncesi");
            cmb_makale_doktora.Items.Add("Doktora Sonrası");
        }

        private void btn_lisans_ekle_Click(object sender, EventArgs e)
        {
            int lisans_puan = Puan;
            if (cmb_makale_doktora.SelectedItem == null ||
                bildiri_sayisi.Value == 0 ||              
                makale_yazar_sayi.Value == 0)
            {
                MessageBox.Show("Boşlukları Doldurun!!");
            }

            string result = ("Lisansüstü Tezlerden Üretilmiş Yayın - " + lisans_puan.ToString());

            this.ownerForm.PassValue(result);
            this.Close();


        }
    }
}
