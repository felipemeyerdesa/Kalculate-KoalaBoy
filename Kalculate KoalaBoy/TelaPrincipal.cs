using System;
using System.Reflection;
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
            DoubleBuffered = true;
            AtivarDoubleBuffered(this);

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

        public void VoltarAoMapaAposBatalha(bool venceu, int vidaRestante)
        {
            if (telaAtual != telaDialogo || telaDialogo == null)
                return;

            mapa.RegistrarResultado(BatalhaAtual, venceu, vidaRestante);
            MostrarMapa();

            telaDialogo.Dispose();
            telaPerguntas?.Dispose();
            telaDialogo = null;
            telaPerguntas = null;
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

        #region Double buffering dos painéis

        private void AtivarDoubleBuffered(Control controle)
        {
            if (controle is Panel)
            {
                typeof(Control)
                    .GetProperty("DoubleBuffered",
                        BindingFlags.Instance | BindingFlags.NonPublic)
                    ?.SetValue(controle, true);
            }

            controle.ControlAdded += ControleAdicionado;

            foreach (Control filho in controle.Controls)
                AtivarDoubleBuffered(filho);
        }

        private void ControleAdicionado(object sender, ControlEventArgs e)
        {
            AtivarDoubleBuffered(e.Control);
        }

        #endregion
    }
}

