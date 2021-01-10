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
    class Karar : IVeriTabani
    {
        public string nesneNumarasi { get; set; }
        public string degisken1 { get; set; }
        public string degisken2 { get; set; }
        public string kosul { get; set; }

        private List<string> karar = new List<string>();

        OleDbConnection baglanti = new OleDbConnection(ConfigurationManager.ConnectionStrings["Baglanti"].ConnectionString);
       
        public void Ekle()
        {
            baglanti.Open();
            OleDbCommand ekle = new OleDbCommand();
            ekle.CommandText = "insert into karar (nesneNumarasi,degisken1,kosul,degisken2) values('" + nesneNumarasi + "','" + degisken1 + "','" + kosul + "','" + degisken2 + "')";
            ekle.Connection = baglanti;
            ekle.ExecuteNonQuery();
            baglanti.Close();
        }

        public void Guncelle()
        {
            baglanti.Open();
            OleDbCommand guncelle = new OleDbCommand();
            guncelle.CommandText = "update karar set degisken1='" + degisken1 + "', degisken2='" + degisken2 + "', kosul='" + kosul + "' where nesneNumarasi='" + nesneNumarasi + "'";
            guncelle.Connection = baglanti;
            guncelle.ExecuteNonQuery();
            baglanti.Close();
        }

        public void Sil()
        {
            baglanti.Open();
            OleDbCommand sil = new OleDbCommand();
            sil.CommandText = "delete * from karar where nesneNumarasi='" + nesneNumarasi + "'";
            sil.Connection = baglanti;
            sil.ExecuteNonQuery();
            baglanti.Close();
        }

        public List<string> Al()
        {
            baglanti.Open();
            OleDbCommand al = new OleDbCommand();
            al.CommandText = "select * from karar where nesneNumarasi='" + nesneNumarasi + "'";
            al.Connection = baglanti;
            OleDbDataReader oku = al.ExecuteReader();
            while (oku.Read())
            {
                karar.Add(oku[1].ToString());
                karar.Add(oku[2].ToString());
                karar.Add(oku[3].ToString());
            }
            baglanti.Close();
            return karar;
        }
    }
}
