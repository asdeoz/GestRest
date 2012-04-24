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
            this.btnSalir = new System.Windows.Forms.Button();
            this.pnlEntradaDatos = new System.Windows.Forms.Panel();
            this.gbEntradaDatos = new System.Windows.Forms.GroupBox();
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
            this.pnlDerecha.Location = new System.Drawing.Point(479, 0);
            this.pnlDerecha.Name = "pnlDerecha";
            this.pnlDerecha.Size = new System.Drawing.Size(305, 562);
            this.pnlDerecha.TabIndex = 0;
            // 
            // pnlBotones
            // 
            this.pnlBotones.Controls.Add(this.tlpBotones);
            this.pnlBotones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBotones.Location = new System.Drawing.Point(0, 324);
            this.pnlBotones.Name = "pnlBotones";
            this.pnlBotones.Size = new System.Drawing.Size(305, 238);
            this.pnlBotones.TabIndex = 1;
            // 
            // tlpBotones
            // 
            this.tlpBotones.ColumnCount = 2;
            this.tlpBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBotones.Controls.Add(this.btnSalir, 1, 1);
            this.tlpBotones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpBotones.Location = new System.Drawing.Point(0, 0);
            this.tlpBotones.Name = "tlpBotones";
            this.tlpBotones.RowCount = 2;
            this.tlpBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBotones.Size = new System.Drawing.Size(305, 238);
            this.tlpBotones.TabIndex = 0;
            // 
            // btnSalir
            // 
            this.btnSalir.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Location = new System.Drawing.Point(155, 122);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(147, 113);
            this.btnSalir.TabIndex = 0;
            this.btnSalir.Text = "Sortir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // pnlEntradaDatos
            // 
            this.pnlEntradaDatos.Controls.Add(this.gbEntradaDatos);
            this.pnlEntradaDatos.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlEntradaDatos.Location = new System.Drawing.Point(0, 0);
            this.pnlEntradaDatos.Name = "pnlEntradaDatos";
            this.pnlEntradaDatos.Size = new System.Drawing.Size(305, 324);
            this.pnlEntradaDatos.TabIndex = 0;
            // 
            // gbEntradaDatos
            // 
            this.gbEntradaDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbEntradaDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbEntradaDatos.Location = new System.Drawing.Point(0, 0);
            this.gbEntradaDatos.Name = "gbEntradaDatos";
            this.gbEntradaDatos.Size = new System.Drawing.Size(305, 324);
            this.gbEntradaDatos.TabIndex = 0;
            this.gbEntradaDatos.TabStop = false;
            this.gbEntradaDatos.Text = "Reserva";
            // 
            // pnlCentral
            // 
            this.pnlCentral.Controls.Add(this.fgReservas);
            this.pnlCentral.Controls.Add(this.pnlSeparador1);
            this.pnlCentral.Controls.Add(this.pnlFecha);
            this.pnlCentral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlCentral.Location = new System.Drawing.Point(0, 0);
            this.pnlCentral.Name = "pnlCentral";
            this.pnlCentral.Size = new System.Drawing.Size(479, 562);
            this.pnlCentral.TabIndex = 1;
            // 
            // fgReservas
            // 
            this.fgReservas.ColumnInfo = "10,1,0,0,0,95,Columns:";
            this.fgReservas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fgReservas.Location = new System.Drawing.Point(0, 107);
            this.fgReservas.Name = "fgReservas";
            this.fgReservas.Rows.DefaultSize = 19;
            this.fgReservas.Size = new System.Drawing.Size(479, 455);
            this.fgReservas.TabIndex = 2;
            // 
            // pnlSeparador1
            // 
            this.pnlSeparador1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSeparador1.Location = new System.Drawing.Point(0, 86);
            this.pnlSeparador1.Name = "pnlSeparador1";
            this.pnlSeparador1.Size = new System.Drawing.Size(479, 21);
            this.pnlSeparador1.TabIndex = 1;
            // 
            // pnlFecha
            // 
            this.pnlFecha.Controls.Add(this.lblDia);
            this.pnlFecha.Controls.Add(this.lblMesAno);
            this.pnlFecha.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFecha.Location = new System.Drawing.Point(0, 0);
            this.pnlFecha.Name = "pnlFecha";
            this.pnlFecha.Size = new System.Drawing.Size(479, 86);
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
            this.ClientSize = new System.Drawing.Size(784, 562);
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
    }
}