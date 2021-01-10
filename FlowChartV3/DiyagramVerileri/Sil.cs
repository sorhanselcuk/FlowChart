using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
using System.Configuration;

namespace FlowChartV3.DiyagramVerileri
{
    class Sil
    {
        public string tabloAdi { get; set; }
        
        OleDbConnection baglanti = new OleDbConnection(ConfigurationManager.ConnectionStrings["Baglanti"].ConnectionString);

        public void Temizle()
        {
            baglanti.Open();
            OleDbCommand silTablo = new OleDbCommand();
            silTablo.CommandText = "delete * from "+tabloAdi+"";
            silTablo.Connection = baglanti;
            silTablo.ExecuteReader();
            baglanti.Close();
        }
    }
}
