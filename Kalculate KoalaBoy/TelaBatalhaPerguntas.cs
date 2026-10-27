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
    public partial class TelaBatalhaPerguntas : UserControl
    {
        private TelaPrincipal principal;

        public TelaBatalhaPerguntas()
        {
            InitializeComponent();
            ConfigurarEfeitoDano();
            FontesJogo.AplicarFonte(this);
        }

        private async void TelaBatalhaPerguntas_Load(object sender, EventArgs e)
        {
            principal = (TelaPrincipal)this.FindForm();
            await Perguntas();
        }

        private Random random = new Random();
        private int gatohp = 3;
        private int koalahp = 3;

        #region Perguntas
        private int perguntaAtual = 1;
        private int respostaCorreta;
        private int A;
        private int B;
        private int C;
        private int AlternativaErrada1;
        private int AlternativaErrada2;

        private async Task Perguntas()
        {
            if (principal.BatalhaAtual == 1)
            {
                if (gatohp == 0)
                {
                    await principal.telaDialogo.EncerrarBatalha(1);
                    principal.MostrarTelaBatalhaDialogo();
                    return;
                }

                if (koalahp == 0)
                {
                    await principal.telaDialogo.EncerrarBatalha(2);
                    principal.MostrarTelaBatalhaDialogo();
                    return;
                }

                int limiteMaximo = 21;

                if (perguntaAtual == 1)
                {
                    limiteMaximo = 21;
                    A = random.Next(1, 11);
                    B = random.Next(1, 11);

                    AlternativaErrada1 = random.Next(1, limiteMaximo);
                    AlternativaErrada2 = random.Next(1, limiteMaximo);

                    respostaCorreta = A + B;

                    // Exibe o enunciado da pergunta 1
                    lblCaixaDialogo.Text = "O Gato separou " + A + " blocos azuis e " + B + " blocos vermelhos para uma construção. Quantos blocos são ao todo?";
                }
                else if (perguntaAtual == 2)
                {
                    limiteMaximo = 41;
                    A = random.Next(1, 21);
                    B = random.Next(1, 21);

                    AlternativaErrada1 = random.Next(1, limiteMaximo);
                    AlternativaErrada2 = random.Next(1, limiteMaximo);

                    respostaCorreta = A + B;

                    // Exibe o enunciado da pergunta 2
                    lblCaixaDialogo.Text = "Uma fachada possui " + A + " janelas e outra possui " + B + " janelas. Quantas janelas existem nas duas fachadas?";
                }
                else if (perguntaAtual == 3)
                {
                    limiteMaximo = 81;
                    A = random.Next(1, 41);
                    B = random.Next(1, 41);

                    AlternativaErrada1 = random.Next(1, limiteMaximo);
                    AlternativaErrada2 = random.Next(1, limiteMaximo);

                    respostaCorreta = A + B;

                    // Exibe o enunciado da pergunta 3
                    lblCaixaDialogo.Text = "Duas vigas de madeira medem " + A + " metros e " + B + " metros. Se forem colocadas uma após a outra, qual será o comprimento total?";
                }
                else if (perguntaAtual == 4)
                {
                    limiteMaximo = 181;
                    A = random.Next(1, 61);
                    B = random.Next(1, 61);
                    C = random.Next(1, 62);

                    AlternativaErrada1 = random.Next(1, limiteMaximo);
                    AlternativaErrada2 = random.Next(1, limiteMaximo);

                    respostaCorreta = A + B + C;

                    // Exibe o enunciado da pergunta 4
                    lblCaixaDialogo.Text = "Uma maquete terá " + A + " árvores, " + B + " bancos e " + C + " postes. Quantos elementos serão colocados no total?";
                }
                else if (perguntaAtual == 5)
                {
                    limiteMaximo = 241;
                    A = random.Next(1, 81);
                    B = random.Next(1, 81);
                    C = random.Next(1, 81);

                    AlternativaErrada1 = random.Next(1, limiteMaximo);
                    AlternativaErrada2 = random.Next(1, limiteMaximo);

                    respostaCorreta = A + B + C;

                    // Exibe o enunciado da pergunta 5
                    lblCaixaDialogo.Text = "O Gato recebeu " + A + " azulejos verdes, " + B + " azulejos amarelos e " + C + " azulejos azuis. Quantos azulejos ele recebeu?";
                }

                // Verifica as alternativas erradas
                while (AlternativaErrada1 == respostaCorreta)
                {
                    AlternativaErrada1 = random.Next(1, limiteMaximo);
                }

                while (AlternativaErrada2 == respostaCorreta || AlternativaErrada2 == AlternativaErrada1)
                {
                    AlternativaErrada2 = random.Next(1, limiteMaximo);
                }

                OrdenarAlternativas();
            }
        }
        #endregion

        #region Verificar Resposta
        int respostaEscolhida;
        private async Task verificarResposta(object sender)
        {
            if (principal.BatalhaAtual == 1)
            {
                if (sender is Label label)
                {
                    respostaEscolhida = int.Parse(label.Text);

                    if (respostaEscolhida == respostaCorreta)
                    {
                        await RespostaCorreta();
                    }
                    else
                    {
                        await RespostaErrada();
                    }
                }
            }
        }
        #endregion

        #region Resposta Correta
        private async Task RespostaCorreta()
        {
            panelCaixaPerguntas.Visible = false;
            panelAlternativas.Visible = false;
            await Ataque();
            perguntaAtual++;
            panelCaixaPerguntas.Visible = true;
            panelAlternativas.Visible = true;
            await Perguntas();
        }
        #endregion

        #region Resposta Errada
        private async Task RespostaErrada()
        {
            panelCaixaPerguntas.Visible = false;
            panelAlternativas.Visible = false;
            await AtaqueInimigo();
            perguntaAtual++;
            panelCaixaPerguntas.Visible = true;
            panelAlternativas.Visible = true;
            await Perguntas();
        }
        #endregion

        #region Ordem das Alternativas
        private int AlternativaCerta;

        private void OrdenarAlternativas()
        {
            AlternativaCerta = random.Next(1,4);

            // Distribui as respostas
            if (AlternativaCerta == 1)
            {
                lblAlternativaA.Text = respostaCorreta.ToString();
                lblAlternativaB.Text = AlternativaErrada1.ToString();
                lblAlternativaC.Text = AlternativaErrada2.ToString();

            }
            else if (AlternativaCerta == 2)
            {
                lblAlternativaA.Text = AlternativaErrada1.ToString();
                lblAlternativaB.Text = respostaCorreta.ToString();
                lblAlternativaC.Text = AlternativaErrada2.ToString();
            }
            else
            {
                lblAlternativaA.Text = AlternativaErrada1.ToString();
                lblAlternativaB.Text = AlternativaErrada2.ToString();
                lblAlternativaC.Text = respostaCorreta.ToString();
            }
        }
        #endregion

        #region Animação de Ataque
        private bool indoParaDireita;
        private bool indoParaEsquerda;

        private async Task Ataque()
        {
            if (principal.BatalhaAtual == 1)
            {
                indoParaDireita = true;
                timerAtaque.Start();

                while (timerAtaque.Enabled)
                {
                    await Task.Delay(15);
                }

                koalaBoy.Size = new Size(325, 335);

                if (koalahp == 3)
                {   

                    koalaBoy.Image = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "KoalaBoy", "KoalaBoyAtacando.gif"));
                }
                else
                {
                    koalaBoy.Image = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "KoalaBoy", "KoalaBoyAtacandoFerido.gif"));
                }
                await Task.Delay(850);
                gato.Image = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "ArqUrb", "GatoRecebendoDano.png"));
                pbEfeitoDanoKoala.Visible = true;
                await Task.Delay(1000);
                pbEfeitoDanoKoala.Visible = false;

                await Task.Delay(400);

                gatohp--;
                pbGatoHp.Image = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "ArqUrb", "gato_" + gatohp + "hp.png"));

                koalaBoy.Size = new Size(220, 335);
                koalaBoy.Image = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "KoalaBoy", "KoalaBoy" + koalahp + ".png"));
                gato.Image = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "ArqUrb", "Gato" + gatohp + ".png"));

                indoParaDireita = false;
                timerAtaque.Start();

                while (timerAtaque.Enabled)
                {
                    await Task.Delay(15);
                }

                await Task.Delay(500);
            }
        }

        private async Task AtaqueInimigo()
        {
            if (principal.BatalhaAtual == 1)
            {
                indoParaEsquerda = true;
                timerAtaque.Start();

                while (timerAtaque.Enabled)
                {
                    await Task.Delay(15);
                }

                gato.Size = new Size(350, 335);

                if (gatohp == 3)
                {
                    gato.Image = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "ArqUrb", "GatoAtacando.gif"));
                }
                else
                {
                    gato.Image = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "ArqUrb", "GatoAtacandoFerido.gif"));
                }
                await Task.Delay(850);
                koalaBoy.Image = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "KoalaBoy", "KoalaBoyRecebendoDano.png"));
                pbEfeitoDanoInimigo.Visible = true;
                await Task.Delay(1000);
                pbEfeitoDanoInimigo.Visible = false;

                await Task.Delay(400);

                koalahp--;
                pbKoalaHp.Image = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "KoalaBoy", "koala_" + koalahp + "hp.png"));

                gato.Size = new Size(255, 335);
                koalaBoy.Image = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "KoalaBoy", "KoalaBoy" + koalahp + ".png"));
                gato.Image = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "ArqUrb", "Gato" + gatohp + ".png"));

                indoParaEsquerda = false;
                timerAtaque.Start();

                while (timerAtaque.Enabled)
                {
                    await Task.Delay(15);
                }

                await Task.Delay(500);
            }
        }

        
        private void timerAtaque_Tick(object sender, EventArgs e)
        {
            if (principal.BatalhaAtual == 1)
            {
                if (indoParaDireita == true && respostaEscolhida == respostaCorreta)
                {
                    koalaBoy.Left += 25;

                    if (koalaBoy.Left >= 580)
                    {
                        koalaBoy.Left = 580;
                        timerAtaque.Stop();
                    }
                }
                else if (indoParaDireita == false && respostaEscolhida == respostaCorreta)
                {
                    koalaBoy.Left -= 25;

                    if (koalaBoy.Left <= 120)
                    {
                        koalaBoy.Left = 120;
                        timerAtaque.Stop();
                    }
                }
                else if (indoParaEsquerda == true && respostaEscolhida != respostaCorreta)
                {
                    gato.Left -= 25;

                    if (gato.Left <= 340)
                    {
                        gato.Left = 340;
                        timerAtaque.Stop();
                    }
                }
                else if (indoParaEsquerda == false && respostaEscolhida != respostaCorreta)
                {
                    gato.Left += 25;

                    if (gato.Left >= 905)
                    {
                        gato.Left = 905;
                        timerAtaque.Stop();
                    }
                }
            }
        }
        #endregion

        #region Animação Botão Alternativa

        // Alternativa A
        private int larguraAlvoA = 140;
        private int alturaAlvoA = 120;

        // Alternativa B
        private int larguraAlvoB = 140;
        private int alturaAlvoB = 120;

        // Alternativa C
        private int larguraAlvoC = 140;
        private int alturaAlvoC = 120;

        bool mouseEmCimaAlternativas;

        // MOUSE ENTER
        private void AnimarBotao_MouseEnter(object sender, EventArgs e)
        {
            mouseEmCimaAlternativas = true;

            if (sender == panelAlternativaA || sender == lblAlternativaA)
            {
                larguraAlvoA = 156;
                alturaAlvoA = 136;
            }
            else if (sender == panelAlternativaB || sender == lblAlternativaB)
            {
                larguraAlvoB = 156;
                alturaAlvoB = 136;
            }
            else if (sender == panelAlternativaC || sender == lblAlternativaC)
            {
                larguraAlvoC = 156;
                alturaAlvoC = 136;
            }

            timerBotaoAlternativas.Start();
        }

        // MOUSE LEAVE
        private void AnimarBotao_MouseLeave(object sender, EventArgs e)
        {
            mouseEmCimaAlternativas = false;

            if (sender == panelAlternativaA || sender == lblAlternativaA)
            {
                larguraAlvoA = 140;
                alturaAlvoA = 120;
            }
            else if (sender == panelAlternativaB || sender == lblAlternativaB)
            {
                larguraAlvoB = 140;
                alturaAlvoB = 120;
            }
            else if (sender == panelAlternativaC || sender == lblAlternativaC)
            {
                larguraAlvoC = 140;
                alturaAlvoC = 120;
            }

            timerBotaoAlternativas.Start();
        }

        // MOUSE DOWN
        private void AnimarBotao_MouseDown(object sender, MouseEventArgs e)
        {
            if (sender == panelAlternativaA || sender == lblAlternativaA)
            {
                larguraAlvoA = 132;
                alturaAlvoA = 112;
            }
            else if (sender == panelAlternativaB || sender == lblAlternativaB)
            {
                larguraAlvoB = 132;
                alturaAlvoB = 112;
            }
            else if (sender == panelAlternativaC || sender == lblAlternativaC)
            {
                larguraAlvoC = 132;
                alturaAlvoC = 112;
            }

            timerBotaoAlternativas.Start();
        }

        // MOUSE UP
        private void AnimarBotao_MouseUp(object sender, MouseEventArgs e)
        {
            if (mouseEmCimaAlternativas == true)
            {
                if (sender == panelAlternativaA || sender == lblAlternativaA)
                {
                    larguraAlvoA = 156;
                    alturaAlvoA = 136;
                }
                else if (sender == panelAlternativaB || sender == lblAlternativaB)
                {
                    larguraAlvoB = 156;
                    alturaAlvoB = 136;
                }
                else if (sender == panelAlternativaC || sender == lblAlternativaC)
                {
                    larguraAlvoC = 156;
                    alturaAlvoC = 136;
                }
            }
            else
            {
                if (sender == panelAlternativaA || sender == lblAlternativaA)
                {
                    larguraAlvoA = 140;
                    alturaAlvoA = 120;
                }
                else if (sender == panelAlternativaB || sender == lblAlternativaB)
                {
                    larguraAlvoB = 140;
                    alturaAlvoB = 120;
                }
                else if (sender == panelAlternativaC || sender == lblAlternativaC)
                {
                    larguraAlvoC = 140;
                    alturaAlvoC = 120;
                }
            }

            timerBotaoAlternativas.Start();
        }

        // TIMER
        private void timerBotaoAlternativas_Tick(object sender, EventArgs e)
        {
            // ALTERNATIVA A

            // Largura
            if (panelAlternativaA.Width < larguraAlvoA)
            {
                panelAlternativaA.Width += 4;
                panelAlternativaA.Left -= 2;
            }
            else if (panelAlternativaA.Width > larguraAlvoA)
            {
                panelAlternativaA.Width -= 4;
                panelAlternativaA.Left += 2;
            }

            // Altura
            if (panelAlternativaA.Height < alturaAlvoA)
            {
                panelAlternativaA.Height += 4;
                panelAlternativaA.Top -= 2;
            }
            else if (panelAlternativaA.Height > alturaAlvoA)
            {
                panelAlternativaA.Height -= 4;
                panelAlternativaA.Top += 2;
            }

            // ALTERNATIVA B

            // Largura
            if (panelAlternativaB.Width < larguraAlvoB)
            {
                panelAlternativaB.Width += 4;
                panelAlternativaB.Left -= 2;
            }
            else if (panelAlternativaB.Width > larguraAlvoB)
            {
                panelAlternativaB.Width -= 4;
                panelAlternativaB.Left += 2;
            }

            // Altura
            if (panelAlternativaB.Height < alturaAlvoB)
            {
                panelAlternativaB.Height += 4;
                panelAlternativaB.Top -= 2;
            }
            else if (panelAlternativaB.Height > alturaAlvoB)
            {
                panelAlternativaB.Height -= 4;
                panelAlternativaB.Top += 2;
            }

            // ALTERNATIVA C

            // Largura
            if (panelAlternativaC.Width < larguraAlvoC)
            {
                panelAlternativaC.Width += 4;
                panelAlternativaC.Left -= 2;
            }
            else if (panelAlternativaC.Width > larguraAlvoC)
            {
                panelAlternativaC.Width -= 4;
                panelAlternativaC.Left += 2;
            }

            // Altura
            if (panelAlternativaC.Height < alturaAlvoC)
            {
                panelAlternativaC.Height += 4;
                panelAlternativaC.Top -= 2;
            }
            else if (panelAlternativaC.Height > alturaAlvoC)
            {
                panelAlternativaC.Height -= 4;
                panelAlternativaC.Top += 2;
            }

            if (panelAlternativaA.Width == larguraAlvoA &&
                panelAlternativaA.Height == alturaAlvoA &&
                panelAlternativaB.Width == larguraAlvoB &&
                panelAlternativaB.Height == alturaAlvoB &&
                panelAlternativaC.Width == larguraAlvoC &&
                panelAlternativaC.Height == alturaAlvoC)
            {
                timerBotaoAlternativas.Stop();
            }
        }

        #endregion

        #region Cria e configura os Efeitos de Dano
        private PictureBox pbEfeitoDanoInimigo;
        private PictureBox pbEfeitoDanoKoala;
        private void ConfigurarEfeitoDano()
        {
            pbEfeitoDanoInimigo = new PictureBox();

            pbEfeitoDanoInimigo.Parent = koalaBoy;
            pbEfeitoDanoInimigo.Location = new Point(12,90);
            pbEfeitoDanoInimigo.Size = new Size(208, 186);
            pbEfeitoDanoInimigo.BackColor = Color.Transparent;
            pbEfeitoDanoInimigo.SizeMode = PictureBoxSizeMode.StretchImage;
            pbEfeitoDanoInimigo.Visible = false;
            pbEfeitoDanoInimigo.Image = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "TelaBatalha", "EfeitoDano.gif"));

            pbEfeitoDanoKoala = new PictureBox();

            pbEfeitoDanoKoala.Parent = gato;
            pbEfeitoDanoKoala.Location = new Point(50, 90);
            pbEfeitoDanoKoala.Size = new Size(208, 186);
            pbEfeitoDanoKoala.BackColor = Color.Transparent;
            pbEfeitoDanoKoala.SizeMode = PictureBoxSizeMode.StretchImage;
            pbEfeitoDanoKoala.Visible = false;
            pbEfeitoDanoKoala.Image = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "TelaBatalha", "EfeitoDano.gif"));

        }
        #endregion
        private async void Alternativa_Click(object sender, EventArgs e)
        {
            await verificarResposta(sender);
        }

        
    }
}
