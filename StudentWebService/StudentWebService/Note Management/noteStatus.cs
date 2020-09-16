using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;



namespace StudentWebService.Note_Management
{
    /// <summary>
    /// Öğrenci notu ekleme, silme ve listeleme  fonksiyonları kullandık.
    /// </summary> 
    public class noteStatus
    {

        static string connectingStringAddStudent = "Data Source = TOSHIBA\\SQLEXPRESS; Initial Catalog = Student; Integrated Security = True";

        /// <summary>
        /// Parametre olarak öğrenci numarası,vize notu,final notu,sonuç notu alarak öğrenci notu ekleme işlemi yapar.
        /// </summary> 
        public static void addNote(string ogrNo, string vize, string final, string sonuc)
        {

            SqlConnection connection = new SqlConnection(connectingStringAddStudent);
            connection.Open();
            SqlCommand komut = new SqlCommand("INSERT INTO exams (stdNo, midterm, final , result ) VALUES(  @ogrNo, @vize, @final, @sonuc)", connection);

            komut.Parameters.Add(new SqlParameter("@ogrNo", ogrNo));

            komut.Parameters.Add(new SqlParameter("@vize", vize));

            komut.Parameters.Add(new SqlParameter("@final", final));

            komut.Parameters.Add(new SqlParameter("@sonuc", sonuc));
            //  komut.Parameters.Add("@sonuc", System.Data.SqlDbType.NVarChar, 255);

            komut.ExecuteNonQuery();



            connection.Close();
        }

        /// <summary>
        /// Parametre olarak öğrenci numarası alarak öğrenci notu silme işlemi yapar.
        /// </summary>     
        public static void deleteNote(string ogrNo)
        {
            SqlConnection connection = new SqlConnection(connectingStringAddStudent);
            connection.Open();

            SqlCommand komut = new SqlCommand("Delete from exams where stdNo = @ogrNo", connection);
            komut.Parameters.Add(new SqlParameter("@ogrNo", ogrNo));
            komut.ExecuteNonQuery();
            connection.Close();

        }
        /// <summary>
        /// Öğrenci notlarını listeleme işlemi yapar.
        /// </summary>     
        public static DataSet noteList()
    {
        SqlConnection connection = new SqlConnection(connectingStringAddStudent);
        SqlDataAdapter adapter = new SqlDataAdapter("SELECT addStudent.stdNo , addStudent.name , addStudent.surname,exams.midterm ,exams.final , exams.result FROM addStudent , exams WHERE exams.stdNo = addStudent.stdNo", connection);
        DataSet ds = new DataSet();
        //ds.Clear();
        adapter.Fill(ds);
        return ds;

  }

    }
       }
