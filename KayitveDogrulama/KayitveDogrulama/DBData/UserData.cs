using KayitveDogrulama.Connection;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Windows.Forms;

namespace KayitveDogrulama.DBData
{
    public class UserData
    {
        SqlConnect conn = new SqlConnect();

       

        public bool SqlAdd(long TCNo, string Name ,string Surname,DateTime BirthDate)
        {
            var data = GetDataByTCNo(TCNo);
            if (!data.HasRows)
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Kullanici (TCKimlikNo,Ad,Soyad,DogumTarihi,KayitTarihi) VALUES (@tc,@ad,@soyad,@dogumtrh,@kayittrh)", conn.Connection());
                cmd.Parameters.AddWithValue("@tc", TCNo);
                cmd.Parameters.AddWithValue("@ad", Name);
                cmd.Parameters.AddWithValue("@soyad", Surname);
                cmd.Parameters.AddWithValue("@dogumtrh", BirthDate);
                cmd.Parameters.AddWithValue("@kayittrh", DateTime.Now ) ;
                cmd.ExecuteNonQuery();
                return true;
            }
            else
            {
                MessageBox.Show("Sisteme kayıtlı kullanıcı bilgisi girdiniz.");
                return false;
            }

        }

        public bool TCNoControl(long TCNo, string Name, string Surname, DateTime BirthDate)
        {
            bool durum = false;
            try
            {
                //Doğum yılı kullanılacak
                //İsim ve Soyisim büyük harflerle girilecek
                using (KimlikDogrulamaServisi.KPSPublicSoapClient service = new KimlikDogrulamaServisi.KPSPublicSoapClient())
                {
                    durum = service.TCKimlikNoDogrula(TCNo, Name, Surname, BirthDate.Year);
                }
            }
            catch (Exception)
            {

                durum = false;
            }
            return durum;
        }

        public SqlDataReader GetDataByTCNo(long tcno)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM Kullanici WHERE TCKimlikNo= @tcno", conn.Connection());
            cmd.Parameters.AddWithValue("@tcno", tcno);
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }

        //public int ConvertDatetoInt(DateTime BirthDate)
        //{
        //    int integerdate;
        //    string stringdate = BirthDate.ToShortDateString();
        //    stringdate = stringdate.Replace("/", "");
        //    stringdate = stringdate.Replace(":", "");
        //    stringdate = stringdate.Replace(" ", "");
        //    stringdate = stringdate.Replace(".", "");
        //    stringdate = stringdate.Replace("AM", "");
        //    stringdate = stringdate.Replace("PM", "");

        //    integerdate = Convert.ToInt32(stringdate);
        //    return integerdate;
        //}
    }
}