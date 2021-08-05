using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProgramacionAvanzadaUned
{
    public partial class InicioS1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnVer_Click(object sender, EventArgs e)
        {
            Response.Redirect("cardiologia.aspx", false);
        }

        protected void btnCirugia_Click(object sender, EventArgs e)
        {
            
        }

        protected void btnNutricion_Click(object sender, EventArgs e)
        {

        }

        protected void btnPsicologia_Click(object sender, EventArgs e)
        {

        }

        protected void btnOrtopedia_Click(object sender, EventArgs e)
        {

        }

        protected void btnFisioterapia_Click(object sender, EventArgs e)
        {

        }

        protected void btnMedicinaG_Click(object sender, EventArgs e)
        {
            Response.Redirect("IndexSA.aspx", false);
        }

        protected void btnLaboratorio_Click(object sender, EventArgs e)
        {

        }

        protected void btnPsiquiatria_Click(object sender, EventArgs e)
        {

        }
    }
}