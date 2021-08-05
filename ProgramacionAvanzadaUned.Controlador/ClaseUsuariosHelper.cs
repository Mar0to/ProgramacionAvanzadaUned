using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProgramacionAvanzadaUned.Modelo;

namespace ProgramacionAvanzadaUned.Controlador
{
    public class ClaseUsuariosHelper
    {
        ClaseUsuarios ObjetoUsuario = null;
        ConexionBaseDatos Datos = null;
        DataTable vDT = new DataTable();

        public ClaseUsuariosHelper(ClaseUsuarios SegundoObjetoUsuario)
        {
            ObjetoUsuario = SegundoObjetoUsuario;
        }

        #region Iniciar Sesion
        public DataTable IniciarSesion()
        {
            vDT = new DataTable();

            try
            {
                Datos = new ConexionBaseDatos();

                SqlParameter[] Parametros = new SqlParameter[3];

                Parametros[0] = new SqlParameter()
                {
                    ParameterName = "@opcion",
                    SqlValue = ObjetoUsuario.opcion,
                    SqlDbType = SqlDbType.Int
                };
                Parametros[1] = new SqlParameter()
                {
                    ParameterName = "@usuario",
                    SqlValue = ObjetoUsuario.usuario,
                    SqlDbType = SqlDbType.VarChar
                };
                Parametros[2] = new SqlParameter()
                {
                    ParameterName = "@clave",
                    SqlValue = ObjetoUsuario.clave,
                    SqlDbType = SqlDbType.VarChar
                };

                vDT = Datos.RetornaTabla(Parametros, "SPUsuarios");

            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }

            return vDT;
        }
        #endregion
        #region Registrar Nuevo Usuario

        public void RegistrarNuevoUsuario()
        {
            try
            {
                Datos = new ConexionBaseDatos();
                SqlParameter[] Parametros = new SqlParameter[8];

                Parametros[0] = new SqlParameter()
                {
                    ParameterName = "opcion",
                    SqlValue = ObjetoUsuario.opcion,
                    SqlDbType = SqlDbType.Int
                };
                Parametros[1] = new SqlParameter()
                {
                    ParameterName = "nombre",
                    SqlDbType = SqlDbType.VarChar,
                    SqlValue = ObjetoUsuario.NombreUsuario
                };
                Parametros[2] = new SqlParameter()
                {
                    ParameterName = "apellidos",
                    SqlValue = ObjetoUsuario.Apellidos,
                    SqlDbType = SqlDbType.VarChar
                };
                Parametros[3] = new SqlParameter()
                {
                    ParameterName = "telefono",
                    SqlValue = ObjetoUsuario.Telefono,
                    SqlDbType = SqlDbType.Int
                };
                Parametros[4] = new SqlParameter()
                {
                    ParameterName = "fechaNacimiento",
                    SqlValue = ObjetoUsuario.fechaNacimiento,
                    SqlDbType = SqlDbType.DateTime
                };
                Parametros[5] = new SqlParameter()
                {
                    ParameterName = "cedula",
                    SqlValue = ObjetoUsuario.cedula,
                    SqlDbType = SqlDbType.Int
                };
                Parametros[6] = new SqlParameter()
                {
                    ParameterName = "usuario",
                    SqlValue = ObjetoUsuario.usuario,
                    SqlDbType = SqlDbType.VarChar
                };
                Parametros[7] = new SqlParameter()
                {
                    ParameterName = "clave",
                    SqlValue = ObjetoUsuario.clave,
                    SqlDbType = SqlDbType.VarChar
                };

                Datos.EjecutarSP(Parametros, "SPUsuarios");
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }
        #endregion
    }
}
