using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace StudentControlPanel
{
    public partial class deneme : System.Web.UI.Page
    {
        /// <summary>
        /// Sayfa başlangıcında textboxlarımıza sınırlandırma ve buton aktif etme işlemi yaptık.
        /// </summary> 
        protected void Page_Load(object sender, EventArgs e)
        {
            ogrNo.Attributes.Add("maxlength", "12");
            vize.Attributes.Add("maxlength", "3");
            final.Attributes.Add("maxlength", "3");
            GridView2.DataBind();
        }
        /// <summary>
        /// Not hesaplama ve bu notları sql'e kaydetmek için  Web servisimize bağlantı işlemi yaptık. Aynı zamanda matematiksel not hesaplama işlemi yaptık.
        /// </summary> 
        protected void Hesapla_Click(object sender, EventArgs e)
        {

             StudentServiceReference.StudentWebServiceSoapClient info = new StudentServiceReference.StudentWebServiceSoapClient();


            int vizeNotu = Convert.ToInt16(vize.Text);
            int finalNotu = Convert.ToInt16(final.Text);

            int ortalamaNotu = (((vizeNotu*40)/100)+((finalNotu*60)/100));
            if(finalNotu <50 ){
                ortalama.Text = "Not Ortalamanız =  " + ortalamaNotu.ToString() + "  Final notunuz 50'den düşük olduğu için kaldınız";
            }
           else if (ortalamaNotu < 50)
            {
                ortalama.Text = "Not Ortalamanız =  " + ortalamaNotu.ToString() + "  Kaldınız!!!!";
            }
            else
            { 
                ortalama.Text = "Not Ortalamanız =  " + ortalamaNotu.ToString() + "  Geçtiniz ;)";
            }
              sonuc.Text = ortalamaNotu.ToString(); 
           

            info.NoteEntry(ogrNo.Text, vize.Text, final.Text,sonuc.Text);

            


            { Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "MESAJ", "<script>alert('ÖĞRENCİ NOT GİRİŞ  İŞLEMİ TAMAMLANDI.');</script>"); }
        }
        /// <summary>
        /// Öğrenci bul butonuna basarak   response redirect komutuyla  öğrenci bul paneline yönlendirme yaptım.
        /// </summary> 
        protected void findStudent_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("FindStudent.aspx");

        }
        /// <summary>
        /// Yeni not girişi butonuna basarak   response redirect komutuyla  not giriş paneline yönlendirme yaptım.
        /// </summary> 
        protected void yeniGiriş_Click(object sender, EventArgs e)
        {
            Response.Redirect("NoteEntry.aspx");
        }
        /// <summary>
        /// Ana sayfa butonuna basarak  response redirect komutuyla ana sayfaya yönlendirme yaptım.
        /// </summary> 
        protected void anaSayfa_Click(object sender, EventArgs e)
        {
            Response.Redirect("HomePage.aspx");
        }
        /// <summary>
        /// Web servisimize bağlanarak not kayıtlarını listeleme işlemi yaptık.
        /// </summary> 
        protected void notListete_Click (object sender, EventArgs e )
        {

            StudentServiceReference.StudentWebServiceSoapClient info = new StudentServiceReference.StudentWebServiceSoapClient();
            DataSet ds = info.NoteList();
          

            GridView2.DataSource = ds.Tables[0];
            GridView2.DataBind();
         
           
        }
        /// <summary>
        /// Web servisimize bağlanarak not kayıtlarını silme işlemi yaptık.
        /// </summary> 
        protected void kayıtSil_Click(object sender, EventArgs e)
        {
            StudentServiceReference.StudentWebServiceSoapClient info = new StudentServiceReference.StudentWebServiceSoapClient();
            info.NoteDelete(ogrNo.Text);
            { Page.ClientScript.RegisterClientScriptBlock(this.GetType(), "MESAJ", "<script>alert('ÖĞRENCİ SİLME İŞLEMİ TAMAMLANDI.');</script>"); }
        }
    }
}