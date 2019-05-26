using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_LibroCSharp.Cap._9.Entidades
{
    class InventarioTienda
    {
        public string ProductoId { get; set; }
        public string Nombre { get; set; }
        public float Precio { get; set; }
        public float Cantidad { get; set; }
        public DateTime FechaIngreso { get; set; }

        public InventarioTienda()
        {
            ProductoId = string.Empty;
            Nombre = string.Empty;
            Precio= 0;
            Cantidad = 0;
            FechaIngreso = DateTime.Now;
        }

    }
}

