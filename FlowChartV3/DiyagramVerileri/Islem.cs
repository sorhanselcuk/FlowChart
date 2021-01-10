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
    class Islem:IVeriTabani
    {
        public string nesneNumarasi { get; set; }
        public string degisken1 { get; set; }
        public string isaret { get; set; }
        public string degisken2 { get; set; }
        public string degiskenSonuc { get; set; }

        private List<string> islem = new List<string>();

        OleDbConnection baglanti = new OleDbConnection(ConfigurationManager.ConnectionStrings["Baglanti"].ConnectionString);
       
        public void Ekle()
        {
            baglanti.Open();
            OleDbCommand ekle = new OleDbCommand();
            ekle.CommandText = "insert into islem (nesneNumarasi,degisken1,isaret,degisken2,degiskenSonuc) values('"+nesneNumarasi+"','"+degisken1+"','"+isaret+"','"+degisken2+"','"+degiskenSonuc+"')";
            ekle.Connection = baglanti;
            ekle.ExecuteNonQuery();
            baglanti.Close();
        }

        public void Guncelle()
        {
            baglanti.Open();
            OleDbCommand guncelle = new OleDbCommand();
            guncelle.CommandText = "update islem set degisken1='"+degisken1+"', degisken2='"+degisken2+"', isaret='"+isaret+"', degiskenSonuc='"+degiskenSonuc+"' where nesneNumarasi='"+nesneNumarasi+"'";
            guncelle.Connection = baglanti;
            guncelle.ExecuteNonQuery();
            baglanti.Close();
        }

        public void Sil()
        {
            baglanti.Open();
            OleDbCommand sil = new OleDbCommand();
            sil.CommandText = "delete * from islem where nesneNumarasi='"+nesneNumarasi+"'";
            sil.Connection = baglanti;
            sil.ExecuteNonQuery();
            baglanti.Close();
        }

        public List<string> Al()
        {
            baglanti.Open();
            OleDbCommand al = new OleDbCommand();
            al.CommandText = "select * from islem where nesneNumarasi='"+nesneNumarasi+"'";
            al.Connection = baglanti;
            OleDbDataReader oku = al.ExecuteReader();
            while (oku.Read())
            {
                islem.Add(oku[0].ToString());
                islem.Add(oku[1].ToString());
                islem.Add(oku[2].ToString());
                islem.Add(oku[3].ToString());
                islem.Add(oku[4].ToString());
            }
            baglanti.Close();
            return islem;
        }
    }
}
