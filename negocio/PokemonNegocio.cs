using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
//using modelo;

namespace Pokemons
{
    public class PokemonNegocio //Aqui se configura todo de la base de datos, pero una vez ordenado en capas no.
		//Lo dejo así, a modo de recordar como empezamos a aprenderlo.
    {
        public List<Pokemon> listaPokemons()//Crear una lista de pokemos con datos de la DB
        {
            //Declaramos lo que vamos a usar
            List<Pokemon> listaPokemons = new List<Pokemon>(); //instanciamos la lista
            SqlConnection conexion = new SqlConnection();
			SqlCommand comando = new SqlCommand();
			SqlDataReader lector;

			try
			{
				conexion.ConnectionString = "server=.\\SQLEXPRESS; database=POKEMON_DB; integrated security=true";
				comando.CommandType = System.Data.CommandType.Text;
				comando.CommandText = "select E.Id IdTipo, D.Id IdDebilidad, P.Id, Numero, Nombre, P.Descripcion, UrlImagen, E.Descripcion Tipo, D.Descripcion Debilidad, P.Activo from POKEMONS P, ELEMENTOS E, ELEMENTOS D where E.Id = P.IdTipo AND D.Id = P.IdDebilidad";
				comando.Connection= conexion;

				//Abrimos la conexión
				conexion.Open();
				lector= comando.ExecuteReader();

				while (lector.Read())
				{
					//Obtenemos todos los datos necesarios de la DB. Y lo guardamos en la colleción tipo lista.
					Pokemon pokemonAux = new Pokemon();
					pokemonAux.Id = (int)lector["Id"];
					pokemonAux.Numero = (int)lector["Numero"];
					pokemonAux.Nombre = (string)lector["Nombre"];
					pokemonAux.Descripcion = (string)lector["Descripcion"];
					if (!(lector["UrlImagen"] is DBNull))
					{
                        pokemonAux.UrlImagen = (string)lector["UrlImagen"];
                    }
					pokemonAux.Debilidad = new Elemento();
					pokemonAux.Debilidad.Descripcion = (string)lector["Debilidad"];
                    pokemonAux.Debilidad.Id = (int)lector["IdDebilidad"];
                    pokemonAux.Tipo = new Elemento();
					pokemonAux.Tipo.Descripcion = (string)lector["Tipo"];
					pokemonAux.Tipo.Id = (int)lector["IdTipo"];
					pokemonAux.Activo = (int)lector["Activo"];

					listaPokemons.Add(pokemonAux);
				}
				conexion.Close();

				return listaPokemons;
			}
			catch (Exception ex)
			{

				 throw ex;
			}
        }
		public void agregar(Pokemon nuevoPokemon)
		{
			AccesoDatos datos = new AccesoDatos();
			
			try
			{
				datos.cambiarConsulta($"insert into POKEMONS(Numero, Nombre, Descripcion,UrlImagen,IdTipo,IdDebilidad,Activo) values ({nuevoPokemon.Numero}, '{nuevoPokemon.Nombre}','{nuevoPokemon.Descripcion}','{nuevoPokemon.UrlImagen}',{nuevoPokemon.Tipo.Id},{nuevoPokemon.Debilidad.Id},1)");
				datos.ejecutarInstruccion();
			}
			catch (Exception ex)
			{

				throw ex;
			}
		}
        public void modificar(Pokemon pokemonAModificar)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.cambiarConsulta("update POKEMONS set Numero = @numero, Nombre = @nombre, Descripcion = @descripicion, UrlImagen = @urlImagen, IdTipo = @idTipo, IdDebilidad = @idDebilidad, IdEvolucion = NULL, Activo = 1 where Id = @id");
				datos.setParametro("@numero", pokemonAModificar.Numero);
				datos.setParametro("@nombre", pokemonAModificar.Nombre);
                datos.setParametro("@descripicion", pokemonAModificar.Descripcion);
                datos.setParametro("@urlImagen", pokemonAModificar.UrlImagen); 
                datos.setParametro("@idTipo", pokemonAModificar.Tipo.Id);
                datos.setParametro("@idDebilidad", pokemonAModificar.Debilidad.Id);
                datos.setParametro("@id", pokemonAModificar.Id);

                datos.ejecutarInstruccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
		public void eliminar(Pokemon eliminarPokemon, bool eliminarLogico = false, bool eliminarTodos = false)
		{
			AccesoDatos datos = new AccesoDatos();
			try
			{
				if (eliminarLogico)
				{
                    datos.cambiarConsulta("update POKEMONS set Activo = 0 where Id = @Id");
					datos.setParametro("@Id", eliminarPokemon.Id);
                    datos.ejecutarInstruccion();
                    //Falta
                    /*
					 Cargar el datagridview solo con los pokemons activos [Listo]
					Mostrar en papelera los inactivos [Listo]
					Hacer la funcion de eliminar fisico [Listo]
					 */
                }
                else if(eliminarTodos)
				{
                    datos.cambiarConsulta("delete from POKEMONS where Activo = 0");
                    datos.ejecutarInstruccion();
                }
				else
				{
                    datos.cambiarConsulta("delete from POKEMONS where Id = @Id");
                    datos.setParametro("@Id", eliminarPokemon.Id);
                    datos.ejecutarInstruccion();
                }
			}
            catch (Exception ex)
            {

                throw ex;
            }
        }
		public void reestablecer(Pokemon pokeReestablecer)
		{
			AccesoDatos datos = new AccesoDatos();
			try
			{
				datos.cambiarConsulta("update POKEMONS set Activo = 1 where Id = @Id");
				datos.setParametro("@Id", pokeReestablecer.Id);
				datos.ejecutarInstruccion();
			}
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public void reestablecerTodos()
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.cambiarConsulta("update POKEMONS set Activo = 1");
                datos.ejecutarInstruccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
