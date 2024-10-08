namespace Pokemons
{
    partial class Papelera
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
            this.dgvPokemonsInactivos = new System.Windows.Forms.DataGridView();
            this.pBoxPokemon = new System.Windows.Forms.PictureBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.debilidadPokemon = new System.Windows.Forms.Label();
            this.tipoPokemon = new System.Windows.Forms.Label();
            this.lblDebilidad = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.btnEliminarTodos = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnReestablecer = new System.Windows.Forms.Button();
            this.btnRecuperarTodos = new System.Windows.Forms.Button();
            this.toolTipRecuperar = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipEliminar = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPokemonsInactivos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxPokemon)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPokemonsInactivos
            // 
            this.dgvPokemonsInactivos.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvPokemonsInactivos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPokemonsInactivos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPokemonsInactivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPokemonsInactivos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvPokemonsInactivos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvPokemonsInactivos.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvPokemonsInactivos.Location = new System.Drawing.Point(12, 31);
            this.dgvPokemonsInactivos.MultiSelect = false;
            this.dgvPokemonsInactivos.Name = "dgvPokemonsInactivos";
            this.dgvPokemonsInactivos.RowHeadersWidth = 62;
            this.dgvPokemonsInactivos.RowTemplate.Height = 28;
            this.dgvPokemonsInactivos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPokemonsInactivos.Size = new System.Drawing.Size(268, 412);
            this.dgvPokemonsInactivos.TabIndex = 10;
            this.dgvPokemonsInactivos.SelectionChanged += new System.EventHandler(this.dgvPokemonsInactivos_SelectionChanged);
            // 
            // pBoxPokemon
            // 
            this.pBoxPokemon.Location = new System.Drawing.Point(379, 107);
            this.pBoxPokemon.Name = "pBoxPokemon";
            this.pBoxPokemon.Size = new System.Drawing.Size(334, 305);
            this.pBoxPokemon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBoxPokemon.TabIndex = 11;
            this.pBoxPokemon.TabStop = false;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Font = new System.Drawing.Font("MS Reference Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblNumero.Location = new System.Drawing.Point(608, 22);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(0, 55);
            this.lblNumero.TabIndex = 13;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("MS Reference Sans Serif", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblNombre.Location = new System.Drawing.Point(305, 22);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(0, 55);
            this.lblNombre.TabIndex = 12;
            // 
            // debilidadPokemon
            // 
            this.debilidadPokemon.AutoSize = true;
            this.debilidadPokemon.BackColor = System.Drawing.Color.IndianRed;
            this.debilidadPokemon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.debilidadPokemon.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.debilidadPokemon.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.debilidadPokemon.Location = new System.Drawing.Point(606, 518);
            this.debilidadPokemon.Name = "debilidadPokemon";
            this.debilidadPokemon.Size = new System.Drawing.Size(2, 25);
            this.debilidadPokemon.TabIndex = 17;
            this.debilidadPokemon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tipoPokemon
            // 
            this.tipoPokemon.AutoSize = true;
            this.tipoPokemon.BackColor = System.Drawing.Color.LightSlateGray;
            this.tipoPokemon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tipoPokemon.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipoPokemon.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.tipoPokemon.Location = new System.Drawing.Point(405, 518);
            this.tipoPokemon.Name = "tipoPokemon";
            this.tipoPokemon.Size = new System.Drawing.Size(2, 25);
            this.tipoPokemon.TabIndex = 16;
            this.tipoPokemon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDebilidad
            // 
            this.lblDebilidad.AutoSize = true;
            this.lblDebilidad.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDebilidad.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblDebilidad.Location = new System.Drawing.Point(566, 458);
            this.lblDebilidad.Name = "lblDebilidad";
            this.lblDebilidad.Size = new System.Drawing.Size(114, 26);
            this.lblDebilidad.TabIndex = 15;
            this.lblDebilidad.Text = "Debilidad";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipo.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.lblTipo.Location = new System.Drawing.Point(374, 458);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(58, 26);
            this.lblTipo.TabIndex = 14;
            this.lblTipo.Text = "Tipo";
            // 
            // btnEliminarTodos
            // 
            this.btnEliminarTodos.BackColor = System.Drawing.Color.Brown;
            this.btnEliminarTodos.FlatAppearance.BorderSize = 0;
            this.btnEliminarTodos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarTodos.Font = new System.Drawing.Font("MS Reference Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarTodos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEliminarTodos.Location = new System.Drawing.Point(12, 568);
            this.btnEliminarTodos.Name = "btnEliminarTodos";
            this.btnEliminarTodos.Size = new System.Drawing.Size(268, 45);
            this.btnEliminarTodos.TabIndex = 18;
            this.btnEliminarTodos.Text = "Eliminar Todos";
            this.btnEliminarTodos.UseVisualStyleBackColor = false;
            this.btnEliminarTodos.Click += new System.EventHandler(this.btnEliminarTodos_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("MS Reference Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.Brown;
            this.btnEliminar.Location = new System.Drawing.Point(736, 160);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(65, 45);
            this.btnEliminar.TabIndex = 19;
            this.btnEliminar.Text = "❌";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnReestablecer
            // 
            this.btnReestablecer.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnReestablecer.FlatAppearance.BorderSize = 0;
            this.btnReestablecer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReestablecer.Font = new System.Drawing.Font("MS Reference Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReestablecer.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnReestablecer.Location = new System.Drawing.Point(736, 107);
            this.btnReestablecer.Name = "btnReestablecer";
            this.btnReestablecer.Size = new System.Drawing.Size(65, 45);
            this.btnReestablecer.TabIndex = 20;
            this.btnReestablecer.Text = "✅";
            this.btnReestablecer.UseVisualStyleBackColor = false;
            this.btnReestablecer.Click += new System.EventHandler(this.btnReestablecer_Click);
            // 
            // btnRecuperarTodos
            // 
            this.btnRecuperarTodos.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnRecuperarTodos.FlatAppearance.BorderSize = 0;
            this.btnRecuperarTodos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecuperarTodos.Font = new System.Drawing.Font("MS Reference Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecuperarTodos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRecuperarTodos.Location = new System.Drawing.Point(12, 509);
            this.btnRecuperarTodos.Name = "btnRecuperarTodos";
            this.btnRecuperarTodos.Size = new System.Drawing.Size(268, 45);
            this.btnRecuperarTodos.TabIndex = 21;
            this.btnRecuperarTodos.Text = "Reestablecer Todos";
            this.btnRecuperarTodos.UseVisualStyleBackColor = false;
            this.btnRecuperarTodos.Click += new System.EventHandler(this.btnRecuperarTodos_Click);
            // 
            // Papelera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(842, 637);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnReestablecer);
            this.Controls.Add(this.btnRecuperarTodos);
            this.Controls.Add(this.btnEliminarTodos);
            this.Controls.Add(this.debilidadPokemon);
            this.Controls.Add(this.tipoPokemon);
            this.Controls.Add(this.lblDebilidad);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.pBoxPokemon);
            this.Controls.Add(this.dgvPokemonsInactivos);
            this.Name = "Papelera";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Papelera";
            this.Load += new System.EventHandler(this.Papelera_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPokemonsInactivos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBoxPokemon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPokemonsInactivos;
        private System.Windows.Forms.PictureBox pBoxPokemon;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label debilidadPokemon;
        private System.Windows.Forms.Label tipoPokemon;
        private System.Windows.Forms.Label lblDebilidad;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Button btnEliminarTodos;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnReestablecer;
        private System.Windows.Forms.Button btnRecuperarTodos;
        private System.Windows.Forms.ToolTip toolTipRecuperar;
        private System.Windows.Forms.ToolTip toolTipEliminar;
    }
}