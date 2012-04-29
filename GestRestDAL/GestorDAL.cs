using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GestRestDAL
{
    public static class GestorDAL
    {
        private static GestRestDCDataContext _context;

        public static GestRestDCDataContext Context
        {
            get {
                if(GestorDAL._context == null)
                {
                    GestorDAL._context = InicializaGestor();
                }

                return GestorDAL._context;
            }
        }

        private static GestRestDCDataContext InicializaGestor()
        {
            return new GestRestDCDataContext();
        }

    }
}
