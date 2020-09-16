using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace StudentControlPanel
{
    public partial class FindStudent : System.Web.UI.Page
    {
        /// <summary>
        /// Sayfa başlangıcında textboxlarımıza sınırlandırma ve verileri gridviewe bastırma işlemi yaptık.
        /// </summary> 
        public void Page_Load(object sender, EventArgs e)
        {
            
            tcNo.Attributes.Add("maxlength", "11");
            ogrNo.Attributes.Add("maxlength", "12");
            adi.Attributes.Add("maxlength", "35");
            GridView1.DataBind();
        }
        /// <summary>
        /// Ana sayfa butonuna basarak  response redirect komutuyla ana sayfaya yönlendirme yaptım.
        /// </summary> 
        protected void anaSayfa_Click(object sender, EventArgs e)
        {
            Response.Redirect("HomePage.aspx");
        }
        /// <summary>
        /// Web servisimize bağlanarak isme göre listeleme işlemi yaptık.
        /// </summary> 
        protected void adaGöreListele_Click(object sender, EventArgs e)
        {
            StudentServiceReference.StudentWebServiceSoapClient info = new StudentServiceReference.StudentWebServiceSoapClient();

            DataSet ds = info.FindName(adi.Text);
            GridView1.DataSource = ds.Tables[0];
            GridView1.DataBind();

        }
        /// <summary>
        /// Web servisimize bağlanarak numaraya göre listeleme işlemi yaptık.
        /// </summary> 
        protected void numaraListele_Click(object sender, EventArgs e)
        {
            StudentServiceReference.StudentWebServiceSoapClient info = new StudentServiceReference.StudentWebServiceSoapClient();

            DataSet ds = info.FindNo(ogrNo.Text);
            GridView1.DataSource = ds.Tables[0];
            GridView1.DataBind();
        }
        /// <summary>
        /// Web servisimize bağlanarak tc numarasına göre listeleme işlemi yaptık.
        /// </summary> 
        protected void tcNolistele_Click(object sender, EventArgs e)
        {
            StudentServiceReference.StudentWebServiceSoapClient info = new StudentServiceReference.StudentWebServiceSoapClient();

            DataSet ds = info.FindTc(tcNo.Text);
            GridView1.DataSource = ds.Tables[0];
            GridView1.DataBind();

        }

       
    }
}