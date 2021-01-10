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
    class Giris : IVeriTabani
    {
        public string nesneNumarasi { get; set; }
        public string degisken { get; set; }
        public string mesaj { get; set; }

        private List<string> giris = new List<string>();

        OleDbConnection baglanti = new OleDbConnection(ConfigurationManager.ConnectionStrings["Baglanti"].ConnectionString);

        public void Ekle()
        {
            baglanti.Open();
            OleDbCommand ekle = new OleDbCommand();
            ekle.CommandText = "insert into giris (nesneNumarasi,degisken,mesaj) values('" + nesneNumarasi + "','" + degisken + "','" + mesaj + "')";
            ekle.Connection = baglanti;
            ekle.ExecuteNonQuery();
            baglanti.Close();
        }

        public void Guncelle()
        {
            baglanti.Open();
            OleDbCommand guncelle = new OleDbCommand();
            OleDbCommand guncelle2 = new OleDbCommand();
            guncelle.CommandText = "update giris set degisken='" + degisken + "', mesaj='" + mesaj + "' where nesneNumarasi='" + nesneNumarasi+"'";
            guncelle.Connection = baglanti;
            guncelle.ExecuteNonQuery();
            baglanti.Close();
        }

        public void Sil()
        {
            baglanti.Open();
            OleDbCommand sil = new OleDbCommand();
            sil.CommandText = "delete * from giris where nesneNumarasi='" + nesneNumarasi + "'";
            sil.Connection = baglanti;
            sil.ExecuteNonQuery();
            baglanti.Close();
        }

        public List<string> Al()
        {
            baglanti.Open();
            OleDbCommand al = new OleDbCommand();
            al.CommandText = "select * from giris where nesneNumarasi='" + nesneNumarasi + "'";
            al.Connection = baglanti;
            OleDbDataReader oku = al.ExecuteReader();
            while (oku.Read())
            {
                giris.Add(oku[1].ToString());
                giris.Add(oku[2].ToString());
            }
            baglanti.Close();
            return giris;
        }
    }
}
