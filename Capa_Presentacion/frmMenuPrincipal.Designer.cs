namespace Capa_Presentacion
{
    partial class frmMenuPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mCerrarSesion = new System.Windows.Forms.ToolStripMenuItem();
            this.mSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.mUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.smUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.mSeguridad = new System.Windows.Forms.ToolStripMenuItem();
            this.smRole = new System.Windows.Forms.ToolStripMenuItem();
            this.smVistas = new System.Windows.Forms.ToolStripMenuItem();
            this.smPermisos = new System.Windows.Forms.ToolStripMenuItem();
            this.mInventario = new System.Windows.Forms.ToolStripMenuItem();
            this.smControlInventario = new System.Windows.Forms.ToolStripMenuItem();
            this.mFacturacion = new System.Windows.Forms.ToolStripMenuItem();
            this.smRegistroFactura = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.mUsuarios,
            this.mSeguridad,
            this.mInventario,
            this.mFacturacion});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1032, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mCerrarSesion,
            this.mSalir});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // mCerrarSesion
            // 
            this.mCerrarSesion.Name = "mCerrarSesion";
            this.mCerrarSesion.Size = new System.Drawing.Size(143, 22);
            this.mCerrarSesion.Text = "Cerrar Sesión";
            this.mCerrarSesion.Click += new System.EventHandler(this.mCerrarSesion_Click);
            // 
            // mSalir
            // 
            this.mSalir.Name = "mSalir";
            this.mSalir.Size = new System.Drawing.Size(143, 22);
            this.mSalir.Text = "Salir";
            this.mSalir.Click += new System.EventHandler(this.mSalir_Click);
            // 
            // mUsuarios
            // 
            this.mUsuarios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smUsuario});
            this.mUsuarios.Name = "mUsuarios";
            this.mUsuarios.Size = new System.Drawing.Size(64, 20);
            this.mUsuarios.Text = "Usuarios";
            // 
            // smUsuario
            // 
            this.smUsuario.Name = "smUsuario";
            this.smUsuario.Size = new System.Drawing.Size(162, 22);
            this.smUsuario.Text = "Control Usuarios";
            this.smUsuario.Click += new System.EventHandler(this.smUsuario_Click);
            // 
            // mSeguridad
            // 
            this.mSeguridad.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smRole,
            this.smVistas,
            this.smPermisos});
            this.mSeguridad.Name = "mSeguridad";
            this.mSeguridad.Size = new System.Drawing.Size(72, 20);
            this.mSeguridad.Text = "Seguridad";
            // 
            // smRole
            // 
            this.smRole.Name = "smRole";
            this.smRole.Size = new System.Drawing.Size(181, 22);
            this.smRole.Text = "Control de Roles";
            this.smRole.Click += new System.EventHandler(this.smRole_Click);
            // 
            // smVistas
            // 
            this.smVistas.Name = "smVistas";
            this.smVistas.Size = new System.Drawing.Size(181, 22);
            this.smVistas.Text = "Control de Vistas";
            // 
            // smPermisos
            // 
            this.smPermisos.Name = "smPermisos";
            this.smPermisos.Size = new System.Drawing.Size(181, 22);
            this.smPermisos.Text = "Control de Permisos";
            this.smPermisos.Click += new System.EventHandler(this.smPermisos_Click);
            // 
            // mInventario
            // 
            this.mInventario.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smControlInventario});
            this.mInventario.Name = "mInventario";
            this.mInventario.Size = new System.Drawing.Size(72, 20);
            this.mInventario.Text = "Inventario";
            // 
            // smControlInventario
            // 
            this.smControlInventario.Name = "smControlInventario";
            this.smControlInventario.Size = new System.Drawing.Size(186, 22);
            this.smControlInventario.Text = "Control de inventario";
            // 
            // mFacturacion
            // 
            this.mFacturacion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smRegistroFactura});
            this.mFacturacion.Name = "mFacturacion";
            this.mFacturacion.Size = new System.Drawing.Size(81, 20);
            this.mFacturacion.Text = "Facturación";
            // 
            // smRegistroFactura
            // 
            this.smRegistroFactura.Name = "smRegistroFactura";
            this.smRegistroFactura.Size = new System.Drawing.Size(162, 22);
            this.smRegistroFactura.Text = "Registrar Factura";
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 452);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMenuPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mCerrarSesion;
        private System.Windows.Forms.ToolStripMenuItem mSalir;
        private System.Windows.Forms.ToolStripMenuItem mUsuarios;
        private System.Windows.Forms.ToolStripMenuItem smUsuario;
        private System.Windows.Forms.ToolStripMenuItem mSeguridad;
        private System.Windows.Forms.ToolStripMenuItem smRole;
        private System.Windows.Forms.ToolStripMenuItem smVistas;
        private System.Windows.Forms.ToolStripMenuItem smPermisos;
        private System.Windows.Forms.ToolStripMenuItem mInventario;
        private System.Windows.Forms.ToolStripMenuItem mFacturacion;
        private System.Windows.Forms.ToolStripMenuItem smControlInventario;
        private System.Windows.Forms.ToolStripMenuItem smRegistroFactura;
    }
}