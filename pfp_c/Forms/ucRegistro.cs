using pfp_c.Forms;
using pfp_c.Models;
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
using static System.Windows.Forms.DataFormats;

namespace pfp_c
{
    public partial class ucRegistro : UserControl
    {
        Form1 form;
        private readonly ProjetoService _projetoService;
        public ucRegistro(Form1 form, ProjetoService projetoService)
        {
            this.form = form;
            InitializeComponent();
            _projetoService = projetoService;

            carregarDadosAsync();

        }

        public async Task carregarDadosAsync()
        {
            try
            {
                var ret = await _projetoService.GetProjetosAsync();
                tbRegistro.DataSource = ret;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar Projeotos: {ex.Message}");
            }
        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.form.AbrirUserControl(new ucRegistroDigitar(form, _projetoService, (long)tbRegistro.CurrentRow.Cells[0].Value));
        }
    }
}
