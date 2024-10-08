using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using negocio;
using System.Configuration;

namespace Pokemons
{
    /*
        Agregar la función de guardar una imagen desde la compu y de descargar imagen
     */
    public partial class frmNuevoPokemon : Form
    {
        Pokemon pokemonModificar = null;
        OpenFileDialog archivo = null;
        Color colorRojoClaro = Color.FromArgb(255, 255, 192, 192);
        public frmNuevoPokemon()
        {
            InitializeComponent();
        }
        public frmNuevoPokemon(Pokemon pokemon)
        {
            InitializeComponent();
            pokemonModificar = pokemon;
            this.Text = "Modificar Pokémon";
            btnAgregar.Text = "Modificar";
        }
        //Métodos
        private void capturarDatos(Pokemon pokemon)
        {
            pokemon.Numero = verificarCampoNumero(txtNumero.Text);
            pokemon.Nombre = txtNombre.Text;
            pokemon.Descripcion = txtDescripcion.Text;
            pokemon.UrlImagen = txtUrlImagen.Text;
            pokemon.Tipo = (Elemento)cBxTipo.SelectedItem;
            pokemon.Debilidad = (Elemento)cBxDebilidad.SelectedItem;
        }
        private void cargarImagen(string url)
        {
            FormPrimeraApp metodoForm = new FormPrimeraApp();
            metodoForm.cargarImagen(url, pBxPokemon);
        }
        private bool esNumero(string cadena)
        {
            //Revisa si hay algún ítem que sea texto. Permite el ingreso del punto.
            foreach (char caracter in cadena)
            {
                if (!char.IsNumber(caracter) && caracter != '.')
                {
                    return false;
                }
            }
            return true;
        }
        private int verificarCampoNumero(string textoEntrada)
        {
            int numero = 0;
            if (esNumero(textoEntrada) && textoEntrada != "")
            {
                numero = int.Parse(textoEntrada);
                return numero;
            }
            else if (textoEntrada == "")
            {
                campoVacioMsj("Número");
                return numero;
            }
            else
            {
                MessageBox.Show("El valor ingresado para numero no es válido.", "Valor Inválido.");
                return numero; 
            }
        }
        private void campoVacioMsj(string nombreCampo)
        {
            MessageBox.Show($"El campo {nombreCampo} está vacío.", "Campo Obligatorio Vacío.", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        //Eventos
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();//Cierra la ventana.
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Captura crea nuevas instancias de un Pokemon y de negocio
            Pokemon pokemon = new Pokemon();
            PokemonNegocio negocio = new PokemonNegocio();

            // Si es un nuevo Pokémon
            if (pokemonModificar is null)
            {
                capturarDatos(pokemon);
                if (pokemon.Numero == 0 || txtNombre.BackColor == colorRojoClaro)
                    return;
                negocio.agregar(pokemon); // Agrega el Pokémon a la BD
                MessageBox.Show("Pókemon Agregado.");
            }
            else
            {
                // Modificar
                capturarDatos(pokemonModificar);
                if (pokemonModificar.Numero == 0 || txtNombre.BackColor == colorRojoClaro)
                    return;
                negocio.modificar(pokemonModificar); // Accede a la base de datos y modifica
                MessageBox.Show("Datos del Pókemon Modificados.");
            }

            Close(); // Cierra el formulario
        }



        private void txtUrlImagen_Leave(object sender, EventArgs e)
        {
            cargarImagen(txtUrlImagen.Text);
        }

        private void frmNuevoPokemon_Load(object sender, EventArgs e)
        {
            ElementoNegocio negocioElemento = new ElementoNegocio();
            cBxTipo.DataSource = negocioElemento.listarElementos();
            cBxTipo.ValueMember = "Id";
            cBxTipo.DisplayMember = "Descripcion";
            cBxDebilidad.DataSource = negocioElemento.listarElementos();
            cBxDebilidad.ValueMember = "Id";
            cBxDebilidad.DisplayMember = "Descripcion";
            toolTipImagenLocal.SetToolTip(this.btnAgregarImgLocal, "Agregar Imagen Local");
            if (pokemonModificar != null)
            {
                txtNumero.Text = $"{pokemonModificar.Numero}";
                txtNombre.Text = pokemonModificar.Nombre;
                txtDescripcion.Text = pokemonModificar.Descripcion;
                txtUrlImagen.Text = pokemonModificar.UrlImagen;
                cBxTipo.SelectedValue = pokemonModificar.Tipo.Id;
                cBxDebilidad.SelectedValue = pokemonModificar.Debilidad.Id;
                cargarImagen(txtUrlImagen.Text);
            }
            else
            {
                cBxTipo.DataSource = negocioElemento.listarElementos();
                cBxDebilidad.DataSource = negocioElemento.listarElementos();
            }
            
        }

        private void txtNumero_Leave(object sender, EventArgs e)
        {
            if (verificarCampoNumero(txtNumero.Text) == 0)
            {
                
                txtNumero.BackColor = colorRojoClaro;
            }
            else
            {
                txtNumero.BackColor = SystemColors.Window;
            }
        }

        private void txtNombre_Leave(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                campoVacioMsj("Nombre");
                txtNombre.BackColor = colorRojoClaro;
            }
            else
            {
                txtNombre.BackColor = SystemColors.Window;
            }
        }

        private void btnAgregarImgLocal_Click(object sender, EventArgs e)
        {
            if (archivo == null)
            {
                archivo = new OpenFileDialog();
            }
            archivo.Filter = "jpg |* .jpg | png |* .png";
            if (archivo.ShowDialog() == DialogResult.OK)
            {
                txtUrlImagen.Text = archivo.FileName;
                cargarImagen(archivo.FileName);
            }
        }
    }
}
