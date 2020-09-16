using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace StudentControlPanel
{
    public partial class DeleteStudentCopy : System.Web.UI.Page
    {
        /// <summary>
        /// Sayfa başlangıcında textboxlarımıza sınırlandırma ve buton aktif etme işlemi yaptık.
        /// </summary> 
        protected void Page_Load(object sender, EventArgs e)
        {
            ogrNo.Attributes.Add("maxlength", "12");
            yeniOgr.Visible = false;

        }

        /// <summary>
        ///  Öğrenci bul butonuna basarak  response redirect komutuyla öğrenci bulma paneline yönlendirme yaptım.
        /// </summary> 
        protected void findStudent_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("FindStudent.aspx");
        }

        /// <summary>
        /// Web servisimize bağlanarak öğrenci silme işlemi yaptık.
        /// </summary> 
        protected void ogrDelete_Click(object sender, EventArgs e)
        {
            StudentServiceReference.StudentWebServiceSoapClient info = new StudentServiceReference.StudentWebServiceSoapClient();
            info.DeleteStudent( ogrNo.Text);
           
            { Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "Başlık", "<script>alert('ÖĞRENCİ SİLME İŞLEMİ TAMAMLANDI.');</script>"); }

            yeniOgr.Visible = true;
            ogrDelete.Visible = false;

        }
        /// <summary>
        /// Web servisimize bağlanarak listeleme işlemi yaptık.
        /// </summary> 
        protected void listele_Click(object sender, EventArgs e)
        {
           

            StudentServiceReference.StudentWebServiceSoapClient info = new StudentServiceReference.StudentWebServiceSoapClient();
            DataSet ds = info.StudentList();


            DataList10.DataSource = ds.Tables[0];
            DataList10.DataBind();

        }
        /// <summary>
        ///  Yeni kayıt silme butonuna basarak  response redirect komutuyla öğrenci silme paneline yönlendirme yaparak sayfa yenileme yaptım.
        /// </summary> 
        protected void farklıOgrenci_Click(object sender, EventArgs e)
        {

            Response.Redirect("DeleteStudent.aspx");

        }

        /// <summary>
        /// Ana sayfa butonuna basarak  response redirect komutuyla ana sayfaya yönlendirme yaptım.
        /// </summary> 
        protected void anaSayfa_Click(object sender, EventArgs e)
        {
            Response.Redirect("HomePage.aspx");
        }

       
    }
}