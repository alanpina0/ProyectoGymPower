namespace view
{
    partial class pMembresias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pMembresias));
            btregresar = new Panel();
            textBox1 = new TextBox();
            btnPagar = new Button();
            btnGuardar = new Button();
            monthCalendar1 = new MonthCalendar();
            btnFecha = new Button();
            txtFecha = new TextBox();
            lbFecha = new Label();
            txtCorreo = new TextBox();
            telefonotxt = new TextBox();
            Telefono = new Label();
            lbCorreo = new Label();
            hombre = new RadioButton();
            mujer = new RadioButton();
            lbSexo = new Label();
            nombrebx = new TextBox();
            apellidobx = new TextBox();
            lbNombre = new Label();
            lbApellido = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            btnRenovarM = new Button();
            txtDias = new TextBox();
            btnEliminar = new Button();
            btnModificar = new Button();
            label2 = new Label();
            cAsistencia = new CheckBox();
            btnActivo = new Button();
            txtMembresia = new TextBox();
            txtId = new TextBox();
            btnBuscar = new Button();
            txtBuscador = new TextBox();
            tablaMiembros = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            nombre = new DataGridViewTextBoxColumn();
            apellido = new DataGridViewTextBoxColumn();
            membresia = new DataGridViewTextBoxColumn();
            dias = new DataGridViewTextBoxColumn();
            btvolver = new PictureBox();
            btcerrar = new Button();
            bminimizar = new Button();
            btregresar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tablaMiembros).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btvolver).BeginInit();
            SuspendLayout();
            // 
            // btregresar
            // 
            btregresar.BackColor = SystemColors.ScrollBar;
            btregresar.Controls.Add(textBox1);
            btregresar.Controls.Add(btnPagar);
            btregresar.Controls.Add(btnGuardar);
            btregresar.Controls.Add(monthCalendar1);
            btregresar.Controls.Add(btnFecha);
            btregresar.Controls.Add(txtFecha);
            btregresar.Controls.Add(lbFecha);
            btregresar.Controls.Add(txtCorreo);
            btregresar.Controls.Add(telefonotxt);
            btregresar.Controls.Add(Telefono);
            btregresar.Controls.Add(lbCorreo);
            btregresar.Controls.Add(hombre);
            btregresar.Controls.Add(mujer);
            btregresar.Controls.Add(lbSexo);
            btregresar.Controls.Add(nombrebx);
            btregresar.Controls.Add(apellidobx);
            btregresar.Controls.Add(lbNombre);
            btregresar.Controls.Add(lbApellido);
            btregresar.Controls.Add(label4);
            btregresar.Controls.Add(label3);
            btregresar.Controls.Add(label1);
            btregresar.Controls.Add(btnRenovarM);
            btregresar.Controls.Add(txtDias);
            btregresar.Controls.Add(btnEliminar);
            btregresar.Controls.Add(btnModificar);
            btregresar.Controls.Add(label2);
            btregresar.Controls.Add(cAsistencia);
            btregresar.Controls.Add(btnActivo);
            btregresar.Controls.Add(txtMembresia);
            btregresar.Controls.Add(txtId);
            btregresar.Controls.Add(btnBuscar);
            btregresar.Controls.Add(txtBuscador);
            btregresar.Controls.Add(tablaMiembros);
            btregresar.Controls.Add(btvolver);
            btregresar.Controls.Add(btcerrar);
            btregresar.Controls.Add(bminimizar);
            btregresar.Location = new Point(0, 1);
            btregresar.Name = "btregresar";
            btregresar.Size = new Size(1358, 812);
            btregresar.TabIndex = 0;
            btregresar.Paint += btregresar_Paint;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Silver;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(1180, 764);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(112, 33);
            textBox1.TabIndex = 46;
            textBox1.Visible = false;
            // 
            // btnPagar
            // 
            btnPagar.BackColor = Color.Red;
            btnPagar.Font = new Font("Arial Rounded MT Bold", 13F, FontStyle.Italic, GraphicsUnit.Point, 0);
            btnPagar.ForeColor = Color.White;
            btnPagar.Location = new Point(1193, 501);
            btnPagar.Name = "btnPagar";
            btnPagar.Size = new Size(112, 43);
            btnPagar.TabIndex = 45;
            btnPagar.Text = "Pagar";
            btnPagar.UseVisualStyleBackColor = false;
            btnPagar.Visible = false;
            btnPagar.Click += btnPagar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.DarkGreen;
            btnGuardar.FlatAppearance.BorderSize = 0;
            btnGuardar.Font = new Font("Arial Rounded MT Bold", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(1180, 659);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(141, 51);
            btnGuardar.TabIndex = 44;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Visible = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // monthCalendar1
            // 
            monthCalendar1.BackColor = SystemColors.Info;
            monthCalendar1.ForeColor = Color.YellowGreen;
            monthCalendar1.Location = new Point(22, 534);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 43;
            monthCalendar1.Visible = false;
            monthCalendar1.DateSelected += monthCalendar1_DateSelected;
            // 
            // btnFecha
            // 
            btnFecha.AutoEllipsis = true;
            btnFecha.BackColor = Color.Khaki;
            btnFecha.FlatAppearance.BorderColor = SystemColors.ActiveBorder;
            btnFecha.FlatAppearance.BorderSize = 0;
            btnFecha.FlatAppearance.MouseDownBackColor = Color.DimGray;
            btnFecha.FlatAppearance.MouseOverBackColor = Color.Silver;
            btnFecha.FlatStyle = FlatStyle.Flat;
            btnFecha.Font = new Font("Segoe UI", 6F);
            btnFecha.Image = (Image)resources.GetObject("btnFecha.Image");
            btnFecha.Location = new Point(753, 659);
            btnFecha.Name = "btnFecha";
            btnFecha.Size = new Size(49, 33);
            btnFecha.TabIndex = 42;
            btnFecha.UseVisualStyleBackColor = false;
            btnFecha.Visible = false;
            btnFecha.Click += btnFecha_Click;
            // 
            // txtFecha
            // 
            txtFecha.BackColor = SystemColors.Window;
            txtFecha.BorderStyle = BorderStyle.None;
            txtFecha.Location = new Point(595, 665);
            txtFecha.Name = "txtFecha";
            txtFecha.ReadOnly = true;
            txtFecha.Size = new Size(121, 24);
            txtFecha.TabIndex = 41;
            txtFecha.Visible = false;
            txtFecha.KeyPress += txtFecha_KeyPress;
            // 
            // lbFecha
            // 
            lbFecha.AutoSize = true;
            lbFecha.FlatStyle = FlatStyle.Flat;
            lbFecha.Font = new Font("Arial Rounded MT Bold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbFecha.Location = new Point(381, 666);
            lbFecha.Name = "lbFecha";
            lbFecha.Size = new Size(185, 23);
            lbFecha.TabIndex = 40;
            lbFecha.Text = "Fecha Nacimiento";
            lbFecha.Visible = false;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(590, 764);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(223, 31);
            txtCorreo.TabIndex = 39;
            txtCorreo.Visible = false;
            txtCorreo.KeyDown += txtCorreo_KeyDown;
            txtCorreo.KeyPress += txtCorreo_KeyPress;
            txtCorreo.Leave += txtCorreo_Leave;
            // 
            // telefonotxt
            // 
            telefonotxt.Location = new Point(590, 709);
            telefonotxt.Name = "telefonotxt";
            telefonotxt.Size = new Size(223, 31);
            telefonotxt.TabIndex = 37;
            telefonotxt.Visible = false;
            telefonotxt.KeyPress += textBox1_KeyPress;
            // 
            // Telefono
            // 
            Telefono.AutoSize = true;
            Telefono.FlatStyle = FlatStyle.Flat;
            Telefono.Font = new Font("Arial Rounded MT Bold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Telefono.Location = new Point(452, 717);
            Telefono.Name = "Telefono";
            Telefono.Size = new Size(100, 23);
            Telefono.TabIndex = 36;
            Telefono.Text = "Teléfono ";
            Telefono.Visible = false;
            // 
            // lbCorreo
            // 
            lbCorreo.AutoSize = true;
            lbCorreo.FlatStyle = FlatStyle.Flat;
            lbCorreo.Font = new Font("Arial Rounded MT Bold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbCorreo.Location = new Point(370, 764);
            lbCorreo.Name = "lbCorreo";
            lbCorreo.Size = new Size(195, 23);
            lbCorreo.TabIndex = 38;
            lbCorreo.Text = "Correo Electronico";
            lbCorreo.Visible = false;
            // 
            // hombre
            // 
            hombre.AutoSize = true;
            hombre.Location = new Point(595, 624);
            hombre.Name = "hombre";
            hombre.Size = new Size(103, 29);
            hombre.TabIndex = 34;
            hombre.TabStop = true;
            hombre.Text = "Hombre";
            hombre.UseVisualStyleBackColor = true;
            hombre.Visible = false;
            // 
            // mujer
            // 
            mujer.AutoSize = true;
            mujer.Location = new Point(720, 624);
            mujer.Name = "mujer";
            mujer.Size = new Size(82, 29);
            mujer.TabIndex = 33;
            mujer.TabStop = true;
            mujer.Text = "Mujer";
            mujer.UseVisualStyleBackColor = true;
            mujer.Visible = false;
            // 
            // lbSexo
            // 
            lbSexo.AutoSize = true;
            lbSexo.FlatStyle = FlatStyle.Flat;
            lbSexo.Font = new Font("Arial Rounded MT Bold", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbSexo.Location = new Point(509, 631);
            lbSexo.Name = "lbSexo";
            lbSexo.Size = new Size(47, 18);
            lbSexo.TabIndex = 35;
            lbSexo.Text = "Sexo";
            lbSexo.Visible = false;
            // 
            // nombrebx
            // 
            nombrebx.BackColor = SystemColors.ControlLightLight;
            nombrebx.Location = new Point(590, 540);
            nombrebx.Name = "nombrebx";
            nombrebx.Size = new Size(223, 31);
            nombrebx.TabIndex = 31;
            nombrebx.Visible = false;
            nombrebx.KeyPress += nombrebx_KeyPress;
            // 
            // apellidobx
            // 
            apellidobx.BackColor = SystemColors.ControlLightLight;
            apellidobx.Location = new Point(590, 583);
            apellidobx.Name = "apellidobx";
            apellidobx.Size = new Size(223, 31);
            apellidobx.TabIndex = 32;
            apellidobx.Visible = false;
            apellidobx.KeyPress += apellidobx_KeyPress;
            // 
            // lbNombre
            // 
            lbNombre.AutoSize = true;
            lbNombre.Font = new Font("Arial Rounded MT Bold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbNombre.Location = new Point(451, 540);
            lbNombre.Name = "lbNombre";
            lbNombre.Size = new Size(114, 23);
            lbNombre.TabIndex = 29;
            lbNombre.Text = "Nombre(s)";
            lbNombre.Visible = false;
            // 
            // lbApellido
            // 
            lbApellido.AutoSize = true;
            lbApellido.FlatStyle = FlatStyle.Flat;
            lbApellido.Font = new Font("Arial Rounded MT Bold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbApellido.Location = new Point(451, 587);
            lbApellido.Name = "lbApellido";
            lbApellido.Size = new Size(114, 23);
            lbApellido.TabIndex = 30;
            lbApellido.Text = "Apellido(s)";
            lbApellido.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(854, 415);
            label4.Name = "label4";
            label4.Size = new Size(75, 32);
            label4.TabIndex = 28;
            label4.Text = "Tipo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(866, 265);
            label3.Name = "label3";
            label3.Size = new Size(31, 23);
            label3.TabIndex = 27;
            label3.Text = "ID";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(866, 349);
            label1.Name = "label1";
            label1.Size = new Size(156, 23);
            label1.TabIndex = 26;
            label1.Text = "Días Restantes";
            // 
            // btnRenovarM
            // 
            btnRenovarM.BackColor = Color.MidnightBlue;
            btnRenovarM.FlatAppearance.BorderSize = 0;
            btnRenovarM.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnRenovarM.ForeColor = Color.White;
            btnRenovarM.Location = new Point(854, 494);
            btnRenovarM.Name = "btnRenovarM";
            btnRenovarM.Size = new Size(304, 58);
            btnRenovarM.TabIndex = 25;
            btnRenovarM.Text = "Renovar Membresia";
            btnRenovarM.UseVisualStyleBackColor = false;
            btnRenovarM.Visible = false;
            btnRenovarM.Click += btnRenovarM_Click;
            // 
            // txtDias
            // 
            txtDias.BackColor = Color.LightGray;
            txtDias.Enabled = false;
            txtDias.Font = new Font("Arial Rounded MT Bold", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDias.ForeColor = Color.Black;
            txtDias.Location = new Point(1065, 339);
            txtDias.Name = "txtDias";
            txtDias.Size = new Size(80, 40);
            txtDias.TabIndex = 24;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.DarkRed;
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEliminar.ForeColor = Color.White;
            btnEliminar.Location = new Point(1031, 575);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(127, 45);
            btnEliminar.TabIndex = 23;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Visible = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = SystemColors.HighlightText;
            btnModificar.FlatAppearance.BorderSize = 0;
            btnModificar.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnModificar.ForeColor = Color.Black;
            btnModificar.Location = new Point(866, 575);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(141, 45);
            btnModificar.TabIndex = 22;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Visible = false;
            btnModificar.Click += btnModificar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Artifakt Element Heavy", 18F);
            label2.Location = new Point(453, 46);
            label2.Name = "label2";
            label2.Size = new Size(255, 51);
            label2.TabIndex = 21;
            label2.Text = "     Miembros  ";
            label2.Click += label2_Click;
            // 
            // cAsistencia
            // 
            cAsistencia.AutoSize = true;
            cAsistencia.Font = new Font("Yu Gothic UI Semibold", 10F);
            cAsistencia.Location = new Point(1180, 257);
            cAsistencia.Name = "cAsistencia";
            cAsistencia.Size = new Size(128, 32);
            cAsistencia.TabIndex = 20;
            cAsistencia.Text = "Asistencia";
            cAsistencia.TextAlign = ContentAlignment.MiddleCenter;
            cAsistencia.UseVisualStyleBackColor = true;
            cAsistencia.Visible = false;
            cAsistencia.CheckedChanged += cAsistencia_CheckedChanged;
            // 
            // btnActivo
            // 
            btnActivo.Enabled = false;
            btnActivo.FlatAppearance.BorderSize = 0;
            btnActivo.Location = new Point(1077, 232);
            btnActivo.Name = "btnActivo";
            btnActivo.Size = new Size(80, 80);
            btnActivo.TabIndex = 19;
            btnActivo.UseVisualStyleBackColor = true;
            // 
            // txtMembresia
            // 
            txtMembresia.Enabled = false;
            txtMembresia.Font = new Font("Arial Rounded MT Bold", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMembresia.Location = new Point(947, 407);
            txtMembresia.Name = "txtMembresia";
            txtMembresia.Size = new Size(125, 40);
            txtMembresia.TabIndex = 18;
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Font = new Font("Arial Rounded MT Bold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtId.Location = new Point(912, 257);
            txtId.Name = "txtId";
            txtId.Size = new Size(125, 31);
            txtId.TabIndex = 17;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = Color.SkyBlue;
            btnBuscar.FlatAppearance.BorderColor = Color.Black;
            btnBuscar.FlatAppearance.MouseDownBackColor = Color.Blue;
            btnBuscar.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 0, 64);
            btnBuscar.Image = (Image)resources.GetObject("btnBuscar.Image");
            btnBuscar.Location = new Point(1169, 169);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(123, 49);
            btnBuscar.TabIndex = 16;
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtBuscador
            // 
            txtBuscador.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBuscador.Location = new Point(853, 175);
            txtBuscador.Name = "txtBuscador";
            txtBuscador.Size = new Size(292, 35);
            txtBuscador.TabIndex = 15;
            // 
            // tablaMiembros
            // 
            tablaMiembros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tablaMiembros.Columns.AddRange(new DataGridViewColumn[] { id, nombre, apellido, membresia, dias });
            tablaMiembros.Location = new Point(22, 179);
            tablaMiembros.Name = "tablaMiembros";
            tablaMiembros.RowHeadersWidth = 62;
            tablaMiembros.Size = new Size(787, 308);
            tablaMiembros.TabIndex = 14;
            tablaMiembros.CellContentClick += tablaMiembros_CellContentClick;
            // 
            // id
            // 
            id.HeaderText = "ID";
            id.MinimumWidth = 8;
            id.Name = "id";
            id.Width = 150;
            // 
            // nombre
            // 
            nombre.HeaderText = "Nombre";
            nombre.MinimumWidth = 8;
            nombre.Name = "nombre";
            nombre.Width = 150;
            // 
            // apellido
            // 
            apellido.HeaderText = "Apellidos";
            apellido.MinimumWidth = 8;
            apellido.Name = "apellido";
            apellido.Width = 150;
            // 
            // membresia
            // 
            membresia.HeaderText = "Membresía";
            membresia.MinimumWidth = 8;
            membresia.Name = "membresia";
            membresia.Width = 150;
            // 
            // dias
            // 
            dias.HeaderText = "Días M";
            dias.MinimumWidth = 8;
            dias.Name = "dias";
            dias.Width = 150;
            // 
            // btvolver
            // 
            btvolver.Image = (Image)resources.GetObject("btvolver.Image");
            btvolver.Location = new Point(1180, 15);
            btvolver.Name = "btvolver";
            btvolver.Size = new Size(66, 67);
            btvolver.TabIndex = 13;
            btvolver.TabStop = false;
            btvolver.Click += btvolver_Click;
            // 
            // btcerrar
            // 
            btcerrar.BackColor = SystemColors.ScrollBar;
            btcerrar.FlatAppearance.BorderSize = 0;
            btcerrar.FlatAppearance.MouseDownBackColor = SystemColors.Control;
            btcerrar.FlatAppearance.MouseOverBackColor = SystemColors.Control;
            btcerrar.FlatStyle = FlatStyle.Flat;
            btcerrar.Image = (Image)resources.GetObject("btcerrar.Image");
            btcerrar.Location = new Point(1267, 13);
            btcerrar.Name = "btcerrar";
            btcerrar.Size = new Size(72, 66);
            btcerrar.TabIndex = 12;
            btcerrar.UseVisualStyleBackColor = false;
            btcerrar.Click += btcerrar_Click;
            // 
            // bminimizar
            // 
            bminimizar.BackColor = Color.Silver;
            bminimizar.FlatAppearance.BorderSize = 0;
            bminimizar.FlatAppearance.MouseDownBackColor = Color.FromArgb(64, 64, 64);
            bminimizar.FlatAppearance.MouseOverBackColor = Color.DimGray;
            bminimizar.FlatStyle = FlatStyle.Flat;
            bminimizar.ForeColor = Color.Snow;
            bminimizar.Image = (Image)resources.GetObject("bminimizar.Image");
            bminimizar.Location = new Point(1087, 15);
            bminimizar.Name = "bminimizar";
            bminimizar.Size = new Size(70, 71);
            bminimizar.TabIndex = 11;
            bminimizar.UseVisualStyleBackColor = false;
            bminimizar.Click += bminimizar_Click;
            // 
            // pMembresias
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1361, 825);
            Controls.Add(btregresar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "pMembresias";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "pMembresias";
            btregresar.ResumeLayout(false);
            btregresar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tablaMiembros).EndInit();
            ((System.ComponentModel.ISupportInitialize)btvolver).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel btregresar;
        private Button bminimizar;
        private Button btcerrar;
        private PictureBox btvolver;
        private DataGridView tablaMiembros;
        private TextBox txtBuscador;
        private Button btnBuscar;
        private Button btnActivo;
        private TextBox txtMembresia;
        private TextBox txtId;
        private CheckBox cAsistencia;
        private Label label2;
        private Button btnEliminar;
        private Button btnModificar;
        private TextBox txtDias;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn apellido;
        private DataGridViewTextBoxColumn membresia;
        private DataGridViewTextBoxColumn dias;
        private Button btnRenovarM;
        private Label label1;
        private Label label4;
        private Label label3;
        private TextBox nombrebx;
        private TextBox apellidobx;
        private Label lbNombre;
        private Label lbApellido;
        private RadioButton hombre;
        private RadioButton mujer;
        private Label lbSexo;
        private TextBox txtCorreo;
        private TextBox telefonotxt;
        private Label Telefono;
        private Label lbCorreo;
        private TextBox txtFecha;
        private Label lbFecha;
        private Button btnFecha;
        private MonthCalendar monthCalendar1;
        private Button btnGuardar;
        private Button btnPagar;
        private TextBox textBox1;
    }
}