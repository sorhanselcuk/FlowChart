using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlowChartV3.DiyagramFormlari
{
    public partial class Pencere : Form,IFormlar
    {
        private string nesneNumarasi;

        private bool guncelle = false;

        VeriTabaniYonetimi veriTabaniYonetimi = new VeriTabaniYonetimi();

        public Pencere()
        {
            InitializeComponent();
        }

        public void Ac(string nesneNumarasi)
        {
            this.nesneNumarasi = nesneNumarasi;
            this.ShowDialog();
        }

        private void buton_tamamla_Click(object sender, EventArgs e)
        {
            if (this.guncelle == true)
                Guncelle();
            else
                Kayit();
        }
        private void Guncelle()
        {
            if (txt_mesaj.Text == "")
            {
                MessageBox.Show("Mesaj alanı boş bırakılamaz !", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                veriTabaniYonetimi.veriTabani = new DiyagramVerileri.Pencere
                {
                    nesneNumarasi = this.nesneNumarasi,
                    degisken = cb_degisken.SelectedItem?.ToString(),
                    mesaj = txt_mesaj.Text.ToString()
                };
                veriTabaniYonetimi.Guncelle();
                this.Hide();
            }
        }
        private void Kayit()
        {
            if (string.IsNullOrEmpty(txt_mesaj.Text))
            {
                MessageBox.Show("Mesaj alanı boş bırakılamaz !", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                
                    veriTabaniYonetimi.veriTabani = new DiyagramVerileri.Pencere
                    {
                        nesneNumarasi = this.nesneNumarasi,
                        mesaj = txt_mesaj.Text.ToString(),
                        degisken = cb_degisken.SelectedItem?.ToString()
                    };
                veriTabaniYonetimi.Ekle();
                this.Hide();
            }
        }

        private void Pencere_Load(object sender, EventArgs e)
        {
            txt_mesaj.Text = "";
            veriTabaniYonetimi.veriTabani = new DiyagramVerileri.Degiskenler();
            foreach (var item in veriTabaniYonetimi.Al())
            {
                cb_degisken.Items.Add(item.ToString());
            }
            cb_degisken.SelectedItem = "null";
            veriTabaniYonetimi.veriTabani = new DiyagramVerileri.Pencere
            {
                nesneNumarasi = this.nesneNumarasi
            };

            List<string> gelenVeriler = veriTabaniYonetimi.Al();
            if (gelenVeriler.Count != 0)
            {
                txt_mesaj.Text += gelenVeriler[1].ToString();
                cb_degisken.SelectedItem = gelenVeriler[0].ToString();
                this.guncelle = true;
            }
        }

        private void Pencere_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (string.IsNullOrEmpty(txt_mesaj.Text))
            {
                MessageBox.Show("Boş alanlar mevcut !");
                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
            }
        }
    }
}
