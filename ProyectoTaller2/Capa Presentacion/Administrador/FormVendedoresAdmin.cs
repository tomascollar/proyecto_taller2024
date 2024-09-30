using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoTaller2.Capa_Presentacion.Administrador
{
    public partial class FormVendedoresAdmin : Form
    {
        public FormVendedoresAdmin()
        {
            InitializeComponent();

            btnVerVentas.Enabled = false;
        }

        private void dataGridVendedores_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridVendedores.SelectedRows.Count > 0)
            {
                btnVerVentas.Enabled = true;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombreVendedor.Text))
            {
                MessageBox.Show("Complete el campo Nombre");
            }
        }

        private void CargarVendedores()
        {
            var negocioVendedor = new NegocioUsuario();
            var datos = negocioVendedor.ListarVendedores();

            dataGridVendedores.DataSource = datos;

            this.formato();
        }

        private void FormVendedoresAdmin_Load(object sender, EventArgs e)
        {
            CargarVendedores();
        }

        private void dataGridUsuarios_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 6 && e.RowIndex >= 0) // Reemplaza con el índice de la columna deseada.
            {
                // Verifica el valor de la celda en la columna deseada.
                if (e.Value != null)
                {
                    int valor = Convert.ToInt32(e.Value);

                    // Asigna el texto correspondiente en función del valor.
                    switch (valor)
                    {
                        case 1:
                            e.Value = "superadmin";
                            break;
                        case 2:
                            e.Value = "admin";
                            break;
                        case 3:
                            e.Value = "vendedor";
                            break;
                        default:
                            // Deja el valor original si no coincide con ninguno de los casos.
                            break;
                    }

                    // Indica que se ha formateado la celda.
                    e.FormattingApplied = true;
                }
            }
        }

        private void formato()
        {
            
            dataGridVendedores.Columns[0].HeaderText = "ID";
            dataGridVendedores.Columns[1].HeaderText = "Nombre";
            dataGridVendedores.Columns[2].HeaderText = "Apellido";
            dataGridVendedores.Columns[3].HeaderText = "Telefono";
            dataGridVendedores.Columns[4].HeaderText = "Usuario";
            dataGridVendedores.Columns[5].HeaderText = "Contraseña";
            dataGridVendedores.Columns[6].HeaderText = "Tipo de Usuario";

        }

        ErrorProvider errorP = new ErrorProvider();
        private void txtNombreVendedor_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool valida = Validar.soloLetras(e);
            if (!valida)
                errorP.SetError(txtNombreVendedor, "Solo letras");
            else
                errorP.Clear();
        }
    }
}
