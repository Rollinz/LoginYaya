using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OracleClient;

namespace LibreriaOnTour.Conexion
{
    public class Conexion
    {
        private static OracleConnection oracle = null;
        private static string cadenaConexion = "Data Source=localhost;Persist Security Info=True;User ID=ROLANDO;Password=7551;Unicode=True";
        public static OracleConnection Conectar()
        {
            oracle = new OracleConnection(cadenaConexion);
            return oracle;
        }
    }
}
