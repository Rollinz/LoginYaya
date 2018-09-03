using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LibreriaOnTour.Consultas;

namespace Prueba
{
    public class Program
    {
        static void Main(string[] args)
        {
            /**Usuario usuario = new Usuario();
            //TipoUsuario tipoUsuario = new TipoUsuario();
            usuario.nombre = "ev_001";
            usuario.password = "ev_001";
            //tipoUsuario.id = 1;
            //tipoUsuario.nombre = "Ejecutivo_Ventas";
            //usuario.tipoUsuario = tipoUsuario;
            ConsultorBaseDatos consultor = new ConsultorBaseDatos();

            if (consultor.Validar(usuario))
            {
                Console.WriteLine("Bienvenido");
            }
            else
            {
                Console.WriteLine("Error");
            }
        */

            foreach (var item in new ConsultorBaseDatos().GetUsuarios())
            {
                Console.WriteLine(item.nombre);
            }
            Console.ReadKey();
        }
    }
}
