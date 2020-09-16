using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace StudentControlPanel
{
    public partial class ListStudent : System.Web.UI.Page
    {
        /// <summary>
        /// Sayfa başlangıcında verileri gridviewe bastırma işlemi yaptık.
        /// </summary> 
        protected void Page_Load(object sender, EventArgs e)
        {
            GridView2.DataBind();

        }

        /// <summary>
        /// Web servisimize bağlanarak listeleme işlemi yaptık.
        /// </summary> 
        protected void listele_Click(object sender, EventArgs e)
        {
            GridView2.Visible =false;
            DataList10.Visible = true;
            StudentServiceReference.StudentWebServiceSoapClient info = new StudentServiceReference.StudentWebServiceSoapClient();
            DataSet ds = info.StudentList();
          

            DataList10.DataSource = ds.Tables[0];
            DataList10.DataBind();
          
        }
        /// <summary>
        /// Web servisimize bağlanarak not kayıtlarını listeleme işlemi yaptık.
        /// </summary> 
        protected void notKayitlari_Click(object sender, EventArgs e)
        {
            GridView2.Visible = true;
            DataList10.Visible = false;
            StudentServiceReference.StudentWebServiceSoapClient info = new StudentServiceReference.StudentWebServiceSoapClient();
            DataSet ds = info.NoteList();
          

            GridView2.DataSource = ds.Tables[0];
            GridView2.DataBind();
           
        }
        /// <summary>
        /// Web servisimize bağlanarak listelerimizi sayfa sayfa gösterme işlemi yaptık.
        /// </summary> 
        protected void GridView2_PageIndexChanging(object sender, GridViewPageEventArgs e)

        {
            StudentServiceReference.StudentWebServiceSoapClient info = new StudentServiceReference.StudentWebServiceSoapClient();

            GridView2.PageIndex = e.NewPageIndex;

             info.StudentList();

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