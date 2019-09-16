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
    public partial class FormularioABM : Form
    {
        public Articulo articulo { get; set; }
        public int instruccion { get; set; }

        //Instruccion 1 = agregar
        //Instruccion 2 = modificar
        //Instruccion 3 = eliminar (en desuso)
        //Instruccion 4 = ver

        public FormularioABM(Articulo articulo, int instruccion)
        {
            this.articulo = articulo;
            this.instruccion = instruccion;
            InitializeComponent();
        }

        private void FormularioABM_Load(object sender, EventArgs e)
        {
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            try
            {
                BoxMarca.DataSource = marcaNegocio.getAll();
                BoxCategoria.DataSource = categoriaNegocio.getAll();

                if (instruccion == 2 || instruccion == 4) {
                    BoxCodigo.Text = articulo.codigo;
                    BoxNombre.Text = articulo.nombre;
                    BoxDescripcion.Text = articulo.descripcion;
                    BoxMarca.SelectedItem = articulo.marca;
                    BoxCategoria.SelectedItem = articulo.categoria;
                    BoxImagen.Text = articulo.imagen;
                    BoxPrecio.Text = articulo.precio.ToString();
                }
                if (instruccion == 4)
                {
                    BoxCodigo.HideSelection = true;
                    BoxCodigo.ReadOnly = true;
                    BoxNombre.ReadOnly = true;
                    BoxDescripcion.ReadOnly = true;
                    BoxMarca.DropDownStyle = ComboBoxStyle.DropDownList;
                    BoxCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
                    BoxImagen.ReadOnly = true;
                    BoxPrecio.ReadOnly = true;
                }
                
                
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();
            try
            {
                articulo.codigo = BoxCodigo.Text;
                articulo.nombre = BoxNombre.Text;
                articulo.descripcion = BoxDescripcion.Text;
                articulo.marca = (Marca)BoxMarca.SelectedItem;
                articulo.categoria = (Categoria)BoxCategoria.SelectedItem;
                articulo.imagen = BoxImagen.Text;
                articulo.precio = decimal.Parse( BoxPrecio.Text)/10000000;
                
                switch (instruccion)
                {
                    case 1:
                        articuloNegocio.insert(articulo);
                        break;
                    case 2:
                        articuloNegocio.update(articulo);
                        break;
                    default:
                        break;
                }
                
                Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                throw;
            }
        }
    }
}
