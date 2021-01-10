using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlowChartV3.DiyagramVerileri;

namespace FlowChartV3
{
    class VeriTabaniYonetimi
    {
        DiyagramVerileri.Sil sil = new Sil();

        public IVeriTabani veriTabani { get; set; }

        private string[] temizle = new string[] 
        { 
        "degiskenler",
        "islem",
        "pencere",
        "giris",
        "karar",
        "compiler"
        };

        public void Ekle()
        {
            veriTabani.Ekle();
        }
        public void Guncelle()
        {
            veriTabani.Guncelle();
        }
        public void Sil()
        {
            veriTabani.Sil();
        }
        public List<string> Al()
        {
            return veriTabani.Al();
        }
        public void Temizle()
        {
            foreach (var item in temizle)
            {
                sil.tabloAdi = item;
                sil.Temizle();
            }
        }
        public void Temizle(string tabloAdi)
        {
            sil.tabloAdi = tabloAdi;
            sil.Temizle();
        }
      
    }
}
