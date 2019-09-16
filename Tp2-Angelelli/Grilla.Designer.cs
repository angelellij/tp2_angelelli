namespace Tp2_Angelelli
{
    partial class Grilla
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.BotonAgregar = new System.Windows.Forms.Button();
            this.BotonModificar = new System.Windows.Forms.Button();
            this.BotonEliminar = new System.Windows.Forms.Button();
            this.BotonDescripcion = new System.Windows.Forms.Button();
            this.dgvListadoArticulos = new System.Windows.Forms.DataGridView();
            this.BoxBuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoArticulos)).BeginInit();
            this.SuspendLayout();
            // 
            // BotonAgregar
            // 
            this.BotonAgregar.Location = new System.Drawing.Point(13, 415);
            this.BotonAgregar.Name = "BotonAgregar";
            this.BotonAgregar.Size = new System.Drawing.Size(75, 23);
            this.BotonAgregar.TabIndex = 0;
            this.BotonAgregar.Text = "Agregar";
            this.BotonAgregar.UseVisualStyleBackColor = true;
            this.BotonAgregar.Click += new System.EventHandler(this.BotonAgregar_Click);
            // 
            // BotonModificar
            // 
            this.BotonModificar.Location = new System.Drawing.Point(110, 415);
            this.BotonModificar.Name = "BotonModificar";
            this.BotonModificar.Size = new System.Drawing.Size(75, 23);
            this.BotonModificar.TabIndex = 1;
            this.BotonModificar.Text = "Modificar";
            this.BotonModificar.UseVisualStyleBackColor = true;
            this.BotonModificar.Click += new System.EventHandler(this.BotonModificar_Click);
            // 
            // BotonEliminar
            // 
            this.BotonEliminar.Location = new System.Drawing.Point(206, 415);
            this.BotonEliminar.Name = "BotonEliminar";
            this.BotonEliminar.Size = new System.Drawing.Size(75, 23);
            this.BotonEliminar.TabIndex = 2;
            this.BotonEliminar.Text = "Eliminar";
            this.BotonEliminar.UseVisualStyleBackColor = true;
            this.BotonEliminar.Click += new System.EventHandler(this.BotonEliminar_Click);
            // 
            // BotonDescripcion
            // 
            this.BotonDescripcion.Location = new System.Drawing.Point(301, 415);
            this.BotonDescripcion.Name = "BotonDescripcion";
            this.BotonDescripcion.Size = new System.Drawing.Size(116, 23);
            this.BotonDescripcion.TabIndex = 3;
            this.BotonDescripcion.Text = "VerDescripcion";
            this.BotonDescripcion.UseVisualStyleBackColor = true;
            this.BotonDescripcion.Click += new System.EventHandler(this.BotonDescripcion_Click);
            // 
            // dgvListadoArticulos
            // 
            this.dgvListadoArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListadoArticulos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvListadoArticulos.Location = new System.Drawing.Point(13, 53);
            this.dgvListadoArticulos.Name = "dgvListadoArticulos";
            this.dgvListadoArticulos.RowHeadersWidth = 51;
            this.dgvListadoArticulos.RowTemplate.Height = 24;
            this.dgvListadoArticulos.Size = new System.Drawing.Size(1003, 346);
            this.dgvListadoArticulos.TabIndex = 4;
            // 
            // BoxBuscar
            // 
            this.BoxBuscar.Location = new System.Drawing.Point(280, 13);
            this.BoxBuscar.Name = "BoxBuscar";
            this.BoxBuscar.Size = new System.Drawing.Size(462, 22);
            this.BoxBuscar.TabIndex = 5;
            this.BoxBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BoxBuscar_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(203, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Buscar";
            // 
            // Grilla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BoxBuscar);
            this.Controls.Add(this.dgvListadoArticulos);
            this.Controls.Add(this.BotonDescripcion);
            this.Controls.Add(this.BotonEliminar);
            this.Controls.Add(this.BotonModificar);
            this.Controls.Add(this.BotonAgregar);
            this.Name = "Grilla";
            this.Text = "Listado de Articulos";
            this.Load += new System.EventHandler(this.Grilla_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoArticulos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BotonAgregar;
        private System.Windows.Forms.Button BotonModificar;
        private System.Windows.Forms.Button BotonEliminar;
        private System.Windows.Forms.Button BotonDescripcion;
        private System.Windows.Forms.DataGridView dgvListadoArticulos;
        private System.Windows.Forms.TextBox BoxBuscar;
        private System.Windows.Forms.Label label1;
    }
}

