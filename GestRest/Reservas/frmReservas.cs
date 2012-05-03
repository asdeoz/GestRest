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
using GestRestDAL;
using System.Data.Linq;

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

        const string eVerde = "eVerde";
        const string eRojo = "eRojo";

        #endregion

        #region enumeraciones

        private enum ModoForm
        {
            Normal = 0,
            Editar = 1,
            Nueva = 2
        }

        #endregion

        #region propiedades

        private DateTime _fechaActual;
        private Reserva _reservaSel;
        private ModoForm _modoActual;

        public DateTime FechaActual
        {
            get { return _fechaActual; }
            set { _fechaActual = value; }
        }

        public Reserva ReservaSel
        {
            get {
                this._reservaSel = null;
                if (this.fgReservas.Selection.r1 >= this.fgReservas.Rows.Fixed &&
                    this.fgReservas.Rows[this.fgReservas.Selection.r1].UserData is Reserva)
                {
                    this._reservaSel = (Reserva)this.fgReservas.Rows[this.fgReservas.Selection.r1].UserData;
                }

                return _reservaSel;
            }
            set { _reservaSel = value; }
        }

        private ModoForm ModoActual
        {
            get { return _modoActual; }
            set { _modoActual = value; }
        }

        #endregion

        #region metodos

        /// <summary>
        /// Modifica el acceso a los controles para los modos Normal, Editar y Nuevo
        /// </summary>
        /// <param name="modo">ModoForm al que se quiere pasar</param>
        private void CambiarModoForm(ModoForm modo)
        {
            switch (modo)
            {
                case ModoForm.Normal:
                    this.fgReservas.Enabled = true;
                    this.btnNueva.Enabled = true;
                    this.btnHanLlegado.Enabled = true;
                    this.btnImprimir.Enabled = true;
                    this.btnSalir.Enabled = true;
                    this.btnModificar.Enabled = true;
                    this.btnCancelarReserva.Enabled = true;
                    this.txtComensales.Enabled = false;
                    this.txtComentarios.Enabled = false;
                    this.txtHora.Enabled = false;
                    this.txtMesa.Enabled = false;
                    this.txtMinutos.Enabled = false;
                    this.txtNombre.Enabled = false;
                    this.txtTelefono.Enabled = false;
                    this.cmbTurno.Enabled = false;

                    this.btnCancelarReserva.Text = Properties.Resources.rxBtnCancelarNormal;
                    this.btnNueva.Text = Properties.Resources.rxBtnNuevoNormal;
                    this.btnModificar.Text = Properties.Resources.rxBtnModificarNormal;
                    break;
                case ModoForm.Editar:
                    this.fgReservas.Enabled = false;
                    this.btnNueva.Enabled = false;
                    this.btnHanLlegado.Enabled = false;
                    this.btnImprimir.Enabled = false;
                    this.btnSalir.Enabled = false;
                    this.btnModificar.Enabled = true;
                    this.btnCancelarReserva.Enabled = true;
                    this.txtComensales.Enabled = true;
                    this.txtComentarios.Enabled = true;
                    this.txtHora.Enabled = true;
                    this.txtMesa.Enabled = true;
                    this.txtMinutos.Enabled = true;
                    this.txtNombre.Enabled = true;
                    this.txtTelefono.Enabled = true;
                    this.cmbTurno.Enabled = true;

                    this.btnCancelarReserva.Text = Properties.Resources.rxBtnCancelarEdicion;
                    this.btnNueva.Text = Properties.Resources.rxBtnNuevoNormal;
                    this.btnModificar.Text = Properties.Resources.rxBtnModificarEdicion;
                    break;
                case ModoForm.Nueva:
                    this.fgReservas.Enabled = false;
                    this.btnNueva.Enabled = true;
                    this.btnHanLlegado.Enabled = false;
                    this.btnImprimir.Enabled = false;
                    this.btnSalir.Enabled = false;
                    this.btnModificar.Enabled = false;
                    this.btnCancelarReserva.Enabled = true;
                    this.txtComensales.Enabled = true;
                    this.txtComentarios.Enabled = true;
                    this.txtHora.Enabled = true;
                    this.txtMesa.Enabled = true;
                    this.txtMinutos.Enabled = true;
                    this.txtNombre.Enabled = true;
                    this.txtTelefono.Enabled = true;
                    this.cmbTurno.Enabled = true;

                    this.btnCancelarReserva.Text = Properties.Resources.rxBtnCancelarInsercion;
                    this.btnNueva.Text = Properties.Resources.rxBtnNuevoInsercion;
                    this.btnModificar.Text = Properties.Resources.rxBtnModificarNormal;
                    break;
                default:
                    break;
            }

            this.ModoActual = modo;
        }

        /// <summary>
        /// Formatea el grid dejándolo preparado para poner datos
        /// </summary>
        private void FormatearGrid()
        {
            this.fgReservas.Font = new Font(this.fgReservas.Font.FontFamily, 16, FontStyle.Bold);

            this.fgReservas.Cols.Count = 5;
            this.fgReservas.Cols.Fixed = 0;
            this.fgReservas.Rows.Count = 1;
            this.fgReservas.Rows.Fixed = 1;

            this.fgReservas.HighLight = HighLightEnum.Never;

            this.fgReservas.AllowEditing = false;
            this.fgReservas.SelectionMode = SelectionModeEnum.Row;

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

        /// <summary>
        /// Añade al grid los estilos para pintar celdas
        /// </summary>
        private void EstilosGrid()
        {
            if (this.fgReservas.Styles.Contains(eVerde)) this.fgReservas.Styles.Remove(eVerde);
            if (this.fgReservas.Styles.Contains(eRojo)) this.fgReservas.Styles.Remove(eRojo);

            CellStyle estilo;

            estilo= this.fgReservas.Styles.Add(eVerde);
            estilo.BackColor = Color.Green;

            estilo = this.fgReservas.Styles.Add(eRojo);
            estilo.BackColor = Color.Red;
        }

        /// <summary>
        /// Llena la grid con la información de BBDD de las reservas
        /// </summary>
        private void LlenarGrid()
        {
            List<Reserva> reservas = GestorReservas.Instance.GetListaPorDia(this.FechaActual);

            foreach (Reserva r in reservas)
            {
                this.CrearRow(r);
            }

        }

        /// <summary>
        /// Crea una row y la envía a rellenar
        /// </summary>
        /// <param name="r">Reserva con la que se llenará la row</param>
        private void CrearRow(Reserva r)
        {
            Row row = this.fgReservas.Rows.Add();

            this.LlenarRow(row, r);
        }

        /// <summary>
        /// Llena y colorea la row pasada por parámetro con la información de la reserva r
        /// </summary>
        /// <param name="row">Row a llenar</param>
        /// <param name="r">Reserva con la que se llena la row</param>
        private void LlenarRow(Row row, Reserva r)
        {
            row[cNombre] = r.Nombre;
            row[cMesa] = r.Mesa;
            row[cComensales] = r.Comensales;
            row[cHora] = r.Fecha;
            row[cHanLlegado] = r.HanLlegado;
            row.UserData = r;

            if (r.HanLlegado)
            {
                this.fgReservas.SetCellStyle(row.Index, cHanLlegado, eVerde);
            }
            else
            {
                this.fgReservas.SetCellStyle(row.Index, cHanLlegado, eRojo);
            }

            if (r.Fecha.TimeOfDay > DateTime.Now.TimeOfDay)
            {
                this.fgReservas.SetCellStyle(row.Index, cHora, eVerde);
            }
            else
            {
                this.fgReservas.SetCellStyle(row.Index, cHora, eRojo);
            }
        }

        /// <summary>
        /// Redimensiona las columnas de la grid dependiendo del tamaño del formulario
        /// </summary>
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

        /// <summary>
        /// Formatea, añade los estilos y llena de información la grid del formulario
        /// </summary>
        private void CargarGrid()
        {
            this.FormatearGrid();
            this.EstilosGrid();
            this.LlenarGrid();
        }

        /// <summary>
        /// Limpia las cajas de texto de la información que pueda haber
        /// </summary>
        private void LimpiarCajas()
        {
            this.txtComensales.Text = "";
            this.txtComentarios.Text = "";
            this.txtHora.Text = "";
            this.txtMesa.Text = "";
            this.txtMinutos.Text = "";
            this.txtNombre.Text = "";
            this.txtTelefono.Text = "";
            this.cmbTurno.SelectedItem = null;
        }

        /// <summary>
        /// Llena las cajas de texto con la información de la reserva r
        /// </summary>
        /// <param name="r">Reserva con la que se llenarán las cajas de texto</param>
        private void LlenarCajas(Reserva r)
        {
            if (r.Comensales.HasValue) this.txtComensales.Text = r.Comensales.Value.ToString();
            this.txtComentarios.Text = r.Comentarios;
            this.txtHora.Text = r.Fecha.Hour.ToString("D2");
            if (r.Mesa.HasValue) this.txtMesa.Text = r.Mesa.Value.ToString();
            this.txtMinutos.Text = r.Fecha.Minute.ToString("D2");
            this.txtNombre.Text = r.Nombre;
            this.txtTelefono.Text = r.Telefono;
            if(r.Turno.HasValue) this.cmbTurno.SelectedItem = (Enums.Turnos)r.Turno.Value;
        }

        /// <summary>
        /// Carga el combo con todos los valores de Enums.Turnos
        /// </summary>
        private void CargarCombo()
        {
            this.cmbTurno.Items.Clear();
            this.cmbTurno.Items.Add(Enums.Turnos.T1);
            this.cmbTurno.Items.Add(Enums.Turnos.T2);
            this.cmbTurno.Items.Add(Enums.Turnos.Unic);
        }

        /// <summary>
        /// Comprueba que los campos de texto esten rellenados correctamente
        /// </summary>
        /// <returns></returns>
        private bool ComprobarCampos()
        {
            if (this.txtNombre.Text == string.Empty)
            {
                MessageBox.Show(Properties.Resources.rxErrorCampoNombre, Properties.Resources.rxCampoIncompleto,
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            int horas, minutos;
            if (!int.TryParse(this.txtHora.Text, out horas) || !int.TryParse(this.txtMinutos.Text, out minutos))
            {
                MessageBox.Show(Properties.Resources.rxErrorCamposFecha, Properties.Resources.rxCampoErroneo,
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (horas < 0 || horas > 23 || minutos < 0 || minutos > 59)
            {
                MessageBox.Show(Properties.Resources.rxErrorCamposFecha, Properties.Resources.rxCampoErroneo,
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        /// <summary>
        /// Llena la reserva r con la información que hay en asl cajs de texto
        /// </summary>
        /// <param name="r">Reserva r a llenar con la información de los campos</param>
        /// <param name="bHanLlegado">Boleano para poner información en el campo HanLlegado de la reserva r</param>
        private void CrearReservaDesdeCampos(Reserva r, bool bHanLlegado)
        {
            int horas, minutos, mesa, comensales;

            r.Nombre = this.txtNombre.Text.Trim();

            horas = int.Parse(this.txtHora.Text.Trim());
            minutos = int.Parse(this.txtMinutos.Text.Trim());
            r.Fecha = new DateTime(this.FechaActual.Year, this.FechaActual.Month,
                this.FechaActual.Day, horas, minutos, 0);

            if (int.TryParse(this.txtMesa.Text.Trim(), out mesa))
            {
                r.Mesa = mesa;
            }
            else
            {
                r.Mesa = null;
            }

            if (int.TryParse(this.txtComensales.Text.Trim(), out comensales))
            {
                r.Comensales = comensales;
            }
            else
            {
                r.Comensales = null;
            }

            r.Telefono = this.txtTelefono.Text.Trim();

            r.HanLlegado = bHanLlegado;

            if (this.cmbTurno.SelectedItem is Enums.Turnos)
            {
                r.Turno = (int)(Enums.Turnos)this.cmbTurno.SelectedItem;
            }
            else
            {
                r.Turno = null;
            }

            r.Comentarios = this.txtComentarios.Text.Trim(); 

        }

        #endregion

        #region constructor

        public frmReservas()
        {
            InitializeComponent();
        }

        #endregion

        #region eventos

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

            this.CargarGrid();
            this.CargarCombo();

            this.CambiarModoForm(ModoForm.Normal);
        }

        private void frmReservas_SizeChanged(object sender, EventArgs e)
        {
            this.RedimensionarColsGrid();
        }

        private void btnNueva_Click(object sender, EventArgs e)
        {
            if (this.ModoActual == ModoForm.Nueva)
            {
                if (this.ComprobarCampos())
                {
                    Reserva r = new Reserva();

                    this.CrearReservaDesdeCampos(r, false);

                    GestorDAL.Context.Reservas.InsertOnSubmit(r);
                    GestorDAL.Context.SubmitChanges();

                    this.CargarGrid();

                    this.CambiarModoForm(ModoForm.Normal);
                }
            }
            else
            {
                this.LimpiarCajas();
                this.CambiarModoForm(ModoForm.Nueva);
                this.txtNombre.Focus();
            }
        }

        private void btnHanLlegado_Click(object sender, EventArgs e)
        {
            if (this.ReservaSel != null)
            {
                this.ReservaSel.HanLlegado = !this.ReservaSel.HanLlegado;

                GestorDAL.Context.SubmitChanges();

                this.CargarGrid();
            }
        }

        private void btnCancelarReserva_Click(object sender, EventArgs e)
        {
            switch (this.ModoActual)
            {
                case ModoForm.Normal:
                    if (this.ReservaSel != null)
                    {
                        GestorDAL.Context.Reservas.DeleteOnSubmit(this.ReservaSel);
                        GestorDAL.Context.SubmitChanges();

                        this.CargarGrid();
                    }
                    break;
                case ModoForm.Editar:
                    if (this.ReservaSel != null)
                    {
                        this.LlenarCajas(this.ReservaSel);
                    }
                    else
                    {
                        this.LimpiarCajas();
                    }
                    this.CambiarModoForm(ModoForm.Normal);
                    break;
                case ModoForm.Nueva:
                    if (this.ReservaSel != null)
                    {
                        this.LlenarCajas(this.ReservaSel);
                    }
                    else
                    {
                        this.LimpiarCajas();
                    }
                    this.CambiarModoForm(ModoForm.Normal);
                    break;
                default:
                    break;
            }
        }

        private void fgReservas_Click(object sender, EventArgs e)
        {
            if (this.ReservaSel != null)
            {
                this.LlenarCajas(this.ReservaSel);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (this.ModoActual == ModoForm.Editar)
            {
                if (this.ReservaSel != null)
                {
                    Reserva r = this.ReservaSel;

                    this.CrearReservaDesdeCampos(r, r.HanLlegado);

                    GestorDAL.Context.SubmitChanges();

                    this.CargarGrid();

                    this.CambiarModoForm(ModoForm.Normal);
                }
            }
            else
            {
                if (this.ReservaSel != null)
                {
                    this.LlenarCajas(this.ReservaSel);
                    this.CambiarModoForm(ModoForm.Editar);
                }
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            this.fgReservas.PrintGrid("aaa", PrintGridFlags.ShowPreviewDialog);
        }

        private void txtNumerico_KeyPress(object sender, KeyPressEventArgs e)
        {
            int result;
            if (!int.TryParse(e.KeyChar.ToString(), out result) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Delete)
            {
                e.Handled = true;
            }
        }

        #endregion
    }
}
