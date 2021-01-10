using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.PowerPacks;

namespace FlowChartV3
{
    class NesneYonetimi
    {
        VeriTabaniYonetimi veriTabaniYonetimi = new VeriTabaniYonetimi();

        private static List<PictureBox> nesneler = new List<PictureBox>();

        private static List<ShapeContainer> oklar = new List<ShapeContainer>();

        private static List<LineShape> okSekil = new List<LineShape>();

        static private int nesneNumarasi = 0;

        static private int okNumarasi = 0;

        public INesneler nesne { get; set; }

        public IOklar ok { get; set; }

        public int GetNesneNumarasi()
        {
            return nesneNumarasi;
        }

        #region Diyagramİslemleri
        public PictureBox EkleDiyagram(INesneler nesne)
        {
            this.nesne = nesne;
            nesneler.Add(new PictureBox());
            nesneler[nesneNumarasi] = nesne.Ekle();
            nesneler[nesneNumarasi].Name = nesneNumarasi.ToString();
            nesneNumarasi++;
            return nesneler[(nesneNumarasi - 1)];
        }

        public void SilDiyagram(int nesneIndex)
        {
            nesneler[nesneIndex].Dispose();
            if (nesneler[nesneIndex].Tag == "karar")
            {
                nesneler[(nesneIndex + 1)].Dispose();
                nesneler[(nesneIndex + 2)].Dispose();
                nesneler[(nesneIndex + 1)].Name = null;
                nesneler[(nesneIndex + 2)].Name = null;
                foreach (var ok in okSekil)
                {
                    if (nesneIndex.ToString() + " to " + (nesneIndex + 1).ToString() == ok.Name)
                    {
                        SilOk(Convert.ToInt16(ok.Tag));
                    }
                    else if (nesneIndex.ToString() + " to " + (nesneIndex + 2).ToString() == ok.Name)
                    {
                        SilOk(Convert.ToInt16(ok.Tag));
                    }
                }
            }
            nesneler[nesneIndex].Name = null;
            DiyagramVeriSil(nesneIndex);
           
        }

        private void DiyagramVeriSil(int nesneIndex)
        {
            switch (nesneler[nesneIndex].Tag.ToString())
            {
                case "giris":
                    veriTabaniYonetimi.veriTabani = new DiyagramVerileri.Giris
                    {
                        nesneNumarasi = nesneIndex.ToString()
                    };
                    veriTabaniYonetimi.Sil();
                    veriTabaniYonetimi.veriTabani = new DiyagramVerileri.Pencere
                    {
                        nesneNumarasi=nesneIndex.ToString()
                    };
                    veriTabaniYonetimi.Sil();
                    break;
                case "karar":
                    veriTabaniYonetimi.veriTabani = new DiyagramVerileri.Karar
                    {
                        nesneNumarasi = nesneIndex.ToString()
                    };
                    veriTabaniYonetimi.Sil();
                    break;

                case "pencere":
                    veriTabaniYonetimi.veriTabani = new DiyagramVerileri.Pencere
                    {
                        nesneNumarasi = nesneIndex.ToString()
                    };
                    veriTabaniYonetimi.Sil();
                    break;
                case "islem":
                    veriTabaniYonetimi.veriTabani = new DiyagramVerileri.Islem
                    {
                        nesneNumarasi = nesneIndex.ToString()
                    };
                    veriTabaniYonetimi.Sil();
                    veriTabaniYonetimi.veriTabani = new DiyagramVerileri.Degiskenler
                    {
                        nesneNumarasi = nesneIndex.ToString()
                    };
                    veriTabaniYonetimi.Sil();
                    break;
            }
        }

        public List<PictureBox> GetDiyagramlar()
        {
            return nesneler;
        } 
        #endregion

        #region Okİslemleri

        public ShapeContainer OkEkle(IOklar ok)
        {
            this.ok = ok;
            oklar.Add(new ShapeContainer());
            okSekil.Add(ok.Ekle());
            okSekil[okNumarasi].Tag = okNumarasi.ToString();
            oklar[okNumarasi].Shapes.AddRange(new Shape[]{okSekil[okNumarasi]});
            oklar[okNumarasi].Tag = okNumarasi.ToString();
            okNumarasi++;
            return oklar[(okNumarasi - 1)];
        }
        public void SilOk(int okIndex)
        {
            okSekil[okIndex].Dispose();
            okSekil[okIndex].Name = null;
            okSekil[okIndex].Tag = null;

        }
        public List<LineShape> GetOklar()
        {
            return okSekil;
        }
        #endregion

        public void Temizle()
        {
            foreach (var item in nesneler)
            {
                item.Dispose();
            }
            foreach (var item in oklar)
            {
                item.Dispose();
            }
            foreach (var item in okSekil)
            {
                item.Dispose();
            }
            nesneler.Clear();
            oklar.Clear();
            okSekil.Clear();
            Oklar.Oklar.nesne1 = null;
            Oklar.Oklar.nesne2 = null;
            nesneNumarasi = 0;
            okNumarasi = 0;
            Kontroller.sayac = 0;
        }
       



    }
}
