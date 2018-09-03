using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OracleClient;

namespace LibreriaOnTour.Consultas
{
    public class ConsultorBaseDatos
    {
        
        public bool autenticar(Usuario usuario)
        {
            String commandText = "SELECT * FROM USUARIO"
            using (OracleConnection conector = Conexion.Conexion.Conectar())
            {
                conector.Open();

                OracleCommand command = new OracleCommand(commandText, conector);
            }
            
            return false;
        }
    }
}
