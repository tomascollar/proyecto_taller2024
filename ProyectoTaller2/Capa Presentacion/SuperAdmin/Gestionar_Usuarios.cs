using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using ProyectoTaller2.Capa_Presentacion.Administrador;
using ProyectoTaller2.CapaPresentacion.SuperAdmin;

namespace ProyectoTaller2.Capa_Presentacion.SuperAdmin
{
    public partial class Gestionar_Usuarios : Form
    {

        private InterfaceSuper _form;
        public Gestionar_Usuarios(InterfaceSuper form)
        {
            InitializeComponent();
            _form = form;

            //Desactivamos los botones del inicio ya que no hay ninguna columna seleccionada
            btnEditaUsuario.Enabled = false;
            btnEliminar.Enabled = false;
                  
        }      

        private void dataGridUsuarios_SelectionChanged(object sender, EventArgs e)
        {
            // Verifica si al menos una fila está seleccionada
            if (dataGridUsuarios.SelectedRows.Count > 0)
            {
                // Habilita los botones si hay al menos una fila seleccionada
                btnEditaUsuario.Enabled = true;
                btnEliminar.Enabled = true;
            }
            else
            {
                // Deshabilita los botones si no hay ninguna fila seleccionada
                btnEditaUsuario.Enabled = false;
                btnEliminar.Enabled = false;
            }
        }

        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            _form.openChildForm(new Agregar_Usuario(_form));
        }

        private void CargarUsuarios()
        {
            var negocioUsuario = new NegocioUsuario();

            var datos = negocioUsuario.ListarUsuario();

            dataGridUsuarios.DataSource = datos;
            this.formato();

            //dataGridUsuarios.RowPrePaint += dataGridUsuarios_RowPrePaint;




        }

        private void Gestionar_Usuarios_Load(object sender, EventArgs e)
        {
            //creo instancia del contexto de datos
            CargarUsuarios();
           
        }

        private void formato()
        {
            //dataGridUsuarios.Columns[0].Visible = false;
            dataGridUsuarios.Columns[1].HeaderText = "ID";
            dataGridUsuarios.Columns[2].HeaderText = "Nombre";
            dataGridUsuarios.Columns[3].HeaderText = "Apellido";
            dataGridUsuarios.Columns[4].HeaderText = "Telefono";
            dataGridUsuarios.Columns[5].HeaderText = "Usuario";
            dataGridUsuarios.Columns[6].HeaderText = "Contraseña";
            dataGridUsuarios.Columns[7].HeaderText = "Tipo de Usuario";       

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int posicion = dataGridUsuarios.CurrentRow.Index;

            var msg = MessageBox.Show("Seguro desea eliminar este usuario?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (msg == DialogResult.Yes)
            {

                //dataGridUsuarios.Rows.RemoveAt(posicion);
                dataGridUsuarios[0, posicion].Value = "Inactivo";
                dataGridUsuarios.Rows[posicion].DefaultCellStyle.BackColor = Color.Red;

            }
        }

        private void dataGridUsuarios_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dataGridUsuarios.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Red;
        }


        private void dataGridUsuarios_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 7 && e.RowIndex >= 0) // Reemplaza con el índice de la columna deseada.
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


        ErrorProvider errorP =  new ErrorProvider();


        private void btnEditaUsuario_Click(object sender, EventArgs e)
        {
            if(dataGridUsuarios.SelectedRows.Count > 0)
            {
                //Obtengo la fila seleccionada
                DataGridViewRow filaSeleccionada = dataGridUsuarios.SelectedRows[0];

                //Obtengo los valores de las celdas
                string id = filaSeleccionada.Cells[1].Value.ToString();
                string nombre = filaSeleccionada.Cells[2].Value.ToString();
                string apellido = filaSeleccionada.Cells[3].Value.ToString();
                string telefono = filaSeleccionada.Cells[4].Value.ToString();
                string usuario = filaSeleccionada.Cells[5].Value.ToString();
                string contraseña = filaSeleccionada.Cells[6].Value.ToString();
                string user_type = filaSeleccionada.Cells[7].Value.ToString();

                //Creo una instancia del formulario de edicion
                Editar_Usuario editarform = new Editar_Usuario(_form);

                //Paso los datos al formulario
                editarform.CargarDatos(id, nombre, apellido, telefono, usuario, contraseña, user_type);

                //Muestro el formulario
                editarform.ShowDialog();
            }



            //Arriba de esto codigo nuevo(para borrar en caso de error), abajo de esto el codigo que funcionaba bien
            // Editar_Usuario editarform = new Editar_Usuario(_form);
            // editarform.Show();
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
             bool valida = Validar.soloLetras(e);
            if (!valida)
                errorP.SetError(txtNombre, "Solo numeros");
            else
                errorP.Clear();
        }
    }
}
