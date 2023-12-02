using System;
using System.Web.UI.WebControls;

namespace WebCinestar
{
    public partial class pelicula : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int id = 0;
            string idd = Request.QueryString["id"];
            if (idd != null && int.TryParse(idd, out id))
            {
                fvPelicula.DataSource = new dao.PeliculaDAO().getPeliculas(id);
                fvPelicula.DataBind();
            }
            else Response.Redirect("Index.aspx");

        }
    }
}