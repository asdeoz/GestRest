using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GestRestDAL
{
    public class GestorReservas
    {
        #region propiedades
        private static GestorReservas _instance;

        public static GestorReservas Instance
        {
            get {
                if (_instance == null)
                {
                    _instance = new GestorReservas();
                }

                return _instance; 
            }
        }
        #endregion

        /// <summary>
        /// Devuelve una lista con todas las reservas del día pasado por parámetro
        /// </summary>
        /// <param name="fecha">Fecha de la que se quieren las reservas</param>
        /// <returns>Lista con todas las reservas del día</returns>
        public List<Reserva> GetListaPorDia(DateTime fecha)
        {
            List<Reserva> reservas = (from r in GestorDAL.Context.Reservas
                                      where r.Fecha.Date == fecha.Date
                                      orderby r.Fecha
                                      select r).ToList<Reserva>();
            return reservas;
        }

        /// <summary>
        /// Devuelve una lista de fechas en los que hay reservas de un mes y un año 
        /// señalados por la fecha pasada por parámetro
        /// </summary>
        /// <param name="fecha">Fecha para coger el mes y año para el que se quiere hacer la lista</param>
        /// <returns>Lista de fechas en los que hay reservas de un mes y un año</returns>
        public List<DateTime> GetListaDiasConReserva(DateTime fecha)
        {
            int mes, year;

            mes = fecha.Month;
            year = fecha.Year;

            List<DateTime> dias = (from r in GestorDAL.Context.Reservas
                                   where r.Fecha.Year == year && r.Fecha.Month == mes
                                   select r.Fecha.Date).Distinct<DateTime>().ToList<DateTime>();

            return dias;
        }
    }
}
