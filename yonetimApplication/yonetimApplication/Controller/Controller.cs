using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yonetimApplication.Controller
{
    public class Controller
    {
        public static bool question()
        {
            DialogResult result = MessageBox.Show("are you sure?", "Confirmation", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
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
