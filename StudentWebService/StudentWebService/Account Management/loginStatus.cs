using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace StudentWebService.Account_Management
{
    /// <summary>
    ///  Giriş ekranı ve bu ekrana bağlanma kontrol fonksiyonlarını kullandık.
    /// </summary> 

    public class loginStatus
    {

        static string connectingStringAddStudent = "Data Source = TOSHIBA\\SQLEXPRESS; Initial Catalog = Student; Integrated Security = True";

        /// <summary>
        /// Parametre olarak kullanıcı adı,şifre ve ekran mesajı  alarak  kullanıcı girişi sağlar.
        /// </summary> 

        public static void loginScreen(string message, string loginId, string loginPassword)
        {
            SqlConnection connection = new SqlConnection(connectingStringAddStudent);

            loginStatus hello = new loginStatus();






            string kullanici = loginId;
            string sifre = loginPassword;
            
            SqlCommand komut = new SqlCommand("SELECT * FROM  login WHERE user=@user AND password=@password", connection);
            komut.Parameters.AddWithValue("@user", kullanici);
            komut.Parameters.AddWithValue("@password", sifre);
            connection.Open();
            SqlDataReader oku = komut.ExecuteReader();
            if (oku.Read())
            {
                //Session["Kullanici"] = oku["user"].ToString();
                HttpContext.Current.Response.Redirect("HomePage.aspx");
            }
            else
                message = "Kullanıcı adı ya da şifre hatalı!";
            oku.Close();
            connection.Close();
            connection.Dispose();


        }
        /// <summary>
        /// Parametre olarak kullanıcı adı,şifre ve ekran mesajı  alarak  kullanıcı girişinin doğru olup olmadığını session ile kontrol eder ve yönlendirme yapar.
        /// </summary> 
        public static void loginConnect(string message, string loginId, string loginPassword)
        {


            //    if (Session["Kullanici"] == null)
            HttpContext.Current.Response.Redirect("HomePage.aspx");
            //else
          //      HttpContext.Current. Response.Write("Hoşgeldiniz " + Session["Kullanici"].ToString());
        }
    }

      
}