using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalculate_KoalaBoy
{
    public partial class TelaLobby : UserControl
    {
        public TelaLobby()
        {
            InitializeComponent();

            btnJogarFase.Click += (sender, e) => JogarFase();
            PictureBox[] casas = ObterCasas();
            tamanhoOriginalMapa = panelMapa.ClientSize;
            posicoesOriginais = Array.ConvertAll(casas, casa => casa.Bounds);
            for (int i = 0; i < casas.Length; i++)
            {
                int fase = i;
                casas[i].Click += (sender, e) => SelecionarFase(fase);
            }
            panelMapa.SizeChanged += (sender, e) => AjustarCaixinhas();
            panelDescricaoFase.Hide();
        }

        private int vidasGerais = 3;
        private int posicaoAtual;
        private int ultimaFaseLiberada = 1;
        private readonly int[] estrelasPorFase = new int[8];
        private const int UltimaFaseDoMapaAtual = 4;
        private readonly Size tamanhoOriginalMapa;
        private readonly Rectangle[] posicoesOriginais;

        public event Action<int> FaseEscolhida;

        public void AtualizarVisual()
        {
            AjustarCaixinhas();
            AtualizarVidasGerais();
        }

        public void RegistrarResultado(int fase, bool venceu, int vidaRestante)
        {
            if (venceu)
            {
                int estrelas = Math.Min(3, vidaRestante);
                estrelasPorFase[fase] = Math.Max(estrelasPorFase[fase], estrelas);
                ultimaFaseLiberada = Math.Max(ultimaFaseLiberada,
                    Math.Min(fase + 1, estrelasPorFase.Length - 1));
            }
            else if (vidasGerais > 0)
            {
                vidasGerais--;
            }
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

        private static readonly string[] imagensDosMenus =
        {
            "MenuGato.png",
            "MenuLobo.png",
            "MenuRaposa.png",
            "MenuTubarão.png"
        };

        private int faseDoMenuExibido;

        private void AtualizarDescricaoFase()
        {
            if (posicaoAtual == 0)
            {
                panelDescricaoFase.Visible = false;
                return;
            }

            if (faseDoMenuExibido != posicaoAtual)
            {
                string caminho = Path.Combine(AppContext.BaseDirectory, "Imagens", "TelaLobby", imagensDosMenus[posicaoAtual - 1]);

                using (Image imagem = Image.FromFile(caminho))
                {
                    Image anterior = panelDescricaoFase.BackgroundImage;
                    panelDescricaoFase.BackgroundImage = new Bitmap(imagem);
                    anterior?.Dispose();
                }

                //panelDescricaoFase.Image = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "KoalaBoy", "koala_" + vidasGerais + "hp.png"));


                faseDoMenuExibido = posicaoAtual;
            }

            btnJogarFase.Enabled = vidasGerais > 0 && posicaoAtual <= ultimaFaseLiberada;

            panelDescricaoFase.Visible = true;
        }

        #endregion

        #region Vidas gerais

        private void AtualizarVidasGerais()
        {
            string caminho = Path.Combine(AppContext.BaseDirectory, "Imagens", "KoalaBoy", "koala_" + vidasGerais + "hp.png");

            using (Image imagem = Image.FromFile(caminho))
            {
                Image anterior = pbKoalaVidas.Image;
                pbKoalaVidas.Image = new Bitmap(imagem);
                anterior?.Dispose();
            }

            //pbKoalaVidas.Image = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "KoalaBoy", "koala_" + vidasGerais + "hp.png"));
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
            };
        }

        private void MoverJogador(int direcao)
        {
            SelecionarFase(posicaoAtual + direcao);
        }

        private void SelecionarFase(int destino)
        {
            if (destino < 0 ||
                destino > UltimaFaseDoMapaAtual ||
                destino > ultimaFaseLiberada)
            {
                return;
            }

            posicaoAtual = destino;
            PosicionarJogador();
        }

        private void AjustarCaixinhas()
        {
            double escalaX = (double)panelMapa.ClientSize.Width / tamanhoOriginalMapa.Width;
            double escalaY = (double)panelMapa.ClientSize.Height / tamanhoOriginalMapa.Height;
            PictureBox[] casas = ObterCasas();

            for (int i = 0; i < casas.Length; i++)
            {
                Rectangle original = posicoesOriginais[i];
                casas[i].SetBounds(
                    (int)Math.Round(original.X * escalaX),
                    (int)Math.Round(original.Y * escalaY),
                    (int)Math.Round(original.Width * escalaX),
                    (int)Math.Round(original.Height * escalaY));
            }

            PosicionarJogador();
        }

        private void PosicionarJogador()
        {
            PictureBox casa = ObterCasas()[posicaoAtual];
            pbJogador.Location = new Point(
                casa.Left + (casa.Width - pbJogador.Width) / 2,
                casa.Top + (casa.Height - pbJogador.Height) / 2
            );

            pbJogador.BringToFront();
            panelDescricaoFase.BringToFront();
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
