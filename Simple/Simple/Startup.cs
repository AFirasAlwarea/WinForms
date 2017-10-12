using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple
{
    class Startup
    {
        static void Main()
        {
            MyForm form = new MyForm();
            // form.Text = "My Form";
            Application.Run(form);
        }
    }
}
