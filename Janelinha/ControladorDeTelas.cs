using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Janelinha
{
    class ControladorDeTelas

    {
        public static void AbrirFormulario(Control pnl, Type uc)
        {
            pnl.Controls.Clear();
            pnl.Controls.Add(Activator.CreateInstance(uc) as UserControl);
        }
    }
}
