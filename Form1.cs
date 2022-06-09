using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace docentlik_puan_hesaplama
{
    public partial class Form1 : Form
    {
        public List<string> puanListesi = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

           
        }
        public void PassValue(string value)
        {
            listBox_veri.Items.Add(value);
        }


        private void btn_makale1_Click(object sender, EventArgs e)
        {
            Makale makaleForm = new Makale(this);
            makaleForm.Puan = 20;
            makaleForm.Show();

        }

        private void btn_makale2_Click(object sender, EventArgs e)
        {
            Makale makaleForm = new Makale(this);
            makaleForm.Puan = 8;
            makaleForm.Show();
        }

        private void btn_makale3_Click(object sender, EventArgs e)
        {
            Makale makaleForm = new Makale(this);
            makaleForm.Puan = 8;
            makaleForm.Show();
        }

        private void btn_lisans_1_Click(object sender, EventArgs e)
        {
            Makale makaleForm = new Makale(this);
            makaleForm.Puan = 10;
            makaleForm.isLisans = true;
            makaleForm.Show();
        }

        private void btn_lisans_2_Click(object sender, EventArgs e)
        {
             Makale makaleForm = new Makale(this);
            makaleForm.Puan = 5;
            makaleForm.isLisans = true;
            makaleForm.Show();
        }

        private void btn_lisans_3_Click(object sender, EventArgs e)
        {
            LisansBildiriForm lisansBildiriForm = new LisansBildiriForm(this);
            lisansBildiriForm.Puan = 5;
            lisansBildiriForm.Show();
        }

        private void btn_lisan_4_Click(object sender, EventArgs e)
        {
            LisansBildiriForm lisansBildiriForm = new LisansBildiriForm(this);
            lisansBildiriForm.Puan = 3;
            lisansBildiriForm.Show();
        }

        private void btn_kitap1_Click(object sender, EventArgs e)
        {
            Kitap1 kitapForm = new Kitap1(this);
            kitapForm.Puan = 20;
            kitapForm.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_kitap2_Click(object sender, EventArgs e)
        {

        }

 


        private void btn_kitap4_Click(object sender, EventArgs e)
        {
            Kitap1 kitapForm = new Kitap1(this);
            kitapForm.Puan = 8;
            kitapForm.Show();
        }

        private void btn_kitap2_Click_1(object sender, EventArgs e)
        {
            Kitap1 kitapForm = new Kitap1(this);
            kitapForm.Puan = 10;
            kitapForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kitap1 kitapForm = new Kitap1(this);
            kitapForm.Puan = 15;
            kitapForm.Show();
        }

        private void btn_paten1_Click(object sender, EventArgs e)
        {
            Patent1 patent = new Patent1(this);
            patent.Puan = 20;
            patent.Show();
        }

        private void btn_patent2_Click(object sender, EventArgs e)
        {
            Patent1 patent = new Patent1(this);
            patent.Puan = 10;
            patent.Show();
        }

        private void btn_atif1_Click(object sender, EventArgs e)
        {
            AtiflarForm atifForm = new AtiflarForm(this);
            atifForm.Puan = 3;
            atifForm.Show();
        }

        private void btn_atif2_Click(object sender, EventArgs e)
        {
            AtiflarForm atifForm = new AtiflarForm(this);
            atifForm.Puan = 2;
            atifForm.Show();
        }

        private void btn_atif3_Click(object sender, EventArgs e)
        {
            AtiflarForm atifForm = new AtiflarForm(this);
            atifForm.Puan = 1;
            atifForm.Show();
        }

        private void btn_danisman1_Click(object sender, EventArgs e)
        {
            DanismanForm danismanForm = new DanismanForm(this);
            danismanForm.Puan = 4;
            danismanForm.Show();
        }

        private void btn_danisman2_Click(object sender, EventArgs e)
        {
            DanismanForm danismanForm = new DanismanForm(this);
            danismanForm.Puan = 2;
            danismanForm.Show();
        }

        private void btn_arastirma1_Click(object sender, EventArgs e)
        {
            ArastirmaForm arastirmaForm = new ArastirmaForm(this);
            arastirmaForm.Puan = 15;
            arastirmaForm.Show();
        }

        private void btn_arastirma2_Click(object sender, EventArgs e)
        {
            ArastirmaForm arastirmaForm = new ArastirmaForm(this);
            arastirmaForm.Puan = 10;
            arastirmaForm.Show();
        }    

       

        private void btn_toplanti1_Click_1(object sender, EventArgs e)
        {
            Toplantı toplantıForm = new Toplantı(this);
            toplantıForm.Puan = 3;
            toplantıForm.Show();
        }

        private void btn_toplanti2_Click_1(object sender, EventArgs e)
        {
            Toplantı toplantıForm = new Toplantı(this);
            toplantıForm.Puan = 2;
            toplantıForm.Show();
        }
        private void btn_egitim1_Click_1(object sender, EventArgs e)
        {
            Egitim egitimForm = new Egitim(this);
            egitimForm.Puan = 3;
            egitimForm.Show();
        }

        private void btn_egitim2_Click(object sender, EventArgs e)
        {
            Egitim egitimForm = new Egitim(this);
            egitimForm.Puan = 2;
            egitimForm.Show();
        }
        private void btn_arastirma3_Click_1(object sender, EventArgs e)
        {
            ArastirmaForm arastirmaForm = new ArastirmaForm(this);
            arastirmaForm.Puan = 6;
            arastirmaForm.Show();
        }

        private void btn_arastirma_4_Click(object sender, EventArgs e)
        {
            ArastirmaForm arastirmaForm = new ArastirmaForm(this);
            arastirmaForm.Puan = 4;
            arastirmaForm.Show();
        }

        private void puan_hesapla_Click(object sender, EventArgs e)
        {
            
            foreach (var listBoxItem in listBox_veri.Items)
            {
                string[] dizi = listBoxItem.ToString().Split("-");
                puanListesi.Add(dizi[1]);
              

            }
            int total = 0;

            foreach (var item in puanListesi)
            {
               
              total += Convert.ToInt32( item);


            }
            MessageBox.Show("Toplam Puanınız : " +total.ToString());
            listBox_veri.Items.Clear();
            puanListesi.Clear();
        }

        private void deleteItem_Click(object sender, EventArgs e)
        {
            listBox_veri.Items.Remove(listBox_veri.SelectedItem);
        }
    }
}
