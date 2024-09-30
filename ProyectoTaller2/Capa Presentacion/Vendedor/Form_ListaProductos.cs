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
    public partial class Form_ListaProductos : Form
    {
        public Form_ListaProductos()
        {
            InitializeComponent();
        }

        private void Form_ListaProductos_Load(object sender, EventArgs e)
        {
            comboListarProducto.SelectedIndex = 0;
            
        }

        ErrorProvider errorP = new ErrorProvider();
        private void txtBuscarProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            string selectedItem = comboListarProducto.SelectedItem.ToString();

            if (selectedItem == "Codigo")
            {
                bool valida = Validar.soloNumeros(e);
                if (!valida)
                    errorP.SetError(txtBuscarProducto, "Solo numeros");
                else
                    errorP.Clear();
            }
            else
            {
                bool valida = Validar.soloLetras(e);
                if (!valida)
                    errorP.SetError(txtBuscarProducto, "Solo letras");
                else
                    errorP.Clear();
            }
        }

        private void btnBuscarProd_Click(object sender, EventArgs e)
        {
            bool validaTxt = Validar.txtVacios(txtBuscarProducto);
            if (validaTxt)
                errorP.SetError(txtBuscarProducto, "Debe completar este campo");
            else
                errorP.Clear();
        }
    }
}
