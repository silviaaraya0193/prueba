using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_EntidadNegocio
{
   public class cls_EntidadUsuario
    {
        #region Atributos
        private String login;
        private String password;
        private String nombre;
        private String perfil;
        private String codigo;
        #endregion
        #region Set/Get
        public String pLogin {
            set {
                try
                {
                     login = value;
                }
                catch (Exception )
                {

                    throw new Exception("No se permiten campos en blanco");
                }
               
            }
            get { return login; }
        }
        public String pPassword
        {
            set
            {
                try
                {
                    password = value;
                }
                catch (Exception ex)
                {

                    throw new Exception("No se permiten campos en blanco");
                }
            }
            get { return password; }
        }
        public String pPerfil {
            set { perfil = value; }
            get { return perfil; }
        }
        public String pNombre
        {
            set { nombre = value; }
            get { return nombre; }
        }
        public String pCodigo {
            set { codigo = value; }
            get { return codigo; }
        }
        #endregion
        #region Constructor
        public cls_EntidadUsuario() {
            pPassword = "";
            pLogin = "";
            pNombre = "";
            pPerfil = "";
        }
        #endregion
    }
}
