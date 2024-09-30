using ProyectoTaller2.Capa_Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoTaller2
{
    public partial class FormProducto : Form
    {
        public event EventHandler<ProductoEventArgs> ProductoAgregadoAlCarrito;


        private Iform _form;
        public FormProducto(Iform form)
        {
            InitializeComponent();
            _form = form;

            btnAgregarCarrito.Visible = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private struct RGBColors
        {
            public static System.Drawing.Color color1 = System.Drawing.Color.FromArgb(172, 126, 241);
            public static System.Drawing.Color color2 = System.Drawing.Color.FromArgb(249, 118, 176);
            public static System.Drawing.Color color3 = System.Drawing.Color.FromArgb(253, 138, 114);
            public static System.Drawing.Color color4 = System.Drawing.Color.FromArgb(95, 77, 221);
            public static System.Drawing.Color color5 = System.Drawing.Color.FromArgb(249, 88, 155);
            public static System.Drawing.Color color6 = System.Drawing.Color.FromArgb(24, 161, 251);
        }

        ErrorProvider errorP = new ErrorProvider(); 
        
        private void CargarProductos()
        {
            var negocioProducto = new NegocioProducto();

            var datos = negocioProducto.ListarProductos();

            using (var context = new proyecto_taller2Entities())
            {
                var query = from p in context.productos
                            join m in context.marca on p.id_marca equals m.id_marca
                            join c in context.categoria on p.id_categoria equals c.id_categoria
                            select new
                            {
                                productoid = p.id_producto,
                                nombre = p.nombre_producto,
                                desc_marca = m.descripcion_marca,
                                stock = p.stock,
                                precio = p.precio,
                                descripcion = p.descripcion,
                                categoria = c.descripcion_categoria
                            };
                dataGridView1.DataSource = query.ToList();
            }


            this.formato();


        }

        private void formato()
        {
            dataGridView1.Columns[0].Width = 50;
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "Nombre";
            dataGridView1.Columns[2].HeaderText = "Marca";
            dataGridView1.Columns[3].HeaderText = "Stock";
            dataGridView1.Columns[4].HeaderText = "Precio";
            dataGridView1.Columns[5].HeaderText = "Descripcion";
            dataGridView1.Columns[6].HeaderText = "Categoria";
           // dataGridView1.Columns[7].Visible = false;
           // dataGridView1.Columns[8].Visible = false;
           //  dataGridView1.Columns[9].Visible = false;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            //verifica si al menos una fila esta seleccionada
            if(dataGridView1.SelectedRows.Count > 0)
            {
                //habilita los botones si hay al menos una fila selected
              //  btnAgregarCarrito.Visible = true;

            }
            else
            {
              //  btnAgregarCarrito.Visible=false;
            }
        }

        private void btnAgregarCarrito_Click(object sender, EventArgs e)
        {
            //_form.ActivateButton(sender, RGBColors.color1);
            //_form.openChildForm(new FormVenta(_form, dataGridView1));

            // Obtener el producto seleccionado del DataGridView
            DataGridViewRow filaSeleccionada = ObtenerFilaSeleccionada();

            if(filaSeleccionada != null )
            {
                _form.ActivateButton(sender, RGBColors.color1);
                _form.openChildForm(new FormVenta(_form, filaSeleccionada));
            }


            
        }

        protected virtual void OnProductoAgregadoAlCarrito(ProductoEventArgs e)
        {
            ProductoAgregadoAlCarrito?.Invoke(this, e);
        }


        private void btnBuscarProd_Click(object sender, EventArgs e)
        {
            bool valida = Validar.txtVacios(txtBuscar);
            if (valida)
                errorP.SetError(txtBuscar, "Debe completar este campo");
            else
                errorP.Clear();
        }

        private void FormProducto_Load(object sender, EventArgs e)
        {
            CargarProductos();
        }

        private DataGridViewRow ObtenerFilaSeleccionada()
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                return dataGridView1.SelectedRows[0];
            }

            return null;
        }
    }
}
