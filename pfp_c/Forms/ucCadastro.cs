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

        public void Alterar()
        {
            form1.AbrirUserControl(new ucCadastroDigitar(form1, _funcionarioService, (long)tbCadastro.CurrentRow.Cells[0].Value));

        }

        public void Excluir()
        {
            _funcionarioService.DeletarFuncionarioAsync((long)tbCadastro.CurrentRow.Cells[0].Value);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            form1.AbrirUserControl(new ucCadastroDigitar(form1, _funcionarioService, 0));
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void alterarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Alterar();
        }

        private void excluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Excluir();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
