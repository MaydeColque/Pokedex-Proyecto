using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Pokemons
{
    public class AccesoDatos
    {
        private SqlConnection conexion;
        private SqlCommand comando;
        private SqlDataReader lector;
        public SqlDataReader Lector {
            get { return lector; }
        }
        public AccesoDatos() {
            conexion = new SqlConnection("server=.\\SQLEXPRESS; database=POKEMON_DB; integrated security=true");
            comando = new SqlCommand();
        }
        public void cambiarConsulta(string consulta)
        {
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = consulta;
        }
        public void ejecutarLector()//Para obtener un Lector y que se posicione en la DB.
        {
            comando.Connection= conexion;
            
            try
            {
                conexion.Open();
                lector = comando.ExecuteReader();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            //finally { conexion.Close(); }
        }
        public void setParametro(string nombre, object valor)
        {
            comando.Parameters.AddWithValue(nombre, valor);
        }
        public void ejecutarInstruccion()
        {
            //Le pasamos la conexion al comando
            comando.Connection= conexion;
            try
            {
                conexion.Open();//Abrimos la conexion y accedemos a la DB
                comando.ExecuteNonQuery();//Va a ejecuatar un una instruccion que no es una consulta de tipo mostrar.

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { conexion.Close(); }
        }
        public void cerrarConexion()//Cierra la conexion y el lector en caso de que haya uno abierto.
        {
            if (lector != null)
            {
                lector.Close();
            }
            conexion.Close();
        }
    }
}
