using System.Windows.Forms;

namespace Kalculate_KoalaBoy
{
    public partial class TelaPrincipal : Form
    {
        private readonly Mapa mapa;
        private UserControl telaAtual;

        public int BatalhaAtual { get; private set; } = 1;
        public TelaBatalhaDialogo telaDialogo;
        public TelaBatalhaPerguntas telaPerguntas;

        public TelaPrincipal()
        {
            InitializeComponent();

            mapa = new Mapa { Dock = DockStyle.Fill, Visible = false };
            mapa.FaseEscolhida += MostrarTelaBatalha;
            panelPrincipal.Controls.Add(mapa);

            MostrarTelaInicial();
        }

        #region Navegação entre telas

        public void MostrarTelaInicial()
        {
            var inicio = new TelaInicial();
            inicio.JogoIniciado += MostrarMapa;
            ExibirTela(inicio);
        }

        public void MostrarMapa()
        {
            ExibirTela(mapa);
            mapa.AtualizarVisual();
            mapa.Focus();
        }

        private void MostrarTelaBatalha(int fase)
        {
            BatalhaAtual = fase;
            MostrarTelaBatalhaDialogo();
        }

        public void MostrarTelaBatalhaDialogo()
        {
            if (telaDialogo == null)
                telaDialogo = new TelaBatalhaDialogo(this);

            telaDialogo.ConfigurarCenario();
            ExibirTela(telaDialogo);
        }

        public void MostrarTelaBatalhaPerguntas()
        {
            if (telaPerguntas == null)
                telaPerguntas = new TelaBatalhaPerguntas(this);

            telaPerguntas.ConfigurarCenario();
            ExibirTela(telaPerguntas);
        }

        private void ExibirTela(UserControl tela)
        {
            if (telaAtual == tela)
                return;

            if (telaAtual == mapa || telaAtual == telaDialogo || telaAtual == telaPerguntas)
            {
                telaAtual?.Hide();
            }
            else if (telaAtual != null)
            {
                panelPrincipal.Controls.Remove(telaAtual);
                telaAtual.Dispose();
            }

            telaAtual = tela;
            tela.Dock = DockStyle.Fill;

            if (tela.Parent != panelPrincipal)
                panelPrincipal.Controls.Add(tela);

            tela.Show();
            tela.BringToFront();
        }

        #endregion
    }
}

