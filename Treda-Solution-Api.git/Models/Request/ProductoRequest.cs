using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Treda_Solution_Api.git.Models.Request
{
    public class ProductoRequest
    {
        public string Nombre { get; set; }
        [Key]
        public int SKU { get; set; }
        public string Descripcion { get; set; }
        public int Valor { get; set; }
        public int Tienda { get; set; }
        public string Imagen { get; set; }
    }
}
