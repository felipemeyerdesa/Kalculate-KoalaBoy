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
    public partial class TelaHistoria : UserControl
    {
        private TelaPrincipal principal;

        public TelaHistoria(TelaPrincipal telaPrincipal)
        {
            InitializeComponent();
            principal = telaPrincipal;
            FontesJogo.AplicarFonte(this);
            ConfigurarLendaFragmento();
        }

        private async void TelaHistoria_Load(object sender, EventArgs e)
        {
            pbUrubu.Size = new Size(220, 386);
            await Task.Delay(2000);
            timerAnimacao.Start();
        }

        #region Animação Urubu e KoalaBoy
        bool pausaUrubuFeita = false;
        bool sairBiblioteca = false;
        private async void timerAnimacao_Tick(object sender, EventArgs e)
        {

            pbUrubu.Left += 25;

            if (pbUrubu.Left >= 310 && pausaUrubuFeita == false && sairBiblioteca == false)
            {
                
                pausaUrubuFeita = true;
                timerAnimacao.Stop();
                await Task.Delay(2850);
                pbUrubu.Size = new Size(220, 335);
                pbUrubu.Location = new Point(310, 256);
                pbUrubu.Image = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "TelaHistoria", "UrubuFrameFinal.png"));
                timerAnimacao.Start();
            }
            else if (pbUrubu.Left >= 630 && pausaUrubuFeita == true && sairBiblioteca == false)
            {
                pbUrubu.Left = 630;
                timerAnimacao.Stop();
                pbKoalaBoy.Size = new Size(238, 378);
                pbKoalaBoy.Location = new Point(846, 213);
                pbKoalaBoy.Image = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "TelaHistoria", "KoalaBoyVirando.gif"));
                await Task.Delay(1650);
                pbKoalaBoy.Size = new Size(220, 335);
                pbKoalaBoy.Location = new Point(864, 256);
                pbKoalaBoy.Image = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "TelaHistoria", "KoalaBoyFrameFinal.png"));
                mostrarLendaFragmento = true;
                principal.MostrarTelaBatalhaDialogo();
                await Task.Delay(2100);
                principal.telaDialogo.MostrarBotaoSkipHistoria();


            }
            else if (pbUrubu.Left >= 1280 && sairBiblioteca == true)
            {
                pbUrubu.Visible = false;
                timerAnimacao.Stop();
                await Task.Delay(1000);
                principal.MostrarTelaBatalhaDialogo();

            }
        }

        #endregion

        #region Cria LendaFragmento e BotãoFecharLenda
        bool mostrarLendaFragmento = false;
        private PictureBox pbLendaFragmento;
        private PictureBox pbBotaoFecharLenda;
        private void ConfigurarLendaFragmento()
        {
            pbLendaFragmento = new PictureBox();

            pbLendaFragmento.Parent = this;
            pbLendaFragmento.Size = new Size(770, 602);
            pbLendaFragmento.Location = new Point(255, 45);
            pbLendaFragmento.BackColor = Color.Transparent;
            pbLendaFragmento.SizeMode = PictureBoxSizeMode.Zoom;
            pbLendaFragmento.Visible = false;
            pbLendaFragmento.Image = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "TelaHistoria", "LendaFragmento.png"));

            pbBotaoFecharLenda = new PictureBox();

            pbBotaoFecharLenda.Parent = pbLendaFragmento;
            pbBotaoFecharLenda.Size = new Size(50, 45);
            pbBotaoFecharLenda.Location = new Point(655, 35);
            pbBotaoFecharLenda.BackColor = Color.Transparent;
            pbBotaoFecharLenda.SizeMode = PictureBoxSizeMode.Zoom;
            pbBotaoFecharLenda.Cursor = Cursors.Hand;
            pbBotaoFecharLenda.Click += pbBotaoFecharLenda_Click;
            pbBotaoFecharLenda.MouseEnter += pbBotaoFecharLenda_MouseEnter;
            pbBotaoFecharLenda.MouseLeave += pbBotaoFecharLenda_MouseLeave;
            pbBotaoFecharLenda.MouseDown += pbBotaoFecharLenda_MouseDown;
            pbBotaoFecharLenda.MouseUp += pbBotaoFecharLenda_MouseUp;
            pbBotaoFecharLenda.Visible = false;
            pbBotaoFecharLenda.Image = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "TelaHistoria", "BotãoFechar.png"));
        }
        #endregion

        #region Botão Fechar Lenda
        private void pbBotaoFecharLenda_Click(object sender, EventArgs e)
        {
            pbLendaFragmento.Visible = false;
            principal.MostrarTelaBatalhaDialogo();
        }
        #endregion

        #region AnimaçãoBotãoFecharLenda
        private int larguraAlvoFecharLenda = 50;
        private int alturaAlvoFecharLenda = 45;
        private bool mouseEmCimaFecharLenda = false;

        // MOUSE ENTER
        private void pbBotaoFecharLenda_MouseEnter(object sender, EventArgs e)
        {
            mouseEmCimaFecharLenda = true;

            larguraAlvoFecharLenda = 56;
            alturaAlvoFecharLenda = 51;

            timerBotaoFechar.Start();
        }

        // MOUSE LEAVE
        private void pbBotaoFecharLenda_MouseLeave(object sender, EventArgs e)
        {
            mouseEmCimaFecharLenda = false;

            larguraAlvoFecharLenda = 50;
            alturaAlvoFecharLenda = 45;

            timerBotaoFechar.Start();
        }

        // MOUSE DOWN
        private void pbBotaoFecharLenda_MouseDown(object sender, MouseEventArgs e)
        {
            larguraAlvoFecharLenda = 46;
            alturaAlvoFecharLenda = 41;

            timerBotaoFechar.Start();
        }

        // MOUSE UP
        private void pbBotaoFecharLenda_MouseUp(object sender, MouseEventArgs e)
        {
            if (mouseEmCimaFecharLenda)
            {
                larguraAlvoFecharLenda = 56;
                alturaAlvoFecharLenda = 51;
            }
            else
            {
                larguraAlvoFecharLenda = 50;
                alturaAlvoFecharLenda = 45;
            }

            timerBotaoFechar.Start();
        }

        // TIMER
        private void timerBotaoFechar_Tick(object sender, EventArgs e)
        {
            // LARGURA
            if (pbBotaoFecharLenda.Width < larguraAlvoFecharLenda)
            {
                pbBotaoFecharLenda.Width += 2;
                pbBotaoFecharLenda.Left -= 1;
            }
            else if (pbBotaoFecharLenda.Width > larguraAlvoFecharLenda)
            {
                pbBotaoFecharLenda.Width -= 2;
                pbBotaoFecharLenda.Left += 1;
            }

            // ALTURA
            if (pbBotaoFecharLenda.Height < alturaAlvoFecharLenda)
            {
                pbBotaoFecharLenda.Height += 2;
                pbBotaoFecharLenda.Top -= 1;
            }
            else if (pbBotaoFecharLenda.Height > alturaAlvoFecharLenda)
            {
                pbBotaoFecharLenda.Height -= 2;
                pbBotaoFecharLenda.Top += 1;
            }

            if (pbBotaoFecharLenda.Width == larguraAlvoFecharLenda &&
                pbBotaoFecharLenda.Height == alturaAlvoFecharLenda)
            {
                timerBotaoFechar.Stop();
            }
        }

        #endregion

        #region Configura o Cenario
        public async void ConfigurarCenario()
        {
            if (principal.BatalhaAtual == 7 && principal.telaDialogo.dialogoAtual == 11)
            {
                pbKoalaBoy.Location = new Point(346, 256);
                pbUrubu.Size = new Size(338, 342);
                pbUrubu.Location = new Point(566, 249);
                pbKoalaBoy.Image = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "KoalaBoy", "KoalaBoyDefendendo.png"));
                pbUrubu.Image = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "Engenharia", "UrubuAtacandoTraição.gif"));

                await Task.Delay(2000);
                principal.MostrarTelaBatalhaDialogo();
            }
            else if (principal.BatalhaAtual == 7 && principal.telaDialogo.dialogoAtual == 34)
            {
                await Task.Delay(1000);
                sairBiblioteca = true;
                timerAnimacao.Start();
            }
        }
        #endregion

        private async void TelaHistoria_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible && mostrarLendaFragmento == true && principal.BatalhaAtual == 0)
            {
                pbKoalaBoy.Visible = false;
                pbUrubu.Visible = false;
                pbLendaFragmento.Visible = true;
                pbBotaoFecharLenda.Visible = true;
            }
            if (this.Visible  && principal.BatalhaAtual == 7)
            {
                pbKoalaBoy.Image = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "KoalaBoy", "KoalaBoy2.png"));
                pbKoalaBoy.Location = new Point(346, 256);
                pbUrubu.Image = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "Engenharia", "UrubuFragmentos.png"));

            }
        }

       
    }
}