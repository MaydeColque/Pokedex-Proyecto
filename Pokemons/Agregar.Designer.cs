namespace Pokemons
{
    partial class frmNuevoPokemon
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
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.cBxTipo = new System.Windows.Forms.ComboBox();
            this.cBxDebilidad = new System.Windows.Forms.ComboBox();
            this.lblDebilidad = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblUrlImagen = new System.Windows.Forms.Label();
            this.txtUrlImagen = new System.Windows.Forms.TextBox();
            this.pBxPokemon = new System.Windows.Forms.PictureBox();
            this.btnAgregarImgLocal = new System.Windows.Forms.Button();
            this.toolTipImagenLocal = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pBxPokemon)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(68, 89);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(69, 20);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.ForestGreen;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAgregar.Location = new System.Drawing.Point(241, 269);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(95, 35);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Brown;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCancelar.Location = new System.Drawing.Point(358, 269);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(89, 35);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(68, 51);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(69, 20);
            this.lblNumero.TabIndex = 3;
            this.lblNumero.Text = "Número:";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(94, 186);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(43, 20);
            this.lblTipo.TabIndex = 4;
            this.lblTipo.Text = "Tipo:";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(177, 51);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(272, 26);
            this.txtNumero.TabIndex = 0;
            this.txtNumero.Leave += new System.EventHandler(this.txtNumero_Leave);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(177, 83);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(272, 26);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.Leave += new System.EventHandler(this.txtNombre_Leave);
            // 
            // cBxTipo
            // 
            this.cBxTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBxTipo.FormattingEnabled = true;
            this.cBxTipo.Location = new System.Drawing.Point(177, 178);
            this.cBxTipo.Name = "cBxTipo";
            this.cBxTipo.Size = new System.Drawing.Size(272, 28);
            this.cBxTipo.TabIndex = 4;
            // 
            // cBxDebilidad
            // 
            this.cBxDebilidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBxDebilidad.FormattingEnabled = true;
            this.cBxDebilidad.Location = new System.Drawing.Point(177, 213);
            this.cBxDebilidad.Name = "cBxDebilidad";
            this.cBxDebilidad.Size = new System.Drawing.Size(272, 28);
            this.cBxDebilidad.TabIndex = 5;
            // 
            // lblDebilidad
            // 
            this.lblDebilidad.AutoSize = true;
            this.lblDebilidad.Location = new System.Drawing.Point(58, 221);
            this.lblDebilidad.Name = "lblDebilidad";
            this.lblDebilidad.Size = new System.Drawing.Size(79, 20);
            this.lblDebilidad.TabIndex = 9;
            this.lblDebilidad.Text = "Debilidad:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(177, 115);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(272, 26);
            this.txtDescripcion.TabIndex = 2;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(41, 121);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(96, 20);
            this.lblDescripcion.TabIndex = 11;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // lblUrlImagen
            // 
            this.lblUrlImagen.AutoSize = true;
            this.lblUrlImagen.Location = new System.Drawing.Point(41, 153);
            this.lblUrlImagen.Name = "lblUrlImagen";
            this.lblUrlImagen.Size = new System.Drawing.Size(91, 20);
            this.lblUrlImagen.TabIndex = 13;
            this.lblUrlImagen.Text = "Url Imagen:";
            // 
            // txtUrlImagen
            // 
            this.txtUrlImagen.Location = new System.Drawing.Point(177, 147);
            this.txtUrlImagen.Name = "txtUrlImagen";
            this.txtUrlImagen.Size = new System.Drawing.Size(272, 26);
            this.txtUrlImagen.TabIndex = 3;
            this.txtUrlImagen.Leave += new System.EventHandler(this.txtUrlImagen_Leave);
            // 
            // pBxPokemon
            // 
            this.pBxPokemon.Location = new System.Drawing.Point(516, 51);
            this.pBxPokemon.Name = "pBxPokemon";
            this.pBxPokemon.Size = new System.Drawing.Size(281, 253);
            this.pBxPokemon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBxPokemon.TabIndex = 14;
            this.pBxPokemon.TabStop = false;
            // 
            // btnAgregarImgLocal
            // 
            this.btnAgregarImgLocal.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnAgregarImgLocal.FlatAppearance.BorderSize = 0;
            this.btnAgregarImgLocal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAgregarImgLocal.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAgregarImgLocal.Location = new System.Drawing.Point(465, 147);
            this.btnAgregarImgLocal.Name = "btnAgregarImgLocal";
            this.btnAgregarImgLocal.Size = new System.Drawing.Size(27, 28);
            this.btnAgregarImgLocal.TabIndex = 15;
            this.btnAgregarImgLocal.Text = "➕";
            this.btnAgregarImgLocal.UseVisualStyleBackColor = false;
            this.btnAgregarImgLocal.Click += new System.EventHandler(this.btnAgregarImgLocal_Click);
            // 
            // toolTipImagenLocal
            // 
            this.toolTipImagenLocal.BackColor = System.Drawing.Color.AliceBlue;
            // 
            // frmNuevoPokemon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 349);
            this.Controls.Add(this.btnAgregarImgLocal);
            this.Controls.Add(this.pBxPokemon);
            this.Controls.Add(this.lblUrlImagen);
            this.Controls.Add(this.txtUrlImagen);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.lblDebilidad);
            this.Controls.Add(this.cBxDebilidad);
            this.Controls.Add(this.cBxTipo);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblNombre);
            this.Name = "frmNuevoPokemon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo Pokémon";
            this.Load += new System.EventHandler(this.frmNuevoPokemon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pBxPokemon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ComboBox cBxTipo;
        private System.Windows.Forms.ComboBox cBxDebilidad;
        private System.Windows.Forms.Label lblDebilidad;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblUrlImagen;
        private System.Windows.Forms.TextBox txtUrlImagen;
        private System.Windows.Forms.PictureBox pBxPokemon;
        private System.Windows.Forms.Button btnAgregarImgLocal;
        private System.Windows.Forms.ToolTip toolTipImagenLocal;
    }
}