using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace docentlik_puan_hesaplama
{
    public partial class Makale : Form
    {
        public int Puan;
        public bool isLisans = false;
        Form1 ownerForm = null; 
        public Makale(Form1 ownerForm)
        {
            InitializeComponent();
            this.ownerForm = ownerForm;
        }

        private void Makale_Load(object sender, EventArgs e)
        {
            cmb_makale_doktora.Items.Add("Doktora Öncesi");
            cmb_makale_doktora.Items.Add("Doktora Sonrası");

            cmb_makale_baslica_yazar.Items.Add("Başlıca Yazar Var");
            cmb_makale_baslica_yazar.Items.Add("Başlıca Yazar Yok");


        }

        private void btn_makale_ekle_Click(object sender, EventArgs e)
        {
            int makale_puan = 0;
            if(cmb_makale_doktora.SelectedItem == null ||
                cmb_makale_baslica_yazar.SelectedItem == null ||
                makale_sayi.Value == 0 ||
                makale_sira.Value == 0 || 
                makale_yazar_sayi.Value == 0)
            {
                MessageBox.Show("Boşlukları Doldurun!!");
            }

            if (cmb_makale_baslica_yazar.SelectedIndex == 0)
            {
                if (makale_yazar_sayi.Value == 1)
                {
                    makale_puan = Puan;
                }
                else if (makale_yazar_sayi.Value == 2)
                {
                    if (makale_sira.Value == 1)
                    {
                        makale_puan = Puan * 8 / 10;
                    }
                    else
                    {
                        makale_puan = Puan * 5 / 10;
                    }
                }
                else if (makale_yazar_sayi.Value > 2)
                {
                    if (makale_sira.Value == 1)
                    {
                        makale_puan = Puan * 5 / 10;
                    }
                    else
                    {
                        makale_puan = Puan / Convert.ToInt32(makale_yazar_sayi.Value);
                    }
                }
            }
            else
            {
                makale_puan = Puan / Convert.ToInt32(makale_yazar_sayi.Value);
            }

            string result = "";
            if (isLisans)
            {
                result = ("Lisansüstü Tezlerden Üretilmiş Yayın - " + makale_puan.ToString());
            }
            else if (!isLisans)
            {
                result = (cmb_makale_doktora.SelectedItem.ToString() + " Makale - " + makale_puan.ToString());
            }

            this.ownerForm.PassValue(result);
            this.Close();
           
            
            
        }
    }
}
