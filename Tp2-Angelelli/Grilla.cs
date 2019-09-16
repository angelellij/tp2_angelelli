using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;


namespace Tp2_Angelelli
{
    public partial class Grilla : Form
    {
        List<Articulo> articulos = new List<Articulo>();
        public Grilla()
        {
            InitializeComponent();
        }

        private void Grilla_Load(object sender, EventArgs e)
        {
            dgvListadoArticulos.MultiSelect = false;
            cargarDatos();
        }

        private void cargarDatos() {
            ArticuloNegocio articulosNegocio = new ArticuloNegocio();
            try
            {
                articulos = articulosNegocio.getAll();
                dgvListadoArticulos.DataSource = articulos;
                dgvListadoArticulos.Columns[0].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void BotonAgregar_Click(object sender, EventArgs e)
        {
            Articulo articulo = new Articulo();
            FormularioABM formularioABM = new FormularioABM(articulo,1);
            formularioABM.ShowDialog();
            cargarDatos();
        }

        private void BotonModificar_Click(object sender, EventArgs e)
        {
            try
            {
                Articulo articulo = new Articulo();
                articulo = (Articulo)dgvListadoArticulos.CurrentRow.DataBoundItem;
                FormularioABM formularioABM = new FormularioABM(articulo, 2);
                formularioABM.ShowDialog();
                cargarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void BotonEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                Articulo articulo = new Articulo();
                articulo = (Articulo)dgvListadoArticulos.CurrentRow.DataBoundItem;
                ArticuloNegocio articuloNegocio = new ArticuloNegocio();
                articuloNegocio.Delete(articulo);
                cargarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BotonDescripcion_Click(object sender, EventArgs e)
        {
            try
            {
                Articulo articulo = new Articulo();
                articulo = (Articulo)dgvListadoArticulos.CurrentRow.DataBoundItem;
                FormularioABM formularioABM = new FormularioABM(articulo, 4);
                formularioABM.ShowDialog();
                cargarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BoxBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            String texto = BoxBuscar.Text.ToLower();
            try
            {
                List<Articulo> articulosFiltrados = new List<Articulo>();
                foreach (Articulo artX in articulos)
                {
                   if(
                        artX.nombre.ToLower().Contains(texto) || 
                        artX.descripcion.ToLower().Contains(texto) ||
                        artX.codigo.ToLower().Contains(texto) || 
                        artX.marca.descripcion.ToLower().Contains(texto) ||
                        artX.categoria.descripcion.ToLower().Contains(texto) || 
                        artX.imagen.ToLower().Contains(texto) || 
                        artX.precio.ToString().ToLower().Contains(texto))
                    {
                        articulosFiltrados.Add(artX);
                    }
                }
                dgvListadoArticulos.DataSource = articulosFiltrados;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
