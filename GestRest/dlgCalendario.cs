using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Utils;
using GestRest.Reservas;
using GestRest.CommonFunctions;
using GestRestDAL;

namespace GestRest
{
    public partial class dlgCalendario : Form
    {
        Label lblDia1 = new Label();
        Label lblDia2 = new Label();
        Label lblDia3 = new Label();
        Label lblDia4 = new Label();
        Label lblDia5 = new Label();
        Label lblDia6 = new Label();
        Label lblDia7 = new Label();
        Button btnExitDer = new Button();
        Button btnExitIzq = new Button();

        private DateTime _diaActual;

        public DateTime DiaActual
        {
            get { return _diaActual; }
            set { _diaActual = new DateTime(value.Year, value.Month, 1); }
        }

        public dlgCalendario()
        {
            InitializeComponent();

            // 
            // lblDia1
            // 
            lblDia1.AutoSize = true;
            lblDia1.Dock = System.Windows.Forms.DockStyle.Fill;
            lblDia1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblDia1.Location = new System.Drawing.Point(47, 0);
            lblDia1.Name = "lblDia1";
            lblDia1.Size = new System.Drawing.Size(123, 64);
            lblDia1.TabIndex = 0;
            lblDia1.Text = "";
            lblDia1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDia2
            // 
            lblDia2.AutoSize = true;
            lblDia2.Dock = System.Windows.Forms.DockStyle.Fill;
            lblDia2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblDia2.Location = new System.Drawing.Point(176, 0);
            lblDia2.Name = "lblDia2";
            lblDia2.Size = new System.Drawing.Size(123, 64);
            lblDia2.TabIndex = 1;
            lblDia2.Text = "";
            lblDia2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDia3
            // 
            lblDia3.AutoSize = true;
            lblDia3.Dock = System.Windows.Forms.DockStyle.Fill;
            lblDia3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblDia3.Location = new System.Drawing.Point(305, 0);
            lblDia3.Name = "lblDia3";
            lblDia3.Size = new System.Drawing.Size(123, 64);
            lblDia3.TabIndex = 2;
            lblDia3.Text = "";
            lblDia3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDia4
            // 
            lblDia4.AutoSize = true;
            lblDia4.Dock = System.Windows.Forms.DockStyle.Fill;
            lblDia4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblDia4.Location = new System.Drawing.Point(434, 0);
            lblDia4.Name = "lblDia4";
            lblDia4.Size = new System.Drawing.Size(123, 64);
            lblDia4.TabIndex = 3;
            lblDia4.Text = "";
            lblDia4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDia5
            // 
            lblDia5.AutoSize = true;
            lblDia5.Dock = System.Windows.Forms.DockStyle.Fill;
            lblDia5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblDia5.Location = new System.Drawing.Point(563, 0);
            lblDia5.Name = "lblDia5";
            lblDia5.Size = new System.Drawing.Size(123, 64);
            lblDia5.TabIndex = 4;
            lblDia5.Text = "";
            lblDia5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDia6
            // 
            lblDia6.AutoSize = true;
            lblDia6.Dock = System.Windows.Forms.DockStyle.Fill;
            lblDia6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblDia6.Location = new System.Drawing.Point(692, 0);
            lblDia6.Name = "lblDia6";
            lblDia6.Size = new System.Drawing.Size(123, 64);
            lblDia6.TabIndex = 5;
            lblDia6.Text = "";
            lblDia6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDia7
            // 
            lblDia7.AutoSize = true;
            lblDia7.Dock = System.Windows.Forms.DockStyle.Fill;
            lblDia7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblDia7.Location = new System.Drawing.Point(821, 0);
            lblDia7.Name = "lblDia7";
            lblDia7.Size = new System.Drawing.Size(123, 64);
            lblDia7.TabIndex = 6;
            lblDia7.Text = "";
            lblDia7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnExitDer
            // 
            btnExitDer.Dock = System.Windows.Forms.DockStyle.Fill;
            btnExitDer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnExitDer.Location = new System.Drawing.Point(950, 3);
            btnExitDer.Name = "btnExitDer";
            btnExitDer.Size = new System.Drawing.Size(41, 58);
            btnExitDer.TabIndex = 0;
            btnExitDer.UseVisualStyleBackColor = true;
            btnExitDer.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnExitIzq
            // 
            btnExitIzq.Dock = System.Windows.Forms.DockStyle.Fill;
            btnExitIzq.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnExitIzq.Location = new System.Drawing.Point(3, 3);
            btnExitIzq.Name = "btnExitIzq";
            btnExitIzq.Size = new System.Drawing.Size(38, 58);
            btnExitIzq.TabIndex = 1;
            btnExitIzq.UseVisualStyleBackColor = true;
            btnExitIzq.Click += new System.EventHandler(this.btnExit_Click);

            lblDia1.Text = CommonFunctions.CF.DiaSemanaString(Enums.Dias.Lunes);
            lblDia2.Text = CommonFunctions.CF.DiaSemanaString(Enums.Dias.Martes);
            lblDia3.Text = CommonFunctions.CF.DiaSemanaString(Enums.Dias.Miercoles);
            lblDia4.Text = CommonFunctions.CF.DiaSemanaString(Enums.Dias.Jueves);
            lblDia5.Text = CommonFunctions.CF.DiaSemanaString(Enums.Dias.Viernes);
            lblDia6.Text = CommonFunctions.CF.DiaSemanaString(Enums.Dias.Sabado);
            lblDia7.Text = CommonFunctions.CF.DiaSemanaString(Enums.Dias.Domingo);

            btnExitDer.Text = Properties.Resources.rxSalir;
            btnExitIzq.Text = Properties.Resources.rxSalir;

            this.tlpCenter.Controls.Add(lblDia1, 1, 0);
            this.tlpCenter.Controls.Add(lblDia2, 2, 0);
            this.tlpCenter.Controls.Add(lblDia3, 3, 0);
            this.tlpCenter.Controls.Add(lblDia4, 4, 0);
            this.tlpCenter.Controls.Add(lblDia5, 5, 0);
            this.tlpCenter.Controls.Add(lblDia6, 6, 0);
            this.tlpCenter.Controls.Add(lblDia7, 7, 0);
            this.tlpCenter.Controls.Add(btnExitIzq, 0, 0);
            this.tlpCenter.Controls.Add(btnExitDer, 8, 0);

        }

        private void dlgCalendario_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Application.OpenForms.Count == 2)
            {
                frmMain oFrmMain = (frmMain)this.MdiParent;
                oFrmMain.TlpMain.Visible = true;
            }
        }

        private void dlgCalendario_Load(object sender, EventArgs e)
        {
            this.FillCalendario();
        }

        private void FormatCalendario()
        {
            this.lblMes.Text = CommonFunctions.CF.MesFechaString((Enums.Meses)this.DiaActual.Month);
        }

        private void FillCalendario()
        {
            this.LimpiarCalendario();
            this.FormatCalendario();

            List<DateTime> lstDiasConReserva = GestorReservas.Instance.GetListaDiasConReserva(this.DiaActual);

            DateTime primerDia = DiaActual;
            int diaSemana = Functions.DiaSemanaSP((int)primerDia.DayOfWeek);
            DateTime ahoraDia = primerDia.AddDays(-(diaSemana-1));
            bool bFinMes = false;

            int x = 0;
            int y = 1;

            do
            {
                if (x == 7)
                {
                    x = 0;
                    y++;
                }
                x++;

                DateButton btnDia = new DateButton(ahoraDia, (lstDiasConReserva.Contains(ahoraDia.Date)));
                btnDia.Click += new EventHandler(btnDia_Click);
                this.tlpCenter.Controls.Add(btnDia, x, y);

                if (ahoraDia.Month != primerDia.Month)
                {
                    btnDia.Enabled = false;
                }

                ahoraDia = ahoraDia.AddDays(1);

                bFinMes = (ahoraDia.Month == primerDia.AddMonths(1).Month);
            }while (!bFinMes || x!=7);
            
        }

        void btnDia_Click(object sender, EventArgs e)
        {
            DateButton btnDia;
            if (sender.GetType() == typeof(DateButton))
            {
                btnDia = (DateButton)sender;
                frmReservas oFrmReservas = new frmReservas();
                oFrmReservas.FechaActual = btnDia.Date;
                oFrmReservas.WindowState = FormWindowState.Maximized;
                oFrmReservas.ShowDialog();
            }
        }

        private void LimpiarCalendario()
        {
            this.tlpCenter.Controls.Clear();
        }

        private void btnMesSiguiente_Click(object sender, EventArgs e)
        {
            this.DiaActual = this.DiaActual.AddMonths(1);
            this.FillCalendario();
        }

        private void btnMesAnterior_Click(object sender, EventArgs e)
        {
            this.DiaActual = this.DiaActual.AddMonths(-1);
            this.FillCalendario();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
