using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LibreriaOnTour.Consultas
{
    public class Usuario
    {
        public string nombre { get; set; }
        public string password { get; set; }
        public TipoUsuario tipoUsuario { get; set; }
    }
}
