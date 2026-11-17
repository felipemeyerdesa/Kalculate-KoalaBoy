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
    public partial class TelaResultados : UserControl
    {
        private TelaPrincipal principal;

        public TelaResultados(TelaPrincipal telaPrincipal)
        {
            InitializeComponent();
            principal = telaPrincipal;
            FontesJogo.AplicarFonte(this);
            DefinirImagens();
        }

        private async void TelaResultados_Load(object sender, EventArgs e)
        {
            if (principal.telaDialogo.koalaVenceu == true)
            {
                await Task.Delay(2000);
                timerAnimacao.Start();
            }
            else
            {
                ConfigurarPainelResultado();
            }
        }

        #region Variaveis
        int pontuação;
        int acertos;
        int qtdPerguntas;
        #endregion

        #region Animação Pegar Fragmento
        private async void timerAnimacao_Tick(object sender, EventArgs e)
        {

            pbKoalaBoy.Left += 25;

            if (pbKoalaBoy.Left >= 532)
            {
                pbKoalaBoy.Left = 532;
                timerAnimacao.Stop();
                await Task.Delay(1000);
                ConfigurarPainelResultado();
            }
        }
        #endregion

        #region Configura Cenario
        public void ConfigurarCenario()
        {
            BackgroundImage = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", pastaInimigo, cenario));

            pbKoalaBoy.Image = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "KoalaBoy", "KoalaBoy" + principal.telaPerguntas.koalahp + ".png"));

            pbInimigo.Image = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", pastaInimigo, inimigo + "0.png"));

            pbFragmento.Image = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "TelaResultados", fragmento));

            pbFragmento.Parent = this;
            pbFragmento.Location = new Point(748, 354);

            // ArqUrb
            if (principal.BatalhaAtual == 1)
            {
                pbKoalaBoy.Location = new Point(120, 252);
                pbInimigo.Location = new Point(905, 252);
            }
            // Biomed
            else if (principal.BatalhaAtual == 2)
            {
                pbKoalaBoy.Location = new Point(120, 252);
                pbInimigo.Location = new Point(905, 252);
            }
            // Direito
            else if (principal.BatalhaAtual == 3)
            {
                pbKoalaBoy.Location = new Point(120, 225);
                pbInimigo.Location = new Point(905, 225);
            }
            // Educação Física
            else if (principal.BatalhaAtual == 4)
            {
                pbKoalaBoy.Location = new Point(120, 252);
                pbInimigo.Location = new Point(905, 252);
            }
            // Artes e Comunicação
            else if (principal.BatalhaAtual == 5)
            {
                pbKoalaBoy.Location = new Point(120, 352);
                pbInimigo.Location = new Point(905, 352);
            }
            // Comércio Exterior
            else if (principal.BatalhaAtual == 6)
            {
                pbKoalaBoy.Location = new Point(120, 300);
                pbInimigo.Location = new Point(905, 300);
            }
            // Engenharia
            else if (principal.BatalhaAtual == 7)
            {
                pbKoalaBoy.Location = new Point(120, 252);
                pbInimigo.Location = new Point(905, 252);
            }
        }
        #endregion

        #region Configura Painel Resultado
        private void ConfigurarPainelResultado()
        {
            pbResultado.Image = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "TelaResultados", resultado + ".gif"));

            pbInimigoResultado.Image = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", pastaInimigo, inimigo + "3.png"));

            pbLogo.Image = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "TelaInicial", "KoalaLogo.gif"));

            pbKoalaBoyUrubu.Image = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "TelaResultados", "KoalaBoyUrubu" + resultado + ".png"));
            
            pbNota.Image = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "TelaResultados", "Estrela" + principal.telaPerguntas.koalahp + ".gif"));

            pontuação = principal.telaPerguntas.pontuacaoBatalha;

            acertos = principal.telaPerguntas.acertos;

            qtdPerguntas = principal.telaPerguntas.perguntaAtual-1;

            lblInimigoBatalha.Text = inimigo;

            lblPontuacaoValor.Text = pontuação.ToString();

            lblAcertosValor.Text = acertos.ToString() + "/" + qtdPerguntas;

            if(principal.telaDialogo.koalaVenceu == true)
            {
                pbFragmento.Parent = panelResultados;
                pbFragmento.Location = new Point(498, 256);
                pbFragmento.BringToFront();
            }

            panelResultados.BringToFront();
            panelResultados.Visible = true;
        }
        #endregion

        #region Imagens
        private string pastaInimigo;
        private string cenario;
        private string fragmento;
        private string inimigo;
        private string resultado;

        private void DefinirImagens()
        {
            // ArqUrb
            if (principal.BatalhaAtual == 1)
            {
                pastaInimigo = "ArqUrb";
                cenario = "ArqUrb.png";
                inimigo = "Gato";
                fragmento = "ArqUrbFragmento.gif";
            }
            // Biomed
            else if (principal.BatalhaAtual == 2)
            {
                pastaInimigo = "Biomed";
                cenario = "Biomed.png";
                inimigo = "Lobo";
                fragmento = "BiomedFragmento.gif";
            }
            // Direito
            else if (principal.BatalhaAtual == 3)
            {
                pastaInimigo = "Direito";
                cenario = "Direito.png";
                inimigo = "Raposa";
                fragmento = "DireitoFragmento.gif";
            }
            // Fefesp
            else if (principal.BatalhaAtual == 4)
            {
                pastaInimigo = "Fefesp";
                cenario = "Fefesp.png";
                inimigo = "Tutuba";
                fragmento = "FefespFragmento.gif";
            }
            // PubliPropag
            else if (principal.BatalhaAtual == 5)
            {
                pastaInimigo = "PubliPropag";
                cenario = "PubliPropag.png";
                inimigo = "Macaca";
                fragmento = "PubliPropagFragmento.gif";
            }
            // Comex
            else if (principal.BatalhaAtual == 6)
            {
                pastaInimigo = "Comex";
                cenario = "Comex.png";
                inimigo = "Pantera";
                fragmento = "ComexFragmento.gif";
            }
            // Engenharia
            else if (principal.BatalhaAtual == 7)
            {
                pastaInimigo = "Engenharia";
                cenario = "Engenharia.png";
                inimigo = "Urubu";
                fragmento = "EngenhariaFragmento.gif";
            }

            if (principal.telaDialogo.koalaVenceu == true)
            {
                resultado = "Vitória";
            }
            else if (principal.telaDialogo.koalaVenceu == false)
            {
                resultado = "Derrota";
            }

        }
        #endregion

        #region Botão Voltar Lobby
        private void pbBotaoLobby_Click(object sender, EventArgs e)
        {
            principal.MostrarTelaLobby();
        }
        
        #region AnimaçãoBotãoLobby

        private int larguraAlvoLobby = 234;
        private int alturaAlvoLobby = 84;
        private bool mouseEmCimaLobby = false;

        // MOUSE ENTER
        private void pbBotaoLobby_MouseEnter(object sender, EventArgs e)
        {
            mouseEmCimaLobby = true;

            larguraAlvoLobby = 250;
            alturaAlvoLobby = 94;

            timerBotaoLobby.Start();
        }

        // MOUSE LEAVE
        private void pbBotaoLobby_MouseLeave(object sender, EventArgs e)
        {
            mouseEmCimaLobby = false;

            larguraAlvoLobby = 234;
            alturaAlvoLobby = 84;

            timerBotaoLobby.Start();
        }

        // MOUSE DOWN
        private void pbBotaoLobby_MouseDown(object sender, MouseEventArgs e)
        {
            larguraAlvoLobby = 228;
            alturaAlvoLobby = 80;

            timerBotaoLobby.Start();
        }

        // MOUSE UP
        private void pbBotaoLobby_MouseUp(object sender, MouseEventArgs e)
        {
            if (mouseEmCimaLobby == true)
            {
                larguraAlvoLobby = 250;
                alturaAlvoLobby = 94;
            }
            else
            {
                larguraAlvoLobby = 234;
                alturaAlvoLobby = 84;
            }

            timerBotaoLobby.Start();
        }

        // TIMER
        private void timerBotaoLobby_Tick(object sender, EventArgs e)
        {
            // LARGURA
            if (pbBotaoLobby.Width < larguraAlvoLobby)
            {
                pbBotaoLobby.Width += 2;
                pbBotaoLobby.Left -= 1;
            }
            else if (pbBotaoLobby.Width > larguraAlvoLobby)
            {
                pbBotaoLobby.Width -= 2;
                pbBotaoLobby.Left += 1;
            }

            // ALTURA
            if (pbBotaoLobby.Height < alturaAlvoLobby)
            {
                pbBotaoLobby.Height += 2;
                pbBotaoLobby.Top -= 1;
            }
            else if (pbBotaoLobby.Height > alturaAlvoLobby)
            {
                pbBotaoLobby.Height -= 2;
                pbBotaoLobby.Top += 1;
            }

            if (pbBotaoLobby.Width == larguraAlvoLobby &&
                pbBotaoLobby.Height == alturaAlvoLobby)
            {
                timerBotaoLobby.Stop();
            }
        }

        #endregion

        #endregion

    }
}
