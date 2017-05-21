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
using Capa_AccesoDatos;

namespace Capa_Presentacion
{
    public partial class frmPermisos : Form
    {
        
        #region Atributos
        cls_EntidadPermiso credenciales;
        private string[] roles;
        private string[] vistas;
        cls_Conexion conexion = new cls_Conexion();
        #endregion
        public frmPermisos(cls_EntidadPermiso pCredenciales)
        {
            InitializeComponent();
            credenciales = pCredenciales;
            cargarRolesComboBox();
            cargarRolesUtilizados();
            cargarVistas();
            this.cbxVistas.Enabled = false;
        }

        #region Form Load
        private void frmPermisos_Load(object sender, EventArgs e)
        {
            mCargarInicioSeguridad();//se ocultan los botones de la ventana para eliminar posbilidades de acceder
            mCargarCredenciales();//se activan aquellos botones de acuerdo a los permisos del usuario
        }
        private void mCargarInicioSeguridad()
        {
            btnGuardar.Visible = false;
            btnEliminar.Visible = false;
            btnModificar.Visible = false;
            btnConsultar.Visible = false;
        }
        /*-----------Activa las credenciales de un usuario-------------*/
        private void mCargarCredenciales()
        {
            if (credenciales.pSelect == "True")
            {
                btnConsultar.Visible = true;
            }
            if (credenciales.pInsert == "True")
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //cargarRolesUtilizados();
        }
        public void cargarRolesComboBox()
        {
            
            this.roles = conexion.mRetornarRolSinUso();
            Console.WriteLine("wtf roles size " + roles.Length);
            if (this.roles != null) {
                this.cbxSinAgregar.Items.Clear();
                for (int i = 0; i<roles.Length; i++)
                {
                    Console.WriteLine("wtf roles que trae " + roles[0]);
                    cbxSinAgregar.Items.Insert(i,roles[i]);
                }
                cbxSinAgregar.Enabled = true;
            }
            else
            {
                cbxSinAgregar.Items.Add("No existen roles");
                cbxSinAgregar.Enabled=false;
            }
        }
        //llama los roles que tienen usuarios, ademas los carga a e listview
        public void cargarRolesUtilizados()
        {
            
            // Define the list 
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            cargarVistas();
        }
        public void cargarVistas()
        {
            this.vistas = conexion.mVistasCreadas();
            if (this.vistas != null)
            {
                this.cbxVistas.Items.Clear();
                for (int i = 0; i < vistas.Length; i++)
                {
                    cbxVistas.Items.Insert(i, vistas[i]);
                }
                cbxVistas.Enabled = true;
            }
            else
            {
                cbxVistas.Items.Add("No existen vistas");
                cbxVistas.Enabled = false;
            }
        }

        private void txtLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                try
                {
                    if (conexion.mConsultarUsuario(Convert.ToInt32(this.txtCodigoUsuarioRole.Text.Trim()))) { 
                        this.cbxSinAgregar.Enabled = true;
                    }
                    else { 
                        this.cbxSinAgregar.Enabled = false;
                    MessageBox.Show("Este usuario no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception)
                {
                    
                    MessageBox.Show("Este usuario no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.cbxVistas.Enabled = false;
                }
            }

        }
        private void txtCodigoUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                try
                {
                    if (conexion.mConsultarUsuario(Convert.ToInt32(this.txtCodigoUsuarioVista.Text.Trim())))
                    {
                        this.cbxVistas.Enabled = true;
                        this.txtCodigoUsuarioVista.Enabled = false;
                    }
                    else
                    {
                        this.cbxVistas.Enabled = false;
                        this.txtCodigoUsuarioVista.Enabled = true;
                        MessageBox.Show("Este usuario no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Este usuario no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.cbxVistas.Enabled = false;
                }
            }

        }

        private void btnAgregarLista_Click(object sender, EventArgs e)
        {
            try
            {
                cls_EntidadPermiso permiso = new cls_EntidadPermiso();
                permiso.pCodPermiso = this.txtCodigoPermiso.Text.Trim();
                permiso.pCodVista = this.cbxVistas.SelectedItem.ToString();
                permiso.pSelect = Convert.ToString(this.checkSelect.Checked);
                permiso.pInsert = Convert.ToString(this.checkInsert.Checked);
                permiso.pDelete = Convert.ToString(this.checkDelete.Checked);
                permiso.pUpdate = Convert.ToString(this.checkUpdate.Checked);

                if (conexion.mPermisos(permiso))
                {
                    MessageBox.Show("Permiso agregado con exito", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    limpiar();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void limpiar()
        {

            this.txtCodigoPermiso.Text = "";
            this.txtCodigoUsuarioVista.Text = "";
            this.txtCodigoUsuarioVista.Enabled = true;
            this.cbxVistas.Enabled = false;
            this.checkDelete.Checked = false;
            this.checkInsert.Checked = false;
            this.checkSelect.Checked = false;
            this.checkUpdate.Checked = false;
        }
    }
}
