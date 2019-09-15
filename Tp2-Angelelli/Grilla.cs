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
            ArticuloNegocio articulosNegocio = new ArticuloNegocio();
            try
            {
                dgvListadoArticulos.DataSource = articulosNegocio.getListArticulos(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
