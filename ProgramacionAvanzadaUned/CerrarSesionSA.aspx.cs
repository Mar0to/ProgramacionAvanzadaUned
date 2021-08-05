using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProgramacionAvanzadaUned
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            try
            {
                CerrarSesion();
            }
            catch (Exception)
            {

                throw new Exception("Error");
            }
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("IndexSA.aspx", false);
        }

        public void CerrarSesion()
        {
            try
            {
                if(Convert.ToString(Session["SesionIniciada"]) != "")
                {
                    Session.RemoveAll();
                    Response.Redirect("InicioS.aspx", false);
                }
               
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }
    }
}