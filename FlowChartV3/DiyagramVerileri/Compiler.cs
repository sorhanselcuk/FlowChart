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
    class Compiler:IVeriTabani
    {
        public string kod { get; set; }

        public string metod { get; set; }

        public string eskiMetod { get; set; }
        
        OleDbConnection baglanti = new OleDbConnection(ConfigurationManager.ConnectionStrings["Baglanti"].ConnectionString);

        private List<string> kodlar = new List<string>();

        public void Ekle()
        {
            baglanti.Open();
            OleDbCommand ekle = new OleDbCommand();
            ekle.CommandText = "insert into compiler (kodlar) values('"+kod+"')";
            ekle.Connection = baglanti;
            ekle.ExecuteNonQuery();
            baglanti.Close();   
        }

        public void Guncelle()
        {
            baglanti.Open();
            OleDbCommand guncelle = new OleDbCommand();
            guncelle.CommandText = "update compiler set kodlar='" + metod + "' where kodlar='" + eskiMetod + "'";
            guncelle.Connection = baglanti;
            guncelle.ExecuteNonQuery();
            baglanti.Close();
        }

        public void Sil()
        {
            throw new NotImplementedException();
        }

        public List<string> Al()
        {
            baglanti.Open();
            OleDbCommand al = new OleDbCommand();
            al.CommandText = "select kodlar from compiler";
            al.Connection = baglanti;
            OleDbDataReader oku = al.ExecuteReader();
            while (oku.Read())
            {
                kodlar.Add(oku[0].ToString());
            }
            baglanti.Close();
            return kodlar;
        }
    }
}
