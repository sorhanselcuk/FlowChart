using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlowChartV3.DiyagramFormlari
{
    public partial class Islem : Form, IFormlar
    {
        private string nesneNumarasi;

        string[] parcala;

        private bool guncelle = false;

        private string islem;

        VeriTabaniYonetimi veriTabaniYonetimi = new VeriTabaniYonetimi();

        public Islem()
        {
            InitializeComponent();
        }

        public void Ac(string nesneNumarasi)
        {
            this.nesneNumarasi = nesneNumarasi;
            this.ShowDialog();
        }

        private void buton_tanimlama_Click(object sender, EventArgs e)
        {
            if (guncelle == true)
                GuncelleDegisken();
            else
                KayitDegisken();

        }
        private void GuncelleDegisken()
        {
            if (txt_degiskenAdi.Text == null || txt_degiskenDegeri.Text == null)
            {
                MessageBox.Show("Boş alanlar var", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (AnahtarKontrol() == false)
            {
                MessageBox.Show("Değişken isimleri keyword olamaz !", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                veriTabaniYonetimi.veriTabani = new DiyagramVerileri.Degiskenler
                {
                    nesneNumarasi = this.nesneNumarasi,
                    nesneAdi = txt_degiskenAdi.Text,
                    nesneTipi = cb_degiskenTipi.SelectedItem.ToString(),
                    nesneDegeri = txt_degiskenDegeri.Text
                };
                veriTabaniYonetimi.Guncelle();
                this.Hide();
            }
        }
        private void KayitDegisken()
        {
            if (txt_degiskenAdi.Text == null || txt_degiskenDegeri.Text == null)
            {
                MessageBox.Show("Boş alanlar var", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (AnahtarKontrol() == false)
            {
                MessageBox.Show("Değişken isimleri keyword olamaz !", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                veriTabaniYonetimi.veriTabani = new DiyagramVerileri.Degiskenler
                {
                    nesneNumarasi = this.nesneNumarasi,
                    nesneAdi = txt_degiskenAdi.Text,
                    nesneTipi = cb_degiskenTipi.SelectedItem.ToString(),
                    nesneDegeri = txt_degiskenDegeri.Text
                };
                veriTabaniYonetimi.Ekle();
                this.Hide();
            }
        }

        private bool AnahtarKontrol()
        {
            AnahtarKelimeler();
            for (int i = 0; i < parcala.Length; i++)
            {
                if (string.Compare(txt_degiskenAdi.Text, parcala[i], true) == 0)
                {
                    return false;
                }
            }
            return true;
        }
        public void AnahtarKelimeler()
        {
            StreamReader streamReader = new StreamReader("..\\..\\Keywords.txt");
            string oku = streamReader.ReadLine();
            while (oku != null)
            {
                parcala = oku.Split('$');
                oku = streamReader.ReadLine();
            }
            streamReader.Close();
            streamReader.Dispose();
        }

        private void txt_degiskenAdi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar >= 65 && (int)e.KeyChar <= 90)
            {
                e.Handled = false;

            }
            else if ((int)e.KeyChar >= 97 && (int)e.KeyChar <= 122)
            {
                e.Handled = false;
            }
            else if ((int)e.KeyChar >= 48 && (int)e.KeyChar <= 57)
            {
                e.Handled = false;
            }
            else if ((int)e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
                e.Handled = true;
        }

        private void txt_degiskenAdi_TextChanged(object sender, EventArgs e)
        {
            int i = 0;
            for (; i < 10; i++)
            {
                if (txt_degiskenAdi.Text.Substring(0) == i.ToString())
                {
                    MessageBox.Show("Değişken isimleri sayı ile başlayamaz !", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    // txt_complete.Enabled = false;
                    txt_degiskenAdi.Text = "";
                }

            }
        }

        private void Islem_Load(object sender, EventArgs e)
        {
            /* Değişken Yüklemesi */
            veriTabaniYonetimi.veriTabani = new DiyagramVerileri.Degiskenler();
            List<string> gelenVeriler = veriTabaniYonetimi.Al();
            if (gelenVeriler.Count != 0)
            {
                foreach (var item in gelenVeriler)
                {
                    cb_degisken1.Items.Add(item.ToString());
                    cb_degisken2.Items.Add(item.ToString());
                    cb_degiskenSonucu.Items.Add(item.ToString());
                }
            }

            /* Değişken Yüklemesi */

            /* Değişken Tanımlama Yüklemesi */
            veriTabaniYonetimi.veriTabani = new DiyagramVerileri.Degiskenler
            {
                nesneNumarasi=this.nesneNumarasi
            };
            gelenVeriler=veriTabaniYonetimi.Al();
            if (gelenVeriler.Count >3)
            {
                txt_degiskenAdi.Text = gelenVeriler[1].ToString();
                cb_degiskenTipi.SelectedItem = gelenVeriler[2].ToString();
                txt_degiskenDegeri.Text = gelenVeriler[3].ToString();
                this.guncelle = true;
                tabControl1.TabPages.Remove(tabPage2);
            }
            /* Değişken Tanımlama Yüklemesi */

            /* İşlem Yüklemesi */
            veriTabaniYonetimi.veriTabani = new DiyagramVerileri.Islem
            {
                nesneNumarasi = this.nesneNumarasi
            };
            gelenVeriler = veriTabaniYonetimi.Al();
            if (gelenVeriler.Count != 0)
            {
                cb_degisken1.SelectedItem = gelenVeriler[1].ToString();
                cb_operator.SelectedItem = gelenVeriler[2].ToString();
                cb_degisken2.SelectedItem = gelenVeriler[3].ToString();
                cb_degiskenSonucu.SelectedItem = gelenVeriler[4].ToString();
                this.guncelle = true;
                tabControl1.TabPages.Remove(tabPage1);
            }
            /* İşlem Yüklemesi */
        }

        private void buton_islem_Click(object sender, EventArgs e)
        {
            if (guncelle == true)
                GuncelleIslem();
            else
                KayitIslem();
        }
        private void GuncelleIslem()
        {
            if (cb_degisken1.SelectedItem == null || cb_degisken2.SelectedItem == null || cb_operator.SelectedItem == null || cb_degiskenSonucu.SelectedItem == null)
            {
                MessageBox.Show("Boş alanlar var !", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                veriTabaniYonetimi.veriTabani = new DiyagramVerileri.Islem
                {
                    nesneNumarasi = this.nesneNumarasi,
                    degisken1 = cb_degisken1.SelectedItem.ToString(),
                    degisken2 = cb_degisken2.SelectedItem.ToString(),
                    isaret = cb_operator.SelectedItem.ToString(),
                    degiskenSonuc = cb_degiskenSonucu.SelectedItem.ToString()
                };
                veriTabaniYonetimi.Guncelle();
                this.Hide();
            }
        }
        private void KayitIslem()
        {
            if (cb_degisken1.SelectedItem == null || cb_degisken2.SelectedItem == null || cb_operator.SelectedItem == null || cb_degiskenSonucu.SelectedItem == null)
            {
                MessageBox.Show("Boş alanlar var !", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                veriTabaniYonetimi.veriTabani = new DiyagramVerileri.Islem
                {
                    nesneNumarasi = this.nesneNumarasi,
                    degisken1 = cb_degisken1.SelectedItem.ToString(),
                    degisken2 = cb_degisken2.SelectedItem.ToString(),
                    isaret = cb_operator.SelectedItem.ToString(),
                    degiskenSonuc = cb_degiskenSonucu.SelectedItem.ToString()
                };
                veriTabaniYonetimi.Ekle();
                this.Hide();
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            cb_degisken1.Items.Add(txt_deger.Text);
            cb_degisken2.Items.Add(txt_deger.Text);
        }

      

        private void Islem_FormClosing(object sender, FormClosingEventArgs e)
        {
                //foreach (Control item in tabPage1.Controls)
                //{
                //    if (item.GetType() == typeof(TextBox) || item.GetType() == typeof(ComboBox))
                //    {
                //        if (string.IsNullOrEmpty(item.Text))
                //        {
                //            MessageBox.Show("Boş alanlar var");
                //            e.Cancel = true;
                //        }
                //        else
                //        {
                //            e.Cancel = false;
                //        }
                //    }
                //}
            
        }
    }
}
