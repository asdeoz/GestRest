using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Utils;

namespace GestRest
{
    public partial class dlgCalendario : Form
    {
        private DateTime _diaActual;

        public DateTime DiaActual
        {
            get { return _diaActual; }
            set { _diaActual = new DateTime(value.Year, value.Month, 1); }
        }

        public dlgCalendario()
        {
            InitializeComponent();
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
            //this.tlpCenter.Controls.Add(new DateButton(DateTime.Now),2, 2);
            this.FillCalendario();
        }

        private void FillCalendario()
        {
            DateTime primerDia = DiaActual;
            DateTime ultimoDia = primerDia.AddMonths(1).AddDays(-1);
            int mesActual = primerDia.Month;
            int diaSemana = Functions.DiaSemanaSP((int)primerDia.DayOfWeek);
            int diasAnteriores = diaSemana-7;
            DateTime ahoraDia = primerDia.AddDays(diasAnteriores);
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

                DateButton btnDia = new DateButton(ahoraDia);
                this.tlpCenter.Controls.Add(btnDia, x, y);

                if (ahoraDia.Month != primerDia.Month)
                {
                    btnDia.Enabled = false;
                }

                ahoraDia = ahoraDia.AddDays(1);

                bFinMes = (ahoraDia.Month == primerDia.AddMonths(1).Month);
            }while (!bFinMes || x!=7);
            

            //MessageBox.Show(primerDia.ToShortDateString() + "-" + primerDia.DayOfWeek.ToString());
        }
    }
}
