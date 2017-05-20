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
    public class cls_LogicaPermiso
    {
        #region Atributos
        private ArrayList arregloPermisos;
        private SqlDataReader drConsulta;
        private cls_Conexion clConexion;

        private String query;
        #endregion
        public cls_LogicaPermiso()
        {
            clConexion = new cls_Conexion();
            arregloPermisos = new ArrayList();
        }//fin del constructor

        #region Metodos

        /*-----------------------------metodo que trae los permisos de apliacion para el usuario---------------------*/
        public void mCargarPermisosRolesUsuario(String codigo)
        {
            drConsulta = clConexion.mSPSelectPermisosRolesUsuario(codigo);
            while (drConsulta.Read())
            {
                cls_EntidadPermiso permiso = new cls_EntidadPermiso();
                permiso.pCodPermiso = drConsulta.GetValue(0).ToString();
                permiso.pSelect = drConsulta.GetValue(1).ToString();
                permiso.pUpdate = drConsulta.GetValue(2).ToString();
                permiso.pInsert = drConsulta.GetValue(3).ToString();
                permiso.pDelete = drConsulta.GetValue(4).ToString();
                permiso.pNomVista = drConsulta.GetValue(5).ToString();
                arregloPermisos.Add(permiso);
            }
        }//fin del metodo que obtiene el total de los permisos asignados por roles a un usuario
        #endregion



        #region Set/Get
        public ArrayList getArregloPermisos
        {
            set { arregloPermisos = value; }
            get { return arregloPermisos; }
        }
        #endregion

    }
}
