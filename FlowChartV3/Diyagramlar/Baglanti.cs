using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace FlowChartV3.Diyagramlar
{
    class Baglanti:INesneler
    {
        public string tip { get; set; }
        Kontroller kontroller = new Kontroller();

        public System.Windows.Forms.PictureBox Ekle()
        {
            PictureBox diyagram = new PictureBox();
            diyagram.Width = 20;
            diyagram.Height = 20;
           
            diyagram.MouseDown += kontroller.MouseDown;
            diyagram.MouseMove += kontroller.MouseMove;
            diyagram.MouseUp += kontroller.MouseUp;
            diyagram.MouseClick += kontroller.MouseClick;
            diyagram.Tag = "bagla";
            if (tip == "evet")
            {
                diyagram.Image = Image.FromFile("..\\..\\Resimler\\Diyagramlar\\yuvarlakEvet.png");
                
                diyagram.Location = new Point(350, 250);
            }
            else if (tip == "hayir")
            {
                diyagram.Image = Image.FromFile("..\\..\\Resimler\\Diyagramlar\\yuvarlakHayir.png");
                
                diyagram.Location = new Point(250, 350);
            }
            else
            {
                
                diyagram.Image = Image.FromFile("..\\..\\Resimler\\Diyagramlar\\yuvarlak.png");
                
                diyagram.MouseDoubleClick += kontroller.MouseDoubleClick;
                diyagram.Location = new Point(250, 250);
            }
            kontroller.diyagram = diyagram;
            return diyagram;
        }
    }
}
