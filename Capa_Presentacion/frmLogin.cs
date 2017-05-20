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
    public partial class frmLogin : Form
    {
        public static string pCodigoLogOn = "";


        #region Atributos
        private cls_EntidadUsuario clEUsuario;
        private cls_LogicaUsuario clControlUser;
        #endregion
        public frmLogin()
        {
            InitializeComponent();
            clEUsuario = new cls_EntidadUsuario();
            clControlUser = new cls_LogicaUsuario();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            pnlDatos.Visible = false;
        }

        #region Acciones
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            mIngresar();
        }
        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter){
                mConsultarLogin();
            }
        }
        #endregion

        private void mConsultarLogin() {
            if (txtLogin.Text != "" && txtPassword.Text != "")
            {
                clEUsuario.pLogin = txtLogin.Text.Trim();
                clEUsuario.pPassword = txtPassword.Text.Trim();
                clEUsuario = clControlUser.mValidarUsuario(clEUsuario);
                if (clEUsuario!=null) {
                    pnlDatos.Visible = true;
                    txtPerfil.Text = clEUsuario.pPerfil;
                    txtNombre.Text = clEUsuario.pNombre;
                    btnAceptar.Enabled = true;
                    pCodigoLogOn = clEUsuario.pCodigo;
                }
            }
            else {
                MessageBox.Show("Se necesitan datos","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }//fin del metod que consulta el login del usuario

        private void mIngresar() {
            frmMenuPrincipal menu = new frmMenuPrincipal(this);
            this.Hide();
            menu.Show();
        }//metodo que abre el menu para el usuario

        
    }
}
