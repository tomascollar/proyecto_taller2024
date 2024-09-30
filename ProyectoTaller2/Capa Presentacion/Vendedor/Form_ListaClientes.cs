using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoTaller2.Capa_Presentacion.Vendedor
{
    public partial class Form_ListaClientes : Form
    {

        ErrorProvider errorP = new ErrorProvider();
        public Form_ListaClientes()
        {
            InitializeComponent();
        }

        private void Form_ListaClientes_Load(object sender, EventArgs e)
        {
            comboListarCliente.SelectedIndex = 0;
        }

        private void txtBuscarCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            string selectedItem = comboListarCliente.SelectedItem.ToString();

            if(selectedItem == "DNI")
            {
                bool valida = Validar.soloNumeros(e);
                if (!valida)
                    errorP.SetError(txtBuscarCliente, "Solo numeros");
                else
                    errorP.Clear();
            }
            else
            {
                bool valida = Validar.soloLetras(e);
                if (!valida)
                    errorP.SetError(txtBuscarCliente, "Solo letras");
                else
                    errorP.Clear();
            }


        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            bool validaVacio = Validar.txtVacios(txtBuscarCliente);
            if (validaVacio)
                errorP.SetError(txtBuscarCliente, "Debe completar este campo");
            else
                errorP.Clear();
        }
    }
}
