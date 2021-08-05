using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramacionAvanzadaUned.Modelo
{
    public class ConexionBaseDatos
    {
        #region Declaracion de variables
        SqlConnection cnnConexion = null;
        SqlCommand cmdComando = null;
        SqlDataAdapter daAdaptador = null;
        DataTable Dtt = null;
        string strCadenaConexion = string.Empty;
        #endregion

        #region Constructores
        public ConexionBaseDatos()
        {
            strCadenaConexion = @"Data Source= DESKTOP-L5V8N7V\SQLEXPRESS;  Initial Catalog = ProgramacionAvanzadaUned; Integrated Security=SSPI";
        }
        #endregion

        #region Metodos a Ejecutar
        public void EjecutarSP(SqlParameter[] parParametros, string parSPName)
        {
            // dtDatos = new DataSet();

            try
            {
                //Instanciamos el objeto conexion con la cadena de conexion.
                cnnConexion = new SqlConnection(strCadenaConexion);
                //Instanciamos el objeto comando con el TSQL y conexion a utilizar.
                cmdComando = new SqlCommand();//(parTSQL, cnnConexion);
                cmdComando.Connection = cnnConexion;
                //Abrimos la conexion
                cnnConexion.Open();
                //Asignamos el tipo de comando a ejecutar.
                cmdComando.CommandType = CommandType.StoredProcedure;
                //Agregamos el nombre del Srore procedure.
                cmdComando.CommandText = parSPName;
                //Agregmos los parametros a ejecutar
                cmdComando.Parameters.AddRange(parParametros);
                //Ejecutamos el TSQL(Transaction SQL) en el servidor.
                cmdComando.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            finally
            {
                cnnConexion.Dispose();
                cmdComando.Dispose();

            }
        }
        public DataTable RetornaTabla(SqlParameter[] parParametros, string parTSQL)
        {
            Dtt = null;
            try
            {
                Dtt = new DataTable();
                //Instanciamos el objeto conexion con la cadena de conexion.
                cnnConexion = new SqlConnection(strCadenaConexion);
                //Instanciamos el objeto comando con el TSQL
                cmdComando = new SqlCommand();//(parTSQL, cnnConexion);
                cmdComando.Connection = cnnConexion;
                //Asignamos el tipo de comando a ejecutar.
                cmdComando.CommandType = CommandType.StoredProcedure;
                //Agregamos el nombre del Srore procedure.
                cmdComando.CommandText = parTSQL;
                //Agregmos los parametros a ejecutar
                cmdComando.Parameters.AddRange(parParametros);
                //Instanciamos el objeto Adaptador con el comando a utilizar
                daAdaptador = new SqlDataAdapter(cmdComando);
                //Llenamos el Dataset con el adaptador de datos.
                daAdaptador.Fill(Dtt);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                cnnConexion.Dispose();
                cmdComando.Dispose();
                daAdaptador.Dispose();
            }
            return Dtt;
        }
        #endregion
    }
}
