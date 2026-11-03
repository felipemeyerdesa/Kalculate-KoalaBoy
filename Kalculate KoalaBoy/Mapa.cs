using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Kalculate_KoalaBoy
{
    public partial class Mapa : UserControl
    {
        private int vidasGerais = 3;
        private int posicaoAtual;
        private int ultimaFaseLiberada = 1;

        public event Action<int> FaseEscolhida;

        public Mapa()
        {
            InitializeComponent();
            btnJogarFase.Click += (sender, e) => JogarFase();
            panelDescricaoFase.Hide();
        }

        public void AtualizarVisual()
        {
            PosicionarJogador();
            AtualizarVidasGerais();
        }

        private void JogarFase()
        {
            if (vidasGerais > 0 && posicaoAtual > 0 &&
                posicaoAtual <= ultimaFaseLiberada)
            {
                FaseEscolhida?.Invoke(posicaoAtual);
            }
        }


        #region Painel de descrição da fase

        private void PosicionarPainelDescricao()
        {
            int margem = 15;
            int centroJogador = pbJogador.Left + pbJogador.Width / 2;

            if (centroJogador >= panelMapa.ClientSize.Width / 2)
            {
                // Jogador à direita: painel à esquerda.
                panelDescricaoFase.Left = margem;
            }
            else
            {
                // Jogador à esquerda: painel à direita.
                panelDescricaoFase.Left =
                    panelMapa.ClientSize.Width
                    - panelDescricaoFase.Width
                    - margem;
            }

            panelDescricaoFase.Top = margem;
            panelDescricaoFase.BringToFront();
        }
        private void AtualizarDescricaoFase()
        {
            if (posicaoAtual == 0)
            {
                panelDescricaoFase.Visible = false;
                return;
            }

            string[,] fases =
            {
        { "Gato", "Arquitetura e Urbanismo", "Adição" },
        { "Lobo", "Biomedicina", "Adição e subtração" },
        { "Raposa", "Direito", "Adição, subtração e multiplicação" },
        { "Tubarão", "Educação Física", "Adição, subtração, multiplicação e divisão" },
        { "Gorila", "Artes e Comunicação", "Operações básicas e porcentagem" },
        { "Puma", "Comércio Exterior", "Operações combinadas" },
        { "Urubu", "Engenharia", "Operações combinadas avançadas" }
    };

            int indice = posicaoAtual - 1;

            lblNomeInimigo.Text = fases[indice, 0];
            lblCurso.Text = fases[indice, 1];
            lblOperacao.Text = "Operações: " + fases[indice, 2];

            btnJogarFase.Enabled = vidasGerais > 0 &&
                posicaoAtual <= ultimaFaseLiberada;

            panelDescricaoFase.Visible = true;
        }

        #endregion

        #region Vidas gerais

        private void AtualizarVidasGerais()
        {
            PictureBox[] coracoes =
            {
                pbCoracao1,
                pbCoracao2,
                pbCoracao3
            };

            for (int i = 0; i < coracoes.Length; i++)
            {
                string arquivo = i < vidasGerais
                    ? "vida cheia.jpg"
                    : "vida perdida.jpg";

                string caminho = Path.Combine(
                    AppContext.BaseDirectory,
                    "Imagens",
                    "TelaPrincipal",
                    arquivo
                );

                // Copia a imagem para não manter o arquivo preso.
                using (Image imagem = Image.FromFile(caminho))
                {
                    Image anterior = coracoes[i].Image;
                    coracoes[i].Image = new Bitmap(imagem);
                    anterior?.Dispose();
                }
            }
        }

        #endregion

        #region Casas e movimentação no mapa

        private PictureBox[] ObterCasas()
        {
            return new PictureBox[]
            {
                pbInicio,
                pbFase1,
                pbFase2,
                pbFase3,
                pbFase4,
                pbFase5,
                pbFase6,
                pbFase7
            };
        }

        private void MoverJogador(int direcao)
        {
            PictureBox[] casas = ObterCasas();
            int destino = posicaoAtual + direcao;

            if (destino < 0 ||
                destino >= casas.Length ||
                destino > ultimaFaseLiberada)
            {
                return;
            }

            posicaoAtual = destino;
            PosicionarJogador();
        }

        private void PosicionarJogador()
        {
            PictureBox casa = ObterCasas()[posicaoAtual];

            // Converte a posição caso estejam em painéis diferentes.
            Point centroDaCasa = casa.PointToScreen(
                new Point(casa.Width / 2, casa.Height / 2)
            );

            Point destino =
                pbJogador.Parent.PointToClient(centroDaCasa);

            pbJogador.Location = new Point(
                destino.X - pbJogador.Width / 2,
                destino.Y - pbJogador.Height / 2
            );

            pbJogador.BringToFront();
            PosicionarPainelDescricao();
            AtualizarDescricaoFase();
        }

        #endregion

        #region Comandos do teclado

        protected override bool ProcessCmdKey(
            ref Message msg, Keys keyData)
        {
            if (Visible)
            {
                switch (keyData)
                {
                    case Keys.D:
                    case Keys.Right:
                    case Keys.S:
                    case Keys.Down:
                        MoverJogador(1);
                        return true;

                    case Keys.A:
                    case Keys.Left:
                    case Keys.W:
                    case Keys.Up:
                        MoverJogador(-1);
                        return true;

                    case Keys.Enter:
                        JogarFase();
                        return true;
                }
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        #endregion

    }
}

