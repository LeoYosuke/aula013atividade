using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula013atividade
{
    internal class Utilidade
    {
        public bool textbox_estavazio(TextBox txt)
        {
            if (txt.Text == "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
