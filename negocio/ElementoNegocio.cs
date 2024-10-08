using Pokemons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace negocio
{
    public class ElementoNegocio
    {

        public List<Elemento> listarElementos()
        {
            List<Elemento> listaElementos = new List<Elemento>();
            AccesoDatos accesoDatos = new AccesoDatos();
            try 
	        {	        
		        accesoDatos.cambiarConsulta("select Id, Descripcion from ELEMENTOS");
                accesoDatos.ejecutarLector();
                while (accesoDatos.Lector.Read())//El método read retorna true si hay lineas para seguir leyendo la DB. O false sino es así.
                {
                    Elemento elemento = new Elemento();
                    elemento.Id = (int)accesoDatos.Lector["Id"];
                    elemento.Descripcion = (string)accesoDatos.Lector["Descripcion"];

                    listaElementos.Add(elemento);
                }

            
                return listaElementos;
            }

	        catch (Exception ex)
	        {

		        throw ex;
	        }
            finally { accesoDatos.cerrarConexion(); }
        }
    }
            
}
        
