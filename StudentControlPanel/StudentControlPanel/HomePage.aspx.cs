using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StudentControlPanel
{
    public partial class HomePage : System.Web.UI.Page
    {
        /// <summary>
        /// Sayfa başlangıcında  session yardımıyla login ekranından girilen bilgileri kontrol ettirdik.
        /// </summary> 
        


            //  ---------------  SESSİON AKTİVE ETME  --------------- //


      /*  protected void Page_Load(object sender, EventArgs e)
        {
            
              if (Session["Kullanici"] == null)
                 Response.Redirect("HomePage.aspx");
              else
                  Response.Write("Hoşgeldiniz " + Session["Kullanici"].ToString());
           

         //   StudentServiceReference.StudentWebServiceSoapClient info = new StudentServiceReference.StudentWebServiceSoapClient();

            
        }
        */

        protected void Button1_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Öğrenci ekle butonuna basarak   response redirect komutuyla  öğrenci ekleme paneline yönlendirme yaptım.
        /// </summary> 
        protected void addStudent_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("AddStudent.aspx");
        }
        /// <summary>
        /// Öğrenci silme butonuna basarak   response redirect komutuyla  öğrenci silme paneline yönlendirme yaptım.
        /// </summary> 
        protected void deleteStudent_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("DeleteStudent.aspx");
        }
        /// <summary>
        /// Öğrenci listele butonuna basarak   response redirect komutuyla  öğrenci listeleme paneline yönlendirme yaptım.
        /// </summary> 
        protected void listStudent_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("ListStudent.aspx");
        }
        /// <summary>
        /// Öğrenci güncelle butonuna basarak   response redirect komutuyla  öğrenci güncelleme paneline yönlendirme yaptım.
        /// </summary> 
        protected void updateStudent_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("UpdateStudent.aspx");
        }
        /// <summary>
        /// Not giriş butonuna basarak   response redirect komutuyla  not giriş paneline yönlendirme yaptım.
        /// </summary> 
        protected void noteEntry_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("NoteEntry.aspx");
        }
        /// <summary>
        /// Öğrenci bul butonuna basarak   response redirect komutuyla  öğrenci bul paneline yönlendirme yaptım.
        /// </summary> 
        protected void findStudent_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("FindStudent.aspx");
        }
        /// <summary>
        /// Geri dön butonuna basarak   response redirect komutuyla  giriş ekranı paneline yönlendirme yaptım.
        /// </summary> 
        protected void geriDon_Click1(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("LoginScreen.aspx");
        }
    }
}