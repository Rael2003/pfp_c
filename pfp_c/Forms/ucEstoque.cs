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
    public partial class ucEstoque : UserControl
    {
        Form1 form;
        PedidoEstoqueService _pedidoService;
        public ucEstoque(Form1 form, PedidoEstoqueService pedidoService)
        {
            this.form = form;
            _pedidoService = pedidoService;
            InitializeComponent();

            carregarDadosAsync();

        }

        public async Task carregarDadosAsync()
        {
            try
            {
                var funcionarios = await _pedidoService.GetPedidosAsync();
                tbCadastro.DataSource = funcionarios;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar pedidos: {ex.Message}");
            }
        }
    }
}
