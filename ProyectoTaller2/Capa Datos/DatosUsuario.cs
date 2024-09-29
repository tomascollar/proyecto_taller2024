using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace ProyectoTaller2
{
    internal class DatosUsuario
    {
        public void InsertarUsuario(usuario nuevoUsuario)
        {
            using (var context = new proyecto_taller2Entities())
            {
                context.usuario.Add(nuevoUsuario);
                context.SaveChanges();
            }
        }

        public void EditarUsuario(usuario usuarioEditado)
        {
            using(var context = new proyecto_taller2Entities())
            {
                
            }
        }

        public List<usuario> ObtenerUsuarios()
        {
            using (var context = new proyecto_taller2Entities())
            {
                return context.usuario.ToList();
            }
        }


        public int ObtenerTipoUsuario(string nombreUsuario, string contraseñaUsuario)
        {
            using (var context = new proyecto_taller2Entities())
            {
                var login = context.usuario
                .FirstOrDefault(u => u.usuario1 == nombreUsuario && u.contraseña == contraseñaUsuario);

                
                 if (login != null)
                {
                    return login.id_tipo_usuario; 
                }
                return -1;
               
                
            }
        }
    }
}
