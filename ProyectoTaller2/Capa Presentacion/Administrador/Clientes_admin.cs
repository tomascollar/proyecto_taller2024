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

namespace ProyectoTaller2.CapaPresentacion.Administrador
{

    
    public partial class Clientes_admin : Form
    {
        public Clientes_admin()
        {
            InitializeComponent();

        }

        private void CargarClientes()
        {
            var negocioCliente = new NegocioCliente();

            var datos = negocioCliente.ListarClientes();

            dataGridView1.DataSource = datos;
            this.formato();
        }


        private void Clientes_admin_Load(object sender, EventArgs e)
        {
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;

            CargarClientes();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                btnEditar.Enabled = true;
                btnEliminar.Enabled = true;
            }
            else
            {
                btnEditar.Enabled = false;
                btnEliminar.Enabled = false;
            }
        }

        ErrorProvider errorP = new ErrorProvider();

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBuscarDni.Text))
            {
                MessageBox.Show("Debe completar el campo DNI");
            }
        }

        private void txtBuscarDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool valida = Validar.soloNumeros(e);
            if (!valida)
                errorP.SetError(txtBuscarDni, "Solo numeros");
            else
                errorP.Clear();
        }

        private void formato()
        {
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "NOMBRE";
            dataGridView1.Columns[2].HeaderText = "APELLIDO";
            dataGridView1.Columns[3].HeaderText = "DNI";
            dataGridView1.Columns[4].HeaderText = "TELEFONO";
            dataGridView1.Columns[5].HeaderText = "DIRECCION";
            dataGridView1.Columns[6].HeaderText = "EMAIL";
            dataGridView1.Columns[7].HeaderText = "ESTADO";
            //dataGridView1.Columns[8].Visible = false;

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int posicion = dataGridView1.CurrentRow.Index;

            var msg = MessageBox.Show("Seguro desea eliminar este usuario?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (msg == DialogResult.Yes)
            {

                //dataGridUsuarios.Rows.RemoveAt(posicion);
                dataGridView1[7, posicion].Value = "Inactivo";
                dataGridView1.Rows[posicion].DefaultCellStyle.BackColor = Color.Red;

            }
        }
    }
    
}
