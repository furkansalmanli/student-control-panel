using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace StudentControlPanel
{
    public partial class UpdateStudentPanel : System.Web.UI.Page
    {
        /// <summary>
        /// Sayfa başlangıcında textboxlarımıza sınırlandırma ve buton aktif etme işlemi yaptık.
        /// </summary> 
        protected void Page_Load(object sender, EventArgs e)
        {
            UpdateStudentPanel yeni = new UpdateStudentPanel();
            ogrNo.Attributes.Add("maxlength", "12");
            tcNo.Attributes.Add("maxlength", "11");
        }

        protected void kaydet_Click(object sender, EventArgs e)
        {
         
            StudentServiceReference.StudentWebServiceSoapClient info = new StudentServiceReference.StudentWebServiceSoapClient();
         //  DataSet ds = info.OgrenciBilgi();
          //  gridview
          //  bool result = info.OgrenciBilgi(ad.Text,soyad.Text,ogrNo.Text,tcNo.Text,telNo.Text,mail.Text);
        }

        protected void anaSayfa_Click(object sender, EventArgs e)
        {
            Response.Redirect("HomePage.aspx");
        }
        protected void güncellemeEkranı_Click(object sender, EventArgs e)
        {
            Response.Redirect("UpdateStudent.aspx");
        }

       
    }
}