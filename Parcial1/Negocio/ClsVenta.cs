using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Parcial1.Entidades;

public static class ClsVenta
    {
        public static double Cobro(Venta venta)
        {
            double precioSinDescuento = venta.PrecioProducto * venta.CantidadProducto;

            if (precioSinDescuento > 50)
            {
                precioSinDescuento -= 10;
                Console.WriteLine($"Precio_original: ${venta.PrecioProducto * venta.CantidadProducto}. Precio_con_descuento: ${precioSinDescuento}.");
            }

            return precioSinDescuento;
        }
    }