using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;//El DisplayName lo usa.
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemons
{
    public class Pokemon
    {
        public int Id { get; set; }
        public int Numero { get; set; }

        [DisplayName("Nombres")]
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string UrlImagen { get; set; }
        public Elemento Tipo { get; set; }
        public Elemento Debilidad { get; set; }
        public int Activo { get; set; }
    }
}
