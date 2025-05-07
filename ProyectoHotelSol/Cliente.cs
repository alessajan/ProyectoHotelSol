using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoHotelSol
{
    internal class Cliente
    {
        public int id_cliente { set;get; }
        public string Nombre { set;get; }
        public string Ap_paterno { set;get; }
        public string Ap_materno { set;get; }
        public int Edad { set;get; }
        public string RFC { set; get; }
    }
}
