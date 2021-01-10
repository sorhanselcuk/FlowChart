using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using System.Configuration;

namespace FlowChartV3.DiyagramVerileri
{
    class Degiskenler : IVeriTabani
    {
        public string nesneNumarasi { get; set; }
        public string nesneAdi { get; set; }
        public string nesneTipi { get; set; }
        public string nesneDegeri { get; set; }

        public bool compilerDurum { get; set; }
        public string compilerDegisken { get; set; }

        OleDbConnection baglanti = new OleDbConnection(ConfigurationManager.ConnectionStrings["Baglanti"].ConnectionString);

        private List<String> degiskenler = new List<string>();

        public void Ekle()
        {
            baglanti.Open();
            OleDbCommand ekle = new OleDbCommand();
            ekle.CommandText = "insert into degiskenler (nesneNumarasi,nesneAdi,nesneTipi,nesneDegeri) values('" + nesneNumarasi + "','" + nesneAdi + "','" + nesneTipi + "','" + nesneDegeri + "')";
            ekle.Connection = baglanti;
            ekle.ExecuteNonQuery();
            baglanti.Close();
        }
        public void Guncelle()
        {
            baglanti.Open();
            OleDbCommand guncelle = new OleDbCommand();
            guncelle.CommandText = "update degiskenler set nesneTipi='" + nesneTipi + "', nesneDegeri='" + nesneDegeri + "', nesneAdi='" + nesneAdi + "' where nesneNumarasi='" + nesneNumarasi + "'";
            guncelle.Connection = baglanti;
            guncelle.ExecuteNonQuery();
            baglanti.Close();
        }
        public void Sil()
        {
            baglanti.Open();
            OleDbCommand sil = new OleDbCommand();
            sil.CommandText = "delete * from degiskenler where nesneNumarasi='" + nesneNumarasi + "'";
            sil.Connection = baglanti;
            sil.ExecuteNonQuery();
            baglanti.Close();
        }
        public List<string> Al()
        {
            if (compilerDurum==true)
            {
                baglanti.Open();
                OleDbCommand al2 = new OleDbCommand();
                al2.CommandText = "select * from degiskenler";
                al2.Connection = baglanti;
                OleDbDataReader oku2 = al2.ExecuteReader();
                while (oku2.Read())
                {
                    if (oku2[1].ToString() == compilerDegisken)
                    {
                        
                        degiskenler.Add(oku2[2].ToString());
                        
                    }

                }
                baglanti.Close();
            }
            else
            {
                if (Kontrol() == false)
                {
                    baglanti.Open();
                    OleDbCommand al = new OleDbCommand();
                    al.CommandText = "select nesneAdi from degiskenler";
                    al.Connection = baglanti;
                    OleDbDataReader oku = al.ExecuteReader();
                    while (oku.Read())
                    {
                        degiskenler.Add(oku[0].ToString());
                    }
                    baglanti.Close();
                }
            }
          
            return degiskenler;
        }
        private bool Kontrol()
        {
            baglanti.Open();
            OleDbCommand kontrol = new OleDbCommand();
            kontrol.CommandText = "select * from degiskenler";
            kontrol.Connection = baglanti;
            OleDbDataReader oku = kontrol.ExecuteReader();
            while (oku.Read())
            {
                if (oku[0].ToString() == nesneNumarasi)
                {
                    degiskenler.Add(oku[0].ToString());
                    degiskenler.Add(oku[1].ToString());
                    degiskenler.Add(oku[2].ToString());
                    degiskenler.Add(oku[3].ToString());
                    baglanti.Close();
                    return true;
                }

            }
            baglanti.Close();
            return false;
        }
    }
}
