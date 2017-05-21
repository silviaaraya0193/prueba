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
using Capa_LogicaNegocio;

namespace Capa_Presentacion
{
    public partial class frmMenuPrincipal : Form
    {
        #region Atributos
        frmLogin vLogin;
        cls_LogicaPermiso clControlPermiso;
        #endregion
        public frmMenuPrincipal(frmLogin plogin)
        {
            InitializeComponent();
            vLogin = plogin;
            clControlPermiso = new cls_LogicaPermiso();
        }//constructor

        #region loadForm 
        private void frmMenuPrincipal_Load(object sender, EventArgs e)
        {
            mCargarInicioMenu();
            mCargarPermisosUsuario();
            mMostrarCredencialesUsuarioLogOn();
        }
        /* con este metodo se ocultan el total de las opciones del menu para que luego se activen unicamente las que el usuario
         * cuenta con lo s debidos permisos para verlas.
         */
        private void mCargarInicioMenu() {
            mUsuarios.Visible = false;
            smUsuario.Visible = false;
            mSeguridad.Visible = false;
            smRole.Visible = false;
            smVistas.Visible = false;
            smPermisos.Visible = false;
            mInventario.Visible = false;
            mFacturacion.Visible = false;
            smRegistroFactura.Visible = false;
            smControlInventario.Visible = false;
        }//fin del metodo que carga la ventan de menu al inicio
        /*-------------------------Metodo que llama a cargar los permisos del usuario que se loguea------------*/
        private void mCargarPermisosUsuario() {
            clControlPermiso.mCargarPermisosRolesUsuario(frmLogin.pCodigoLogOn);
        }
        #endregion

        #region Acciones
        /*-----------------Menu de archivo--------------------*/
         private void mCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Close();
            vLogin.Show();
        }
        private void mSalir_Click(object sender, EventArgs e)
        {
            this.Close();
            vLogin.Close();
            this.Dispose();
        }

        /*-----------------------Menu Usuario-------------------*/
        private void smUsuario_Click(object sender, EventArgs e)
        {

        }
        
        /*-----------------------Menu seguridad-------------------*/
        private void smRole_Click(object sender, EventArgs e)
        {
            frmRole role = new frmRole(mGetCredencialEspecifica("Vista_Roles"));
            role.Show();
        }
        private void smPermisos_Click(object sender, EventArgs e)
        {
            frmPermisos permiso = new frmPermisos(mGetCredencialEspecifica("Vista_Permisos"));
            permiso.cargarRolesComboBox();
            permiso.ShowDialog();
        }
        #endregion

        #region Metodos
        /*-------------------------Metodo que obtine las credenciales de la ventana que se abre---------------*/
        private cls_EntidadPermiso mGetCredencialEspecifica(String vista)
        {
            cls_EntidadPermiso credencial = null;
            foreach (cls_EntidadPermiso permiso in clControlPermiso.getArregloPermisos)
            {
                if (permiso.pNomVista.Equals(vista)) {
                    credencial = permiso;
                }
            }
            return credencial;
        }

        /*--------Metodo que verifica las credenciales de un usuario y las envia a validacion de las mismas para mostrar a lo que se tiene permiso----------*/
        private void mMostrarCredencialesUsuarioLogOn() {
            foreach (cls_EntidadPermiso permiso in clControlPermiso.getArregloPermisos) {
                mActivacionVistasPorCredenciales(permiso.pNomVista);
            }
        }//fin del metodo que verifica las credenciales
        /*-----------------------Metodo que activa vistas de acuerdo a las credenciales del usuario----------------*/
        private void mActivacionVistasPorCredenciales(String vista) {
            switch(vista){
                case "Vista_Usuario":
                    mUsuarios.Visible = true;
                    smUsuario.Visible = true;//toot trip usuario
                    break;
                case "Vista_Permisos":
                    mSeguridad.Visible = true;
                    smPermisos.Visible = true;//tool trip permisos
                    break;
                case "Vista_Roles":
                    mSeguridad.Visible = true;
                    smRole.Visible = true;
                    break;
                case "Vista_Vistas":
                    mSeguridad.Visible = true;
                    smVistas.Visible = true;
                    break;
            }//fin del switch
        }//fin del metodo que activa las vistas del menu de acuerdo a las credenciales del usuario
        #endregion


       
    }
}
