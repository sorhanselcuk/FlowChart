using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlowChartV3.Exceptions
{
    class StackOverFlowException:Exception
    {
        RaspberryPi raspberryPi = new RaspberryPi();
        public StackOverFlowException()
        {
            raspberryPi.KirmiziLed();
            MessageBox.Show("Algoritmanızda aşırı yükleme mevcut");
        }
    }
}
