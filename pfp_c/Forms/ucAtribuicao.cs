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
    public partial class ucAtribuicao : UserControl
    {
        Form form;
        public ucAtribuicao(Form form)
        {
            this.form = form;
            InitializeComponent();
        }
    }
}
