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
    public partial class Generar_Backup : Form
    {
        private InterfaceSuper _form;
        public Generar_Backup(InterfaceSuper form)
        {
            InitializeComponent();
            _form = form;
        }

        
    }
}
