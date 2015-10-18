using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hastane_Otomasyon_Suna
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //border style

        DateTime suankiTarih;
        DateTime kalanSure;//??kullanmadı diyor??????????????????????????????
        DateTime saat;
        DateTime dakika;
        DateTime saniye;
        public bool checkedEn = false;
        public bool checkedTr = true;

        private void Form1_Load(object sender, EventArgs e)
        {
            lstwRandevu.FullRowSelect = true;

        }

        private void tRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            enToolStripMenuItem.Checked = false;
            tRToolStripMenuItem.Checked = true;
            checkedEn = false;
            checkedTr = true;


            dillerToolStripMenuItem.Text = "Diller";
            randevuİşlemleriToolStripMenuItem.Text = "Randevu İşlemleri";
            silToolStripMenuItem.Text = "Sil";
            deaktiflerToolStripMenuItem.Text = "Deaktifler";
            akiflerToolStripMenuItem.Text = "Aktifler";
            groupBox1.Text = "Hasta Bilgileri";
            label1.Text = "TC Kimlik No :";
            label2.Text = "Ad :";
            label3.Text = "Soyad :";
            label4.Text = "Doğum Tarihi :";

            groupBox2.Text = "Randevu Bilgileri";
            label5.Text = "Branş Giriniz :";
            label6.Text = "Randevu Tarihi :";

            label7.Text = "Randevu Durumu :";
            btnRandevuEkle.Text = "Randevu Ekle";
            btnRandevuDüzenle.Text = "Randevu Düzenle";
            btnRandevuSil.Text = "Randevu Sil";
            btnAktif.Text = "Aktif";
            btnDeaktif.Text = "Deaktif";

            //lstwRandevu
            columnHeader1.Text = label1.Text;
            columnHeader2.Text = label2.Text;
            columnHeader3.Text = label3.Text;
            columnHeader4.Text = "Branş Giriniz";
            columnHeader5.Text = "Doğum Tarihi";
            columnHeader6.Text = "Randevu Tarihi";
            columnHeader7.Text = "Randevu Durumu";

        }

        private void enToolStripMenuItem_Click(object sender, EventArgs e)
        {
            enToolStripMenuItem.Checked = true;
            tRToolStripMenuItem.Checked = false;
            checkedEn = true;
            checkedTr = false;

            // DilSecimi dl = new DilSecimi();
            //// dl.enLanguage();
            // string fjtrd = dl.dil;

            dillerToolStripMenuItem.Text = "Languages";
            randevuİşlemleriToolStripMenuItem.Text = "Date Process";
            silToolStripMenuItem.Text = "Delete";
            deaktiflerToolStripMenuItem.Text = "Disables";
            akiflerToolStripMenuItem.Text = "Enables";
            groupBox1.Text = "Patient Info";
            label1.Text = "ID :";
            label2.Text = "Name :";
            label3.Text = "Surname :";
            label4.Text = "Born Date :";

            groupBox2.Text = "Date Info";
            label5.Text = "Diagnonis :";
            label6.Text = "Date Time :";

            label7.Text = "Appointment Status :";
            btnRandevuEkle.Text = "Add Date";
            btnRandevuDüzenle.Text = "Edit Date";
            btnRandevuSil.Text = "Delete Date";
            btnAktif.Text = "Enabled";
            btnDeaktif.Text = "Disabled";

            //lstwRandevu
            columnHeader1.Text = "ID";
            columnHeader2.Text = "Name";
            columnHeader3.Text = "Surname";
            columnHeader4.Text = "Diagnonis";
            columnHeader5.Text = "Born Date";
            columnHeader6.Text = "Date Time";
            columnHeader7.Text = "Date State";

        }

        private void btnRandevuEkle_Click(object sender, EventArgs e)
        {
            ListViewItem item;

            item = new ListViewItem(txtTC.Text);

            item.SubItems.Add(txtAd.Text);
            item.SubItems.Add(txtSoyad.Text);
            if (cBoxBransGirisi.SelectedItem.ToString() != null)
            {
                item.SubItems.Add(cBoxBransGirisi.SelectedItem.ToString());
            }
            //else if (cBoxBransGirisi.SelectedItem.ToString()==null)
            //    MessageBox.Show("Lütfen Branş Seçiniz");

            item.SubItems.Add(dTpDogumTarihi.Value.ToString());
            item.SubItems.Add(dTpRandevuTarihi.Value.ToString());
            //if (tRToolStripMenuItem.Selected == true)
            //{
            //    item.SubItems.Add("Aktif");
            //}
            //else if (enToolStripMenuItem.Selected == true)
            //{
            //    item.SubItems.Add("Enabled");
            //}
           
        

            if (checkedTr == true)
                item.SubItems.Add("Aktif");
            else
                item.SubItems.Add("Enabled");

            lstwRandevu.Items.Add(item);

            ClearMethod();
        }

        public void ClearMethod()
        {
            txtTC.Clear();
            txtAd.Clear();
            txtSoyad.Clear();
            cBoxBransGirisi.ResetText();
            dTpDogumTarihi.ResetText();
            dTpDogumTarihi.Value = DateTime.Now.Date;
            dTpRandevuTarihi.ResetText();
            dTpRandevuTarihi.Value = DateTime.Now.Date;
        }

        public void timer1_Tick(object sender, EventArgs e)
        {


            TimeSpan diff = suankiTarih.Subtract(DateTime.Now);
            lblGeriSayım.Text = string.Format("{0} day {1:00}:{2:00}:{3:00}", diff.Days, diff.Hours, diff.Minutes, diff.Seconds);
            if (suankiTarih < DateTime.Now)
                ((Timer)sender).Stop();


            if (lblGeriSayım.Text == "0 day 00:00:00")
            {
                if (enToolStripMenuItem.Checked == true)
                {
                    MessageBox.Show("Out of Time");
                }
                else
                {
                    MessageBox.Show("Süre Doldu");
                }
                timer1.Stop();
            }
        }

        private void btnRandevuSil_Click(object sender, EventArgs e)
        {
            if (lstwRandevu.SelectedIndices.Count > 0)
                lstwRandevu.Items.RemoveAt(lstwRandevu.SelectedItems[0].Index); //Seçili satırın indexi ile siler.
            else
                MessageBox.Show("Lütfen Randevu Seçiniz...");
        }

        public void lstwRandevu_MouseClick(object sender, MouseEventArgs e)
        {
            DateTime items = Convert.ToDateTime(lstwRandevu.SelectedItems[0].SubItems[5].Text);//seçtiğimiz randevuda, randevu tarihini bulur.     

            suankiTarih = DateTime.Now;
            TimeSpan kalanSure = items - suankiTarih;

            //saat= items.Hour - suankiTarih.Hour;
            //TimeSpan saat = items.Hour - suankiTarih.Hour;
            //suankiTarih = DateTime.Now.AddDays(kalanSure.Days).AddHours(saat.Hour).AddMinutes(1).AddSeconds(10);


            suankiTarih = DateTime.Now.AddDays(kalanSure.Days).AddHours(0).AddMinutes(1).AddSeconds(10);
            timer1.Start();
            lblGeriSayım.Text = kalanSure.ToString();


        }

        private void btnDeaktif_Click(object sender, EventArgs e)
        {
            lstwRandevu.SelectedItems[0].SubItems[6].Text = "Deaktif";

        }


    }


}






