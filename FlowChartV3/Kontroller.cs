using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using Microsoft.VisualBasic.PowerPacks;

namespace FlowChartV3
{
    class Kontroller
    {
        private bool hareket = false;
        private Point ilkKonum;
        public PictureBox diyagram { get; set; }
        public LineShape oklar { get; set; }
        private static bool sil = false;
        public static int sayac=0;
        NesneYonetimi nesneYonetimi = new NesneYonetimi();
        FormYonetimi formYonetimi = new FormYonetimi();

        #region NesneHareketleri
        public void MouseDown(object sender, MouseEventArgs e)
        {
            hareket = true;
            ilkKonum = e.Location;
        }
        public void MouseUp(object sender, MouseEventArgs e)
        {
            hareket = false;
        }
        public void MouseMove(object sender, MouseEventArgs e)
        {
            if (hareket)
            {
                diyagram.Left = e.X + diyagram.Left - (ilkKonum.X);
                diyagram.Top = e.Y + diyagram.Top - (ilkKonum.Y);
            }
        }
        #endregion


        public void MouseClick(object sender, MouseEventArgs e)
        {

            if (sayac % 2 == 0)
            {
                Oklar.Oklar.nesne1 = diyagram;
                sayac++;
            }
            else
            {
                Oklar.Oklar.nesne2 = diyagram;
                sayac++;
            }
        }
       
        private void FormAc()
        {
            switch (diyagram.Tag.ToString())
            {
                case "giris":
                    formYonetimi.Ac(new DiyagramFormlari.Giris(), this.diyagram.Name.ToString());
                    break;
                case "islem":
                    formYonetimi.Ac(new DiyagramFormlari.Islem(), this.diyagram.Name.ToString());
                    break;
                case "karar":
                    formYonetimi.Ac(new DiyagramFormlari.Karar(), this.diyagram.Name.ToString());
                    break;
                case "pencere":
                    formYonetimi.Ac(new DiyagramFormlari.Pencere(), this.diyagram.Name.ToString());
                    break;
                default:
                    break;
            }
        }

        #region Sil
        public void MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (sil)
            {
                nesneYonetimi.SilDiyagram(Convert.ToInt32(diyagram.Name));
            }
            else
            {
                FormAc();
            }
        }
        public void OkDoubleClick(object sender, MouseEventArgs e)
        {
           
            if (sil == true)
            {
                nesneYonetimi.SilOk(Convert.ToInt16(oklar.Tag));
            }

        }
        #endregion

        #region GetVeSet
        public void SetSil(bool durum)
        {
            sil = durum;
        }
        public bool GetSil()
        {
            return sil;
        }
        public int getSayac()
        {
            return sayac;
        }
        #endregion

    }
}
