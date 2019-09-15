namespace Tp2_Angelelli
{
    partial class FormularioABM
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
            this.Codigo = new System.Windows.Forms.Label();
            this.Nombre = new System.Windows.Forms.Label();
            this.Descripcion = new System.Windows.Forms.Label();
            this.Marca = new System.Windows.Forms.Label();
            this.Categoria = new System.Windows.Forms.Label();
            this.Imagen = new System.Windows.Forms.Label();
            this.Precio = new System.Windows.Forms.Label();
            this.BoxCategoria = new System.Windows.Forms.ComboBox();
            this.BoxMarca = new System.Windows.Forms.ComboBox();
            this.BoxDescripcion = new System.Windows.Forms.RichTextBox();
            this.BoxCodigo = new System.Windows.Forms.TextBox();
            this.BoxNombre = new System.Windows.Forms.TextBox();
            this.BoxImagen = new System.Windows.Forms.TextBox();
            this.BoxPrecio = new System.Windows.Forms.TextBox();
            this.Submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Codigo
            // 
            this.Codigo.AutoSize = true;
            this.Codigo.Location = new System.Drawing.Point(63, 43);
            this.Codigo.Name = "Codigo";
            this.Codigo.Size = new System.Drawing.Size(52, 17);
            this.Codigo.TabIndex = 0;
            this.Codigo.Text = "Codigo";
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Location = new System.Drawing.Point(63, 88);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(58, 17);
            this.Nombre.TabIndex = 1;
            this.Nombre.Text = "Nombre";
            // 
            // Descripcion
            // 
            this.Descripcion.AutoSize = true;
            this.Descripcion.Location = new System.Drawing.Point(63, 132);
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Size = new System.Drawing.Size(82, 17);
            this.Descripcion.TabIndex = 2;
            this.Descripcion.Text = "Descripcion";
            // 
            // Marca
            // 
            this.Marca.AutoSize = true;
            this.Marca.Location = new System.Drawing.Point(63, 241);
            this.Marca.Name = "Marca";
            this.Marca.Size = new System.Drawing.Size(47, 17);
            this.Marca.TabIndex = 3;
            this.Marca.Text = "Marca";
            // 
            // Categoria
            // 
            this.Categoria.AutoSize = true;
            this.Categoria.Location = new System.Drawing.Point(63, 289);
            this.Categoria.Name = "Categoria";
            this.Categoria.Size = new System.Drawing.Size(69, 17);
            this.Categoria.TabIndex = 4;
            this.Categoria.Text = "Categoria";
            // 
            // Imagen
            // 
            this.Imagen.AutoSize = true;
            this.Imagen.Location = new System.Drawing.Point(63, 339);
            this.Imagen.Name = "Imagen";
            this.Imagen.Size = new System.Drawing.Size(76, 17);
            this.Imagen.TabIndex = 5;
            this.Imagen.Text = "Imagen Url";
            // 
            // Precio
            // 
            this.Precio.AutoSize = true;
            this.Precio.Location = new System.Drawing.Point(63, 387);
            this.Precio.Name = "Precio";
            this.Precio.Size = new System.Drawing.Size(48, 17);
            this.Precio.TabIndex = 6;
            this.Precio.Text = "Precio";
            // 
            // BoxCategoria
            // 
            this.BoxCategoria.FormattingEnabled = true;
            this.BoxCategoria.Location = new System.Drawing.Point(181, 289);
            this.BoxCategoria.Name = "BoxCategoria";
            this.BoxCategoria.Size = new System.Drawing.Size(233, 24);
            this.BoxCategoria.TabIndex = 7;
            // 
            // BoxMarca
            // 
            this.BoxMarca.FormattingEnabled = true;
            this.BoxMarca.Location = new System.Drawing.Point(181, 238);
            this.BoxMarca.Name = "BoxMarca";
            this.BoxMarca.Size = new System.Drawing.Size(233, 24);
            this.BoxMarca.TabIndex = 8;
            // 
            // BoxDescripcion
            // 
            this.BoxDescripcion.Location = new System.Drawing.Point(181, 132);
            this.BoxDescripcion.Name = "BoxDescripcion";
            this.BoxDescripcion.Size = new System.Drawing.Size(233, 82);
            this.BoxDescripcion.TabIndex = 10;
            this.BoxDescripcion.Text = "";
            // 
            // BoxCodigo
            // 
            this.BoxCodigo.Location = new System.Drawing.Point(181, 37);
            this.BoxCodigo.Name = "BoxCodigo";
            this.BoxCodigo.Size = new System.Drawing.Size(100, 22);
            this.BoxCodigo.TabIndex = 11;
            // 
            // BoxNombre
            // 
            this.BoxNombre.Location = new System.Drawing.Point(181, 83);
            this.BoxNombre.Name = "BoxNombre";
            this.BoxNombre.Size = new System.Drawing.Size(233, 22);
            this.BoxNombre.TabIndex = 12;
            // 
            // BoxImagen
            // 
            this.BoxImagen.Location = new System.Drawing.Point(181, 334);
            this.BoxImagen.Name = "BoxImagen";
            this.BoxImagen.Size = new System.Drawing.Size(233, 22);
            this.BoxImagen.TabIndex = 13;
            // 
            // BoxPrecio
            // 
            this.BoxPrecio.Location = new System.Drawing.Point(181, 382);
            this.BoxPrecio.Name = "BoxPrecio";
            this.BoxPrecio.Size = new System.Drawing.Size(233, 22);
            this.BoxPrecio.TabIndex = 14;
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(339, 444);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(75, 23);
            this.Submit.TabIndex = 15;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // FormularioABM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 505);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.BoxPrecio);
            this.Controls.Add(this.BoxImagen);
            this.Controls.Add(this.BoxNombre);
            this.Controls.Add(this.BoxCodigo);
            this.Controls.Add(this.BoxDescripcion);
            this.Controls.Add(this.BoxMarca);
            this.Controls.Add(this.BoxCategoria);
            this.Controls.Add(this.Precio);
            this.Controls.Add(this.Imagen);
            this.Controls.Add(this.Categoria);
            this.Controls.Add(this.Marca);
            this.Controls.Add(this.Descripcion);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.Codigo);
            this.Name = "FormularioABM";
            this.Text = "FormularioABM";
            this.Load += new System.EventHandler(this.FormularioABM_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Codigo;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.Label Descripcion;
        private System.Windows.Forms.Label Marca;
        private System.Windows.Forms.Label Categoria;
        private System.Windows.Forms.Label Imagen;
        private System.Windows.Forms.Label Precio;
        private System.Windows.Forms.ComboBox BoxCategoria;
        private System.Windows.Forms.ComboBox BoxMarca;
        private System.Windows.Forms.RichTextBox BoxDescripcion;
        private System.Windows.Forms.TextBox BoxCodigo;
        private System.Windows.Forms.TextBox BoxNombre;
        private System.Windows.Forms.TextBox BoxImagen;
        private System.Windows.Forms.TextBox BoxPrecio;
        private System.Windows.Forms.Button Submit;
    }
}