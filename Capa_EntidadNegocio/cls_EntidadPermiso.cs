using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_EntidadNegocio
{
    public class cls_EntidadPermiso
    {
        #region Atributos
        private String codPermiso;
        private String codVista;
        private String select;
        private String insert;
        private String update;
        private String delete;
        private String nomVista;
        private String codUsuario;
        private String codRole;
        private String nomRole;
        #endregion

        #region "Constructor"
        public cls_EntidadPermiso()
        {
            pCodPermiso = "";
            pCodVista = "";
            pSelect = "";
            pInsert = "";
            pUpdate = "";
            pDelete = "";
            pNomVista = "";
            pCodUsuario = "";
            pCodRole = "";
            pNomRole = "";
        }
        #endregion


        #region Set/Get
        public String pCodPermiso {
            set { codPermiso = value; }
            get { return codPermiso; }
        }
        public String pCodVista
        {
            set { codVista = value; }
            get { return codVista; }
        }
        public String pSelect
        {
            set { select = value; }
            get { return select; }
        }
        public String pInsert
        {
            set { insert = value; }
            get { return insert; }
        }
        public String pUpdate
        {
            set { update = value; }
            get { return update; }
        }
        public String pDelete
        {
            set { delete = value; }
            get { return delete; }
        }
        public String pNomVista
        {
            set { nomVista = value; }
            get { return nomVista; }
        }
        public String pCodUsuario
        {
            set { codUsuario = value; }
            get { return codUsuario; }
        }
        public String pCodRole
        {
            set { codRole = value; }
            get { return codRole; }
        }
        public String pNomRole
        {
            set { nomRole = value; }
            get { return nomRole; }
        }
        #endregion
    }
}
