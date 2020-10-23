using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Schedule
{
    class CheckedListWithWhiteItems : CheckedListBox
    {
        public CheckedListWithWhiteItems()
        {
            this.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);
            this.ForeColor = Color.White;
            this.BackColor = Color.CornflowerBlue;
        }
    }
}
