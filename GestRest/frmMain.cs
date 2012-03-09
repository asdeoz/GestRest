using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GestRestDAL;

namespace GestRest
{
    public partial class frmMain : Form
    {
        public TableLayoutPanel TlpMain
        {
            get { return this.tlpMain; }
        }


        public frmMain()
        {
            InitializeComponent();
        }

        private void tsmiReservas_Click(object sender, EventArgs e)
        {
            dlgCalendario oDlgCalendario = new dlgCalendario();

            oDlgCalendario.DiaActual = DateTime.Now;

            oDlgCalendario.MdiParent = this;
            oDlgCalendario.BringToFront();
            tlpMain.Visible = false;
            oDlgCalendario.WindowState = FormWindowState.Maximized;
            oDlgCalendario.Show(); //Canviar a showDialog
        }
    }
}
