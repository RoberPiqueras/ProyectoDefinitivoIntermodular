namespace ProyectoIntermodularLinkBD
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbUsuario = new System.Windows.Forms.GroupBox();
            this.lblContadorColumnas = new System.Windows.Forms.Label();
            this.btanadirColumna = new System.Windows.Forms.Button();
            this.tbTrigger = new System.Windows.Forms.TextBox();
            this.tbProcedure = new System.Windows.Forms.TextBox();
            this.cbTrigger = new System.Windows.Forms.CheckBox();
            this.cbProcedure = new System.Windows.Forms.CheckBox();
            this.cbColumna = new System.Windows.Forms.CheckBox();
            this.cbTabla = new System.Windows.Forms.CheckBox();
            this.tbColumna = new System.Windows.Forms.TextBox();
            this.tbTabla = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnCrear = new System.Windows.Forms.Button();
            this.dataGV = new System.Windows.Forms.DataGridView();
            this.btConectar = new System.Windows.Forms.Button();
            this.btnCargar = new System.Windows.Forms.Button();
            this.cbAscendente = new System.Windows.Forms.CheckBox();
            this.cbDescendente = new System.Windows.Forms.CheckBox();
            this.gbOrdenar = new System.Windows.Forms.GroupBox();
            this.cbOrdenar = new System.Windows.Forms.CheckBox();
            this.tbOrdenar = new System.Windows.Forms.TextBox();
            this.gbOperaciones = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblImportante = new System.Windows.Forms.Label();
            this.gbAgrupar = new System.Windows.Forms.GroupBox();
            this.cbAgrupar = new System.Windows.Forms.CheckBox();
            this.tbAgrupar = new System.Windows.Forms.TextBox();
            this.cbDescendente1 = new System.Windows.Forms.CheckBox();
            this.cbAscendente1 = new System.Windows.Forms.CheckBox();
            this.gbSeleccionarBD = new System.Windows.Forms.GroupBox();
            this.cbBaseDatos = new System.Windows.Forms.ComboBox();
            this.tbQuery = new System.Windows.Forms.TextBox();
            this.gbAgregacion = new System.Windows.Forms.GroupBox();
            this.cbAgregacion = new System.Windows.Forms.CheckBox();
            this.cbMIN = new System.Windows.Forms.CheckBox();
            this.cbMAX = new System.Windows.Forms.CheckBox();
            this.cbAVG = new System.Windows.Forms.CheckBox();
            this.cbCOUNT = new System.Windows.Forms.CheckBox();
            this.cbSUM = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gbUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV)).BeginInit();
            this.gbOrdenar.SuspendLayout();
            this.gbOperaciones.SuspendLayout();
            this.gbAgrupar.SuspendLayout();
            this.gbSeleccionarBD.SuspendLayout();
            this.gbAgregacion.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbUsuario
            // 
            this.gbUsuario.Controls.Add(this.lblContadorColumnas);
            this.gbUsuario.Controls.Add(this.btanadirColumna);
            this.gbUsuario.Controls.Add(this.tbTrigger);
            this.gbUsuario.Controls.Add(this.tbProcedure);
            this.gbUsuario.Controls.Add(this.cbTrigger);
            this.gbUsuario.Controls.Add(this.cbProcedure);
            this.gbUsuario.Controls.Add(this.cbColumna);
            this.gbUsuario.Controls.Add(this.cbTabla);
            this.gbUsuario.Controls.Add(this.tbColumna);
            this.gbUsuario.Controls.Add(this.tbTabla);
            this.gbUsuario.Location = new System.Drawing.Point(12, 33);
            this.gbUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbUsuario.Name = "gbUsuario";
            this.gbUsuario.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbUsuario.Size = new System.Drawing.Size(449, 207);
            this.gbUsuario.TabIndex = 0;
            this.gbUsuario.TabStop = false;
            this.gbUsuario.Text = "Panel de Usuario";
            // 
            // lblContadorColumnas
            // 
            this.lblContadorColumnas.AutoSize = true;
            this.lblContadorColumnas.Location = new System.Drawing.Point(409, 79);
            this.lblContadorColumnas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContadorColumnas.Name = "lblContadorColumnas";
            this.lblContadorColumnas.Size = new System.Drawing.Size(14, 16);
            this.lblContadorColumnas.TabIndex = 18;
            this.lblContadorColumnas.Text = "0";
            // 
            // btanadirColumna
            // 
            this.btanadirColumna.Location = new System.Drawing.Point(276, 73);
            this.btanadirColumna.Margin = new System.Windows.Forms.Padding(4);
            this.btanadirColumna.Name = "btanadirColumna";
            this.btanadirColumna.Size = new System.Drawing.Size(116, 28);
            this.btanadirColumna.TabIndex = 17;
            this.btanadirColumna.Text = "AñadirColumna";
            this.btanadirColumna.UseVisualStyleBackColor = true;
            this.btanadirColumna.Click += new System.EventHandler(this.btanadirColumna_Click);
            // 
            // tbTrigger
            // 
            this.tbTrigger.Location = new System.Drawing.Point(133, 155);
            this.tbTrigger.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbTrigger.Name = "tbTrigger";
            this.tbTrigger.Size = new System.Drawing.Size(125, 22);
            this.tbTrigger.TabIndex = 15;
            // 
            // tbProcedure
            // 
            this.tbProcedure.Location = new System.Drawing.Point(133, 114);
            this.tbProcedure.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbProcedure.Name = "tbProcedure";
            this.tbProcedure.Size = new System.Drawing.Size(125, 22);
            this.tbProcedure.TabIndex = 14;
            // 
            // cbTrigger
            // 
            this.cbTrigger.AutoSize = true;
            this.cbTrigger.Location = new System.Drawing.Point(21, 159);
            this.cbTrigger.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbTrigger.Name = "cbTrigger";
            this.cbTrigger.Size = new System.Drawing.Size(73, 20);
            this.cbTrigger.TabIndex = 13;
            this.cbTrigger.Text = "Trigger";
            this.cbTrigger.UseVisualStyleBackColor = true;
            this.cbTrigger.CheckedChanged += new System.EventHandler(this.cbTrigger_CheckedChanged);
            // 
            // cbProcedure
            // 
            this.cbProcedure.AutoSize = true;
            this.cbProcedure.Location = new System.Drawing.Point(21, 117);
            this.cbProcedure.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbProcedure.Name = "cbProcedure";
            this.cbProcedure.Size = new System.Drawing.Size(92, 20);
            this.cbProcedure.TabIndex = 12;
            this.cbProcedure.Text = "Procedure";
            this.cbProcedure.UseVisualStyleBackColor = true;
            this.cbProcedure.CheckedChanged += new System.EventHandler(this.cbProcedure_CheckedChanged);
            // 
            // cbColumna
            // 
            this.cbColumna.AutoSize = true;
            this.cbColumna.Location = new System.Drawing.Point(21, 75);
            this.cbColumna.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbColumna.Name = "cbColumna";
            this.cbColumna.Size = new System.Drawing.Size(82, 20);
            this.cbColumna.TabIndex = 11;
            this.cbColumna.Text = "Columna";
            this.cbColumna.UseVisualStyleBackColor = true;
            this.cbColumna.CheckedChanged += new System.EventHandler(this.cbColumna_CheckedChanged);
            // 
            // cbTabla
            // 
            this.cbTabla.AutoSize = true;
            this.cbTabla.Location = new System.Drawing.Point(21, 39);
            this.cbTabla.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbTabla.Name = "cbTabla";
            this.cbTabla.Size = new System.Drawing.Size(65, 20);
            this.cbTabla.TabIndex = 10;
            this.cbTabla.Text = "Tabla";
            this.cbTabla.UseVisualStyleBackColor = true;
            this.cbTabla.CheckedChanged += new System.EventHandler(this.cbTabla_CheckedChanged);
            // 
            // tbColumna
            // 
            this.tbColumna.Location = new System.Drawing.Point(133, 75);
            this.tbColumna.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbColumna.Name = "tbColumna";
            this.tbColumna.Size = new System.Drawing.Size(125, 22);
            this.tbColumna.TabIndex = 7;
            // 
            // tbTabla
            // 
            this.tbTabla.Location = new System.Drawing.Point(133, 37);
            this.tbTabla.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbTabla.Name = "tbTabla";
            this.tbTabla.Size = new System.Drawing.Size(125, 22);
            this.tbTabla.TabIndex = 6;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(568, 23);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(172, 37);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(365, 23);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(177, 37);
            this.btnModificar.TabIndex = 4;
            this.btnModificar.Text = "MODIFICAR";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(13, 23);
            this.btnCrear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(149, 37);
            this.btnCrear.TabIndex = 3;
            this.btnCrear.Text = "CREAR";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // dataGV
            // 
            this.dataGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGV.Location = new System.Drawing.Point(693, 191);
            this.dataGV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGV.Name = "dataGV";
            this.dataGV.RowHeadersWidth = 51;
            this.dataGV.RowTemplate.Height = 24;
            this.dataGV.Size = new System.Drawing.Size(748, 407);
            this.dataGV.TabIndex = 1;
            // 
            // btConectar
            // 
            this.btConectar.Location = new System.Drawing.Point(9, 34);
            this.btConectar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btConectar.Name = "btConectar";
            this.btConectar.Size = new System.Drawing.Size(193, 60);
            this.btConectar.TabIndex = 2;
            this.btConectar.Text = "CONECTAR";
            this.btConectar.UseVisualStyleBackColor = true;
            this.btConectar.Click += new System.EventHandler(this.btConectar_Click);
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(9, 160);
            this.btnCargar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(193, 60);
            this.btnCargar.TabIndex = 3;
            this.btnCargar.Text = "CARGAR";
            this.btnCargar.UseVisualStyleBackColor = true;
            // 
            // cbAscendente
            // 
            this.cbAscendente.AutoSize = true;
            this.cbAscendente.Location = new System.Drawing.Point(21, 39);
            this.cbAscendente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbAscendente.Name = "cbAscendente";
            this.cbAscendente.Size = new System.Drawing.Size(101, 20);
            this.cbAscendente.TabIndex = 12;
            this.cbAscendente.Text = "Ascendente";
            this.cbAscendente.UseVisualStyleBackColor = true;
            this.cbAscendente.CheckedChanged += new System.EventHandler(this.cbAscendente_CheckedChanged);
            // 
            // cbDescendente
            // 
            this.cbDescendente.AutoSize = true;
            this.cbDescendente.Location = new System.Drawing.Point(284, 39);
            this.cbDescendente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbDescendente.Name = "cbDescendente";
            this.cbDescendente.Size = new System.Drawing.Size(110, 20);
            this.cbDescendente.TabIndex = 13;
            this.cbDescendente.Text = "Descendente";
            this.cbDescendente.UseVisualStyleBackColor = true;
            this.cbDescendente.CheckedChanged += new System.EventHandler(this.cbDescendente_CheckedChanged);
            // 
            // gbOrdenar
            // 
            this.gbOrdenar.Controls.Add(this.tbOrdenar);
            this.gbOrdenar.Controls.Add(this.cbAscendente);
            this.gbOrdenar.Controls.Add(this.cbDescendente);
            this.gbOrdenar.Location = new System.Drawing.Point(12, 258);
            this.gbOrdenar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbOrdenar.Name = "gbOrdenar";
            this.gbOrdenar.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbOrdenar.Size = new System.Drawing.Size(449, 121);
            this.gbOrdenar.TabIndex = 16;
            this.gbOrdenar.TabStop = false;
            // 
            // cbOrdenar
            // 
            this.cbOrdenar.AutoSize = true;
            this.cbOrdenar.Location = new System.Drawing.Point(12, 244);
            this.cbOrdenar.Name = "cbOrdenar";
            this.cbOrdenar.Size = new System.Drawing.Size(81, 20);
            this.cbOrdenar.TabIndex = 15;
            this.cbOrdenar.Text = "Ordenar:";
            this.cbOrdenar.UseVisualStyleBackColor = true;
            // 
            // tbOrdenar
            // 
            this.tbOrdenar.Location = new System.Drawing.Point(137, 76);
            this.tbOrdenar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbOrdenar.Name = "tbOrdenar";
            this.tbOrdenar.ReadOnly = true;
            this.tbOrdenar.Size = new System.Drawing.Size(127, 22);
            this.tbOrdenar.TabIndex = 14;
            // 
            // gbOperaciones
            // 
            this.gbOperaciones.Controls.Add(this.button1);
            this.gbOperaciones.Controls.Add(this.btnModificar);
            this.gbOperaciones.Controls.Add(this.btnCrear);
            this.gbOperaciones.Controls.Add(this.btnEliminar);
            this.gbOperaciones.Location = new System.Drawing.Point(693, 602);
            this.gbOperaciones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbOperaciones.Name = "gbOperaciones";
            this.gbOperaciones.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbOperaciones.Size = new System.Drawing.Size(748, 78);
            this.gbOperaciones.TabIndex = 17;
            this.gbOperaciones.TabStop = false;
            this.gbOperaciones.Text = "Operaciones";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(191, 23);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 37);
            this.button1.TabIndex = 6;
            this.button1.Text = "SELECCIONAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblImportante
            // 
            this.lblImportante.AutoSize = true;
            this.lblImportante.BackColor = System.Drawing.Color.Red;
            this.lblImportante.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImportante.Location = new System.Drawing.Point(382, -2);
            this.lblImportante.Name = "lblImportante";
            this.lblImportante.Size = new System.Drawing.Size(680, 32);
            this.lblImportante.TabIndex = 18;
            this.lblImportante.Text = "Si no se selecciona columna mostrara la tabla entera";
            // 
            // gbAgrupar
            // 
            this.gbAgrupar.Controls.Add(this.tbAgrupar);
            this.gbAgrupar.Controls.Add(this.cbDescendente1);
            this.gbAgrupar.Controls.Add(this.cbAscendente1);
            this.gbAgrupar.Location = new System.Drawing.Point(12, 402);
            this.gbAgrupar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbAgrupar.Name = "gbAgrupar";
            this.gbAgrupar.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbAgrupar.Size = new System.Drawing.Size(449, 140);
            this.gbAgrupar.TabIndex = 19;
            this.gbAgrupar.TabStop = false;
            // 
            // cbAgrupar
            // 
            this.cbAgrupar.AutoSize = true;
            this.cbAgrupar.Location = new System.Drawing.Point(12, 384);
            this.cbAgrupar.Name = "cbAgrupar";
            this.cbAgrupar.Size = new System.Drawing.Size(77, 20);
            this.cbAgrupar.TabIndex = 3;
            this.cbAgrupar.Text = "Agrupar";
            this.cbAgrupar.UseVisualStyleBackColor = true;
            // 
            // tbAgrupar
            // 
            this.tbAgrupar.Location = new System.Drawing.Point(137, 73);
            this.tbAgrupar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbAgrupar.Name = "tbAgrupar";
            this.tbAgrupar.ReadOnly = true;
            this.tbAgrupar.Size = new System.Drawing.Size(127, 22);
            this.tbAgrupar.TabIndex = 2;
            // 
            // cbDescendente1
            // 
            this.cbDescendente1.AutoSize = true;
            this.cbDescendente1.Location = new System.Drawing.Point(284, 37);
            this.cbDescendente1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbDescendente1.Name = "cbDescendente1";
            this.cbDescendente1.Size = new System.Drawing.Size(110, 20);
            this.cbDescendente1.TabIndex = 1;
            this.cbDescendente1.Text = "Descendente";
            this.cbDescendente1.UseVisualStyleBackColor = true;
            this.cbDescendente1.CheckedChanged += new System.EventHandler(this.cbDescendente1_CheckedChanged);
            // 
            // cbAscendente1
            // 
            this.cbAscendente1.AutoSize = true;
            this.cbAscendente1.Location = new System.Drawing.Point(20, 37);
            this.cbAscendente1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbAscendente1.Name = "cbAscendente1";
            this.cbAscendente1.Size = new System.Drawing.Size(101, 20);
            this.cbAscendente1.TabIndex = 0;
            this.cbAscendente1.Text = "Ascendente";
            this.cbAscendente1.UseVisualStyleBackColor = true;
            this.cbAscendente1.CheckedChanged += new System.EventHandler(this.cbAscendente1_CheckedChanged);
            // 
            // gbSeleccionarBD
            // 
            this.gbSeleccionarBD.Controls.Add(this.cbBaseDatos);
            this.gbSeleccionarBD.Location = new System.Drawing.Point(693, 47);
            this.gbSeleccionarBD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbSeleccionarBD.Name = "gbSeleccionarBD";
            this.gbSeleccionarBD.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbSeleccionarBD.Size = new System.Drawing.Size(748, 139);
            this.gbSeleccionarBD.TabIndex = 20;
            this.gbSeleccionarBD.TabStop = false;
            this.gbSeleccionarBD.Text = "Seleccion Base de Datos:";
            // 
            // cbBaseDatos
            // 
            this.cbBaseDatos.FormattingEnabled = true;
            this.cbBaseDatos.Location = new System.Drawing.Point(13, 50);
            this.cbBaseDatos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbBaseDatos.Name = "cbBaseDatos";
            this.cbBaseDatos.Size = new System.Drawing.Size(725, 24);
            this.cbBaseDatos.TabIndex = 0;
            this.cbBaseDatos.SelectedIndexChanged += new System.EventHandler(this.cbBaseDatos_SelectedIndexChanged);
            // 
            // tbQuery
            // 
            this.tbQuery.Location = new System.Drawing.Point(13, 548);
            this.tbQuery.Margin = new System.Windows.Forms.Padding(4);
            this.tbQuery.Multiline = true;
            this.tbQuery.Name = "tbQuery";
            this.tbQuery.ReadOnly = true;
            this.tbQuery.Size = new System.Drawing.Size(664, 132);
            this.tbQuery.TabIndex = 21;
            this.tbQuery.Text = "Escribe aqui, tanto el Trigger como el Procedure:";
            this.tbQuery.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gbAgregacion
            // 
            this.gbAgregacion.Controls.Add(this.cbMIN);
            this.gbAgregacion.Controls.Add(this.cbMAX);
            this.gbAgregacion.Controls.Add(this.cbAVG);
            this.gbAgregacion.Controls.Add(this.cbCOUNT);
            this.gbAgregacion.Controls.Add(this.cbSUM);
            this.gbAgregacion.Location = new System.Drawing.Point(468, 67);
            this.gbAgregacion.Margin = new System.Windows.Forms.Padding(4);
            this.gbAgregacion.Name = "gbAgregacion";
            this.gbAgregacion.Padding = new System.Windows.Forms.Padding(4);
            this.gbAgregacion.Size = new System.Drawing.Size(211, 173);
            this.gbAgregacion.TabIndex = 22;
            this.gbAgregacion.TabStop = false;
            // 
            // cbAgregacion
            // 
            this.cbAgregacion.AutoSize = true;
            this.cbAgregacion.Location = new System.Drawing.Point(477, 47);
            this.cbAgregacion.Name = "cbAgregacion";
            this.cbAgregacion.Size = new System.Drawing.Size(185, 20);
            this.cbAgregacion.TabIndex = 5;
            this.cbAgregacion.Text = "Funciones de agregación:";
            this.cbAgregacion.UseVisualStyleBackColor = true;
            this.cbAgregacion.CheckedChanged += new System.EventHandler(this.cbAgregacion_CheckedChanged);
            // 
            // cbMIN
            // 
            this.cbMIN.AutoSize = true;
            this.cbMIN.Location = new System.Drawing.Point(57, 150);
            this.cbMIN.Margin = new System.Windows.Forms.Padding(4);
            this.cbMIN.Name = "cbMIN";
            this.cbMIN.Size = new System.Drawing.Size(53, 20);
            this.cbMIN.TabIndex = 4;
            this.cbMIN.Text = "MIN";
            this.cbMIN.UseVisualStyleBackColor = true;
            // 
            // cbMAX
            // 
            this.cbMAX.AutoSize = true;
            this.cbMAX.Location = new System.Drawing.Point(57, 116);
            this.cbMAX.Margin = new System.Windows.Forms.Padding(4);
            this.cbMAX.Name = "cbMAX";
            this.cbMAX.Size = new System.Drawing.Size(57, 20);
            this.cbMAX.TabIndex = 3;
            this.cbMAX.Text = "MAX";
            this.cbMAX.UseVisualStyleBackColor = true;
            // 
            // cbAVG
            // 
            this.cbAVG.AutoSize = true;
            this.cbAVG.Location = new System.Drawing.Point(57, 82);
            this.cbAVG.Margin = new System.Windows.Forms.Padding(4);
            this.cbAVG.Name = "cbAVG";
            this.cbAVG.Size = new System.Drawing.Size(57, 20);
            this.cbAVG.TabIndex = 2;
            this.cbAVG.Text = "AVG";
            this.cbAVG.UseVisualStyleBackColor = true;
            // 
            // cbCOUNT
            // 
            this.cbCOUNT.AutoSize = true;
            this.cbCOUNT.Location = new System.Drawing.Point(57, 50);
            this.cbCOUNT.Margin = new System.Windows.Forms.Padding(4);
            this.cbCOUNT.Name = "cbCOUNT";
            this.cbCOUNT.Size = new System.Drawing.Size(77, 20);
            this.cbCOUNT.TabIndex = 1;
            this.cbCOUNT.Text = "COUNT";
            this.cbCOUNT.UseVisualStyleBackColor = true;
            // 
            // cbSUM
            // 
            this.cbSUM.AutoSize = true;
            this.cbSUM.Location = new System.Drawing.Point(57, 20);
            this.cbSUM.Margin = new System.Windows.Forms.Padding(4);
            this.cbSUM.Name = "cbSUM";
            this.cbSUM.Size = new System.Drawing.Size(59, 20);
            this.cbSUM.TabIndex = 0;
            this.cbSUM.Text = "SUM";
            this.cbSUM.UseVisualStyleBackColor = true;
            this.cbSUM.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btConectar);
            this.groupBox1.Controls.Add(this.btnCargar);
            this.groupBox1.Location = new System.Drawing.Point(468, 258);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(209, 284);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1456, 704);
            this.Controls.Add(this.cbOrdenar);
            this.Controls.Add(this.cbAgrupar);
            this.Controls.Add(this.cbAgregacion);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbAgregacion);
            this.Controls.Add(this.tbQuery);
            this.Controls.Add(this.gbSeleccionarBD);
            this.Controls.Add(this.gbAgrupar);
            this.Controls.Add(this.lblImportante);
            this.Controls.Add(this.gbOperaciones);
            this.Controls.Add(this.gbOrdenar);
            this.Controls.Add(this.dataGV);
            this.Controls.Add(this.gbUsuario);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbUsuario.ResumeLayout(false);
            this.gbUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV)).EndInit();
            this.gbOrdenar.ResumeLayout(false);
            this.gbOrdenar.PerformLayout();
            this.gbOperaciones.ResumeLayout(false);
            this.gbAgrupar.ResumeLayout(false);
            this.gbAgrupar.PerformLayout();
            this.gbSeleccionarBD.ResumeLayout(false);
            this.gbAgregacion.ResumeLayout(false);
            this.gbAgregacion.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbUsuario;
        private System.Windows.Forms.DataGridView dataGV;
        private System.Windows.Forms.Button btConectar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.CheckBox cbColumna;
        private System.Windows.Forms.CheckBox cbTabla;
        private System.Windows.Forms.TextBox tbColumna;
        private System.Windows.Forms.TextBox tbTabla;
        private System.Windows.Forms.CheckBox cbAscendente;
        private System.Windows.Forms.CheckBox cbDescendente;
        private System.Windows.Forms.GroupBox gbOrdenar;
        private System.Windows.Forms.GroupBox gbOperaciones;
        private System.Windows.Forms.Label lblImportante;
        private System.Windows.Forms.TextBox tbOrdenar;
        private System.Windows.Forms.GroupBox gbAgrupar;
        private System.Windows.Forms.TextBox tbAgrupar;
        private System.Windows.Forms.CheckBox cbDescendente1;
        private System.Windows.Forms.CheckBox cbAscendente1;
        private System.Windows.Forms.GroupBox gbSeleccionarBD;
        private System.Windows.Forms.ComboBox cbBaseDatos;
        private System.Windows.Forms.TextBox tbTrigger;
        private System.Windows.Forms.TextBox tbProcedure;
        private System.Windows.Forms.CheckBox cbTrigger;
        private System.Windows.Forms.CheckBox cbProcedure;
        private System.Windows.Forms.TextBox tbQuery;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btanadirColumna;
        private System.Windows.Forms.GroupBox gbAgregacion;
        private System.Windows.Forms.CheckBox cbSUM;
        private System.Windows.Forms.CheckBox cbMIN;
        private System.Windows.Forms.CheckBox cbMAX;
        private System.Windows.Forms.CheckBox cbAVG;
        private System.Windows.Forms.CheckBox cbCOUNT;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblContadorColumnas;
        private System.Windows.Forms.CheckBox cbOrdenar;
        private System.Windows.Forms.CheckBox cbAgregacion;
        private System.Windows.Forms.CheckBox cbAgrupar;
    }
}

