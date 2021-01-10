using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlowChartV3
{
    class FormYonetimi
    {
        public IFormlar formlar { get; set; }
        public string nesneNumarasi { get; set; }
        
        public void Ac(IFormlar form,string nesneNumarasi)
        {
            this.nesneNumarasi = nesneNumarasi;
            this.formlar = form;
            formlar.Ac(this.nesneNumarasi);
        }
    }
}
