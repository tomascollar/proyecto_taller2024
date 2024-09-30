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
    public partial class FormVenta : Form
    {

        private Iform _form;
        FormProducto formularioPrincipal;
        public FormVenta(Iform form)
        {
            InitializeComponent();
            _form = form;

            btnRealizarVenta.Enabled = false;
            if(dataGridVenta.Rows.Count > 1)
            {
                btnRealizarVenta.Enabled = true;
            }

            /*if(dataGridVenta.RowCount < 2)
            {
                dataGridVenta.Visible = false;
            }*/


        }

        public FormVenta(Iform form, DataGridViewRow dtg)
        {
            InitializeComponent();
            _form = form;

            btnRealizarVenta.Enabled = false;

            /*foreach(DataGridViewRow row in dtg.Rows)
            {
                dataGridVenta.Rows.Add();
                dataGridVenta.Rows[row.Index].Cells["Column1"].Value = row.Cells[0].Value;
                dataGridVenta.Rows[row.Index].Cells["Column2"].Value = row.Cells[1].Value;
                dataGridVenta.Rows[row.Index].Cells["Column3"].Value = row.Cells[2].Value;
                dataGridVenta.Rows[row.Index].Cells["Column4"].Value = row.Cells[3].Value;
                dataGridVenta.Rows[row.Index].Cells["Column5"].Value = row.Cells[4].Value;
                dataGridVenta.Rows[row.Index].Cells["Column6"].Value = row.Cells[5].Value;
                dataGridVenta.Rows[row.Index].Cells["Column7"].Value = row.Cells[6].Value;
            }*/

            if(dtg != null)
            {
                dataGridVenta.Rows.Add(
                dtg.Cells[0].Value,
                dtg.Cells[1].Value,
                dtg.Cells[2].Value,
                dtg.Cells[3].Value,
                dtg.Cells[4].Value,
                dtg.Cells[5].Value,
                dtg.Cells[6].Value
                // Agrega más celdas según sea necesario
            );
            }

            dataGridVenta.Columns[0].Width = 50;
            dataGridVenta.Columns[0].HeaderText = "ID";
            dataGridVenta.Columns[1].HeaderText = "Nombre";
            dataGridVenta.Columns[2].HeaderText = "Marca";
            dataGridVenta.Columns[3].HeaderText = "Stock";
            dataGridVenta.Columns[4].HeaderText = "Precio";
            dataGridVenta.Columns[5].HeaderText = "Descripcion";
            dataGridVenta.Columns[6].HeaderText = "Categoria";

        }

        public FormVenta(Iform form, DataGridView dtg, FormProducto formulario)
        {
            InitializeComponent();
            formularioPrincipal = formulario;
        }

        

        private void dataGridVenta_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            /*if (e.ColumnIndex == 6)
            {
                e.Value = "    X    ";

            }*/
        }

        private void dataGridVenta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           /* DataGridViewRow row = dataGridVenta.Rows[e.RowIndex];
            DataGridViewCell deleteCell = row.Cells["eliminarCarrito"];
            DataGridViewCell nombreCell = row.Cells["nombreProd"];



            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewColumn columna = dataGridVenta.Columns[e.ColumnIndex];
                if (columna.Name != "eliminarCarrito")
                {

                    //desactivamos el evento click en celdas q no sean del tipo boton
                    dataGridVenta.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = false;

                }
                else {

                    if (string.IsNullOrEmpty(Convert.ToString(nombreCell.Value)))
                    {
                        deleteCell.ReadOnly = true;
                    }
                    else
                    {
                        //Desactivamos el read only asi podemos usar el boton
                        deleteCell.ReadOnly = false;
                        var msg = MessageBox.Show("Desea eliminar el producto?", "Confirmar Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (msg == DialogResult.Yes)
                        {

                            if (e.RowIndex >= 0 && e.ColumnIndex == dataGridVenta.Columns["eliminarCarrito"].Index)
                            {
                                //Eliminamos la fila correspondiente
                                dataGridVenta.Rows.RemoveAt(e.RowIndex);

                            }
                            MessageBox.Show("Producto eliminado del carrito correctamente", "Quitar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }*/
        }


        private void btnRealizarVenta_Click(object sender, EventArgs e)
        {

        }

        private void dataGridVenta_SelectionChanged(object sender, EventArgs e)
        {
            if(dataGridVenta.SelectedRows.Count > 0)
            {
                btnRealizarVenta.Enabled = true;
            }
            else
            {
                btnRealizarVenta.Enabled=false;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            var msg = MessageBox.Show("Desea cancelar esta venta?", "Cancelar Venta", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (msg == DialogResult.Yes)
            {
                dataGridVenta.Rows.Clear();

            }

            //this.Close();
        }

        private void FormVenta_Load(object sender, EventArgs e)
        {
            // Suscribirse al evento del formulario principal para recibir notificaciones de productos agregados al carrito.
            if (formularioPrincipal != null)
            {
                formularioPrincipal.ProductoAgregadoAlCarrito += FormularioPrincipal_ProductoAgregadoAlCarrito;
            }

            txtFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void FormularioPrincipal_ProductoAgregadoAlCarrito(object sender, ProductoEventArgs e)
        {
            // Agregar el producto al DataGridView del carrito.
           // AgregarProductoAlCarrito(e.ProductoAgregado);
           // MessageBox.Show("Producto agregado al carrito");
        }

        private void AgregarProductoAlCarrito(productos producto)
        {
            // dataGridVenta.Rows.Add(producto.id_producto, producto.nombre_producto,producto.id_marca, producto.stock,producto.precio,   producto.descripcion, producto.id_categoria);
            dataGridVenta.AutoGenerateColumns = false;


            dataGridVenta.Columns.Add("ID", "id");
            dataGridVenta.Columns.Add("nombre", "nombre");
            dataGridVenta.Columns.Add("marca","marca");
            dataGridVenta.Columns.Add("asd","asd");
            dataGridVenta.Columns.Add("asdadd","asdad");
            dataGridVenta.Columns.Add("asdasda", "asdasda");
            dataGridVenta.Columns.Add("aqwec","qasecd");

            dataGridVenta.Rows.Add(producto);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
