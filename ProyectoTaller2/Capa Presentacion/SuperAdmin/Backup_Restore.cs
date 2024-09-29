using ProyectoTaller2.CapaPresentacion.SuperAdmin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoTaller2.Capa_Presentacion.SuperAdmin
{
    public partial class Backup_Restore : Form
    {

        private InterfaceSuper _form;
        public Backup_Restore(InterfaceSuper form)
        {
            InitializeComponent();
            _form = form;
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {

            _form.openChildForm(new Generar_Backup(_form));
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            _form.openChildForm(new Restaurar_Backup());
        }
    }
}
