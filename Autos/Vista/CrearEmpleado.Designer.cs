namespace Autos.Vista
{
    partial class CrearEmpleado
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.pnlDatosPersonales = new System.Windows.Forms.Panel();
            this.mskTele = new System.Windows.Forms.MaskedTextBox();
            this.mskDni = new System.Windows.Forms.MaskedTextBox();
            this.btnSiguiente1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlRegistro = new System.Windows.Forms.Panel();
            this.mskFechaVen = new System.Windows.Forms.MaskedTextBox();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.btnGuardaEmple = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.pnlAuto = new System.Windows.Forms.Panel();
            this.mskPateVieja = new System.Windows.Forms.MaskedTextBox();
            this.mskPateNueva = new System.Windows.Forms.MaskedTextBox();
            this.numAnio = new System.Windows.Forms.NumericUpDown();
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.btnSiguiente2 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.prbBarra = new System.Windows.Forms.ProgressBar();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.btnGuardaAuto = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.pnlDatosPersonales.SuspendLayout();
            this.pnlRegistro.SuspendLayout();
            this.pnlAuto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAnio)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(879, 426);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.pnlDatosPersonales);
            this.tabPage3.Controls.Add(this.pnlRegistro);
            this.tabPage3.Controls.Add(this.pnlAuto);
            this.tabPage3.Controls.Add(this.prbBarra);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(871, 400);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Crear Empleado";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // pnlDatosPersonales
            // 
            this.pnlDatosPersonales.Controls.Add(this.mskTele);
            this.pnlDatosPersonales.Controls.Add(this.mskDni);
            this.pnlDatosPersonales.Controls.Add(this.btnSiguiente1);
            this.pnlDatosPersonales.Controls.Add(this.label6);
            this.pnlDatosPersonales.Controls.Add(this.txtEmail);
            this.pnlDatosPersonales.Controls.Add(this.txtApellido);
            this.pnlDatosPersonales.Controls.Add(this.txtNombre);
            this.pnlDatosPersonales.Controls.Add(this.label5);
            this.pnlDatosPersonales.Controls.Add(this.label4);
            this.pnlDatosPersonales.Controls.Add(this.label3);
            this.pnlDatosPersonales.Controls.Add(this.label2);
            this.pnlDatosPersonales.Controls.Add(this.label1);
            this.pnlDatosPersonales.Location = new System.Drawing.Point(32, 24);
            this.pnlDatosPersonales.Name = "pnlDatosPersonales";
            this.pnlDatosPersonales.Size = new System.Drawing.Size(260, 255);
            this.pnlDatosPersonales.TabIndex = 16;
            // 
            // mskTele
            // 
            this.mskTele.Location = new System.Drawing.Point(93, 143);
            this.mskTele.Mask = "000-0000";
            this.mskTele.Name = "mskTele";
            this.mskTele.Size = new System.Drawing.Size(154, 20);
            this.mskTele.TabIndex = 13;
            // 
            // mskDni
            // 
            this.mskDni.Location = new System.Drawing.Point(93, 183);
            this.mskDni.Mask = "90000000";
            this.mskDni.Name = "mskDni";
            this.mskDni.Size = new System.Drawing.Size(154, 20);
            this.mskDni.TabIndex = 12;
            this.mskDni.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt;
            // 
            // btnSiguiente1
            // 
            this.btnSiguiente1.Location = new System.Drawing.Point(17, 210);
            this.btnSiguiente1.Name = "btnSiguiente1";
            this.btnSiguiente1.Size = new System.Drawing.Size(221, 24);
            this.btnSiguiente1.TabIndex = 11;
            this.btnSiguiente1.Text = "Siguiente";
            this.btnSiguiente1.UseVisualStyleBackColor = true;
            this.btnSiguiente1.Click += new System.EventHandler(this.btnSiguiente1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(2, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "Datos Personales";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(93, 111);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(154, 20);
            this.txtEmail.TabIndex = 7;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(93, 75);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(154, 20);
            this.txtApellido.TabIndex = 6;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(93, 43);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(154, 20);
            this.txtNombre.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "DNI";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(2, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefono";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellido";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // pnlRegistro
            // 
            this.pnlRegistro.Controls.Add(this.mskFechaVen);
            this.pnlRegistro.Controls.Add(this.cmbTipo);
            this.pnlRegistro.Controls.Add(this.btnGuardaEmple);
            this.pnlRegistro.Controls.Add(this.label12);
            this.pnlRegistro.Controls.Add(this.label15);
            this.pnlRegistro.Controls.Add(this.label16);
            this.pnlRegistro.Location = new System.Drawing.Point(592, 24);
            this.pnlRegistro.Name = "pnlRegistro";
            this.pnlRegistro.Size = new System.Drawing.Size(255, 255);
            this.pnlRegistro.TabIndex = 16;
            // 
            // mskFechaVen
            // 
            this.mskFechaVen.Location = new System.Drawing.Point(43, 152);
            this.mskFechaVen.Mask = "00/00/0000";
            this.mskFechaVen.Name = "mskFechaVen";
            this.mskFechaVen.Size = new System.Drawing.Size(156, 20);
            this.mskFechaVen.TabIndex = 15;
            this.mskFechaVen.ValidatingType = typeof(System.DateTime);
            // 
            // cmbTipo
            // 
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Items.AddRange(new object[] {
            "Clase  A",
            "Clase  B",
            "Clase  C",
            "Clase  D",
            "Clase  E",
            "Clase  F",
            "Clase  G"});
            this.cmbTipo.Location = new System.Drawing.Point(42, 76);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(158, 21);
            this.cmbTipo.TabIndex = 14;
            // 
            // btnGuardaEmple
            // 
            this.btnGuardaEmple.Location = new System.Drawing.Point(16, 210);
            this.btnGuardaEmple.Name = "btnGuardaEmple";
            this.btnGuardaEmple.Size = new System.Drawing.Size(232, 24);
            this.btnGuardaEmple.TabIndex = 12;
            this.btnGuardaEmple.Text = "Guardar";
            this.btnGuardaEmple.UseVisualStyleBackColor = true;
            this.btnGuardaEmple.Click += new System.EventHandler(this.btnGuardaEmple_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(13, 11);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 18);
            this.label12.TabIndex = 5;
            this.label12.Text = "Registro";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(3, 109);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(147, 18);
            this.label15.TabIndex = 2;
            this.label15.Text = "Fecha de vencimiento";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(13, 42);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(91, 18);
            this.label16.TabIndex = 1;
            this.label16.Text = "Tipo registro";
            // 
            // pnlAuto
            // 
            this.pnlAuto.Controls.Add(this.mskPateVieja);
            this.pnlAuto.Controls.Add(this.mskPateNueva);
            this.pnlAuto.Controls.Add(this.numAnio);
            this.pnlAuto.Controls.Add(this.txtModelo);
            this.pnlAuto.Controls.Add(this.txtMarca);
            this.pnlAuto.Controls.Add(this.btnSiguiente2);
            this.pnlAuto.Controls.Add(this.label11);
            this.pnlAuto.Controls.Add(this.label10);
            this.pnlAuto.Controls.Add(this.label9);
            this.pnlAuto.Controls.Add(this.label8);
            this.pnlAuto.Controls.Add(this.label7);
            this.pnlAuto.Location = new System.Drawing.Point(310, 24);
            this.pnlAuto.Name = "pnlAuto";
            this.pnlAuto.Size = new System.Drawing.Size(255, 255);
            this.pnlAuto.TabIndex = 2;
            // 
            // mskPateVieja
            // 
            this.mskPateVieja.Location = new System.Drawing.Point(89, 143);
            this.mskPateVieja.Mask = "LLL 000";
            this.mskPateVieja.Name = "mskPateVieja";
            this.mskPateVieja.Size = new System.Drawing.Size(166, 20);
            this.mskPateVieja.TabIndex = 18;
            // 
            // mskPateNueva
            // 
            this.mskPateNueva.Location = new System.Drawing.Point(89, 174);
            this.mskPateNueva.Mask = "LL 000 LL";
            this.mskPateNueva.Name = "mskPateNueva";
            this.mskPateNueva.Size = new System.Drawing.Size(166, 20);
            this.mskPateNueva.TabIndex = 17;
            // 
            // numAnio
            // 
            this.numAnio.Location = new System.Drawing.Point(89, 114);
            this.numAnio.Maximum = new decimal(new int[] {
            2023,
            0,
            0,
            0});
            this.numAnio.Minimum = new decimal(new int[] {
            2005,
            0,
            0,
            0});
            this.numAnio.Name = "numAnio";
            this.numAnio.Size = new System.Drawing.Size(158, 20);
            this.numAnio.TabIndex = 16;
            this.numAnio.Value = new decimal(new int[] {
            2005,
            0,
            0,
            0});
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(89, 74);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(159, 20);
            this.txtModelo.TabIndex = 13;
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(89, 42);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(159, 20);
            this.txtMarca.TabIndex = 12;
            // 
            // btnSiguiente2
            // 
            this.btnSiguiente2.Location = new System.Drawing.Point(16, 210);
            this.btnSiguiente2.Name = "btnSiguiente2";
            this.btnSiguiente2.Size = new System.Drawing.Size(232, 24);
            this.btnSiguiente2.TabIndex = 12;
            this.btnSiguiente2.Text = "Siguiente";
            this.btnSiguiente2.UseVisualStyleBackColor = true;
            this.btnSiguiente2.Click += new System.EventHandler(this.btnSiguiente2_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(13, 11);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 18);
            this.label11.TabIndex = 5;
            this.label11.Text = "Auto";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(13, 145);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 18);
            this.label10.TabIndex = 4;
            this.label10.Text = "Patente";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(13, 110);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 18);
            this.label9.TabIndex = 3;
            this.label9.Text = "Año";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 18);
            this.label8.TabIndex = 2;
            this.label8.Text = "Modelo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 18);
            this.label7.TabIndex = 1;
            this.label7.Text = "Marca";
            // 
            // prbBarra
            // 
            this.prbBarra.Location = new System.Drawing.Point(174, 336);
            this.prbBarra.Name = "prbBarra";
            this.prbBarra.Size = new System.Drawing.Size(440, 23);
            this.prbBarra.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.panel4);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(871, 400);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Crear Auto";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.textBox10);
            this.panel4.Controls.Add(this.textBox11);
            this.panel4.Controls.Add(this.textBox14);
            this.panel4.Controls.Add(this.textBox15);
            this.panel4.Controls.Add(this.btnGuardaAuto);
            this.panel4.Controls.Add(this.label13);
            this.panel4.Controls.Add(this.label14);
            this.panel4.Controls.Add(this.label17);
            this.panel4.Controls.Add(this.label18);
            this.panel4.Controls.Add(this.label19);
            this.panel4.Location = new System.Drawing.Point(308, 73);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(255, 255);
            this.panel4.TabIndex = 3;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(89, 146);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(159, 20);
            this.textBox10.TabIndex = 15;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(89, 110);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(159, 20);
            this.textBox11.TabIndex = 14;
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(89, 74);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(159, 20);
            this.textBox14.TabIndex = 13;
            // 
            // textBox15
            // 
            this.textBox15.Location = new System.Drawing.Point(89, 42);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(159, 20);
            this.textBox15.TabIndex = 12;
            // 
            // btnGuardaAuto
            // 
            this.btnGuardaAuto.Location = new System.Drawing.Point(16, 210);
            this.btnGuardaAuto.Name = "btnGuardaAuto";
            this.btnGuardaAuto.Size = new System.Drawing.Size(232, 24);
            this.btnGuardaAuto.TabIndex = 12;
            this.btnGuardaAuto.Text = "Guardar";
            this.btnGuardaAuto.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(13, 21);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(39, 18);
            this.label13.TabIndex = 5;
            this.label13.Text = "Auto";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(13, 145);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(56, 18);
            this.label14.TabIndex = 4;
            this.label14.Text = "Patente";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(13, 110);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(35, 18);
            this.label17.TabIndex = 3;
            this.label17.Text = "Año";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(13, 74);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(55, 18);
            this.label18.TabIndex = 2;
            this.label18.Text = "Modelo";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(13, 42);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(48, 18);
            this.label19.TabIndex = 1;
            this.label19.Text = "Marca";
            // 
            // CrearEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "CrearEmpleado";
            this.Text = "CrearEmpleado";
            this.Load += new System.EventHandler(this.CrearEmpleado_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.pnlDatosPersonales.ResumeLayout(false);
            this.pnlDatosPersonales.PerformLayout();
            this.pnlRegistro.ResumeLayout(false);
            this.pnlRegistro.PerformLayout();
            this.pnlAuto.ResumeLayout(false);
            this.pnlAuto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAnio)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.ProgressBar prbBarra;
        private System.Windows.Forms.Panel pnlAuto;
        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Button btnSiguiente2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel pnlRegistro;
        private System.Windows.Forms.Button btnGuardaEmple;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.Button btnGuardaAuto;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.MaskedTextBox mskPateVieja;
        private System.Windows.Forms.MaskedTextBox mskPateNueva;
        private System.Windows.Forms.NumericUpDown numAnio;
        private System.Windows.Forms.MaskedTextBox mskFechaVen;
        private System.Windows.Forms.Panel pnlDatosPersonales;
        private System.Windows.Forms.MaskedTextBox mskTele;
        private System.Windows.Forms.MaskedTextBox mskDni;
        private System.Windows.Forms.Button btnSiguiente1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}