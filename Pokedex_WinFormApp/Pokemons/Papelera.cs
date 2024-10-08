using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pokemons
{
    public partial class Papelera : Form
    {
        List<Pokemon> listaPokemonsInactivos = null;
        Pokemon seleccionado = null;
        public Papelera()
        {
            InitializeComponent();
            toolTipRecuperar.SetToolTip(btnReestablecer, "Reestablecer");
            toolTipEliminar.SetToolTip(btnEliminar, "Eliminar");
        }
        //Metodos
        private List<Pokemon> obtenerListaPokeInactivos()
        {
            PokemonNegocio crearLista = new PokemonNegocio();
            List<Pokemon> listaPokemons = crearLista.listaPokemons();
            listaPokemonsInactivos = listaPokemons.FindAll(poke => poke.Activo == 0);
            return listaPokemonsInactivos;
        }
        private void cargarDgv()
        {
            dgvPokemonsInactivos.DataSource = obtenerListaPokeInactivos();//Le pasamos la lista para que muestre los datos en una tabla, todas las propiedades del objeto en columnas. Los que tengas Get.
            //Config de estilo de la tabla
            dgvPokemonsInactivos.Columns["Numero"].Visible = false;
            dgvPokemonsInactivos.Columns["UrlImagen"].Visible = false;
            dgvPokemonsInactivos.Columns["Descripcion"].Visible = false;
            dgvPokemonsInactivos.Columns["Tipo"].Visible = false;
            dgvPokemonsInactivos.Columns["Debilidad"].Visible = false;
            dgvPokemonsInactivos.Columns["Id"].Visible = false;
            dgvPokemonsInactivos.Columns["Activo"].Visible = false;
        }
        private void cargarImagen(string url, PictureBox nombreElemento)
        {
            try
            {
                nombreElemento.Load(url);
            }
            catch(Exception ex)
            {
                nombreElemento.Load("https://tse2.mm.bing.net/th?id=OIP.2KdMLsskO-By1dqK2epgegHaHa&pid=Api&P=0");
            }
        }
        private void pokemonSeleccionado()
        {
            if (dgvPokemonsInactivos.CurrentRow.DataBoundItem == null)
            {
                MessageBox.Show("Asegurese de seleccionar un Pokémon... ", "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            seleccionado = (Pokemon)dgvPokemonsInactivos.CurrentRow.DataBoundItem;
        }
        //Eventos
        private void Papelera_Load(object sender, EventArgs e)
        {
            listaPokemonsInactivos = obtenerListaPokeInactivos();
            if ( listaPokemonsInactivos.Count == 0)
            {
                MessageBox.Show("No hay Pokémons en la papelera en este momento.", "Papelera Vacía...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            cargarDgv();
        }

        private void dgvPokemonsInactivos_SelectionChanged(object sender, EventArgs e)
        {
            pokemonSeleccionado(); //Obtenemos y cargamos la variable seleccionado.
            lblNombre.Text = seleccionado.Nombre;
            lblNumero.Text = $"N°00{seleccionado.Numero}";
            debilidadPokemon.Text = seleccionado.Debilidad.Descripcion;
            tipoPokemon.Text = seleccionado.Tipo.ToString();
            cargarImagen(seleccionado.UrlImagen, pBoxPokemon);
        }

        private void btnReestablecer_Click(object sender, EventArgs e)
        {
            pokemonSeleccionado();
            string nombre = seleccionado.Nombre;
            PokemonNegocio pokeAux = new PokemonNegocio();
            pokeAux.reestablecer(seleccionado);
            int cantPokes = listaPokemonsInactivos.Count - 1;
            if (cantPokes == 0)
            {
                MessageBox.Show($"Se ha recuperado a {nombre}. La papelera esta vacía, se habilitará cuando elimine Pokémons.", "Papelera Vacía...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else
            {
                MessageBox.Show($"Se ha recuperado a {nombre}.", "Pokémon recuperado...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cargarDgv();
            }
                
        }

        private void btnRecuperarTodos_Click(object sender, EventArgs e)
        {
            PokemonNegocio pokeAux = new PokemonNegocio();
            pokeAux.reestablecerTodos();
            MessageBox.Show("Se han recuperado todos los Pokémons de la papelera. La papelera esta vacía, se habilitará cuando elimine Pokémons", "Papelera Vacía...", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            pokemonSeleccionado();
            string nombrePoke = seleccionado.Nombre;
            PokemonNegocio pokeAux = new PokemonNegocio();
            DialogResult resultado = MessageBox.Show($"¿Deseas elimininar a {seleccionado.Nombre} definitivamente? Recuerda: Se eliminará de forma permanente.", $"Confirmación eliminar {seleccionado.Nombre}...", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (resultado == DialogResult.Yes)
            {
                pokeAux.eliminar(seleccionado);
                int contPokes = listaPokemonsInactivos.Count - 1;
                if (contPokes == 0)
                {
                    MessageBox.Show($"Se ha eliminado permanentemente a {nombrePoke} de la papelera. La papelera esta vacía, se habilitará cuando elimine Pokémons.", "Papelera Vacía...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    MessageBox.Show($"Se ha eliminado permanentemente a {nombrePoke}.", "Pokémon recuperado...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cargarDgv();
                }
            }
            else
            {
                MessageBox.Show($"Eliminar a {nombrePoke} fue cancelada con éxito.", "Notificación...", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEliminarTodos_Click(object sender, EventArgs e)
        {
            pokemonSeleccionado();
            PokemonNegocio pokeAux = new PokemonNegocio();
            DialogResult resultado = MessageBox.Show("¿Deseas elimininar todos los Pokémons definitivamente? Recuerda: Se eliminarán permanentemente.", "Confirmación eliminar todos...", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (resultado == DialogResult.Yes)
            {
                pokeAux.eliminar(seleccionado, false, true);
                MessageBox.Show("Se han eliminado permanentemente todos los Pokémons de la papelera. La papelera esta vacía, se habilitará cuando elimine Pokémons.", "Papelera Vacía...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            else
            {
                MessageBox.Show("Acción de Eliminar todos cancelada con éxito.", "Notificación...", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
