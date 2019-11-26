using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda_ArtChik
{
    class Global
    {
        public static class cliente
        {
            private static string nome = ""; //sim,não
            public static string clientes
            {
                get { return nome; }
                set { nome = value; }
            }
            
        }
        public static class alarme
        {
            private static string nome1 = ""; //sim,não
            public static string Alarme1
            {
                get { return nome1; }
                set { nome1 = value; }
            }

        }
    }
}
