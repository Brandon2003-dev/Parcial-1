using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


public class Venta
    {
        public int IdProducto { get; set; }
        public string NombreProducto { get; set; }
        public string DescripcionProducto { get; set; }
        public double PrecioProducto { get; set; }
        public int CantidadProducto { get; set; }

        public Venta(int idProducto, string nombreProducto, string descripcionProducto, double precioProducto, int cantidadProducto)
        {
            IdProducto = idProducto;
            NombreProducto = nombreProducto;
            DescripcionProducto = descripcionProducto;
            PrecioProducto = precioProducto;
            CantidadProducto = cantidadProducto;
        }
    }