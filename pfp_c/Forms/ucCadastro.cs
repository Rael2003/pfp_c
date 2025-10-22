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

namespace pfp_c
{
    public partial class ucCadastro : UserControl
    {
        private readonly FuncionarioService _funcionarioService;
        private Form1 form1;
        public ucCadastro(Form1 form, FuncionarioService funcionarioService)
        {
            InitializeComponent();
            _funcionarioService = funcionarioService;
            form1 = form;

            carregarDadosAsync();
        }

        public async Task carregarDadosAsync()
        {
            try
            {
                var funcionarios = await _funcionarioService.ListarFuncionariosAsync();
                tbCadastro.DataSource = funcionarios;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar funcionários: {ex.Message}");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            form1.AbrirUserControl(new ucCadastroDigitar(form1, _funcionarioService));
        }
    }
}
