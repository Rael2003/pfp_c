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
    public partial class ucRegistro : UserControl
    {
        Form form;
        private readonly ProjetoService _projetoService;
        public ucRegistro(Form form, ProjetoService projetoService)
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
    }
}
