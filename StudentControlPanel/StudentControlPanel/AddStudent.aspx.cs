using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Threading;
using System.Data;


namespace StudentControlPanel
{
    public partial class AddStudent : System.Web.UI.Page
    {
        /// <summary>
        /// Sayfa başlangıcında textboxlarımıza sınırlandırma ve buton aktif etme işlemi yaptık.
        /// </summary> 
        protected void Page_Load(object sender, EventArgs e)
        {
           
            yeniKayit.Visible = false;
            adi.Attributes.Add("maxlength", "35");
            soyadi.Attributes.Add("maxlength", "35");
            tcNo.Attributes.Add("maxlength", "11");
            ogrNo.Attributes.Add("maxlength", "12");
            telefon_no.Attributes.Add("maxlength", "11");
        }
        /// <summary>
        /// Ana sayfa butonuna basarak  response redirect komutuyla ana sayfaya yönlendirme yaptım.
        /// </summary> 
        protected void anaSayfa_Click(object sender, EventArgs e)
        {
            Response.Redirect("HomePage.aspx");
        }

        /// <summary>
        /// Kayıt işlemi yapabilmek için web servisimize parametre gönderdim. 
        /// </summary> 
        protected void kaydet_Click(object sender, EventArgs e)
         {
            yeniKayit.Visible = true;
            kaydetButon.Visible = false;


            StudentServiceReference.StudentWebServiceSoapClient info = new StudentServiceReference.StudentWebServiceSoapClient();
       

            info.OgrenciKayit(adi.Text, soyadi.Text, ogrNo.Text, tcNo.Text, telefon_no.Text,mail.Text);
          

            { Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "Başlık", "<script>alert('ÖĞRENCİ KAYIT İŞLEMİ TAMAMLANDI.');</script>"); }



        }
        /// <summary>
        /// Yeni kayıt butonuna basarak  response redirect komutuyla öğrenci ekleme paneline yönlendirerek sayfa yenileme işlemi yaptım.
        /// </summary> 
        protected void yeniKayit_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddStudent.aspx");
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
    }
    }