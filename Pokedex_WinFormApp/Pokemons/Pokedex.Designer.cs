namespace Pokemons
{
    partial class FormPrimeraApp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.pBoxPokemon = new System.Windows.Forms.PictureBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblDebilidad = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.dgvNombresPokemon = new System.Windows.Forms.DataGridView();
            this.tipoPokemon = new System.Windows.Forms.Label();
            this.debilidadPokemon = new System.Windows.Forms.Label();
            this.btnPokedexWeb = new System.Windows.Forms.Button();
            this.btnNewPokemon = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnPapelera = new System.Windows.Forms.Button();
            this.panelBuscar = new System.Windows.Forms.Panel();
            this.btnLimpiarBuscador = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.toolTipPapelera = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pBoxPokemon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNombresPokemon)).BeginInit();
            this.panelBuscar.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("MS Reference Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblNombre.Location = new System.Drawing.Point(336, 50);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(0, 55);
            this.lblNombre.TabIndex = 0;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Font = new System.Drawing.Font("MS Reference Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblNumero.Location = new System.Drawing.Point(645, 50);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(0, 55);
            this.lblNumero.TabIndex = 1;
            // 
            // pBoxPokemon
            // 
            this.pBoxPokemon.Location = new System.Drawing.Point(420, 127);
            this.pBoxPokemon.Name = "pBoxPokemon";
            this.pBoxPokemon.Size = new System.Drawing.Size(334, 305);
            this.pBoxPokemon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxPokemon.TabIndex = 2;
            this.pBoxPokemon.TabStop = false;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblTipo.Location = new System.Drawing.Point(377, 584);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(58, 26);
            this.lblTipo.TabIndex = 4;
            this.lblTipo.Text = "Tipo";
            // 
            // lblDebilidad
            // 
            this.lblDebilidad.AutoSize = true;
            this.lblDebilidad.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDebilidad.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblDebilidad.Location = new System.Drawing.Point(569, 584);
            this.lblDebilidad.Name = "lblDebilidad";
            this.lblDebilidad.Size = new System.Drawing.Size(114, 26);
            this.lblDebilidad.TabIndex = 5;
            this.lblDebilidad.Text = "Debilidad";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(376, 478);
            this.lblDescripcion.MaximumSize = new System.Drawing.Size(460, 300);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(0, 26);
            this.lblDescripcion.TabIndex = 8;
            // 
            // dgvNombresPokemon
            // 
            this.dgvNombresPokemon.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvNombresPokemon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvNombresPokemon.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvNombresPokemon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNombresPokemon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvNombresPokemon.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvNombresPokemon.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvNombresPokemon.Location = new System.Drawing.Point(0, 68);
            this.dgvNombresPokemon.MultiSelect = false;
            this.dgvNombresPokemon.Name = "dgvNombresPokemon";
            this.dgvNombresPokemon.RowHeadersWidth = 62;
            this.dgvNombresPokemon.RowTemplate.Height = 28;
            this.dgvNombresPokemon.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNombresPokemon.Size = new System.Drawing.Size(268, 390);
            this.dgvNombresPokemon.TabIndex = 9;
            this.dgvNombresPokemon.SelectionChanged += new System.EventHandler(this.dgvNombresPokemon_SelectionChanged);
            // 
            // tipoPokemon
            // 
            this.tipoPokemon.AutoSize = true;
            this.tipoPokemon.BackColor = System.Drawing.Color.LightSlateGray;
            this.tipoPokemon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tipoPokemon.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipoPokemon.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tipoPokemon.Location = new System.Drawing.Point(408, 644);
            this.tipoPokemon.Name = "tipoPokemon";
            this.tipoPokemon.Size = new System.Drawing.Size(2, 25);
            this.tipoPokemon.TabIndex = 10;
            this.tipoPokemon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // debilidadPokemon
            // 
            this.debilidadPokemon.AutoSize = true;
            this.debilidadPokemon.BackColor = System.Drawing.Color.IndianRed;
            this.debilidadPokemon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.debilidadPokemon.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.debilidadPokemon.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.debilidadPokemon.Location = new System.Drawing.Point(609, 644);
            this.debilidadPokemon.Name = "debilidadPokemon";
            this.debilidadPokemon.Size = new System.Drawing.Size(2, 25);
            this.debilidadPokemon.TabIndex = 11;
            this.debilidadPokemon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPokedexWeb
            // 
            this.btnPokedexWeb.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnPokedexWeb.FlatAppearance.BorderSize = 0;
            this.btnPokedexWeb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPokedexWeb.Font = new System.Drawing.Font("MS Reference Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPokedexWeb.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPokedexWeb.Location = new System.Drawing.Point(153, 543);
            this.btnPokedexWeb.Name = "btnPokedexWeb";
            this.btnPokedexWeb.Size = new System.Drawing.Size(115, 98);
            this.btnPokedexWeb.TabIndex = 12;
            this.btnPokedexWeb.Text = "Conocer más";
            this.btnPokedexWeb.UseVisualStyleBackColor = false;
            this.btnPokedexWeb.Click += new System.EventHandler(this.btnPokedexWeb_Click);
            // 
            // btnNewPokemon
            // 
            this.btnNewPokemon.BackColor = System.Drawing.Color.SteelBlue;
            this.btnNewPokemon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewPokemon.FlatAppearance.BorderSize = 0;
            this.btnNewPokemon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewPokemon.Font = new System.Drawing.Font("MS Reference Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewPokemon.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNewPokemon.Location = new System.Drawing.Point(12, 492);
            this.btnNewPokemon.Name = "btnNewPokemon";
            this.btnNewPokemon.Size = new System.Drawing.Size(135, 149);
            this.btnNewPokemon.TabIndex = 13;
            this.btnNewPokemon.Text = "Nuevo Pokémon";
            this.btnNewPokemon.UseVisualStyleBackColor = false;
            this.btnNewPokemon.Click += new System.EventHandler(this.btnNewPokemon_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Brown;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("MS Reference Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEliminar.Location = new System.Drawing.Point(153, 492);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(115, 45);
            this.btnEliminar.TabIndex = 14;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.SeaGreen;
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnModificar.Location = new System.Drawing.Point(12, 647);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(256, 40);
            this.btnModificar.TabIndex = 15;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnPapelera
            // 
            this.btnPapelera.BackColor = System.Drawing.Color.SeaGreen;
            this.btnPapelera.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPapelera.FlatAppearance.BorderSize = 0;
            this.btnPapelera.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPapelera.Font = new System.Drawing.Font("MS Reference Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPapelera.ForeColor = System.Drawing.SystemColors.Menu;
            this.btnPapelera.Location = new System.Drawing.Point(789, 632);
            this.btnPapelera.Name = "btnPapelera";
            this.btnPapelera.Size = new System.Drawing.Size(56, 55);
            this.btnPapelera.TabIndex = 16;
            this.btnPapelera.Text = "♻";
            this.btnPapelera.UseVisualStyleBackColor = false;
            this.btnPapelera.Click += new System.EventHandler(this.btnPapelera_Click);
            // 
            // panelBuscar
            // 
            this.panelBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelBuscar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelBuscar.Controls.Add(this.btnLimpiarBuscador);
            this.panelBuscar.Controls.Add(this.btnBuscar);
            this.panelBuscar.Controls.Add(this.txtBuscar);
            this.panelBuscar.Location = new System.Drawing.Point(0, 0);
            this.panelBuscar.Name = "panelBuscar";
            this.panelBuscar.Size = new System.Drawing.Size(868, 38);
            this.panelBuscar.TabIndex = 17;
            // 
            // btnLimpiarBuscador
            // 
            this.btnLimpiarBuscador.BackColor = System.Drawing.Color.Transparent;
            this.btnLimpiarBuscador.FlatAppearance.BorderSize = 0;
            this.btnLimpiarBuscador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiarBuscador.Font = new System.Drawing.Font("MS Reference Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarBuscador.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnLimpiarBuscador.Location = new System.Drawing.Point(416, 3);
            this.btnLimpiarBuscador.Name = "btnLimpiarBuscador";
            this.btnLimpiarBuscador.Size = new System.Drawing.Size(28, 32);
            this.btnLimpiarBuscador.TabIndex = 19;
            this.btnLimpiarBuscador.Text = "❌";
            this.btnLimpiarBuscador.UseVisualStyleBackColor = false;
            this.btnLimpiarBuscador.Click += new System.EventHandler(this.btnLimpiarBuscador_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Coral;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("MS Reference Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBuscar.Location = new System.Drawing.Point(22, 3);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(112, 32);
            this.btnBuscar.TabIndex = 18;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(140, 3);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(270, 26);
            this.txtBuscar.TabIndex = 18;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // FormPrimeraApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(868, 737);
            this.Controls.Add(this.panelBuscar);
            this.Controls.Add(this.btnPapelera);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnNewPokemon);
            this.Controls.Add(this.btnPokedexWeb);
            this.Controls.Add(this.debilidadPokemon);
            this.Controls.Add(this.tipoPokemon);
            this.Controls.Add(this.dgvNombresPokemon);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblDebilidad);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.pBoxPokemon);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.lblNombre);
            this.MaximumSize = new System.Drawing.Size(900, 1600);
            this.Name = "FormPrimeraApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pokedex";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pBoxPokemon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNombresPokemon)).EndInit();
            this.panelBuscar.ResumeLayout(false);
            this.panelBuscar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.PictureBox pBoxPokemon;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Label lblDebilidad;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.DataGridView dgvNombresPokemon;
        private System.Windows.Forms.Label tipoPokemon;
        private System.Windows.Forms.Label debilidadPokemon;
        private System.Windows.Forms.Button btnPokedexWeb;
        private System.Windows.Forms.Button btnNewPokemon;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnPapelera;
        private System.Windows.Forms.Panel panelBuscar;
        private System.Windows.Forms.Button btnLimpiarBuscador;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.ToolTip toolTipPapelera;
    }
}

