using System;
using System.Drawing;
using System.Windows.Forms;

namespace Schedule
{
    public class CustomLabel : Label
    {


        public CustomLabel()
        {

            this.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.White;
        }

    }
}
