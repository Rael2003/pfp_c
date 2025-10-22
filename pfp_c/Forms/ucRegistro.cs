using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pfp_c
{
    public partial class ucRegistro : UserControl
    {
        Form form;
        public ucRegistro(Form form)
        {
            this.form = form;
            InitializeComponent();
        }
    }
}
