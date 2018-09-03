using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OracleClient;

namespace LibreriaOnTour.Consultas
{
    public class ConsultorBaseDatos
    {
        public List<Usuario> GetUsuarios()
        {
            List<Usuario> listado = new List<Usuario>();

            String commandText = "SELECT NOMBRE_USUARIO, PASSWORD FROM USUARIO";

            Usuario usuario = new Usuario();
            using (OracleConnection conector = Conexion.Conexion.Conectar())
            {
                conector.Open();

                OracleCommand command = new OracleCommand(commandText, conector);
                OracleDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    usuario.nombre = Convert.ToString(reader["NOMBRE_USUARIO"]);
                    usuario.password = Convert.ToString(reader["PASSWORD"]);
                    //usuario.tipoUsuario.id = Convert.ToInt32(reader["ID_TIPO_USUARIO"]);
                    //usuario.tipoUsuario.nombre = Convert.ToString(reader["NOMBRE_TIPO_USUARIO"]);

                    listado.Add(usuario);
                }
            }
            
            return listado;
        }


        public bool Validar(Usuario usuario)
        {
            bool estado = false;
            List<Usuario> usuarios = null;
            try
            {
                usuarios = GetUsuarios();

                foreach (var u in usuarios)
                {
                    if (u.nombre == usuario.nombre && u.password == usuario.password) 
                    {
                        estado = true;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return estado;
        }
    }
}
