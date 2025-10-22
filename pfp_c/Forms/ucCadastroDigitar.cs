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

namespace pfp_c.Forms
{
    public partial class ucCadastroDigitar : UserControl
    {
        private readonly FuncionarioService _funcionarioService;
        private Form1 form1;
        public ucCadastroDigitar(Form1 form, FuncionarioService funcionarioService)
        {
            InitializeComponent();
            _funcionarioService = funcionarioService;
            form1 = form;
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
                var resposta = _funcionarioService.CriarFuncionarioAsync(funcionario);
                MessageBox.Show($"Servidor respondeu: Sucesso {resposta}", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar funcionário: Erro \n{ex.Message}", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
