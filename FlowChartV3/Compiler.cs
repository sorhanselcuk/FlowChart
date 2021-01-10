using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.PowerPacks;
using FlowChartV3.DiyagramVerileri;
using System.Xml.Linq;
using System.Diagnostics;
using System.Threading;
using FlowChartV3.Exceptions;

namespace FlowChartV3
{
    class Compiler
    {
        RaspberryPi raspberryPi = new RaspberryPi();
        VeriTabaniYonetimi veriTabaniYonetimi = new VeriTabaniYonetimi();
        private NesneYonetimi nesneYonetimi = new NesneYonetimi();
        List<PictureBox> diyagramlar = new List<PictureBox>();
        List<string> oklar = new List<string>();
        List<string> setKod = new List<string>();
        List<string> getKod = new List<string>();
        private List<string> gelenVeriler;

        private int baslangicNumarasi;
        private int bitisNumarasi;
        private int ilkMetod;

        public Compiler()
        {
            DosyaTemizle();
            veriTabaniYonetimi.Temizle("compiler");
            GetDiyagram();
            GetOKlar();
            BaslaBitirNumaralari();
            IlkMetod();
        }

        public void Baslat()
        {
            KodlariHazirla();
            KodlariYazdir();
            XmlYazdir();
            Derle();
            HandleException(() => { Calistir(); });


        }

        private void Calistir()
        {

            if (File.Exists("uygulama.exe"))
            {
                Process.Start("uygulama.exe");
                raspberryPi.YesilLed();
            }
            else
            {
                throw new CompilerException();
            }
        }
        private void HandleException(Action action)
        {
            try
            {
                action.Invoke();
            }
            catch (CompilerException compilerException)
            {
                MessageBox.Show("DERLEME HATASI !");
            }
        }

        private void KodlariHazirla()
        {
            foreach (var diyagram in diyagramlar)
            {
                this.bitisNumarasi = Convert.ToInt16(diyagram.Name);
                Yazdir(TagAl(bitisNumarasi.ToString()));
            }
            foreach (var ok in oklar)
            {
                int sub, sub2;
                sub = ok.IndexOf(" ");
                sub2 = ok.LastIndexOf(" ");
                veriTabaniYonetimi.veriTabani = new DiyagramVerileri.Compiler
                {
                    eskiMetod = "$" + ok.Substring(0, sub),
                    metod = "a" + ok.Substring((sub2 + 1)) + "();",
                };
                veriTabaniYonetimi.Guncelle();
            }
        }
        private string TagAl(string nesneNumarasi)
        {
            foreach (var diyagram in diyagramlar)
            {
                if (diyagram.Name == nesneNumarasi)
                {
                    return diyagram.Tag.ToString();
                }
            }
            return null;
        }
        private void Yazdir(string tipi)
        {
            switch (tipi)
            {
                case "giris":
                    YazdirGiris();
                    break;
                case "islem":
                    YazdirIslem();
                    break;
                case "karar":
                    YazdirKarar();
                    break;
                case "pencere":
                    YazdirPencere();
                    break;
                case "bitir":
                    YazdirBitir();
                    break;
                case "bagla":
                    YazdirBagla();
                    break;

            }
        }
        private void KodlariYazdir()
        {
            veriTabaniYonetimi.veriTabani = new DiyagramVerileri.Compiler();
            getKod = veriTabaniYonetimi.Al();
            StreamWriter streamWriter = File.AppendText("uygulama.cs");
            streamWriter.WriteLine("using System;");
            streamWriter.WriteLine("using System.Collections.Generic;");
            streamWriter.WriteLine("using System.Text;");
            
            streamWriter.WriteLine("namespace EnginFurkanSuayipYakup");
            streamWriter.WriteLine("{");
            streamWriter.WriteLine("class FlowChart");
            streamWriter.WriteLine("{");
            streamWriter.WriteLine("static void Main(string[] args)");
            streamWriter.WriteLine("{");
           
            streamWriter.WriteLine("a" + this.ilkMetod.ToString() + "();");
            
            streamWriter.WriteLine("}");
            
            foreach (var kodlar in getKod)
            {
                streamWriter.WriteLine(kodlar);
            }
            streamWriter.WriteLine("}");
            streamWriter.WriteLine("}");

            streamWriter.Close();
            streamWriter.Dispose();
        }
        #region YazdirKomutlari
        private void YazdirBagla()
        {
            setKod.Add("public static void a" + this.bitisNumarasi.ToString() + "()");
            setKod.Add("{");
            setKod.Add("$" + this.bitisNumarasi.ToString());
            setKod.Add("return;");
            setKod.Add("}");
            foreach (var item in setKod)
            {
                veriTabaniYonetimi.veriTabani = new DiyagramVerileri.Compiler
                {
                    kod = item
                };
                veriTabaniYonetimi.Ekle();
            }
            setKod.Clear();
        }
        private void YazdirGiris()
        {
            veriTabaniYonetimi.veriTabani = new Giris
            {
                nesneNumarasi = this.bitisNumarasi.ToString()
            };
            gelenVeriler = veriTabaniYonetimi.Al();
            setKod.Add("public static void a" + this.bitisNumarasi.ToString() + "()");
            setKod.Add("{");
            setKod.Add("Console.WriteLine(\"" + gelenVeriler[1] + "\");");
            string degiskenAdi = gelenVeriler[0];
            if (gelenVeriler[0] != "null")
            {

                veriTabaniYonetimi.veriTabani = new Degiskenler
                {
                    compilerDegisken = gelenVeriler[0].ToString(),
                    compilerDurum = true
                };
                gelenVeriler.Clear();
                gelenVeriler = veriTabaniYonetimi.Al();
                if (gelenVeriler[0].ToString() == "int")
                    setKod.Add(degiskenAdi + "=Convert.ToInt16(Console.ReadLine());");
                else if (gelenVeriler[0].ToString() == "double")
                    setKod.Add(degiskenAdi + "=Convert.ToDouble(Console.ReadLine());");
            }
            setKod.Add("$" + this.bitisNumarasi.ToString());
            setKod.Add("return;");
            setKod.Add("}");
            foreach (var item in setKod)
            {
                veriTabaniYonetimi.veriTabani = new DiyagramVerileri.Compiler
                {
                    kod = item
                };
                veriTabaniYonetimi.Ekle();
            }
            setKod.Clear();
        }
        private void YazdirIslem()
        {

            veriTabaniYonetimi.veriTabani = new Islem
            {
                nesneNumarasi = this.bitisNumarasi.ToString()
            };
            gelenVeriler = veriTabaniYonetimi.Al();
            setKod.Add("public static void a" + this.bitisNumarasi.ToString() + "()");
            setKod.Add("{");
            if (gelenVeriler.Count != 0)
            {
                setKod.Add(gelenVeriler[4] + "=" + gelenVeriler[1] + " " + gelenVeriler[2] + " " + gelenVeriler[3] + ";");
                setKod.Add("$" + this.bitisNumarasi.ToString());
                setKod.Add("return;");
                setKod.Add("}");
            }
            else
            {
                setKod.Add("$" + this.bitisNumarasi.ToString());
                setKod.Add("return;");
                setKod.Add("}");
                veriTabaniYonetimi.veriTabani = new Degiskenler
                {
                    nesneNumarasi = this.bitisNumarasi.ToString()
                };
                gelenVeriler = veriTabaniYonetimi.Al();
                setKod.Add("static " + gelenVeriler[2] + " " + gelenVeriler[1] + " = " + gelenVeriler[3] + ";");
            }


            foreach (var item in setKod)
            {
                veriTabaniYonetimi.veriTabani = new DiyagramVerileri.Compiler
                {
                    kod = item
                };
                veriTabaniYonetimi.Ekle();
            }
            setKod.Clear();
        }
        private void YazdirKarar()
        {
            veriTabaniYonetimi.veriTabani = new Karar
            {
                nesneNumarasi = this.bitisNumarasi.ToString()
            };
            gelenVeriler = veriTabaniYonetimi.Al();
            setKod.Add("public static void a" + this.bitisNumarasi.ToString() + "()");
            setKod.Add("{");
            setKod.Add("if(" + gelenVeriler[0] + " " + gelenVeriler[1] + " " + gelenVeriler[2] + ")");
            setKod.Add("{");
            setKod.Add("a" + (this.bitisNumarasi + 1).ToString() + "();");
            setKod.Add("return;");
            setKod.Add("}");
            setKod.Add("else");
            setKod.Add("{");
            setKod.Add("a" + (this.bitisNumarasi + 2).ToString() + "();");
            setKod.Add("return;");
            setKod.Add("}");
            setKod.Add("}");
            foreach (var item in setKod)
            {
                veriTabaniYonetimi.veriTabani = new DiyagramVerileri.Compiler
                {
                    kod = item
                };
                veriTabaniYonetimi.Ekle();
            }
            setKod.Clear();
        }
        private void YazdirPencere()
        {
            veriTabaniYonetimi.veriTabani = new Pencere
            {
                nesneNumarasi = this.bitisNumarasi.ToString()
            };
            gelenVeriler = veriTabaniYonetimi.Al();
            setKod.Add("public static void a" + this.bitisNumarasi.ToString() + "()");
            setKod.Add("{");
            if (gelenVeriler[0] != "null")
            {
                setKod.Add("Console.WriteLine(\"" + gelenVeriler[1] + "{0} \"," + gelenVeriler[0] + ");");
            }
            else
            {
                setKod.Add("Console.WriteLine(\"" + gelenVeriler[1] + "\");");
            }
            setKod.Add("$" + this.bitisNumarasi.ToString());
            setKod.Add("return;");
            setKod.Add("}");
            foreach (var item in setKod)
            {
                veriTabaniYonetimi.veriTabani = new DiyagramVerileri.Compiler
                {
                    kod = item
                };
                veriTabaniYonetimi.Ekle();
            }
            setKod.Clear();
        }
        private void YazdirBitir()
        {
            setKod.Add("public static void a" + this.bitisNumarasi.ToString() + "()");
            setKod.Add("{");
            setKod.Add("Console.ReadKey(true);");
            setKod.Add("}");
            foreach (var item in setKod)
            {
                veriTabaniYonetimi.veriTabani = new DiyagramVerileri.Compiler
                {
                    kod = item
                };
                veriTabaniYonetimi.Ekle();
            }
            setKod.Clear();
        }
        #endregion
        private void GetDiyagram()
        {
            foreach (var diyagram in nesneYonetimi.GetDiyagramlar())
            {
                if (!string.IsNullOrEmpty(diyagram.Name))
                {
                    diyagramlar.Add(diyagram);
                }
            }
        }
        private void GetOKlar()
        {
            foreach (var ok in nesneYonetimi.GetOklar())
            {
                if (!string.IsNullOrEmpty(ok.Name))
                {
                    oklar.Add(ok.Name);
                }
            }
        }
        private void XmlYazdir()
        {
            string[] veri = File.ReadAllLines("uygulama.cs");
            XElement root = new XElement("root",
                from item in veri select new XElement("Line", item));
            root.Save("uygulama.Xml");
        }

        private void Derle()
        {
            DirectoryInfo info = new DirectoryInfo(Directory.GetCurrentDirectory());

            //raspberryPi.SariLed();
            using (Process derle = Process.Start("cmd.exe", "/c cd C:\\Windows\\Microsoft.Net\\Framework\\v4.0.30319 & csc /out:\"" + info + "\\uygulama.exe\" \"" + info + "\\uygulama.cs\""))
            {
                do
                {
                    if (!derle.HasExited)
                    {
                        // Refresh the current process property values.
                        derle.Refresh();

                    }
                }
                while (!derle.WaitForExit(1000));
            }

        }


        private void BaslaBitirNumaralari()
        {
            foreach (var diyagram in diyagramlar)
            {
                if (diyagram.Tag.Equals("basla"))
                {
                    this.baslangicNumarasi = Convert.ToInt16(diyagram.Name);
                }

                if (diyagram.Tag.Equals("bitir"))
                {
                    this.bitisNumarasi = Convert.ToInt16(diyagram.Name);
                }
            }
        }

        private void IlkMetod()
        {
            foreach (var ok in oklar)
            {

                int sub1, sub2;
                sub1 = ok.IndexOf(" ");
                sub2 = ok.LastIndexOf(" ");
                if (ok.Substring(0, sub1).Equals(baslangicNumarasi.ToString()))
                {
                    ilkMetod = Convert.ToInt16(ok.Substring(sub2 + 1));
                }
            }
        }

        private void DosyaTemizle()
        {
            var dosya = new List<string>(File.ReadAllLines("uygulama.cs"));
            dosya.Clear();
            File.WriteAllLines("uygulama.cs", dosya.ToArray());
            using (Process derle = Process.Start("cmd.exe", "/c del uygulama.exe"))
            {
                do
                {
                    if (!derle.HasExited)
                    {
                        // Refresh the current process property values.
                        derle.Refresh();

                    }
                }
                while (!derle.WaitForExit(1000));
            }
        }
    }
}
