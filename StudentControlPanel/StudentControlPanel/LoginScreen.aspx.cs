using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace StudentControlPanel
{
    public partial class loginScreen2 : System.Web.UI.Page
    {
        /// <summary>
        /// Sayfa başlangıcında labelde bulunan mesajı gizleme işlemi yaptık.
        /// </summary> 
        protected void Page_Load(object sender, EventArgs e)
        {
            message.Visible = false;

        }
        /// <summary>
        /// Session kullanarak  girilen bilgileri ana sayfa paneline göndererek kontrol işlemi gerçekleştirdik.
        /// </summary> 
        protected void giris_Click(object sender, EventArgs e)
        {

            message.Visible = true;

            /* -----------     StudentServiceReference.StudentWebServiceSoapClient info = new StudentServiceReference.StudentWebServiceSoapClient();

                 info.LoginScreen(loginId.Text, loginPassword.Text, message.Text);
                 info.LoginConnect(loginId.Text, loginPassword.Text, message.Text);
                 ------------ */

            //   StudentServiceReference.StudentWebServiceSoapClient info = new StudentServiceReference.StudentWebServiceSoapClient();


            // info.(adi.Text, soyadi.Text, ogrNo.Text, tcNo.Text, telefon_no.Text, mail.Text);

            string kullanici = loginId.Text;
            string sifre = loginPassword.Text;
            SqlConnection connection = new SqlConnection("Data Source = TOSHIBA\\SQLEXPRESS; Initial Catalog = Student; Integrated Security = True");
            SqlCommand komut = new SqlCommand("SELECT * FROM  addStudent WHERE name=@name AND surname=@surname", connection);
            komut.Parameters.AddWithValue("@name", kullanici);
            komut.Parameters.AddWithValue("@surname", sifre);
            connection.Open();
            SqlDataReader oku = komut.ExecuteReader();
            if (oku.Read())
            {
                Session["Kullanici"] = oku["name"].ToString();
                Response.Redirect("HomePage.aspx");
            }
            else
                message.Text = "Kullanıcı adı ya da şifre hatalı!";
            oku.Close();
            connection.Close();
            connection.Dispose();
            /*--------- farklı bir database kullanırsak ----------

               string kullanici = loginId.Text;
               string sifre = loginPassword.Text;
               SqlConnection connection = new SqlConnection("Data Source = TOSHIBA\\SQLEXPRESS; Initial Catalog = Admin; Integrated Security = True");
               SqlCommand komut = new SqlCommand("SELECT * FROM  login WHERE user=@user AND password=@password", connection);
               komut.Parameters.AddWithValue("@user",kullanici);
               komut.Parameters.AddWithValue("@password", sifre);
               connection.Open();
               SqlDataReader oku = komut.ExecuteReader();
               if (oku.Read())
               {
                   Session["Kullanici"] = oku["user"].ToString();
                   Response.Redirect("HomePage.aspx");
               }
               else
               message.Text = "Kullanıcı adı ya da şifre hatalı!";
               oku.Close();
               connection.Close();
               connection.Dispose();

               --------*/



            //Sql kullanmadan giriş yapmak istersek------------------
            // ---------------------------------------------------------


            /*  if ((loginId.Text == "admin") && (loginPassword.Text == "1234"))
              {

                  Response.Redirect("HomePage.aspx");
                  // message.ForeColor = System.Drawing.Color.Green;
                  //message.Text = "Şifre Doğru";
              }
              else
              {
                  message.ForeColor = System.Drawing.Color.Red;
                  message.Text = "Şifre Yanlış";
              }
              */

        }
    }
}