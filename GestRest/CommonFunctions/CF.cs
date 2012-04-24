using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Utils;

namespace GestRest.CommonFunctions
{
    public static class CF
    {
        public static string DiaSemanaString(Enums.Dias dia)
        {
            switch (dia)
            {
                case Enums.Dias.Lunes:
                    return Properties.Resources.rxLunes;
                case Enums.Dias.Martes:
                    return Properties.Resources.rxMartes;
                case Enums.Dias.Miercoles:
                    return Properties.Resources.rxMiercoles;
                case Enums.Dias.Jueves:
                    return Properties.Resources.rxJueves;
                case Enums.Dias.Viernes:
                    return Properties.Resources.rxViernes;
                case Enums.Dias.Sabado:
                    return Properties.Resources.rxSabado;
                case Enums.Dias.Domingo:
                    return Properties.Resources.rxDomingo;
            }

            return string.Empty;
        }

        public static string MesFechaString(Enums.Meses mes)
        {
            switch (mes)
            {
                case Enums.Meses.Enero:
                    return Properties.Resources.rxEnero;
                case Enums.Meses.Febrero:
                    return Properties.Resources.rxFebrero;
                case Enums.Meses.Marzo:
                    return Properties.Resources.rxMarzo;
                case Enums.Meses.Abril:
                    return Properties.Resources.rxAbril;
                case Enums.Meses.Mayo:
                    return Properties.Resources.rxMayo;
                case Enums.Meses.Junio:
                    return Properties.Resources.rxJunio;
                case Enums.Meses.Julio:
                    return Properties.Resources.rxJulio;
                case Enums.Meses.Agosto:
                    return Properties.Resources.rxAgosto;
                case Enums.Meses.Setiembre:
                    return Properties.Resources.rxSetiembre;
                case Enums.Meses.Octubre:
                    return Properties.Resources.rxOctubre;
                case Enums.Meses.Noviembre:
                    return Properties.Resources.rxNoviembre;
                case Enums.Meses.Diciembre:
                    return Properties.Resources.rxDiciembre;
            }

            return string.Empty;
        }
    }
}
