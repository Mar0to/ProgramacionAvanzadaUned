using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProgramacionAvanzadaUned
{
    public partial class InicioSesionIniciada : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            VerificacionSesionIniciada();
        }

        public void VerificacionSesionIniciada()
        {
            try
            {
                if (Convert.ToString(Session["SesionIniciada"]) != "")
                {
                }
                else
                {
                    Response.Redirect("InicioS.aspx", false);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}