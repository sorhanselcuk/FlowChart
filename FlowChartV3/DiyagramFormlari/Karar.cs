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
    public partial class Karar : Form,IFormlar
    {
        private string nesneNumarasi;

        private bool guncelle = false;

        VeriTabaniYonetimi veriTabaniYonetimi = new VeriTabaniYonetimi();

        public Karar()
        {
            InitializeComponent();
        }

        public void Ac(string nesneNumarasi)
        {
            this.nesneNumarasi = nesneNumarasi;
            this.ShowDialog();
        }

        private void Karar_Load(object sender, EventArgs e)
        {
            veriTabaniYonetimi.veriTabani = new DiyagramVerileri.Degiskenler();
            foreach (var item in veriTabaniYonetimi.Al())
            {
                cb_degisken1.Items.Add(item.ToString());
                cb_degisken2.Items.Add(item.ToString());
            }

            veriTabaniYonetimi.veriTabani = new DiyagramVerileri.Karar
            {
                nesneNumarasi = this.nesneNumarasi
            };

            List<string> gelenVeriler = veriTabaniYonetimi.Al();
            if (gelenVeriler.Count != 0)
            {
                cb_degisken1.SelectedItem=gelenVeriler[0].ToString();
                cb_islem.SelectedItem=gelenVeriler[1].ToString();
                 cb_degisken2.SelectedItem=gelenVeriler[2].ToString();
                this.guncelle = true;
            }
        }

        private void buton_tamamla_Click(object sender, EventArgs e)
        {
            if (guncelle == true)
                Guncelle();
            else
                Kayit();
        }
        private void Guncelle()
        {
            if (cb_degisken1.SelectedItem == null || cb_degisken2.SelectedItem == null || cb_islem.SelectedItem == null)
            {
                MessageBox.Show("Boş alanlar var ", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                veriTabaniYonetimi.veriTabani = new DiyagramVerileri.Karar
                {
                    nesneNumarasi = this.nesneNumarasi,
                    degisken1 = cb_degisken1.SelectedItem.ToString(),
                    degisken2 = cb_degisken2.SelectedItem.ToString(),
                    kosul = cb_islem.SelectedItem.ToString()
                };
                veriTabaniYonetimi.Guncelle();
                this.Hide();

            }
        }
        private void Kayit()
        {
            if (cb_degisken1.SelectedItem == null || cb_degisken2.SelectedItem == null || cb_islem.SelectedItem == null)
            {
                MessageBox.Show("Boş alanlar var ", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                veriTabaniYonetimi.veriTabani = new DiyagramVerileri.Karar
                {
                    nesneNumarasi = this.nesneNumarasi,
                    degisken1 = cb_degisken1.SelectedItem.ToString(),
                    degisken2 = cb_degisken2.SelectedItem.ToString(),
                    kosul = cb_islem.SelectedItem.ToString()
                };
                veriTabaniYonetimi.Ekle();
                this.Hide();
            
            }
                
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            cb_degisken1.Items.Add(txt_deger.Text);
            cb_degisken2.Items.Add(txt_deger.Text);
        }
    }
}
