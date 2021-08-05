using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ProgramacionAvanzadaUned.Controlador;

namespace ProgramacionAvanzadaUned
{
    public partial class IniciarSesion : System.Web.UI.Page
    {
        private ClaseUsuarios Usuarios;
        private ClaseUsuariosHelper UsuariosHelper;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        protected void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            try
            {
                VerificacionUsuario();
            }
            catch (Exception)
            {

                throw new Exception("error");
            }
        }

        #region ProcesoVerificacionUsuario
        public void VerificacionUsuario()
        {
            try
            {
                if(this.txtUsuario.Text != "" && this.txtPassword.Text != "")
                {
                    this.Usuarios = new ClaseUsuarios();
                    this.Usuarios.opcion = 1;
                    this.Usuarios.usuario = this.txtUsuario.Text;
                    this.Usuarios.clave = this.txtPassword.Text;

                    this.UsuariosHelper = new ClaseUsuariosHelper(Usuarios);
                    DataTable vDT = this.UsuariosHelper.IniciarSesion();
                    if(vDT.Rows.Count > 0)
                    {
                        Session["SesionIniciada"] = vDT.Rows[0]["Usuario"].ToString();
                        Response.Redirect("InicioSA.aspx", false);
                    }
                    else
                    {
                        string script = "alert('Lo sentimos, no se encuentran datos con el usuario ingresado.')";
                        ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);
                    }
                }
                else
                {
                    string script = "alert('Lo sentimos, debe de rellenar los espacios correspondientes')";
                    ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, true);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        #endregion
    }
}