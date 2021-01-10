using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FlowChartV3.Exceptions;

namespace FlowChartV3
{
    public partial class Form1 : Form
    {
        bool maximized = false;

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        NesneYonetimi nesneYonetimi = new NesneYonetimi();

        Kontroller kontroller = new Kontroller();

        VeriTabaniYonetimi veriTabaniYonetimi = new VeriTabaniYonetimi();

        RaspberryPi raspberryPi = new RaspberryPi();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            veriTabaniYonetimi.Temizle();
            raspberryPi.IsiklariKapat();

        }
        #region NesneEkle
        private void buton_basla_Click(object sender, EventArgs e)
        {
            this.Controls.Add(nesneYonetimi.EkleDiyagram(new Diyagramlar.Basla()));
        }

        private void buton_giris_Click(object sender, EventArgs e)
        {
            this.Controls.Add(nesneYonetimi.EkleDiyagram(new Diyagramlar.Giris()));
        }

        private void buton_islem_Click(object sender, EventArgs e)
        {
            this.Controls.Add(nesneYonetimi.EkleDiyagram(new Diyagramlar.Islem()));
        }

        private void buton_karar_Click(object sender, EventArgs e)
        {

            this.Controls.Add(nesneYonetimi.EkleDiyagram(new Diyagramlar.Karar()));

            KararGerecleri();


        }

        private void KararGerecleri()
        {
            Kontroller.sayac = 0;
            List<PictureBox> nesneler = nesneYonetimi.GetDiyagramlar();
            this.Controls.Add(nesneYonetimi.EkleDiyagram(new Diyagramlar.Baglanti { tip = "evet" }));

            Oklar.Oklar.nesne1 = nesneler[(nesneYonetimi.GetNesneNumarasi() - 2)];
            Oklar.Oklar.nesne2 = nesneler[(nesneYonetimi.GetNesneNumarasi() - 1)];

            this.Controls.Add(nesneYonetimi.OkEkle(new Oklar.Oklar()));

            this.Controls.Add(nesneYonetimi.EkleDiyagram(new Diyagramlar.Baglanti { tip = "hayir" }));

            Oklar.Oklar.nesne1 = nesneler[(nesneYonetimi.GetNesneNumarasi() - 3)];
            Oklar.Oklar.nesne2 = nesneler[(nesneYonetimi.GetNesneNumarasi() - 1)];

            this.Controls.Add(nesneYonetimi.OkEkle(new Oklar.Oklar()));
        }

        private void buton_dongu_Click(object sender, EventArgs e)
        {
            this.Controls.Add(nesneYonetimi.EkleDiyagram(new Diyagramlar.Dongu()));
        }

        private void buton_pencere_Click(object sender, EventArgs e)
        {
            this.Controls.Add(nesneYonetimi.EkleDiyagram(new Diyagramlar.Pencere()));
        }

        private void buton_bitir_Click(object sender, EventArgs e)
        {
            this.Controls.Add(nesneYonetimi.EkleDiyagram(new Diyagramlar.Bitir()));
        }

        private void buton_baglanti_Click(object sender, EventArgs e)
        {
            this.Controls.Add(nesneYonetimi.EkleDiyagram(new Diyagramlar.Baglanti()));
        }
        #endregion

        private void buton_sil_Click(object sender, EventArgs e)
        {
            if (kontroller.GetSil())
            {
                kontroller.SetSil(false);
                buton_sil.BackColor = Color.FromArgb(64, 64, 64);
            }
            else
            {
                kontroller.SetSil(true);
                buton_sil.BackColor = Color.Green;
            }
        }

        private void Guncelle_Tick(object sender, EventArgs e)
        {
            KoordinatGuncelle();
           
        }

        private void KoordinatGuncelle()
        {
            foreach (var diyagram in nesneYonetimi.GetDiyagramlar())
            {
                foreach (var ok in nesneYonetimi.GetOklar())
                {
                    if (ok.Name != null && diyagram.Name!=null)
                    {
                        int sub, sub2;
                        sub = ok.Name.IndexOf(" ");
                        sub2 = ok.Name.LastIndexOf(" ");
                        if (sub!=-1 && sub2!=-1 && ok.Name.Substring(0, sub) == diyagram.Name )
                        {
                            if (diyagram.Tag == "bagla")
                            {
                                ok.X1 = (diyagram.Location.X + 10);
                                ok.Y1 = (diyagram.Location.Y + 10);
                            }
                            else
                            {
                                ok.X1 = (diyagram.Location.X + 35);
                                ok.Y1 = (diyagram.Location.Y + 35);
                            }


                        }
                        if (sub != -1 && sub2 != -1 && ok.Name.Substring((sub2 + 1)) == diyagram.Name)
                        {
                            if (diyagram.Tag == "bagla")
                            {
                                ok.X2 = (diyagram.Location.X + 10);
                                ok.Y2 = (diyagram.Location.Y + 10);
                            }
                            else
                            {
                                ok.X2 = (diyagram.Location.X + 35);
                                ok.Y2 = (diyagram.Location.Y + 35);
                            }

                        }
                    }

                }
            }
        }



        private void buton_bagla_Click(object sender, EventArgs e)
        {
            if (Oklar.Oklar.nesne1 != null && Oklar.Oklar.nesne2 != null)
                this.Controls.Add(nesneYonetimi.OkEkle(new Oklar.Oklar()));
            else
                MessageBox.Show("Nesneleri bağlamak için en az 2 diyagram seçilmelidir !", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }


        List<string> akislar = new List<string>();
        List<string> okcul = new List<string>();
        private void button2_Click(object sender, EventArgs e)
        {
            if (BaslaDiyagramKontrol() == false)
            {
                MessageBox.Show("Başla diyagramınız eksik !", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (BitirDiyagramKontrol() == false)
            {
                MessageBox.Show("Bitir diyagramınız eksik !", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                try
                {
                    raspberryPi.SariLed();
                    DiyagramKontrolleri diyagramKontrolleri = new DiyagramKontrolleri();
                    Compiler cmp = new Compiler();
                    cmp.Baslat();
                }
                catch (StackOverFlowException stackOverFlowException)
                {

                }
                catch (BosVeriException bosVeriException)
                {

                }
               
            }

        }
        private bool BaslaDiyagramKontrol()
        {
            foreach (var diyagram in nesneYonetimi.GetDiyagramlar())
            {
                if (diyagram.Tag == "basla" && diyagram.Name != null)
                {
                    return true;
                }

            }
            return false;
        }
        private bool BitirDiyagramKontrol()
        {
            foreach (var diyagram in nesneYonetimi.GetDiyagramlar())
            {
                if (diyagram.Tag == "basla" && diyagram.Name != null)
                {
                    return true;
                }

            }
            return false;
        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            raspberryPi.IsiklariKapat();
            nesneYonetimi.Temizle();
            veriTabaniYonetimi.Temizle();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e) {
            if (e.Button == MouseButtons.Left) {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void button1_Click(object sender, EventArgs e) {
            Close();
        }

        private void button3_Click(object sender, EventArgs e) {
            if(maximized == true) {
                WindowState = FormWindowState.Normal;
                maximized = false;
            }
            else {
                WindowState = FormWindowState.Maximized;
                maximized = true;
            }
        }

        private void button4_Click(object sender, EventArgs e) {
            WindowState = FormWindowState.Minimized;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            RaspberryPi raspberryPi = new RaspberryPi();
            raspberryPi.IsiklariKapat();
            e.Cancel = false;
        }
    }
}
