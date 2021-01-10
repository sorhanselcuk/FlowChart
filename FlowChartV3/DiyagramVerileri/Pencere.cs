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
    class Pencere : IVeriTabani
    {
        public string nesneNumarasi { get; set; }
        public string degisken { get; set; }
        public string mesaj { get; set; }

        OleDbConnection baglanti = new OleDbConnection(ConfigurationManager.ConnectionStrings["Baglanti"].ConnectionString);

        private List<string> pencere = new List<string>();
        
        public void Ekle()
        {
            if (degisken == null)
            {
                degisken = "null";
            }
            baglanti.Open();
            OleDbCommand ekle = new OleDbCommand();
            ekle.CommandText = "insert into pencere (nesneNumarasi,degisken,mesaj) values('" + nesneNumarasi + "','" + degisken + "','" + mesaj + "')";
            ekle.Connection = baglanti;
            ekle.ExecuteNonQuery();
            baglanti.Close();
        }

        public void Guncelle()
        {
            baglanti.Open();
            OleDbCommand guncelle = new OleDbCommand();
            guncelle.CommandText = "update pencere set degisken='" + degisken + "', mesaj='" + mesaj + "' where nesneNumarasi='" + nesneNumarasi + "'";
            guncelle.Connection = baglanti;
            guncelle.ExecuteNonQuery();
            baglanti.Close();
        }

        public void Sil()
        {
            baglanti.Open();
            OleDbCommand sil = new OleDbCommand();
            sil.CommandText = "delete * from pencere where nesneNumarasi='" + nesneNumarasi + "'";
            sil.Connection = baglanti;
            sil.ExecuteNonQuery();
            baglanti.Close();
        }

        public List<string> Al()
        {
            baglanti.Open();
            OleDbCommand al = new OleDbCommand();
            al.CommandText = "select * from pencere where nesneNumarasi='" + nesneNumarasi + "'";
            al.Connection = baglanti;
            OleDbDataReader oku = al.ExecuteReader();
            while (oku.Read())
            {
                pencere.Add(oku[1].ToString());
                pencere.Add(oku[2].ToString());
            }
            baglanti.Close();
            return pencere;
        }
    }
}
