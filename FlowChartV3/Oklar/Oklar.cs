using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.PowerPacks;
using System.Windows.Forms;
using FlowChartV3.Exceptions;

namespace FlowChartV3.Oklar
{
    class Oklar : IOklar
    {
        public static PictureBox nesne1;
        public static PictureBox nesne2;
        Kontroller kontroller = new Kontroller();
        private NesneYonetimi nesneYonetimi = new NesneYonetimi();
        public LineShape Ekle()
        {
            LineShape ok = new LineShape();
          

            
            if (HandleException(() => { BaglantiKontrol(); }))
            {
                try
                {
                    if (nesne1.Name != nesne2.Name)
                    {
                        if (kontroller.getSayac() % 2 == 0)
                            ok.Name = nesne1.Name + " to " + nesne2.Name;
                        else
                            ok.Name = nesne2.Name + " to " + nesne1.Name;

                        ok.X1 = nesne1.Location.X;
                        ok.Y1 = nesne1.Location.Y;
                        ok.X2 = nesne2.Location.X;
                        ok.Y2 = nesne2.Location.Y;
                        ok.MouseDoubleClick += kontroller.OkDoubleClick;
                        kontroller.oklar = ok;
                        nesne1 = null;
                        nesne2 = null;
                    }

                }
                catch (Exception)
                {

                    nesne1 = null;
                    nesne2 = null;
                }


            }

            return ok;
        }

        private bool HandleException(Action action)
        {
            try
            {
                action.Invoke();
            }
            catch (OkBaglantiException okBaglantiException)
            {
                MessageBox.Show(okBaglantiException.Message);
                return false;
            }

            return true;
        }

        private void BaglantiKontrol()
        {
            string baglantiYolu = nesne2.Name + " to " + nesne1.Name;
            string baglantiYolu2 = nesne1.Name + " to " + nesne2.Name;
            foreach (var gelenOk in nesneYonetimi.GetOklar())
            {
                if (baglantiYolu.Equals(gelenOk.Name))
                {
                    throw new OkBaglantiException();
                }
                else if (baglantiYolu2.Equals(gelenOk.Name))
                {
                    throw new OkBaglantiException();
                }
            }
        }
    }
}
