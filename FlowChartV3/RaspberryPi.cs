using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Renci.SshNet;

namespace FlowChartV3
{
    public class RaspberryPi
    {
        private SshClient sshClient;
        public RaspberryPi()
        {
           
                sshClient = new SshClient("raspberrypi", "pi", "flowchart");
                sshClient.Connect();
          
        }

        private void Calistir()
        {
            sshClient.RunCommand("python /home/pi/Desktop/raspberrypi.py");
          
        }
        public void SariLed()
        {
           
            sshClient.RunCommand("echo \"sari$\" > /home/pi/Desktop/durum.txt");
            Calistir();
          
        }

        public void KirmiziLed()
        {
            
            sshClient.RunCommand("echo \"kirmizi$\" > /home/pi/Desktop/durum.txt");
            Calistir();
           
        }

        public void YesilLed()
        {
            
            sshClient.RunCommand("echo \"yesil$\" > /home/pi/Desktop/durum.txt");
            Calistir();
           
        }

        public void IsiklariKapat()
        {
            sshClient.RunCommand("python /home/pi/Desktop/deneme.py");
        }
    }
}
