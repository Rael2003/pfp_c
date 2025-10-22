using pfp_c.Services;

namespace pfp_c
{
    public partial class Form1 : Form
    {
        FuncionarioService _funcionarioService;
        public Form1(FuncionarioService funcionarioService)
        {
            InitializeComponent();

            _funcionarioService = funcionarioService;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public void AbrirUserControl(UserControl uc)
        {
            // Limpa o painel principal antes de abrir outro
            pnlPrincipal.Controls.Clear();

            // Ajusta o tamanho do UserControl para ocupar o painel
            uc.Dock = DockStyle.Fill;

            // Adiciona o UserControl no painel principal
            pnlPrincipal.Controls.Add(uc);
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            AbrirUserControl(new ucCadastro(this, _funcionarioService));
        }
        private void btnAtribuicao_Click_1(object sender, EventArgs e)
        {
            AbrirUserControl(new ucAtribuicao(this));
        }

        private void btnRegistro_Click_1(object sender, EventArgs e)
        {
            AbrirUserControl(new ucRegistro(this));
        }

        private void btnEstoque_Click_1(object sender, EventArgs e)
        {
            AbrirUserControl(new ucEstoque(this));
        }
    }
}
