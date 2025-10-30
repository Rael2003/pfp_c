using pfp_c.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pfp_c.Forms
{
    public partial class ucRegistroDigitar : UserControl
    {
        Form1 form;
        private readonly ProjetoService _projetoService;
        long id;
        public ucRegistroDigitar(Form1 form, ProjetoService projetoService, long id)
        {
            InitializeComponent();
            this.form = form;
            _projetoService = projetoService;
            this.id = id;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            form.AbrirUserControl(new ucRegistro(form, _projetoService));
        }
    }
}
