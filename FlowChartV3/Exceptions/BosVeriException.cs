using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlowChartV3.Exceptions
{
    class BosVeriException:Exception
    {
        public BosVeriException()
        {
            MessageBox.Show("Boş veriler mevcut");
        }
    }
}
