using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlowChartV3.Exceptions
{
    class CompilerException:Exception
    {
        RaspberryPi raspberryPi = new RaspberryPi();
        public CompilerException()
        {
            MessageBox.Show("Diyagramlarınızda boşluklar var");
            raspberryPi.KirmiziLed();
        }
    }
}
