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
        public Grilla()
        {
            InitializeComponent();
        }

        private void Grilla_Load(object sender, EventArgs e)
        {
            cargarDatos();
        }

        private void cargarDatos() {
            ArticuloNegocio articulosNegocio = new ArticuloNegocio();
            try
            {
                dgvListadoArticulos.DataSource = articulosNegocio.getAll();
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
    }
}
