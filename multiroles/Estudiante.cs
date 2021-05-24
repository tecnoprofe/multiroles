using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
namespace multiroles
{
    class Estudiante:PersonaAbstract
    {
        public void saludo() {
            MessageBox.Show("Soy estudiante");
        }
    }
}
