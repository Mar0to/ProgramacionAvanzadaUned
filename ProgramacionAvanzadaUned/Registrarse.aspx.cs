using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProgramacionAvanzadaUned
{
    public partial class Registrarse : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegistro_Click(object sender, EventArgs e)
        {
            AgregarUsuario();
        }

        protected void btnInciarSesion_Click(object sender, EventArgs e)
        {
            Response.Redirect("IniciarSesion.aspx", false);
        }
        public void AgregarUsuario()
        {
            try
            {

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}