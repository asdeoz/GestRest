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
            set { _diaActual = value; }
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
            this.tlpCenter.Controls.Add(new DateButton(DateTime.Now),2, 2);
        }
    }
}
