using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Data.SqlClient;
using System.Data;
using Capa_EntidadNegocio;

namespace Capa_AccesoDatos
{
    public class cls_Conexion
    {
        #region Atributos
        private String stringConexion;
        private String strCodigo;
        private String strClave;
        private String strPerfil;
        private String strDB;

        private SqlConnection conexion;//realiza la conexion de la BD
        private SqlCommand comando;//ejecuta las sentencias a la BD
        private SqlDataReader drConsulta;// data reader para guardar las consultas
        #endregion
        #region Constructor
        public cls_Conexion() {
            strCodigo = "Laboratorio";
            strClave = "Laboratorio";
            strPerfil = "";
            strDB = "Laboratorio";
        }
        #endregion

        #region "Set_get"
            
        #endregion
        #region Metodos Conexion de BD
        private String pNombreServidor() {
            
            return Dns.GetHostName();
        }//fin del metodo que obtiene el nombre del servidor
        private String pStringConexion(cls_Conexion conexion) {
            return "user id='"+conexion.strCodigo+"'; password='"+conexion.strClave+"'; Data Source='"+pNombreServidor()+ "'; Initial Catalog='" + strDB+"'";
        }//fin del metodo que obtiene el String de la conexion
        private String pStringConexionSQLEXPRESS(cls_Conexion conexion)
        {
            return "user id='" + conexion.strCodigo + "'; password='" + conexion.strClave + "'; Data Source='" + pNombreServidor() + "\\SQLEXPRESS'; Initial Catalog='" + strDB + "'";
        }//fin del metodo que obtiene el String de la conexion con sql express al conexion
        /*--------------Abrir la conexion a la base de datos*/
        private Boolean mConectar() {
            try
            {
                this.conexion = new SqlConnection();
                this.conexion.ConnectionString = pStringConexion(this);
                conexion.Open();
                return true;
                
            }
            catch (SqlException)
            {
                conexion.Close();
                this.conexion.ConnectionString = pStringConexionSQLEXPRESS(this);
                conexion.Open();
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }//fin del metodo que abre la conexion  
        /*----------Metodo que obtiene la conexion abierta a la BD------*/
        private SqlConnection getConexion() {
            if (mConectar())
            {
                return conexion;
            }//fin del if que verifica si es posible abrir la conexion
            else {
                return null;
            }
        }//fin del metodo que retorna la conexion creada


        /*-----------------Metodo realiza consultas sea cual sea*/
        public SqlDataReader mConsultaGeneralByQuery(String query) {
            try
            {
                comando = new SqlCommand();
                comando.Connection = getConexion();
                comando.CommandText = query;
                return comando.ExecuteReader();

            }
            catch (Exception)
            {
                throw new Exception("Error de consulta");
            }
        }//fin del metodo que realiza las consultas mediante un query sencillo a la BD

        public SqlDataReader mSPSelectPermisosRolesUsuario(String codigo) {
            try
            {
                comando = new SqlCommand();
                comando.Connection = getConexion();
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "spSelectPermisosRolesUsuario";
                comando.Parameters.AddWithValue("@codUsuario", codigo);
                return comando.ExecuteReader();
            }
            catch (Exception)
            {
                throw new Exception("Error en consulta de credenciales de acceso de usuario");
            }
        }

        public void mBitacoraDB(String query) {
            try
            {
                comando = new SqlCommand();

                comando.Connection = getConexion();
                comando.CommandText = query;
                comando.ExecuteNonQuery();
                mCerrarConexion();
            }
            catch (Exception)
            {
                throw new Exception("Error de bitacora");
            }
        }//fin del metodo de la bitacora

        private void mCerrarConexion() {
            conexion.Close();
            comando.Dispose();
            conexion.Dispose();
        }//fin del emtodo que cierra la conexion a la base de datos
       

        #endregion
    }
}
