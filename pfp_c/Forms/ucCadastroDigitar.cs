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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace pfp_c.Forms
{
    public partial class ucCadastroDigitar : UserControl
    {
        private readonly FuncionarioService _funcionarioService;
        private Form1 form1;
        long id = 0;
        public ucCadastroDigitar(Form1 form, FuncionarioService funcionarioService, long id)
        {
            InitializeComponent();
            _funcionarioService = funcionarioService;
            form1 = form;
            if (id > 0)
            {
                this.id = id;
                CarregarDados();
            }
        }

        public async void CarregarDados()
        {
            try
            {
                var fun = await _funcionarioService.BuscarFuncionarioPorIdAsync(this.id);
                txtNome.Text = fun.NomeCompleto;
                txtCPF.Text = fun.Cpf;
                txtRG.Text = fun.Rg;
                txtEmail.Text = fun.Email;
                txtTelefone.Text = fun.TelefoneCelular;
                txtCargo.Text = fun.CargoFuncao;
                txtSalario.Text = fun.Salario.ToString();
                txtEndereco.Text = fun.EnderecoCompleto;
                txtPIS.Text = fun.NumeroDoPis;
                txtBanco.Text = fun.Banco;
                txtAgencia.Text = fun.Agencia;
                cboEstadoCivil.SelectedItem = fun.EstadoCivil;
                cboRegime.SelectedItem = fun.RegimeDeContratacao;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar funcionários: {ex.Message}");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Cria o objeto Funcionario a partir dos campos da tela
                var funcionario = new Funcionario
                {
                    NomeCompleto = txtNome.Text,
                    Cpf = txtCPF.Text,
                    Rg = txtRG.Text,
                    Email = txtEmail.Text,
                    TelefoneCelular = txtTelefone.Text,
                    CargoFuncao = txtCargo.Text,
                    Salario = decimal.TryParse(txtSalario.Text, out var salario) ? salario : 0,
                    DataDeAdmissao = "2025-10-20",
                    DataDeNascimento = "1990-05-10"
                };

                // Envia para a API
                if (id > 0)
                {
                    var resposta = _funcionarioService.AtualizarFuncionarioAsync(id, funcionario);
                    MessageBox.Show($"Servidor respondeu: Sucesso {resposta}", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    var resposta = _funcionarioService.CriarFuncionarioAsync(funcionario);
                    MessageBox.Show($"Servidor respondeu: Sucesso {resposta}", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar funcionário: Erro \n{ex.Message}", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            form1.AbrirUserControl(new ucCadastro(form1,_funcionarioService));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            form1.AbrirUserControl(new ucCadastro(form1, _funcionarioService));

        }
    }
}
