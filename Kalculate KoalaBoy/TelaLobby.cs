using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Kalculate_KoalaBoy
{
    public partial class TelaLobby : UserControl
    {
        #region Componentes da tela

        private Panel panelMapa; // Variavel do panel do mapa.
        private PictureBox pbKoala; // Koala.
        private int faseSelecionada = 1; // fase

        // Posições do koala
        private Point[] posicoesFases =
        {
            new Point(325, 326), // Fase 1: Arquitetura e Urbanismo.
            new Point(655, 163), // Fase 2: Biomedicina.
            new Point(670, 408), // Fase 3: Direito.
            new Point(299, 616), // Fase 4: Educação Física.
            new Point(662, 616), // Fase 5: Artes e Comunicações.
            new Point(988, 256)  // Fase 6: Comércio Exterior.
        };

        #endregion

        #region inicializa tela mapa
        // Inicia o Lobby.
        public TelaLobby()
        {
            InitializeComponent();
        }

        // Inicializa a tela com a tela principal nos parametros.
        public TelaLobby(TelaPrincipal telaPrincipal)
        {
            // Prepara a estrutura básica do UserControl.
            InitializeComponent();

            // Monta o painel e coloca a imagem do mapa nele.
            CriarPainelMapa();

            // Cria o personagem e o coloca na primeira fase.
            CriarKoala();
            PosicionarKoala();

            // Liga as teclas A e D à movimentação entre as fases.
            this.KeyDown += new KeyEventHandler(TelaLobby_KeyDown);

        }
        #endregion

        #region Criação do painel do mapa

        private void CriarPainelMapa()
        {
            // Cria o painel
            panelMapa = new Panel();
            panelMapa.Name = "panelMapa";

            panelMapa.Dock = DockStyle.Fill; // Preenche a tela inteira com o painel.
            panelMapa.BackgroundImageLayout = ImageLayout.Stretch; // imagem esticada.

            // Carrega a imagem da pasta Imagens/TelaLobby.
            panelMapa.BackgroundImage = Image.FromFile(Path.Combine(
                AppContext.BaseDirectory, "Imagens", "TelaLobby", "TelaLobby.png"));

            // Add o painel.
            this.Controls.Add(panelMapa);

            // Ao clicar no mapa, o teclado continua controlando o Koala.
            panelMapa.Click += new EventHandler(FocarLobby);
        }

        #endregion

        #region Koala

        private void CriarKoala()
        {
            // Cria a PictureBox e define o tamanho do personagem no mapa.
            pbKoala = new PictureBox();
            pbKoala.Name = "pbKoala";
            pbKoala.Size = new Size(32, 50);
            pbKoala.SizeMode = PictureBoxSizeMode.Zoom;
            pbKoala.BackColor = Color.Transparent;
            pbKoala.TabStop = false;
            pbKoala.Image = Image.FromFile(Path.Combine(
                AppContext.BaseDirectory, "Imagens", "KoalaBoy", "KoalaBoy3.png"));

            // add koala.
            panelMapa.Controls.Add(pbKoala);
            pbKoala.Click += new EventHandler(FocarLobby);
        }
        #endregion

        #region Posição do Koala

        private void PosicionarKoala()
        {
            int indice = faseSelecionada - 1;

            // Muda a posição.
            pbKoala.Location = posicoesFases[indice];
            pbKoala.BringToFront();
        }

        #endregion

        #region Teclas A e D

        private void TelaLobby_KeyDown(object sender, KeyEventArgs e)
        {
            // D avança.
            if (e.KeyCode == Keys.D)
            {
                if (faseSelecionada < posicoesFases.Length)
                {
                    faseSelecionada++;
                    PosicionarKoala();
                }

                e.SuppressKeyPress = true;
            }

            // A volta.
            if (e.KeyCode == Keys.A)
            {
                if (faseSelecionada > 1)
                {
                    faseSelecionada--;
                    PosicionarKoala();
                }

                e.SuppressKeyPress = true;
            }
        }

        #endregion

        #region Foco do teclado

        private void FocarLobby(object sender, EventArgs e)
        {
            // Recupera o foco ao clicar no fundo ou no personagem.
            this.Focus();
        }

        #endregion

    }
}