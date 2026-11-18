using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.IO;

namespace Kalculate_KoalaBoy
{
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal()
        {
            InitializeComponent();

            AtivarDoubleBuffered(this);
            MostrarTelaInicial();
        }

        #region Variaveis
        public int BatalhaAtual = 0;
        public TelaInicial telaInicial;
        public TelaTutorial telaTutorial;
        public TelaHistoria telaHistoria;
        public TelaLobby telaLobby;
        public TelaBatalhaDialogo telaDialogo;
        public TelaBatalhaPerguntas telaPerguntas;
        public TelaResultados telaResultados;
        public int pontuacaoTotal = 0;
        #endregion

        #region Exibir TelaInicial
        public void MostrarTelaInicial()
        {
            panelPrincipal.Controls.Clear();

            telaInicial = new TelaInicial(this);
            telaInicial.Dock = DockStyle.Fill;

            panelPrincipal.Controls.Add(telaInicial);
        }
        #endregion

        #region Exibir TelaTutorial
        public void MostrarTelaTutorial()
        {
            panelPrincipal.Controls.Clear();

            telaTutorial = new TelaTutorial(this);
            telaTutorial.Dock = DockStyle.Fill;

            panelPrincipal.Controls.Add(telaTutorial);
        }
        #endregion

        #region Exibir TelaHistoria
        public void MostrarTelaHistoria()
        {
            if (telaHistoria == null)
            {
                telaHistoria = new TelaHistoria(this);
                telaHistoria.Dock = DockStyle.Fill;

                panelPrincipal.Controls.Add(telaHistoria);
            }

            if (telaDialogo != null)
            {
                telaDialogo.Hide();
            }
            if (telaResultados != null)
            {
                telaResultados.Hide();
            }

            telaHistoria.ConfigurarCenario();
            telaHistoria.Show();
            telaHistoria.BringToFront();
        }
        #endregion

        #region Exibir TelaLobby
        public void MostrarTelaLobby()
        {
            if (telaLobby == null)
            {
                telaLobby = new TelaLobby(this);
                telaLobby.Dock = DockStyle.Fill;

                panelPrincipal.Controls.Add(telaLobby);
            }

            if (telaHistoria != null)
            {
                telaHistoria.Hide();
            }
            if (telaResultados != null)
            {
                telaResultados.Hide();
            }

            telaLobby.Show();
            telaLobby.BringToFront();

            // Faz o lobby receber as teclas A e D quando ele é aberto.
            telaLobby.Focus();
        }
        #endregion

        #region Exibir TelaBatalhaDialogo
        public void MostrarTelaBatalhaDialogo()
        {
            if (telaDialogo == null)
            { 
                telaDialogo = new TelaBatalhaDialogo(this);
                telaDialogo.Dock = DockStyle.Fill;

                panelPrincipal.Controls.Add(telaDialogo);
            }

            if (telaHistoria != null)
            {
                telaHistoria.Hide();
            }
            if (telaPerguntas != null)
            {
                telaPerguntas.Hide();
            }

            telaDialogo.DefinirImagensInimigo();
            telaDialogo.ConfigurarCenario();
            telaDialogo.Show();
            telaDialogo.BringToFront();
        }
        #endregion

        #region Exibir TelaBatalhaPerguntas
        public void MostrarTelaBatalhaPerguntas()
        {
            if (telaPerguntas == null)
            {
                telaPerguntas = new TelaBatalhaPerguntas(this);
                telaPerguntas.Dock = DockStyle.Fill;

                panelPrincipal.Controls.Add(telaPerguntas);
            }

            if (telaDialogo != null)
            {
                telaDialogo.Hide();
            }

            telaPerguntas.InicializarVidaInimigo();
            telaPerguntas.ReiniciarPontuacao();
            telaPerguntas.DefinirImagensInimigo();
            telaPerguntas.ConfigurarCenario();
            telaPerguntas.Show();
            telaPerguntas.BringToFront();
        }
        #endregion

        #region Exibir TelaResultados
        public void MostrarTelaResultados()
        {
            if (telaResultados == null)
            {
                telaResultados = new TelaResultados(this);
                telaResultados.Dock = DockStyle.Fill;

                panelPrincipal.Controls.Add(telaResultados);
            }

            if (telaDialogo != null)
            {
                telaDialogo.Hide();
            }

            telaResultados.DefinirImagens();
            telaResultados.ConfigurarCenario();
            telaResultados.Show();
            telaResultados.BringToFront();
        }
        #endregion

        #region Derrota definitiva - Game Over

        public void MostrarTelaDerrota()
        {
            // Cobre as outras telas com a imagem de derrota.
            Panel panelDerrota = new Panel();
            panelDerrota.Name = "panelDerrota";
            panelDerrota.Dock = DockStyle.Fill;
            panelDerrota.BackgroundImageLayout = ImageLayout.Stretch;
            panelDerrota.BackgroundImage = Image.FromFile(Path.Combine(
                AppContext.BaseDirectory, "Imagens", "TelaDerrota", "Derrota.png"));

            // Um botão simples na parte de baixo fecha a janela do jogo.
            Button btnFecharJogo = new Button();
            btnFecharJogo.Name = "btnFecharJogo";
            btnFecharJogo.Text = "FECHAR JOGO";
            btnFecharJogo.Dock = DockStyle.Bottom;
            btnFecharJogo.Height = 40;
            btnFecharJogo.BackColor = Color.White;
            btnFecharJogo.Font = new Font("Arial", 12, FontStyle.Bold);
            btnFecharJogo.Click += new EventHandler(btnFecharJogo_Click);
            panelDerrota.Controls.Add(btnFecharJogo);

            panelPrincipal.Controls.Add(panelDerrota);
            panelDerrota.BringToFront();
            btnFecharJogo.Focus();
        }

        private void btnFecharJogo_Click(object sender, EventArgs e)
        {
            // Ao fechar a janela principal, o jogo também é encerrado.
            this.Close();
        }

        #endregion

        #region DoubleBuffered em Paineis
        public void AtivarDoubleBuffered(Control controle)
        {
            if (controle is Panel)
            {
                typeof(Control)
                    .GetProperty("DoubleBuffered",BindingFlags.Instance | BindingFlags.NonPublic)
                    ?.SetValue(controle, true);
            }

            controle.ControlAdded -= ControleAdicionado;
            controle.ControlAdded += ControleAdicionado;

            foreach (Control controleFilho in controle.Controls)
            {
                AtivarDoubleBuffered(controleFilho);
            }
        }

        private void ControleAdicionado(object sender, ControlEventArgs e)
        {
            AtivarDoubleBuffered(e.Control);
        }
        #endregion
    }
}
