using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Utils;
using C1.Win.C1FlexGrid;

namespace GestRest.Reservas
{
    public partial class frmReservas : Form
    {
        #region constantes
        const int cNombre = 0;
        const int cMesa = 1;
        const int cComensales = 2;
        const int cHora = 3;
        const int cHanLlegado = 4;
        const int cHeightRows = 35;
        const int cNombreW = 60;
        const int cMesaW = 8;
        const int cComensalesW = 8;
        const int cHoraW = 16;
        const int cHanLlegadoW = 8;

        #endregion

        #region propiedades
        private DateTime _fechaActual;

        public DateTime FechaActual
        {
            get { return _fechaActual; }
            set { _fechaActual = value; }
        }
        #endregion

        private void FormatearGrid()
        {
            this.fgReservas.Font = new Font(this.fgReservas.Font.FontFamily, 20, FontStyle.Bold);

            this.fgReservas.Cols.Count = 5;
            this.fgReservas.Cols.Fixed = 0;
            this.fgReservas.Rows.Count = 1;
            this.fgReservas.Rows.Fixed = 1;

            this.fgReservas.AllowEditing = false;

            this.fgReservas.Rows[0].ImageAlign = ImageAlignEnum.CenterCenter;
            this.fgReservas.SetCellImage(0, cNombre, Properties.Resources.persona);
            this.fgReservas.SetCellImage(0, cMesa, Properties.Resources.mesa);
            this.fgReservas.SetCellImage(0, cComensales, Properties.Resources.comensales);
            this.fgReservas.SetCellImage(0, cHora, Properties.Resources.reloj);

            this.fgReservas.AutoSizeRows();

            this.fgReservas.Cols[cNombre].DataType = typeof(string);
            this.fgReservas.Cols[cMesa].DataType = typeof(int);
            this.fgReservas.Cols[cComensales].DataType = typeof(int);
            this.fgReservas.Cols[cHora].DataType = typeof(DateTime);
            this.fgReservas.Cols[cHanLlegado].DataType = typeof(bool);

            this.fgReservas.Cols[cHora].Format = "HH:mm";

            this.fgReservas.Cols[cNombre].TextAlign = TextAlignEnum.LeftCenter;
            this.fgReservas.Cols[cMesa].TextAlign = TextAlignEnum.CenterCenter;
            this.fgReservas.Cols[cComensales].TextAlign = TextAlignEnum.CenterCenter;
            this.fgReservas.Cols[cHora].TextAlign = TextAlignEnum.CenterCenter;
            this.fgReservas.Cols[cHanLlegado].TextAlign = TextAlignEnum.CenterCenter;

            this.fgReservas.ExtendLastCol = true;
            this.RedimensionarColsGrid();
        }

        private void LlenarGrid()
        {
            Row row = this.fgReservas.Rows.Add();

            row[cNombre] = "Peter";
            row[cMesa] = 5;
            row[cComensales] = 2;
            row[cHora] = DateTime.Now;
            row[cHanLlegado] = true;

        }

        private void CrearRow()
        {
        }

        private void RedimensionarColsGrid()
        {
            if (this.fgReservas.Rows.Count > 0)
            {
                this.fgReservas.Cols[cNombre].Width = (this.fgReservas.Width / 100) * cNombreW;
                this.fgReservas.Cols[cMesa].Width = (this.fgReservas.Width / 100) * cMesaW;
                this.fgReservas.Cols[cComensales].Width = (this.fgReservas.Width / 100) * cComensalesW;
                this.fgReservas.Cols[cHora].Width = (this.fgReservas.Width / 100) * cHoraW;
                this.fgReservas.Cols[cHanLlegado].Width = (this.fgReservas.Width / 100) * cHanLlegadoW;
            }
        }

        public frmReservas()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmReservas_Load(object sender, EventArgs e)
        {
            if (this.FechaActual == null)
            {
                this.Close();
            }

            this.lblDia.Text = this.FechaActual.Day.ToString();
            this.lblMesAno.Text = "<b><i>" + CommonFunctions.CF.MesFechaString((Enums.Meses)this.FechaActual.Month)
                + " " + this.FechaActual.Year + "</i></b>";

            this.FormatearGrid();
            this.LlenarGrid();
        }

        private void frmReservas_SizeChanged(object sender, EventArgs e)
        {
            this.RedimensionarColsGrid();
        }
    }
}
