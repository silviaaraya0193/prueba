using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_EntidadNegocio;

namespace Capa_Presentacion
{
    public partial class frmRole : Form
    {
        #region Atributos
        cls_EntidadPermiso credenciales;
        #endregion
        public frmRole(cls_EntidadPermiso pCredenciales)
        {
            InitializeComponent();
            credenciales = pCredenciales;
        }
        #region Form Load
        private void frmRole_Load(object sender, EventArgs e)
        {
            mCargarInicioSeguridad();//se ocultan los botones de la ventana para eliminar posbilidades de acceder
            mCargarCredenciales();//se activan aquellos botones de acuerdo a los permisos del usuario
        }
        private void mCargarInicioSeguridad() {
            btnGuardar.Visible = false;
            btnEliminar.Visible = false;
            btnModificar.Visible = false;
            btnConsultar.Visible = false;
        }
        /*-----------Activa las credenciales de un usuario-------------*/
        private void mCargarCredenciales() {
            if (credenciales.pSelect=="True") {
                btnConsultar.Visible = true;
            }
            if (credenciales.pInsert=="True")
            {
                btnGuardar.Visible = true;
            }
            if (credenciales.pUpdate == "True")
            {
                btnModificar.Visible = true;
            }
            if (credenciales.pDelete == "True")
            {
                btnEliminar.Visible = true;
            }
        }//fin del metodo que activa las credenciales
        #endregion

        #region Acciones
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        
    }
}
