using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Treda_Solution_Api.git.Models.Request
{
    public class TiendaRequest
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaApertura { get; set; }
    }
}
