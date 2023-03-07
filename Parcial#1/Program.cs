using System;
using parcial1.Entidades;
using Parcial1.Negocio;
using System.Drawing;

namespace VentaDeProductos
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creación de un usuario predefinido
            Usuario usuario = new Usuario("TU_NOMBRE", "123");

            // Acceso al negocio para verificar el usuario y la contraseña
            if (ClsUsuario.Acceso(usuario))
            {
                Console.WriteLine("Inicio_de_sesión_correcto. Puede_continuar_con_el_proceso_de_venta.");
                Console.WriteLine();

                // Captura de los datos del producto por teclado
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

                // Creación del objeto Venta con los datos del producto
                Venta venta = new Venta(idProducto, nombreProducto, descripcionProducto, precioProducto, cantidadProducto);

                // Cobro de la venta y cálculo del precio final
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
