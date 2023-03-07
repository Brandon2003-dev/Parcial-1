using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Drawing;
using Parcial1.Entidades;
using Parcial1.Negocio;


namespace VentaDeProductos
{
    class Program
    {
        static void Main(string[] args)
        {
            Usuario usuario = new Usuario("TU_NOMBRE", "123");

            if (ClsUsuario.Acceso(usuario))
            {
                Console.WriteLine("Inicio_de_sesión_correcto. Puede_continuar_con_el_proceso_de_venta.");
                Console.WriteLine();

                Console.Write("Ingrese_el_identificador_del_producto: ");
                int idProducto = int.Parse(Console.ReadLine());

                Console.Write("Ingrese_el_nombre_del_producto: ");
                string nombreProducto = Console.ReadLine();

                Console.Write("Ingrese_la_descripción_del_producto: ");
                string descripcionProducto = Console.ReadLine();

                Console.Write("Ingrese_el_precio_del_producto: ");
                double precioProducto = double.Parse(Console.ReadLine());

                Console.Write("Ingrese_la_cantidad_de_producto: ");
                int cantidadProducto = int.Parse(Console.ReadLine());

                Venta venta = new Venta(idProducto, nombreProducto, descripcionProducto, precioProducto, cantidadProducto);

                double precioVenta = ClsVenta.Cobro(venta);

                Console.WriteLine();
                Console.WriteLine($"Total_a_pagar: ${precioVenta}");
            }
            else
            {
                Console.WriteLine("Nombre_de_usuario_incorrecto.");
            }
        }
    }
}
