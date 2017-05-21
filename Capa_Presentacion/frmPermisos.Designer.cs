namespace Capa_Presentacion
{
    partial class frmPermisos
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
            this.components = new System.ComponentModel.Container();
            this.pnlBotones = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.tbctrlOpciones = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cbxSinAgregar = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lstRolesAgregados = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtCodigoUsuarioRole = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAgregarLista = new System.Windows.Forms.Button();
            this.checkDelete = new System.Windows.Forms.CheckBox();
            this.cbxVistas = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.checkUpdate = new System.Windows.Forms.CheckBox();
            this.checkInsert = new System.Windows.Forms.CheckBox();
            this.checkSelect = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCodigoUsuarioVista = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView1 = new System.Windows.Forms.ListView();
            this.txtCodigoPermiso = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pnlBotones.SuspendLayout();
            this.tbctrlOpciones.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBotones
            // 
            this.pnlBotones.Controls.Add(this.btnSalir);
            this.pnlBotones.Controls.Add(this.btnConsultar);
            this.pnlBotones.Controls.Add(this.btnEliminar);
            this.pnlBotones.Controls.Add(this.btnModificar);
            this.pnlBotones.Controls.Add(this.btnGuardar);
            this.pnlBotones.Controls.Add(this.btnLimpiar);
            this.pnlBotones.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBotones.Location = new System.Drawing.Point(0, 395);
            this.pnlBotones.Name = "pnlBotones";
            this.pnlBotones.Size = new System.Drawing.Size(1140, 61);
            this.pnlBotones.TabIndex = 1;
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(1028, 14);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(90, 35);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.Location = new System.Drawing.Point(169, 14);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(90, 35);
            this.btnConsultar.TabIndex = 4;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(628, 14);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(90, 35);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(466, 14);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(90, 35);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "Moficar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(323, 14);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(90, 35);
            this.btnGuardar.TabIndex = 1;
            this.btnGuardar.Text = "Agregar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(12, 14);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(90, 35);
            this.btnLimpiar.TabIndex = 0;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // tbctrlOpciones
            // 
            this.tbctrlOpciones.Controls.Add(this.tabPage1);
            this.tbctrlOpciones.Controls.Add(this.tabPage2);
            this.tbctrlOpciones.Controls.Add(this.tabPage3);
            this.tbctrlOpciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbctrlOpciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbctrlOpciones.ItemSize = new System.Drawing.Size(125, 22);
            this.tbctrlOpciones.Location = new System.Drawing.Point(0, 0);
            this.tbctrlOpciones.Name = "tbctrlOpciones";
            this.tbctrlOpciones.SelectedIndex = 0;
            this.tbctrlOpciones.Size = new System.Drawing.Size(1140, 395);
            this.tbctrlOpciones.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cbxSinAgregar);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.lstRolesAgregados);
            this.tabPage1.Controls.Add(this.txtCodigoUsuarioRole);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1132, 365);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Asignar Roles a Usuario";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cbxSinAgregar
            // 
            this.cbxSinAgregar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSinAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxSinAgregar.FormattingEnabled = true;
            this.cbxSinAgregar.Location = new System.Drawing.Point(198, 161);
            this.cbxSinAgregar.Name = "cbxSinAgregar";
            this.cbxSinAgregar.Size = new System.Drawing.Size(263, 32);
            this.cbxSinAgregar.TabIndex = 7;
            this.cbxSinAgregar.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Roles sin Agregar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(764, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Lista Roles Agregados";
            // 
            // lstRolesAgregados
            // 
            this.lstRolesAgregados.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lstRolesAgregados.GridLines = true;
            this.lstRolesAgregados.Location = new System.Drawing.Point(571, 46);
            this.lstRolesAgregados.Name = "lstRolesAgregados";
            this.lstRolesAgregados.Size = new System.Drawing.Size(519, 284);
            this.lstRolesAgregados.TabIndex = 4;
            this.lstRolesAgregados.UseCompatibleStateImageBehavior = false;
            this.lstRolesAgregados.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Código Role";
            this.columnHeader1.Width = 204;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nombre Role";
            this.columnHeader2.Width = 307;
            // 
            // txtCodigoUsuarioRole
            // 
            this.txtCodigoUsuarioRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoUsuarioRole.Location = new System.Drawing.Point(198, 29);
            this.txtCodigoUsuarioRole.Name = "txtCodigoUsuarioRole";
            this.txtCodigoUsuarioRole.Size = new System.Drawing.Size(163, 29);
            this.txtCodigoUsuarioRole.TabIndex = 3;
            this.txtCodigoUsuarioRole.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLogin_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Código Usuario";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.txtCodigoPermiso);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.listView1);
            this.tabPage2.Controls.Add(this.txtCodigoUsuarioVista);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1132, 365);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Asignar Permisos Directos";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAgregarLista);
            this.groupBox1.Controls.Add(this.checkDelete);
            this.groupBox1.Controls.Add(this.cbxVistas);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.checkUpdate);
            this.groupBox1.Controls.Add(this.checkInsert);
            this.groupBox1.Controls.Add(this.checkSelect);
            this.groupBox1.Location = new System.Drawing.Point(25, 104);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(363, 232);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Opciones";
            // 
            // btnAgregarLista
            // 
            this.btnAgregarLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarLista.Location = new System.Drawing.Point(82, 183);
            this.btnAgregarLista.Name = "btnAgregarLista";
            this.btnAgregarLista.Size = new System.Drawing.Size(147, 35);
            this.btnAgregarLista.TabIndex = 6;
            this.btnAgregarLista.Text = "Agregar a la Lista";
            this.btnAgregarLista.UseVisualStyleBackColor = true;
            this.btnAgregarLista.Click += new System.EventHandler(this.btnAgregarLista_Click);
            // 
            // checkDelete
            // 
            this.checkDelete.AutoSize = true;
            this.checkDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkDelete.Location = new System.Drawing.Point(207, 153);
            this.checkDelete.Name = "checkDelete";
            this.checkDelete.Size = new System.Drawing.Size(81, 24);
            this.checkDelete.TabIndex = 3;
            this.checkDelete.Text = "Delete";
            this.checkDelete.UseVisualStyleBackColor = true;
            // 
            // cbxVistas
            // 
            this.cbxVistas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxVistas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxVistas.FormattingEnabled = true;
            this.cbxVistas.Location = new System.Drawing.Point(82, 35);
            this.cbxVistas.Name = "cbxVistas";
            this.cbxVistas.Size = new System.Drawing.Size(263, 32);
            this.cbxVistas.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 24);
            this.label6.TabIndex = 8;
            this.label6.Text = "Vistas";
            // 
            // checkUpdate
            // 
            this.checkUpdate.AutoSize = true;
            this.checkUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkUpdate.Location = new System.Drawing.Point(207, 88);
            this.checkUpdate.Name = "checkUpdate";
            this.checkUpdate.Size = new System.Drawing.Size(87, 24);
            this.checkUpdate.TabIndex = 2;
            this.checkUpdate.Text = "Update";
            this.checkUpdate.UseVisualStyleBackColor = true;
            // 
            // checkInsert
            // 
            this.checkInsert.AutoSize = true;
            this.checkInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkInsert.Location = new System.Drawing.Point(42, 153);
            this.checkInsert.Name = "checkInsert";
            this.checkInsert.Size = new System.Drawing.Size(75, 24);
            this.checkInsert.TabIndex = 1;
            this.checkInsert.Text = "Insert";
            this.checkInsert.UseVisualStyleBackColor = true;
            // 
            // checkSelect
            // 
            this.checkSelect.AutoSize = true;
            this.checkSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkSelect.Location = new System.Drawing.Point(42, 88);
            this.checkSelect.Name = "checkSelect";
            this.checkSelect.Size = new System.Drawing.Size(79, 24);
            this.checkSelect.TabIndex = 0;
            this.checkSelect.Text = "Select";
            this.checkSelect.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(761, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(228, 24);
            this.label5.TabIndex = 7;
            this.label5.Text = "Lista Permisos Agregados";
            // 
            // txtCodigoUsuarioVista
            // 
            this.txtCodigoUsuarioVista.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoUsuarioVista.Location = new System.Drawing.Point(167, 25);
            this.txtCodigoUsuarioVista.Name = "txtCodigoUsuarioVista";
            this.txtCodigoUsuarioVista.Size = new System.Drawing.Size(163, 29);
            this.txtCodigoUsuarioVista.TabIndex = 5;
            this.txtCodigoUsuarioVista.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigoUsuario_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "Código Usuario";
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 26);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1132, 365);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Asignar Permisos a Roles";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Código";
            this.columnHeader3.Width = 137;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Vista";
            this.columnHeader4.Width = 222;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Select";
            this.columnHeader5.Width = 70;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Insert";
            this.columnHeader6.Width = 74;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Update";
            this.columnHeader7.Width = 73;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Delete";
            this.columnHeader8.Width = 76;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(422, 52);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(665, 284);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // txtCodigoPermiso
            // 
            this.txtCodigoPermiso.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoPermiso.Location = new System.Drawing.Point(167, 77);
            this.txtCodigoPermiso.Name = "txtCodigoPermiso";
            this.txtCodigoPermiso.Size = new System.Drawing.Size(163, 29);
            this.txtCodigoPermiso.TabIndex = 12;
            this.toolTip1.SetToolTip(this.txtCodigoPermiso, "Ingrese el codigo del permiso");
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(21, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 24);
            this.label7.TabIndex = 11;
            this.label7.Text = "Código Permiso";
            // 
            // frmPermisos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 456);
            this.Controls.Add(this.tbctrlOpciones);
            this.Controls.Add(this.pnlBotones);
            this.Name = "frmPermisos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control Permisos";
            this.Load += new System.EventHandler(this.frmPermisos_Load);
            this.pnlBotones.ResumeLayout(false);
            this.tbctrlOpciones.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBotones;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.TabControl tbctrlOpciones;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox txtCodigoUsuarioRole;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lstRolesAgregados;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ComboBox cbxSinAgregar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCodigoUsuarioVista;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAgregarLista;
        private System.Windows.Forms.CheckBox checkDelete;
        private System.Windows.Forms.ComboBox cbxVistas;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkUpdate;
        private System.Windows.Forms.CheckBox checkInsert;
        private System.Windows.Forms.CheckBox checkSelect;
        private System.Windows.Forms.TextBox txtCodigoPermiso;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
    }
}