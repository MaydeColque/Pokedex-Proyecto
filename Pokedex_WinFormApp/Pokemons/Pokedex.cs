using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using negocio;

namespace Pokemons
{
    public partial class FormPrimeraApp : Form
    {
        private List<Pokemon> pokemons;
        //private Pokemon dgvItem;
        Pokemon pokeSeleccionado;
        public FormPrimeraApp()
        {
            InitializeComponent();
            toolTipPapelera.SetToolTip(btnPapelera, "Papelera");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cargarDgv();
        }
        private void cargarDgv()
        {
            PokemonNegocio listaPokemon = new PokemonNegocio();
            List<Pokemon> listaPokemonActivos = new List<Pokemon>();
            pokemons = listaPokemon.listaPokemons();
            listaPokemonActivos = pokemons.FindAll(p => p.Activo == 1);


            dgvNombresPokemon.DataSource = listaPokemonActivos;//Le pasamos la lista para que muestre los datos en una tabla, todas las propiedades del objeto en columnas. Los que tengas Get.
            //Config de estilo de la tabla
            dgvConfig();
        }
        private void dgvConfig()
        {
            dgvNombresPokemon.Columns["Numero"].Visible = false;
            dgvNombresPokemon.Columns["UrlImagen"].Visible = false;
            dgvNombresPokemon.Columns["Descripcion"].Visible = false;
            dgvNombresPokemon.Columns["Tipo"].Visible = false;
            dgvNombresPokemon.Columns["Debilidad"].Visible = false;
            dgvNombresPokemon.Columns["Id"].Visible = false;
            dgvNombresPokemon.Columns["Activo"].Visible = false;
        }
        private void dgvNombresPokemon_SelectionChanged(object sender, EventArgs e) //Este evento detecta cuando cambia la seleccion y se activa.
        {
            Pokemon itemSeleccionado = (Pokemon)dgvNombresPokemon.CurrentRow.DataBoundItem;//Se usa para obtener el objeto seleccionado en el momento actual.
            //Ahora podemos acceder a las propiedades de los pokemons que se encuentren seleccionados en nuestra tabla.
            cargarImagen(itemSeleccionado.UrlImagen, pBoxPokemon);//cómo itemSeleccionado es un Pokemon se puede acceder a la propiedad UrlImagen.
            //Este metodo, carga y muestra la imagen de cada pokemon.
            
            //Mostramos los datos que necesitamos los cuales cambian en cuanto se cambia la selección.
            lblNombre.Text = itemSeleccionado.Nombre;
            string numeroPokemon = $"N°00{itemSeleccionado.Numero}";
            lblNumero.Text = numeroPokemon;
            lblDescripcion.Text = itemSeleccionado.Descripcion;
            
            //Aquí en la label se esta guardando la descripción de la propiedad Tipo del objeto seleccionado.
            //Tanto el tipo como la debilidad son propiedades de tipo Elemento. Es decir, son instancias de la clase Elemento.
            tipoPokemon.Text = itemSeleccionado.Tipo.Descripcion;//Debemos acceder exactamente a la propiedad que queremos que muestre.
            debilidadPokemon.Text = itemSeleccionado.Debilidad.Descripcion;//Dado que es un Objeto y no puede transformarlo en String.
            
        }


        private void bulbasaurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Muestra un link, Bulbasaur cuando lo elegimos en el menú.
            MessageBox.Show($"{pokemons[0].Nombre}. Para más información: https://www.pokemon.com/es/pokedex/bulbasaur");
            
            //
            //Como hacer para que desde el menú, podamos elegir a los pokemons sin tener la tabla.
            //
        }

        private void btnPokedexWeb_Click(object sender, EventArgs e)
        {
            //Accede nuevamente al pokemon "actualmente" seleccionado en la tabla.
            //Pokemon itemSeleccionado = (Pokemon)dgvNombresPokemon.CurrentRow.DataBoundItem;

            //Para no crear nuevamente un pokemon y volver a consultar por el itemSelecionado:
            try
            {
                string Url = $"https://www.pokemon.com/es/pokedex/{pokeSeleccionado.Nombre}";
                Process.Start(Url); //Sirve para abrir la Url, y dirigirnos al navegador.
            }
            catch (Exception)
            {

                MessageBox.Show("El link a esta imagen no es correcto. Por favor, revise su Base de Datos y modifiquelo.");
            }
            
        }

        //Metodos
        public void cargarImagen(string Url, PictureBox nombre)
        {
            try
            {
                nombre.Load(Url);//los pictureBox tienen un método que lee las url y las abre(muestra la imagen).
            }
            catch (Exception ex)//capta un error general.
            {
                //si la url no es correcta, la celda se encuentra vacia, cualquiera que sea el error va a mostrar la siguiente imagen.
                nombre.Load("https://tse2.mm.bing.net/th?id=OIP.2KdMLsskO-By1dqK2epgegHaHa&pid=Api&P=0");
                //excepto cuando encutra un DBNull.
            }
        }

        private void btnNewPokemon_Click(object sender, EventArgs e)
        {
            //Este evento instancia la ventana "frmNuevoPokemon" y luego la muestra.
            frmNuevoPokemon ventanaNuevoPokemon = new frmNuevoPokemon();
            ventanaNuevoPokemon.ShowDialog();//Hasta que no cerremos esta ventana no nos permitira usar otra función de la app.
            //Esto por el Dialog.
            cargarDgv();
        }
        private void itemSeleccionadoDGV()
        {
            //Este método devuelve el objeto actualmente seleccionado. 
            if (dgvNombresPokemon.CurrentRow.DataBoundItem is null)
            {
                MessageBox.Show("Asegurese de seleccionar un pokémon...");
                return;
            }
            pokeSeleccionado = (Pokemon)dgvNombresPokemon.CurrentRow.DataBoundItem;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            itemSeleccionadoDGV();
            PokemonNegocio pokemonEliminar = new PokemonNegocio();
            pokemonEliminar.eliminar(pokeSeleccionado, true);
            cargarDgv();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            itemSeleccionadoDGV();
            frmNuevoPokemon ventanaModificar = new frmNuevoPokemon(pokeSeleccionado);
            ventanaModificar.ShowDialog();
            cargarDgv();
        }

        private void btnPapelera_Click(object sender, EventArgs e)
        {
            Papelera papelera = new Papelera();
            papelera.ShowDialog();
            cargarDgv();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string textoBuscado = txtBuscar.Text;
            List<Pokemon> listaBusqueda = pokemons.FindAll(p => p.Nombre.ToLower().Contains(textoBuscado.ToLower()));
            dgvNombresPokemon.DataSource = listaBusqueda;
            dgvConfig();
        }

        private void btnLimpiarBuscador_Click(object sender, EventArgs e)
        {
            txtBuscar.Text = "";
            cargarDgv();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "")
                cargarDgv();
        }
    }
}
