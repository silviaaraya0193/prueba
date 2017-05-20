using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Collections;
using System.Data.SqlClient;
using Capa_EntidadNegocio;
using Capa_AccesoDatos;

namespace Capa_LogicaNegocio
{
    public class cls_LogicaUsuario
    {
        #region Atributos
        private SqlDataReader drConsulta;
        private cls_Conexion clConexion;

        private String query;
        #endregion

        public cls_LogicaUsuario() {
            clConexion = new cls_Conexion();
        }

        #region Metodos
        /*-------------Validar existencia de usuario---------------------*/
        public cls_EntidadUsuario mValidarUsuario(cls_EntidadUsuario pUsuario)
        {
            query = "SELECT CODIGO_USUARIO, NOMBRE, PERFIL FROM TB_USUARIO WHERE LOGIN_USUARIO = '"+pUsuario.pLogin+"' AND PASSWORD_USUARIO = '"+pUsuario.pPassword+"'; ";
            cls_EntidadUsuario usuario = null;
            drConsulta = clConexion.mConsultaGeneralByQuery(query);
           if (drConsulta.Read())
            {
                usuario = new cls_EntidadUsuario();
                usuario.pCodigo = drConsulta.GetValue(0).ToString();
                usuario.pNombre = drConsulta.GetValue(1).ToString();
                usuario.pPerfil = drConsulta.GetValue(2).ToString();
                query = "insert into TB_BITACORA(FECHA,REG_USUARIO)values(GETDATE(),'"+ usuario.pNombre + "');";
                clConexion.mBitacoraDB(query);
            }
            return usuario;
        }//fin del metodo validar usuario
        #endregion

      
    }
}
