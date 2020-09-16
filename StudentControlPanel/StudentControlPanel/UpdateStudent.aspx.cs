using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;



namespace StudentControlPanel
{
    public partial class UpdateStudent : System.Web.UI.Page
    {
        /// <summary>
        /// Sayfa başlangıcında textboxlarımıza sınırlandırma ve buton aktif etme işlemi yaptık.
        /// </summary> 
        protected void Page_Load(object sender, EventArgs e)
        {
            ad.Attributes.Add("maxlength", "35");
            soyad.Attributes.Add("maxlength", "35");
            ogrNo.Attributes.Add("maxlength", "12");
            tcNo.Attributes.Add("maxlength", "11");
            telNo.Attributes.Add("maxlength", "11");
            yeniGuncelle.Visible = false;


            if (!IsPostBack)
            {
                studentList();
            }
        }


        /// <summary>
        /// Sql ile bağlantı kurarak öğrenci bilgileri güncelleme işlemi yaptık.
        /// </summary> 
        protected void güncelle_Click(object sender, EventArgs e)
        {

            /*
            StudentServiceReference.StudentWebServiceSoapClient info = new StudentServiceReference.StudentWebServiceSoapClient();
            info.UpdateButton(DropDownList1.SelectedItem.Value,ad.Text, soyad.Text, ogrNo.Text, tcNo.Text, telNo.Text, mail.Text);
            
            */

        
            
            SqlConnection baglanti = new SqlConnection("Data Source=TOSHIBA\\SQLEXPRESS;Initial Catalog=Student;Integrated Security=True");            
            SqlCommand komut = new SqlCommand("UPDATE addStudent SET  name=@name,surname=@surname,stdNo=@stdNo,tcNo=@tcNo,telNo=@telNo,eMail=@eMail FROM addStudent WHERE ID = @ID", baglanti);
            // SqlCommand komut = new SqlCommand("UPDATE addStudent SET (name, surname, stdNo, tcNo, telNo , eMail ) VALUES(@name, @surname , @stdNo, @tcNo, @telNo, @eMail)", baglanti);

           

          //  komut.Parameters.AddWithValue("@name", ad);
            komut.Parameters.Add("@name", System.Data.SqlDbType.NVarChar, 255);
            komut.Parameters["@name"].Value = ad.Text;
            komut.Parameters.Add("@surname", System.Data.SqlDbType.NVarChar, 255);
            komut.Parameters["@surname"].Value = soyad.Text;
            komut.Parameters.Add("@stdNo", System.Data.SqlDbType.NVarChar, 255);
            komut.Parameters["@stdNo"].Value = ogrNo.Text;
            // komut.Parameters.AddWithValue("@tcNo", tcNo);
            komut.Parameters.Add("@tcNo", System.Data.SqlDbType.NVarChar, 11);
            komut.Parameters["@tcNo"].Value = tcNo.Text;
            komut.Parameters.Add("@telNo", System.Data.SqlDbType.NVarChar, 12);
            komut.Parameters["@telNo"].Value = telNo.Text;
            komut.Parameters.Add("@eMail", System.Data.SqlDbType.NVarChar, 255); 
            komut.Parameters["@eMail"].Value =mail.Text;
         
            komut.Parameters.Add("@ID", System.Data.SqlDbType.Int);
            komut.Parameters["@ID"].Value = students.SelectedItem.Value;

            baglanti.Open();
            komut.ExecuteNonQuery();
            baglanti.Close();

            studentList();

            
            { Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "Başlık", "<script>alert('ÖĞRENCİ GÜNCELLEME İŞLEMİ TAMAMLANDI.');</script>"); }

          
            

        }
        /// <summary>
        ///  Yeni kayıt güncelle butonuna basarak response redirect komutuyla öğrenci güncelle paneline yönlendirme yaptım.
        /// </summary> 
        protected void yenigüncelle_Click(object sender, EventArgs e)
        {
            
            Response.Redirect("UpdateStudent.aspx");
        }

        /// <summary>
        ///Sql ile bağlantı kurarak  dropdownlistte öğrencilerin sadece isim ve soyisim olarak listelenmesini sağladık.
        /// </summary> 
        public void studentList()
        {
          
         /*   UpdateStudent update = new UpdateStudent();
            StudentServiceReference.StudentWebServiceSoapClient info = new StudentServiceReference.StudentWebServiceSoapClient();
            

            info.UpdateList(DropDownList1.SelectedItem.Value,ad.Text, soyad.Text, ogrNo.Text, tcNo.Text, telNo.Text, mail.Text);

          */  

            // DataSource=updatelist.table  yap
            SqlDataReader reader;
            SqlConnection baglanti = new SqlConnection("Data Source=TOSHIBA\\SQLEXPRESS;Initial Catalog=Student;Integrated Security=True");
            SqlCommand komut = new SqlCommand("SELECT ID, name + ' ' + surname AS namesurname FROM addStudent", baglanti);
            baglanti.Open();
           
            reader = komut.ExecuteReader();
           
            students.DataSource = reader;
            students.DataValueField = "ID";
            students.DataTextField = "namesurname";
            students.DataBind();
            reader.Close();
            

            baglanti.Close();
            
          
        }
        /// <summary>
        /// Öğrenci bul butonuna basarak   response redirect komutuyla  öğrenci bul paneline yönlendirme yaptım.
        /// </summary>
        protected void findStudent_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("FindStudent.aspx");
        }
        /// <summary>
        /// Ana sayfa butonuna basarak  response redirect komutuyla ana sayfaya yönlendirme yaptım.
        /// </summary>
        protected void anaSayfa_Click(object sender, EventArgs e)
        {
            Response.Redirect("HomePage.aspx");
        }

      
      

        /// <summary>
        /// Sql ile bağlantı kurarak seçtiğimiz öğrencinin bilgilerini textboxlara bastırdık.
        /// </summary> 
        protected void sec_Click(object sender, EventArgs e)
        {
         /*   UpdateStudent güncelle = new UpdateStudent();
            StudentServiceReference.StudentWebServiceSoapClient info = new StudentServiceReference.StudentWebServiceSoapClient();

            info.UpdateChoose(DropDownList1.SelectedItem.Value,ad.Text, soyad.Text, ogrNo.Text, tcNo.Text, telNo.Text, mail.Text);
          
            */
            

            SqlDataReader reader;
            SqlConnection baglanti = new SqlConnection("Data Source=TOSHIBA\\SQLEXPRESS;Initial Catalog=Student;Integrated Security=True");
          
           

            SqlCommand komut = new SqlCommand("SELECT name,surname,stdNo,tcNo,telNo,eMail FROM addStudent WHERE ID = @ID", baglanti);

            komut.Parameters.Add("@ID", System.Data.SqlDbType.Int);
            komut.Parameters["@ID"].Value = (students.SelectedItem.Value);
            baglanti.Open();

            reader = komut.ExecuteReader();
            if (reader.Read())
            {
                
                ad.Text = reader["name"].ToString();
                soyad.Text = reader["surname"].ToString();
                ogrNo.Text = reader["stdNo"].ToString();
                tcNo.Text = reader["tcNo"].ToString();
                telNo.Text = reader["telNo"].ToString();
                mail.Text = reader["eMail"].ToString();
               
            }
            reader.Close();
            baglanti.Close();

        
       }
        /// <summary>
        /// Web servisimize bağlanarak listeleme işlemi yaptık.
        /// </summary> 
        protected void listele_Click(object sender, EventArgs e)
        {
            yeniGuncelle.Visible = true;
            guncelle.Visible = false;
            StudentServiceReference.StudentWebServiceSoapClient info = new StudentServiceReference.StudentWebServiceSoapClient();
            DataSet ds = info.StudentList();


            DataList10.DataSource = ds.Tables[0];
            DataList10.DataBind();
        }
    }
}