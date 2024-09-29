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
    public partial class FormVentasRegistradas : Form
    {

        private Iform _form;

        public FormVentasRegistradas(Iform form)
        {
            InitializeComponent();
            _form = form;
        }

        private void FormVentasRegistradas_Load(object sender, EventArgs e)
        {
            btnVerDetalle.Enabled = false;
        }

        private void btnVerDetalle_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count > 0)
            {
                btnVerDetalle.Enabled=true;
            }
            else
            {
                btnVerDetalle.Enabled=false;
            }
        }
    }
}
