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
    public partial class ucAtribuicao : UserControl
    {
        Form form;
        private readonly ProjetoService _projetoService;
        public ucAtribuicao(Form form, ProjetoService projetoService)
        {
            this.form = form;
            _projetoService = projetoService;
            InitializeComponent();

            carregarDadosAsync();
        }

        public async Task carregarDadosAsync()
        {
            try
            {
                var funcionarios = await _projetoService.GetProjetosSemAtribuicaoAsync();
                tbAtribuicao.DataSource = funcionarios;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar Projeotos: {ex.Message}");
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
