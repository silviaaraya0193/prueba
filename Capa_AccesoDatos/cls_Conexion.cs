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
        }//fin del metodo que obtiene el String de la conexion con sqlexpress al conexion
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
       
        //Metodo que guarda los roles ... 
        public void mGuardarRole(String nombreRole, int codigoRole)
        {
            try
            {
                comando = new SqlCommand();
                comando.Connection = getConexion();
                this.comando.CommandType = CommandType.Text;
                this.comando.CommandText = "Insert into TB_ROLE(CODIGO_ROLE,nombre) values(@codigo,@nombre)";
                this.comando.Parameters.AddWithValue("@codigo", codigoRole);
                this.comando.Parameters.AddWithValue("@nombre", nombreRole);
                comando.ExecuteNonQuery();
                mCerrarConexion();
            }
            catch (Exception )
            {

                throw new Exception("Error bd");
            }
            
        }
        //metodo que regresa los roles existente

        public string[] mRetornarRolSinUso()
        {
            try
            {
                SqlDataReader lectura;
                string[] roles;
                comando = new SqlCommand();
                comando.Connection = getConexion();
                List<string> numbersList = new List<string>();
                this.comando.CommandType = CommandType.Text;
                this.comando.CommandText = "select CODIGO_ROLE FROM TB_ROLE WHERE CODIGO_ROLE NOT IN(SELECT CODIGO_ROLE FROM TB_ROLE_USUARIO)";
                lectura = this.comando.ExecuteReader();
                if (lectura.Read())
                {
                    while (lectura.Read()) {
                        numbersList.Add(Convert.ToString(lectura["CODIGO_ROLE"]));
                    }
                    roles = numbersList.ToArray();
                    lectura.Close();
                    mCerrarConexion();
                    return roles;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public DataSet mRolesUtilizados()
        {
            try
            {
                DataSet datos;//devuelve el registro completo
                SqlDataAdapter adaptador = new SqlDataAdapter();
                datos = new DataSet("CODIGO_ROLE");
                this.comando = new SqlCommand();
                this.comando.Connection = getConexion();
                this.comando.CommandType = CommandType.Text;
                this.comando.CommandText = "Select CODIGO_ROLE,NOMBRE FROM TB_ROLE WHERE CODIGO_ROLE  IN(SELECT CODIGO_ROLE FROM TB_ROLE_USUARIO)";

                //en este punt0 se llena el dataset por medio del adaptador 
                adaptador.SelectCommand = this.comando;
                adaptador.Fill(datos);
                //
                mCerrarConexion();
                adaptador.Dispose();

                return datos;

            }
            catch (Exception)
            {

                throw;
            }
        }
        //guarda las vistas
        public void guardarVista(int numeroVista,string nombreVista)
        {
            try
            {
                comando = new SqlCommand();
                comando.Connection = getConexion();
                this.comando.CommandType = CommandType.Text;
                this.comando.CommandText = "Insert into TB_VISTAS(ID_VISTA,NOMBRE_VISTA) values(@codigo,@nombre)";
                this.comando.Parameters.AddWithValue("@codigo", numeroVista);
                this.comando.Parameters.AddWithValue("@nombre", nombreVista);
                comando.ExecuteNonQuery();
                mCerrarConexion();
            }
            catch (Exception)
            {
                throw new Exception("Error bd");
            }
        }
        public string[] mVistasCreadas()
        {
            try
            {
                SqlDataReader lectura;
                string[] vistas;
                comando = new SqlCommand();
                comando.Connection = getConexion();
                List<string> numbersList = new List<string>();
                this.comando.CommandType = CommandType.Text;
                this.comando.CommandText = "select ID_VISTA FROM TB_VISTAS";
                lectura = this.comando.ExecuteReader();
                if (lectura.Read())
                {
                    while (lectura.Read())
                    {
                        numbersList.Add(Convert.ToString(lectura["ID_VISTA"]));
                    }
                    vistas = numbersList.ToArray();
                    lectura.Close();
                    mCerrarConexion();
                    return vistas;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void mRolesVentanas()
        {

        }
        public Boolean mConsultarUsuario(int codigo)
        {
            try
            {
                SqlDataReader lectura;
                comando = new SqlCommand();
                comando.Connection = getConexion();
                this.comando.CommandType = CommandType.Text;
                this.comando.CommandText = "SELECT NOMBRE FROM TB_USUARIO WHERE CODIGO_USUARIO=@CODIGO";
                this.comando.Parameters.AddWithValue("@codigo", codigo);
                lectura = this.comando.ExecuteReader();
                if (lectura.Read())
                {
                    mCerrarConexion();
                    return true;
                }
                else
                {
                    mCerrarConexion();
                    return false;
                }
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }
        public Boolean  mPermisos(cls_EntidadPermiso permiso)
        {
            try
            {
                Console.WriteLine("AgregarPermisos 1 ");
                comando = new SqlCommand();
                comando.Connection = getConexion();
                this.comando.CommandType = CommandType.Text;
                this.comando.CommandText = "INSERT INTO TB_PERMISOS(CODIGO_PERMISO,CODIGO_VISTA,SELECCION,INSERCION,ACTUALIZACION,BORRADO)" +
                                           " VALUES(@COD_PERMISO,@COD_VISTA,@SELECCION,@INSERCION,@ACTUALIZACION,@BORRADO)";
                this.comando.Parameters.AddWithValue("@COD_PERMISO", Convert.ToInt32(permiso.pCodPermiso));
                this.comando.Parameters.AddWithValue("@COD_VISTA", Convert.ToInt32(permiso.pCodVista));
                this.comando.Parameters.AddWithValue("@SELECCION", Convert.ToBoolean(permiso.pSelect));
                this.comando.Parameters.AddWithValue("@INSERCION", Convert.ToBoolean(permiso.pInsert));
                this.comando.Parameters.AddWithValue("@BORRADO", Convert.ToBoolean(permiso.pDelete));
                this.comando.Parameters.AddWithValue("@ACTUALIZACION", Convert.ToBoolean(permiso.pUpdate));
                //this.comando.Parameters.AddWithValue("@BORRADO", permiso.pCodPermiso);
                Console.WriteLine("AgregarPermisos 2 ");
                comando.ExecuteNonQuery();
                mCerrarConexion();
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
           

        }
        #endregion
    }
}
