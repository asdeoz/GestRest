namespace GestRest.Reservas
{
    partial class frmReservas
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
            this.pnlDerecha = new System.Windows.Forms.Panel();
            this.pnlBotones = new System.Windows.Forms.Panel();
            this.tlpBotones = new System.Windows.Forms.TableLayoutPanel();
            this.btnHanLlegado = new System.Windows.Forms.Button();
            this.btnNueva = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnCancelarReserva = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.pnlEntradaDatos = new System.Windows.Forms.Panel();
            this.gbEntradaDatos = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbTurno = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtComentarios = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtMesa = new System.Windows.Forms.TextBox();
            this.txtMinutos = new System.Windows.Forms.TextBox();
            this.txtHora = new System.Windows.Forms.TextBox();
            this.txtComensales = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.pnlCentral = new System.Windows.Forms.Panel();
            this.fgReservas = new C1.Win.C1FlexGrid.C1FlexGrid();
            this.pnlSeparador1 = new System.Windows.Forms.Panel();
            this.pnlFecha = new System.Windows.Forms.Panel();
            this.lblDia = new System.Windows.Forms.Label();
            this.lblMesAno = new C1.Win.C1SuperTooltip.C1SuperLabel();
            this.pnlDerecha.SuspendLayout();
            this.pnlBotones.SuspendLayout();
            this.tlpBotones.SuspendLayout();
            this.pnlEntradaDatos.SuspendLayout();
            this.gbEntradaDatos.SuspendLayout();
            this.pnlCentral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fgReservas)).BeginInit();
            this.pnlFecha.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDerecha
            // 
            this.pnlDerecha.Controls.Add(this.pnlBotones);
            this.pnlDerecha.Controls.Add(this.pnlEntradaDatos);
            this.pnlDerecha.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlDerecha.Location = new System.Drawing.Point(478, 0);
            this.pnlDerecha.Name = "pnlDerecha";
            this.pnlDerecha.Size = new System.Drawing.Size(306, 612);
            this.pnlDerecha.TabIndex = 0;
            // 
            // pnlBotones
            // 
            this.pnlBotones.Controls.Add(this.tlpBotones);
            this.pnlBotones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBotones.Location = new System.Drawing.Point(0, 388);
            this.pnlBotones.Name = "pnlBotones";
            this.pnlBotones.Size = new System.Drawing.Size(306, 224);
            this.pnlBotones.TabIndex = 1;
            // 
            // tlpBotones
            // 
            this.tlpBotones.ColumnCount = 2;
            this.tlpBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBotones.Controls.Add(this.btnHanLlegado, 1, 0);
            this.tlpBotones.Controls.Add(this.btnNueva, 0, 0);
            this.tlpBotones.Controls.Add(this.btnSalir, 1, 2);
            this.tlpBotones.Controls.Add(this.btnModificar, 0, 1);
            this.tlpBotones.Controls.Add(this.btnCancelarReserva, 1, 1);
            this.tlpBotones.Controls.Add(this.btnImprimir, 0, 2);
            this.tlpBotones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpBotones.Location = new System.Drawing.Point(0, 0);
            this.tlpBotones.Name = "tlpBotones";
            this.tlpBotones.RowCount = 3;
            this.tlpBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpBotones.Size = new System.Drawing.Size(306, 224);
            this.tlpBotones.TabIndex = 0;
            // 
            // btnHanLlegado
            // 
            this.btnHanLlegado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnHanLlegado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHanLlegado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHanLlegado.Location = new System.Drawing.Point(156, 3);
            this.btnHanLlegado.Name = "btnHanLlegado";
            this.btnHanLlegado.Size = new System.Drawing.Size(147, 68);
            this.btnHanLlegado.TabIndex = 1;
            this.btnHanLlegado.Text = "Han arribat";
            this.btnHanLlegado.UseVisualStyleBackColor = true;
            this.btnHanLlegado.Click += new System.EventHandler(this.btnHanLlegado_Click);
            // 
            // btnNueva
            // 
            this.btnNueva.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNueva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNueva.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNueva.Location = new System.Drawing.Point(3, 3);
            this.btnNueva.Name = "btnNueva";
            this.btnNueva.Size = new System.Drawing.Size(147, 68);
            this.btnNueva.TabIndex = 0;
            this.btnNueva.Text = "Nova reserva";
            this.btnNueva.UseVisualStyleBackColor = true;
            this.btnNueva.Click += new System.EventHandler(this.btnNueva_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(156, 151);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(147, 70);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Sortir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(3, 77);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(147, 68);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "Modifica reserva";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnCancelarReserva
            // 
            this.btnCancelarReserva.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCancelarReserva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarReserva.Location = new System.Drawing.Point(156, 77);
            this.btnCancelarReserva.Name = "btnCancelarReserva";
            this.btnCancelarReserva.Size = new System.Drawing.Size(147, 68);
            this.btnCancelarReserva.TabIndex = 3;
            this.btnCancelarReserva.Text = "Cancel·la reserva";
            this.btnCancelarReserva.UseVisualStyleBackColor = true;
            this.btnCancelarReserva.Click += new System.EventHandler(this.btnCancelarReserva_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.Location = new System.Drawing.Point(3, 151);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(147, 70);
            this.btnImprimir.TabIndex = 4;
            this.btnImprimir.Text = "Imprimeix";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // pnlEntradaDatos
            // 
            this.pnlEntradaDatos.Controls.Add(this.gbEntradaDatos);
            this.pnlEntradaDatos.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEntradaDatos.Location = new System.Drawing.Point(0, 0);
            this.pnlEntradaDatos.Name = "pnlEntradaDatos";
            this.pnlEntradaDatos.Size = new System.Drawing.Size(306, 388);
            this.pnlEntradaDatos.TabIndex = 0;
            // 
            // gbEntradaDatos
            // 
            this.gbEntradaDatos.Controls.Add(this.label8);
            this.gbEntradaDatos.Controls.Add(this.label7);
            this.gbEntradaDatos.Controls.Add(this.cmbTurno);
            this.gbEntradaDatos.Controls.Add(this.label6);
            this.gbEntradaDatos.Controls.Add(this.label5);
            this.gbEntradaDatos.Controls.Add(this.label4);
            this.gbEntradaDatos.Controls.Add(this.label3);
            this.gbEntradaDatos.Controls.Add(this.label2);
            this.gbEntradaDatos.Controls.Add(this.label1);
            this.gbEntradaDatos.Controls.Add(this.txtComentarios);
            this.gbEntradaDatos.Controls.Add(this.txtTelefono);
            this.gbEntradaDatos.Controls.Add(this.txtMesa);
            this.gbEntradaDatos.Controls.Add(this.txtMinutos);
            this.gbEntradaDatos.Controls.Add(this.txtHora);
            this.gbEntradaDatos.Controls.Add(this.txtComensales);
            this.gbEntradaDatos.Controls.Add(this.txtNombre);
            this.gbEntradaDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbEntradaDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbEntradaDatos.Location = new System.Drawing.Point(0, 0);
            this.gbEntradaDatos.Name = "gbEntradaDatos";
            this.gbEntradaDatos.Size = new System.Drawing.Size(306, 388);
            this.gbEntradaDatos.TabIndex = 0;
            this.gbEntradaDatos.TabStop = false;
            this.gbEntradaDatos.Text = "Reserva";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 210);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 24);
            this.label8.TabIndex = 15;
            this.label8.Text = "Comentaris";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(205, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 24);
            this.label7.TabIndex = 14;
            this.label7.Text = "Torn";
            // 
            // cmbTurno
            // 
            this.cmbTurno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTurno.FormattingEnabled = true;
            this.cmbTurno.Location = new System.Drawing.Point(209, 178);
            this.cmbTurno.Name = "cmbTurno";
            this.cmbTurno.Size = new System.Drawing.Size(80, 32);
            this.cmbTurno.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(142, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 24);
            this.label6.TabIndex = 13;
            this.label6.Text = "Taula";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 24);
            this.label5.TabIndex = 12;
            this.label5.Text = "Telèfon";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(178, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 24);
            this.label4.TabIndex = 11;
            this.label4.Text = ":";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(135, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "Hora";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "Comensals";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nom";
            // 
            // txtComentarios
            // 
            this.txtComentarios.AcceptsReturn = true;
            this.txtComentarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComentarios.Location = new System.Drawing.Point(17, 237);
            this.txtComentarios.MaxLength = 250;
            this.txtComentarios.Multiline = true;
            this.txtComentarios.Name = "txtComentarios";
            this.txtComentarios.Size = new System.Drawing.Size(272, 133);
            this.txtComentarios.TabIndex = 7;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Location = new System.Drawing.Point(17, 177);
            this.txtTelefono.MaxLength = 9;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(112, 30);
            this.txtTelefono.TabIndex = 4;
            this.txtTelefono.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtMesa
            // 
            this.txtMesa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMesa.Location = new System.Drawing.Point(146, 177);
            this.txtMesa.MaxLength = 2;
            this.txtMesa.Name = "txtMesa";
            this.txtMesa.Size = new System.Drawing.Size(40, 30);
            this.txtMesa.TabIndex = 5;
            this.txtMesa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMesa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumerico_KeyPress);
            // 
            // txtMinutos
            // 
            this.txtMinutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMinutos.Location = new System.Drawing.Point(192, 117);
            this.txtMinutos.MaxLength = 2;
            this.txtMinutos.Name = "txtMinutos";
            this.txtMinutos.Size = new System.Drawing.Size(40, 30);
            this.txtMinutos.TabIndex = 3;
            this.txtMinutos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMinutos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumerico_KeyPress);
            // 
            // txtHora
            // 
            this.txtHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHora.Location = new System.Drawing.Point(139, 117);
            this.txtHora.MaxLength = 2;
            this.txtHora.Name = "txtHora";
            this.txtHora.Size = new System.Drawing.Size(40, 30);
            this.txtHora.TabIndex = 2;
            this.txtHora.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtHora.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumerico_KeyPress);
            // 
            // txtComensales
            // 
            this.txtComensales.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComensales.Location = new System.Drawing.Point(17, 117);
            this.txtComensales.MaxLength = 3;
            this.txtComensales.Name = "txtComensales";
            this.txtComensales.Size = new System.Drawing.Size(47, 30);
            this.txtComensales.TabIndex = 1;
            this.txtComensales.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtComensales.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumerico_KeyPress);
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(17, 57);
            this.txtNombre.MaxLength = 100;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(272, 30);
            this.txtNombre.TabIndex = 0;
            // 
            // pnlCentral
            // 
            this.pnlCentral.Controls.Add(this.fgReservas);
            this.pnlCentral.Controls.Add(this.pnlSeparador1);
            this.pnlCentral.Controls.Add(this.pnlFecha);
            this.pnlCentral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCentral.Location = new System.Drawing.Point(0, 0);
            this.pnlCentral.Name = "pnlCentral";
            this.pnlCentral.Size = new System.Drawing.Size(478, 612);
            this.pnlCentral.TabIndex = 1;
            // 
            // fgReservas
            // 
            this.fgReservas.ColumnInfo = "10,1,0,0,0,95,Columns:";
            this.fgReservas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fgReservas.Location = new System.Drawing.Point(0, 107);
            this.fgReservas.Name = "fgReservas";
            this.fgReservas.Rows.DefaultSize = 19;
            this.fgReservas.Size = new System.Drawing.Size(478, 505);
            this.fgReservas.TabIndex = 2;
            this.fgReservas.Click += new System.EventHandler(this.fgReservas_Click);
            // 
            // pnlSeparador1
            // 
            this.pnlSeparador1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSeparador1.Location = new System.Drawing.Point(0, 86);
            this.pnlSeparador1.Name = "pnlSeparador1";
            this.pnlSeparador1.Size = new System.Drawing.Size(478, 21);
            this.pnlSeparador1.TabIndex = 1;
            // 
            // pnlFecha
            // 
            this.pnlFecha.Controls.Add(this.lblDia);
            this.pnlFecha.Controls.Add(this.lblMesAno);
            this.pnlFecha.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFecha.Location = new System.Drawing.Point(0, 0);
            this.pnlFecha.Name = "pnlFecha";
            this.pnlFecha.Size = new System.Drawing.Size(478, 86);
            this.pnlFecha.TabIndex = 0;
            // 
            // lblDia
            // 
            this.lblDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDia.Location = new System.Drawing.Point(3, 7);
            this.lblDia.Margin = new System.Windows.Forms.Padding(0);
            this.lblDia.Name = "lblDia";
            this.lblDia.Size = new System.Drawing.Size(89, 74);
            this.lblDia.TabIndex = 2;
            this.lblDia.Text = "30";
            this.lblDia.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblMesAno
            // 
            this.lblMesAno.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMesAno.Location = new System.Drawing.Point(95, 39);
            this.lblMesAno.Name = "lblMesAno";
            this.lblMesAno.Size = new System.Drawing.Size(251, 30);
            this.lblMesAno.TabIndex = 1;
            this.lblMesAno.Text = "<i>Desembre 2012</i>";
            this.lblMesAno.UseMnemonic = true;
            // 
            // frmReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 612);
            this.Controls.Add(this.pnlCentral);
            this.Controls.Add(this.pnlDerecha);
            this.Name = "frmReservas";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reserves";
            this.Load += new System.EventHandler(this.frmReservas_Load);
            this.SizeChanged += new System.EventHandler(this.frmReservas_SizeChanged);
            this.pnlDerecha.ResumeLayout(false);
            this.pnlBotones.ResumeLayout(false);
            this.tlpBotones.ResumeLayout(false);
            this.pnlEntradaDatos.ResumeLayout(false);
            this.gbEntradaDatos.ResumeLayout(false);
            this.gbEntradaDatos.PerformLayout();
            this.pnlCentral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fgReservas)).EndInit();
            this.pnlFecha.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDerecha;
        private System.Windows.Forms.Panel pnlCentral;
        private System.Windows.Forms.Panel pnlFecha;
        private C1.Win.C1SuperTooltip.C1SuperLabel lblMesAno;
        private System.Windows.Forms.Panel pnlBotones;
        private System.Windows.Forms.Panel pnlEntradaDatos;
        private System.Windows.Forms.GroupBox gbEntradaDatos;
        private C1.Win.C1FlexGrid.C1FlexGrid fgReservas;
        private System.Windows.Forms.Panel pnlSeparador1;
        private System.Windows.Forms.TableLayoutPanel tlpBotones;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblDia;
        private System.Windows.Forms.Button btnNueva;
        private System.Windows.Forms.Button btnCancelarReserva;
        private System.Windows.Forms.Button btnHanLlegado;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.TextBox txtComentarios;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtMesa;
        private System.Windows.Forms.TextBox txtMinutos;
        private System.Windows.Forms.TextBox txtHora;
        private System.Windows.Forms.TextBox txtComensales;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbTurno;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}