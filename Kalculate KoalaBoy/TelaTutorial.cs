using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalculate_KoalaBoy
{
    public partial class TelaTutorial : UserControl
    {
        private TelaPrincipal principal;

        public TelaTutorial(TelaPrincipal telaPrincipal)
        {
            InitializeComponent();
            principal = telaPrincipal;
            FontesJogo.AplicarFonte(this);

            ConfigurarAnimacaoSeta(pbIrPontuacao);
            ConfigurarAnimacaoSeta(pbVoltarTutorial);
            ConfigurarAnimacaoSeta(pbFechar);
        }
        private int tamanhoAlvoFechar = 40;
        private bool mouseEmCimaFechar = false;

        // MOUSE ENTER
        private void pbFechar_MouseEnter(object sender, EventArgs e)
        {
            mouseEmCimaFechar = true;
            tamanhoAlvoFechar = 48;

            timerBotaoFechar.Start();
        }

        // MOUSE LEAVE
        private void pbFechar_MouseLeave(object sender, EventArgs e)
        {
            mouseEmCimaFechar = false;
            tamanhoAlvoFechar = 40;

            timerBotaoFechar.Start();
        }

        // MOUSE DOWN
        private void pbFechar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;

            tamanhoAlvoFechar = 32;

            timerBotaoFechar.Start();
        }

        // MOUSE UP
        private void pbFechar_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;

            tamanhoAlvoFechar = mouseEmCimaFechar ? 48 : 40;

            timerBotaoFechar.Start();
        }

        // TIMER
        private void timerBotaoFechar_Tick(object sender, EventArgs e)
        {
            int larguraAnterior = pbFechar.Width;
            int alturaAnterior = pbFechar.Height;

            if (pbFechar.Width < tamanhoAlvoFechar)
            {
                pbFechar.Width =
                    Math.Min(pbFechar.Width + 2, tamanhoAlvoFechar);
            }
            else if (pbFechar.Width > tamanhoAlvoFechar)
            {
                pbFechar.Width =
                    Math.Max(pbFechar.Width - 2, tamanhoAlvoFechar);
            }

            pbFechar.Height = pbFechar.Width;

            // Mantém o centro do botão
            pbFechar.Left -= (pbFechar.Width - larguraAnterior) / 2;
            pbFechar.Top -= (pbFechar.Height - alturaAnterior) / 2;

            if (pbFechar.Width == tamanhoAlvoFechar)
            {
                timerBotaoFechar.Stop();
            }
        }
        private void pbFecharTutorial_Click(object sender, EventArgs e)
        {
            timerBotaoFechar.Stop();

            pbFechar.Left += (pbFechar.Width - 40) / 2;
            pbFechar.Top += (pbFechar.Height - 40) / 2;
            pbFechar.Size = new Size(40, 40);

            mouseEmCimaFechar = false;
            tamanhoAlvoFechar = 40;

            this.Hide();

        }

        public void MostrarTutorial()
        {
            pbConteudo.Image = Properties.Resources.Tutorial;


            pbIrPontuacao.Visible = true;
            pbVoltarTutorial.Visible = false;
            pbIrPontuacao.Show();
            pbVoltarTutorial.Hide();
        }

        private void pbIrPontuacao_Click(object sender, EventArgs e)
        {
            pbConteudo.Image = Properties.Resources.Pontuacao;

            pbIrPontuacao.Hide();
            pbVoltarTutorial.Show();
        }

        private void pbVoltarTutorial_Click(object sender, EventArgs e)
        {
            MostrarTutorial();
        }

        private void ConfigurarAnimacaoSeta(PictureBox seta)
        {
            const int escalaNormal = 84;
            const int escalaDestaque = 100;
            const int escalaPressionada = 68;

            int escalaAtual = escalaNormal;
            int escalaAlvo = escalaNormal;
            var timer = new System.Windows.Forms.Timer { Interval = 15 };

            void AtualizarImagem()
            {
                var imagem = seta.Image;
                int largura = seta.ClientSize.Width;
                int altura = seta.ClientSize.Height;

                if (imagem == null || largura == 0 || altura == 0)
                    return;

                // Redimensiona mantendo a proporção do PNG.
                double fator = Math.Min((double)largura / imagem.Width,
                                        (double)altura / imagem.Height) * escalaAtual / 100.0;

                int sobraX = largura - Math.Max(1, (int)Math.Round(imagem.Width * fator));
                int sobraY = altura - Math.Max(1, (int)Math.Round(imagem.Height * fator));

                // Divide o espaço que sobrou para centralizar a imagem.
                seta.Padding = new Padding(
                    sobraX / 2, sobraY / 2,
                    (sobraX + 1) / 2, (sobraY + 1) / 2);

                seta.Invalidate();
            }

            void AnimarPara(int alvo)
            {
                if (!seta.Visible)
                    return;

                escalaAlvo = alvo;
                timer.Start();
            }

            seta.SizeMode = PictureBoxSizeMode.StretchImage;

            timer.Tick += (s, e) =>
            {
                int diferenca = escalaAlvo - escalaAtual;
                escalaAtual += Math.Sign(diferenca) * Math.Min(4, Math.Abs(diferenca));

                AtualizarImagem();

                if (escalaAtual == escalaAlvo)
                    timer.Stop();
            };

            seta.MouseEnter += (s, e) => AnimarPara(escalaDestaque);
            seta.MouseLeave += (s, e) => AnimarPara(escalaNormal);

            seta.MouseDown += (s, e) =>
            {
                if (e.Button == MouseButtons.Left)
                    AnimarPara(escalaPressionada);
            };

            seta.MouseUp += (s, e) =>
            {
                if (e.Button == MouseButtons.Left)
                {
                    bool mouseEmCima = seta.ClientRectangle.Contains(e.Location);
                    AnimarPara(mouseEmCima ? escalaDestaque : escalaNormal);
                }
            };

            seta.VisibleChanged += (s, e) =>
            {
                if (!seta.Visible)
                {
                    timer.Stop();
                    escalaAtual = escalaNormal;
                    escalaAlvo = escalaNormal;
                    AtualizarImagem();
                }
            };

            seta.SizeChanged += (s, e) => AtualizarImagem();
            seta.Disposed += (s, e) => timer.Dispose();

            AtualizarImagem();
        }
    }
}
