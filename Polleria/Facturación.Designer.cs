namespace Polleria
{
    partial class Facturación
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Facturación));
            this.label1 = new System.Windows.Forms.Label();
            this.txtnumeroFact = new System.Windows.Forms.TextBox();
            this.txtFecha1 = new System.Windows.Forms.TextBox();
            this.txtNombre1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDNI = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnconfirmar = new System.Windows.Forms.Button();
            this.panelEncabezado = new System.Windows.Forms.Panel();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lblErrorEncabezado = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txtHora = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtApellido1 = new System.Windows.Forms.TextBox();
            this.txtDNI1 = new System.Windows.Forms.TextBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.panelrenglones = new System.Windows.Forms.Panel();
            this.btnNuevoRenglon = new System.Windows.Forms.Button();
            this.txtTotales = new System.Windows.Forms.TextBox();
            this.cboxKilo = new System.Windows.Forms.ComboBox();
            this.cboxProducto = new System.Windows.Forms.ComboBox();
            this.cboxCantidad = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lblRenglon = new System.Windows.Forms.Label();
            this.panelpie = new System.Windows.Forms.Panel();
            this.lblDevolucion = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.txtEfectivo = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnCalcularDevolucion = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lblIva = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblBruto = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.panelEncabezado.SuspendLayout();
            this.panelrenglones.SuspendLayout();
            this.panelpie.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(429, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "NºFactura:";
            // 
            // txtnumeroFact
            // 
            this.txtnumeroFact.ForeColor = System.Drawing.Color.Maroon;
            this.txtnumeroFact.Location = new System.Drawing.Point(512, 56);
            this.txtnumeroFact.Name = "txtnumeroFact";
            this.txtnumeroFact.Size = new System.Drawing.Size(114, 22);
            this.txtnumeroFact.TabIndex = 2;
            this.txtnumeroFact.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtFecha1
            // 
            this.txtFecha1.ForeColor = System.Drawing.Color.Maroon;
            this.txtFecha1.Location = new System.Drawing.Point(512, 104);
            this.txtFecha1.Name = "txtFecha1";
            this.txtFecha1.Size = new System.Drawing.Size(114, 22);
            this.txtFecha1.TabIndex = 10;
            this.txtFecha1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNombre1
            // 
            this.txtNombre1.ForeColor = System.Drawing.Color.Maroon;
            this.txtNombre1.Location = new System.Drawing.Point(87, 63);
            this.txtNombre1.Name = "txtNombre1";
            this.txtNombre1.Size = new System.Drawing.Size(111, 22);
            this.txtNombre1.TabIndex = 9;
            this.txtNombre1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(451, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Fecha:";
            // 
            // txtDNI
            // 
            this.txtDNI.AutoSize = true;
            this.txtDNI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDNI.ForeColor = System.Drawing.Color.Black;
            this.txtDNI.Location = new System.Drawing.Point(237, 62);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(38, 16);
            this.txtDNI.TabIndex = 7;
            this.txtDNI.Text = "DNI:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(12, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nombre:";
            // 
            // btnconfirmar
            // 
            this.btnconfirmar.BackColor = System.Drawing.Color.DimGray;
            this.btnconfirmar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnconfirmar.FlatAppearance.BorderColor = System.Drawing.Color.Chartreuse;
            this.btnconfirmar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnconfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnconfirmar.ForeColor = System.Drawing.Color.Black;
            this.btnconfirmar.Location = new System.Drawing.Point(512, 133);
            this.btnconfirmar.Name = "btnconfirmar";
            this.btnconfirmar.Size = new System.Drawing.Size(114, 27);
            this.btnconfirmar.TabIndex = 13;
            this.btnconfirmar.Text = "Confirmar";
            this.btnconfirmar.UseVisualStyleBackColor = false;
            this.btnconfirmar.Click += new System.EventHandler(this.btnconfirmar_Click);
            // 
            // panelEncabezado
            // 
            this.panelEncabezado.BackColor = System.Drawing.Color.DarkGray;
            this.panelEncabezado.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelEncabezado.Controls.Add(this.lbl4);
            this.panelEncabezado.Controls.Add(this.lblErrorEncabezado);
            this.panelEncabezado.Controls.Add(this.label19);
            this.panelEncabezado.Controls.Add(this.txtHora);
            this.panelEncabezado.Controls.Add(this.label3);
            this.panelEncabezado.Controls.Add(this.txtApellido1);
            this.panelEncabezado.Controls.Add(this.label4);
            this.panelEncabezado.Controls.Add(this.btnconfirmar);
            this.panelEncabezado.Controls.Add(this.txtFecha1);
            this.panelEncabezado.Controls.Add(this.label1);
            this.panelEncabezado.Controls.Add(this.txtnumeroFact);
            this.panelEncabezado.Controls.Add(this.txtNombre1);
            this.panelEncabezado.Controls.Add(this.txtDNI1);
            this.panelEncabezado.Controls.Add(this.label2);
            this.panelEncabezado.Controls.Add(this.txtDNI);
            this.panelEncabezado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelEncabezado.ForeColor = System.Drawing.Color.Maroon;
            this.panelEncabezado.Location = new System.Drawing.Point(13, 12);
            this.panelEncabezado.Name = "panelEncabezado";
            this.panelEncabezado.Size = new System.Drawing.Size(639, 173);
            this.panelEncabezado.TabIndex = 15;
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.BackColor = System.Drawing.Color.Transparent;
            this.lbl4.Font = new System.Drawing.Font("Perpetua Titling MT", 21.75F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4.ForeColor = System.Drawing.Color.Maroon;
            this.lbl4.Location = new System.Drawing.Point(151, 0);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(316, 34);
            this.lbl4.TabIndex = 26;
            this.lbl4.Text = "Polleria YaniBel";
            // 
            // lblErrorEncabezado
            // 
            this.lblErrorEncabezado.AutoSize = true;
            this.lblErrorEncabezado.Location = new System.Drawing.Point(8, 138);
            this.lblErrorEncabezado.Name = "lblErrorEncabezado";
            this.lblErrorEncabezado.Size = new System.Drawing.Size(0, 16);
            this.lblErrorEncabezado.TabIndex = 25;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.Black;
            this.label19.Location = new System.Drawing.Point(237, 106);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(46, 16);
            this.label19.TabIndex = 22;
            this.label19.Text = "Hora:";
            // 
            // txtHora
            // 
            this.txtHora.ForeColor = System.Drawing.Color.Maroon;
            this.txtHora.Location = new System.Drawing.Point(286, 106);
            this.txtHora.Name = "txtHora";
            this.txtHora.Size = new System.Drawing.Size(114, 22);
            this.txtHora.TabIndex = 21;
            this.txtHora.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(9, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 20;
            this.label3.Text = "Apellido:";
            // 
            // txtApellido1
            // 
            this.txtApellido1.ForeColor = System.Drawing.Color.Maroon;
            this.txtApellido1.Location = new System.Drawing.Point(87, 106);
            this.txtApellido1.Name = "txtApellido1";
            this.txtApellido1.Size = new System.Drawing.Size(111, 22);
            this.txtApellido1.TabIndex = 10;
            this.txtApellido1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDNI1
            // 
            this.txtDNI1.ForeColor = System.Drawing.Color.Maroon;
            this.txtDNI1.Location = new System.Drawing.Point(286, 63);
            this.txtDNI1.Name = "txtDNI1";
            this.txtDNI1.Size = new System.Drawing.Size(114, 22);
            this.txtDNI1.TabIndex = 6;
            this.txtDNI1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.DimGray;
            this.btnVolver.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btnVolver.FlatAppearance.BorderColor = System.Drawing.Color.Chartreuse;
            this.btnVolver.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.ForeColor = System.Drawing.Color.Black;
            this.btnVolver.Location = new System.Drawing.Point(520, 23);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(111, 27);
            this.btnVolver.TabIndex = 27;
            this.btnVolver.Text = "VOLVER";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // panelrenglones
            // 
            this.panelrenglones.BackColor = System.Drawing.Color.DarkGray;
            this.panelrenglones.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelrenglones.Controls.Add(this.btnNuevoRenglon);
            this.panelrenglones.Controls.Add(this.txtTotales);
            this.panelrenglones.Controls.Add(this.cboxKilo);
            this.panelrenglones.Controls.Add(this.cboxProducto);
            this.panelrenglones.Controls.Add(this.cboxCantidad);
            this.panelrenglones.Controls.Add(this.label13);
            this.panelrenglones.Controls.Add(this.label14);
            this.panelrenglones.Controls.Add(this.label15);
            this.panelrenglones.Controls.Add(this.label16);
            this.panelrenglones.Controls.Add(this.lblRenglon);
            this.panelrenglones.Enabled = false;
            this.panelrenglones.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelrenglones.ForeColor = System.Drawing.Color.Maroon;
            this.panelrenglones.Location = new System.Drawing.Point(12, 203);
            this.panelrenglones.Name = "panelrenglones";
            this.panelrenglones.Size = new System.Drawing.Size(639, 250);
            this.panelrenglones.TabIndex = 16;
            // 
            // btnNuevoRenglon
            // 
            this.btnNuevoRenglon.BackColor = System.Drawing.Color.DimGray;
            this.btnNuevoRenglon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevoRenglon.FlatAppearance.BorderColor = System.Drawing.Color.Chartreuse;
            this.btnNuevoRenglon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnNuevoRenglon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoRenglon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoRenglon.ForeColor = System.Drawing.Color.Black;
            this.btnNuevoRenglon.Location = new System.Drawing.Point(500, 206);
            this.btnNuevoRenglon.Name = "btnNuevoRenglon";
            this.btnNuevoRenglon.Size = new System.Drawing.Size(132, 28);
            this.btnNuevoRenglon.TabIndex = 24;
            this.btnNuevoRenglon.Text = "CargarProducto";
            this.btnNuevoRenglon.UseVisualStyleBackColor = false;
            this.btnNuevoRenglon.Click += new System.EventHandler(this.btnNuevoRenglon_Click);
            // 
            // txtTotales
            // 
            this.txtTotales.ForeColor = System.Drawing.Color.Maroon;
            this.txtTotales.Location = new System.Drawing.Point(497, 29);
            this.txtTotales.Name = "txtTotales";
            this.txtTotales.Size = new System.Drawing.Size(132, 24);
            this.txtTotales.TabIndex = 23;
            this.txtTotales.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cboxKilo
            // 
            this.cboxKilo.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cboxKilo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboxKilo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxKilo.ForeColor = System.Drawing.Color.Maroon;
            this.cboxKilo.FormattingEnabled = true;
            this.cboxKilo.Items.AddRange(new object[] {
            "80",
            "120",
            "130",
            "230",
            "300",
            "330",
            ""});
            this.cboxKilo.Location = new System.Drawing.Point(362, 29);
            this.cboxKilo.Name = "cboxKilo";
            this.cboxKilo.Size = new System.Drawing.Size(118, 26);
            this.cboxKilo.TabIndex = 22;
            // 
            // cboxProducto
            // 
            this.cboxProducto.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cboxProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboxProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxProducto.ForeColor = System.Drawing.Color.Maroon;
            this.cboxProducto.FormattingEnabled = true;
            this.cboxProducto.Items.AddRange(new object[] {
            "pollo",
            "patamuslo",
            "alitas",
            "medallon de pescado",
            "medallon de pollo",
            "patitas rebozadas",
            "milanesas de pollo"});
            this.cboxProducto.Location = new System.Drawing.Point(147, 29);
            this.cboxProducto.Name = "cboxProducto";
            this.cboxProducto.Size = new System.Drawing.Size(187, 26);
            this.cboxProducto.TabIndex = 21;
            // 
            // cboxCantidad
            // 
            this.cboxCantidad.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.cboxCantidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboxCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxCantidad.ForeColor = System.Drawing.Color.Maroon;
            this.cboxCantidad.FormattingEnabled = true;
            this.cboxCantidad.Items.AddRange(new object[] {
            "0,1",
            "0,25",
            "0,5",
            "0,75",
            "1",
            "1,5",
            "2",
            "2,5",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cboxCantidad.Location = new System.Drawing.Point(12, 29);
            this.cboxCantidad.Name = "cboxCantidad";
            this.cboxCantidad.Size = new System.Drawing.Size(118, 26);
            this.cboxCantidad.TabIndex = 20;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(497, 10);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 16);
            this.label13.TabIndex = 19;
            this.label13.Text = "$ Total";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(359, 7);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(37, 16);
            this.label14.TabIndex = 17;
            this.label14.Text = "$ kg";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(144, 10);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(70, 16);
            this.label15.TabIndex = 15;
            this.label15.Text = "Producto";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(11, 7);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(70, 16);
            this.label16.TabIndex = 13;
            this.label16.Text = "Cantidad";
            // 
            // lblRenglon
            // 
            this.lblRenglon.AutoSize = true;
            this.lblRenglon.BackColor = System.Drawing.Color.Transparent;
            this.lblRenglon.ForeColor = System.Drawing.Color.Maroon;
            this.lblRenglon.Location = new System.Drawing.Point(3, 80);
            this.lblRenglon.Name = "lblRenglon";
            this.lblRenglon.Size = new System.Drawing.Size(0, 18);
            this.lblRenglon.TabIndex = 11;
            this.lblRenglon.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelpie
            // 
            this.panelpie.BackColor = System.Drawing.Color.DarkGray;
            this.panelpie.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelpie.Controls.Add(this.lblDevolucion);
            this.panelpie.Controls.Add(this.btnVolver);
            this.panelpie.Controls.Add(this.lbl5);
            this.panelpie.Controls.Add(this.btnImprimir);
            this.panelpie.Controls.Add(this.txtEfectivo);
            this.panelpie.Controls.Add(this.label12);
            this.panelpie.Controls.Add(this.btnCalcularDevolucion);
            this.panelpie.Controls.Add(this.label17);
            this.panelpie.Controls.Add(this.label6);
            this.panelpie.Controls.Add(this.label18);
            this.panelpie.Controls.Add(this.lblIva);
            this.panelpie.Controls.Add(this.lblTotal);
            this.panelpie.Controls.Add(this.lblBruto);
            this.panelpie.Location = new System.Drawing.Point(13, 469);
            this.panelpie.Name = "panelpie";
            this.panelpie.Size = new System.Drawing.Size(639, 164);
            this.panelpie.TabIndex = 17;
            // 
            // lblDevolucion
            // 
            this.lblDevolucion.BackColor = System.Drawing.SystemColors.Control;
            this.lblDevolucion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDevolucion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDevolucion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDevolucion.ForeColor = System.Drawing.Color.Maroon;
            this.lblDevolucion.Location = new System.Drawing.Point(329, 75);
            this.lblDevolucion.Name = "lblDevolucion";
            this.lblDevolucion.Size = new System.Drawing.Size(100, 23);
            this.lblDevolucion.TabIndex = 18;
            this.lblDevolucion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl5.ForeColor = System.Drawing.Color.Black;
            this.lbl5.Location = new System.Drawing.Point(229, 75);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(83, 18);
            this.lbl5.TabIndex = 29;
            this.lbl5.Text = "Su vuelto:";
            this.lbl5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackColor = System.Drawing.Color.DimGray;
            this.btnImprimir.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btnImprimir.FlatAppearance.BorderColor = System.Drawing.Color.Chartreuse;
            this.btnImprimir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.ForeColor = System.Drawing.Color.Black;
            this.btnImprimir.Location = new System.Drawing.Point(520, 119);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(111, 29);
            this.btnImprimir.TabIndex = 28;
            this.btnImprimir.Text = "IMPRIMIR";
            this.btnImprimir.UseVisualStyleBackColor = false;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // txtEfectivo
            // 
            this.txtEfectivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEfectivo.ForeColor = System.Drawing.Color.Maroon;
            this.txtEfectivo.Location = new System.Drawing.Point(326, 28);
            this.txtEfectivo.Name = "txtEfectivo";
            this.txtEfectivo.Size = new System.Drawing.Size(103, 22);
            this.txtEfectivo.TabIndex = 32;
            this.txtEfectivo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(8, 130);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 18);
            this.label12.TabIndex = 18;
            this.label12.Text = "Neto:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnCalcularDevolucion
            // 
            this.btnCalcularDevolucion.BackColor = System.Drawing.Color.DimGray;
            this.btnCalcularDevolucion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalcularDevolucion.FlatAppearance.BorderColor = System.Drawing.Color.Chartreuse;
            this.btnCalcularDevolucion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.btnCalcularDevolucion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcularDevolucion.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcularDevolucion.ForeColor = System.Drawing.Color.Black;
            this.btnCalcularDevolucion.Location = new System.Drawing.Point(268, 119);
            this.btnCalcularDevolucion.Name = "btnCalcularDevolucion";
            this.btnCalcularDevolucion.Size = new System.Drawing.Size(161, 29);
            this.btnCalcularDevolucion.TabIndex = 28;
            this.btnCalcularDevolucion.Text = "Calcular Devolución\r\n";
            this.btnCalcularDevolucion.UseVisualStyleBackColor = false;
            this.btnCalcularDevolucion.Click += new System.EventHandler(this.btnCalcularDevolucion_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(20, 79);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(37, 18);
            this.label17.TabIndex = 17;
            this.label17.Text = "IVA:";
            this.label17.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(237, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 18);
            this.label6.TabIndex = 31;
            this.label6.Text = "Su pago:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Black;
            this.label18.Location = new System.Drawing.Point(9, 32);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(54, 18);
            this.label18.TabIndex = 16;
            this.label18.Text = "Bruto:";
            this.label18.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblIva
            // 
            this.lblIva.BackColor = System.Drawing.SystemColors.Control;
            this.lblIva.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblIva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblIva.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIva.ForeColor = System.Drawing.Color.Maroon;
            this.lblIva.Location = new System.Drawing.Point(69, 79);
            this.lblIva.Name = "lblIva";
            this.lblIva.Size = new System.Drawing.Size(100, 23);
            this.lblIva.TabIndex = 15;
            this.lblIva.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotal
            // 
            this.lblTotal.BackColor = System.Drawing.SystemColors.Control;
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.Maroon;
            this.lblTotal.Location = new System.Drawing.Point(69, 129);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(100, 23);
            this.lblTotal.TabIndex = 15;
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBruto
            // 
            this.lblBruto.BackColor = System.Drawing.SystemColors.Control;
            this.lblBruto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBruto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblBruto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBruto.ForeColor = System.Drawing.Color.Maroon;
            this.lblBruto.Location = new System.Drawing.Point(69, 32);
            this.lblBruto.Name = "lblBruto";
            this.lblBruto.Size = new System.Drawing.Size(100, 23);
            this.lblBruto.TabIndex = 14;
            this.lblBruto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Facturación
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(667, 641);
            this.Controls.Add(this.panelpie);
            this.Controls.Add(this.panelrenglones);
            this.Controls.Add(this.panelEncabezado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Facturación";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Facturación";
            this.Load += new System.EventHandler(this.Facturación_Load);
            this.panelEncabezado.ResumeLayout(false);
            this.panelEncabezado.PerformLayout();
            this.panelrenglones.ResumeLayout(false);
            this.panelrenglones.PerformLayout();
            this.panelpie.ResumeLayout(false);
            this.panelpie.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnumeroFact;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label txtDNI;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnconfirmar;
        private System.Windows.Forms.Panel panelEncabezado;
        private System.Windows.Forms.Panel panelrenglones;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblRenglon;
        private System.Windows.Forms.Panel panelpie;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lblIva;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblBruto;
        public System.Windows.Forms.TextBox txtNombre1;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtApellido1;
        public System.Windows.Forms.TextBox txtDNI1;
        public System.Windows.Forms.TextBox txtFecha1;
        private System.Windows.Forms.ComboBox cboxCantidad;
        private System.Windows.Forms.ComboBox cboxKilo;
        private System.Windows.Forms.ComboBox cboxProducto;
        public System.Windows.Forms.TextBox txtTotales;
        private System.Windows.Forms.Label label19;
        public System.Windows.Forms.TextBox txtHora;
        private System.Windows.Forms.Button btnNuevoRenglon;
        private System.Windows.Forms.Label lblErrorEncabezado;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.Label lblDevolucion;
        private System.Windows.Forms.Button btnCalcularDevolucion;
        private System.Windows.Forms.TextBox txtEfectivo;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}