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
    public partial class TelaBatalhaDialogo : UserControl
    {
        private TelaPrincipal principal;

        public TelaBatalhaDialogo()
        {
            InitializeComponent();

            FontesJogo.AplicarFonte(this);
        }

        private async void TelaBatalha_Load(object sender, EventArgs e)
        {
            await Task.Delay(2100);

            principal = (TelaPrincipal)this.FindForm();

            koalaBoy.Visible = false;
            gato.Visible = false;
            Dialogo();
            panelDialogo.Visible = true;
        }

        #region Dialogos
        private int dialogoAtual = 1;

        private void Dialogo()
        {   
            if (principal.BatalhaAtual == 1)
            {
                this.BackgroundImage = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "ArqUrb", "ArqUrb Desfocado.png"));

                if (dialogoAtual == 1)
                {
                    pbPersonagem.Image = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "KoalaBoy", "KoalaBoyFalando.png"));
                    panelBoxDialogo.BackgroundImage = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "TelaBatalha", "BoxKoalaBoy.png"));
                    lblDialogo.Text = "Vim aqui para capturar o seu fragmento ESPECIAL, seu Bafo de Leite!";
                }
                else if (dialogoAtual == 2)
                {
                    pbPersonagem.Image = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "KoalaBoy", "KoalaBoyFalando.png"));
                    panelBoxDialogo.BackgroundImage = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "TelaBatalha", "BoxKoalaBoy.png"));
                    lblDialogo.Text = "Vamos batalhar aqui e agora!";
                }
                else if (dialogoAtual == 3)
                {
                    pbPersonagem.Image = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "ArqUrb", "GatoFalando.png"));
                    panelBoxDialogo.BackgroundImage = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "TelaBatalha", "BoxGato.png"));
                    lblDialogo.Text = "Tenho um projeto de arranhador atrasado por sua culpa, vamos acabar com isso de uma vez - Miau!";
                }
                else if (dialogoAtual == 4)
                {
                    pbPersonagem.Image = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "Urubu", "UrubuFalando.png"));
                    panelBoxDialogo.BackgroundImage = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "TelaBatalha", "BoxUrubu.png"));
                    lblDialogo.Text = "Fique esperto com o operador matemático dele, KoalaBoy. Ele utiliza a SOMA em suas batalhas";
                }
                //KoalaBoy Venceu
                else if (dialogoAtual == 5)
                {
                    pbPersonagem.Image = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "KoalaBoy", "KoalaBoyFalando.png"));
                    panelBoxDialogo.BackgroundImage = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "TelaBatalha", "BoxKoalaBoy.png"));
                    lblDialogo.Text = "Eu venci, seu fragmento agora é meu. Volte para o lixão de onde você veio";
                }
                else if (dialogoAtual == 6)
                {
                    pbPersonagem.Image = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "ArqUrb", "GatoFalandoDerrotado.png"));
                    panelBoxDialogo.BackgroundImage = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "TelaBatalha", "BoxGatoDerrotado.png"));
                    lblDialogo.Text = "Isso não ficará assim, ainda tenho mais 4 vidas, voltarei para me vingar - Miau!";
                }
                //KoalaBoy Perdeu
                else if (dialogoAtual == 7)
                {
                    pbPersonagem.Image = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "ArqUrb", "GatoFalando.png"));
                    panelBoxDialogo.BackgroundImage = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "TelaBatalha", "BoxGato.png"));
                    lblDialogo.Text = "Você não é páreo para me derrotar. Tente novamente seu Koala mané - Miau!";
                }
                else if (dialogoAtual == 8)
                {
                    pbPersonagem.Image = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "KoalaBoy", "KoalaBoyDerrotado.png"));
                    panelBoxDialogo.BackgroundImage = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "TelaBatalha", "BoxKoalaBoyDerrotado.png"));
                    lblDialogo.Text = "Eu voltarei e me vingarei de você!";
                }
            }
            
        }
        #endregion

        #region Batalha Encerrada
        public async Task EncerrarBatalha (int vencedor)
        {
            if (principal.BatalhaAtual == 1)
            {
                // Koala venceu
                if (vencedor == 1)
                {
                    dialogoAtual = 5;
                    Dialogo();
                }

                // Gato venceu
                else if (vencedor == 2)
                {
                    dialogoAtual = 7;
                    Dialogo();
                }
            }
        }
        #endregion

        #region Iniciar Batalha
        private async Task IniciarBatalha()
        {
            panelDialogo.Visible = false;
            koalaBoy.Visible = true;
            gato.Visible = true;
            pb321Battle.Visible = true;

            this.BackgroundImage = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "ArqUrb", "ArqUrb.png"));
            pb321Battle.Image = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "TelaBatalha", "3.png"));
            await Task.Delay(1000);
            pb321Battle.Image = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "TelaBatalha", "2.png"));
            await Task.Delay(1000);
            pb321Battle.Image = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "TelaBatalha", "1.png"));
            await Task.Delay(1000);
            pb321Battle.Image = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "TelaBatalha", "Battle.png"));
            await Task.Delay(1000);
            pb321Battle.Visible = false;


            principal.MostrarTelaBatalhaPerguntas();
        }
        #endregion

        #region AnimaçãoBotãoSkip
        private int larguraAlvoSkip = 59;
        private int alturaAlvoSkip = 62;
        private bool mouseEmCimaSkip = false;

        // MOUSE ENTER
        private void pbBotaoStart_MouseEnter(object sender, EventArgs e)
        {
            mouseEmCimaSkip = true;

            larguraAlvoSkip = 65;
            alturaAlvoSkip = 68;

            timerBotaoSkip.Start();
        }

        // MOUSE LEAVE
        private void pbBotaoStart_MouseLeave(object sender, EventArgs e)
        {
            mouseEmCimaSkip = false;

            larguraAlvoSkip = 59;
            alturaAlvoSkip = 62;

            timerBotaoSkip.Start();
        }

        // MOUSE DOWN
        private void pbBotaoStart_MouseDown(object sender, MouseEventArgs e)
        {
            larguraAlvoSkip = 55;
            alturaAlvoSkip = 58;

            timerBotaoSkip.Start();
        }

        // MOUSE UP
        private void pbBotaoStart_MouseUp(object sender, MouseEventArgs e)
        {
            if (mouseEmCimaSkip == true)
            {
                larguraAlvoSkip = 65;
                alturaAlvoSkip = 68;
            }
            else
            {
                larguraAlvoSkip = 59;
                alturaAlvoSkip = 62;
            }

            timerBotaoSkip.Start();
        }

        // TIMER
        private void timerBotaoSkip_Tick(object sender, EventArgs e)
        {
            //largura

            if (pbBotaoSkip.Width < larguraAlvoSkip)
            {
                pbBotaoSkip.Width += 2;
                pbBotaoSkip.Left -= 1;
            }
            else if (pbBotaoSkip.Width > larguraAlvoSkip)
            {
                pbBotaoSkip.Width -= 2;
                pbBotaoSkip.Left += 1;
            }

            //altura

            if (pbBotaoSkip.Height < alturaAlvoSkip)
            {
                pbBotaoSkip.Height += 2;
                pbBotaoSkip.Top -= 1;
            }
            else if (pbBotaoSkip.Height > alturaAlvoSkip)
            {
                pbBotaoSkip.Height -= 2;
                pbBotaoSkip.Top += 1;
            }

            if (pbBotaoSkip.Width == larguraAlvoSkip && pbBotaoSkip.Height == alturaAlvoSkip)
            {
                timerBotaoSkip.Stop();
            }
        }

        #endregion

        #region Botão Skip
        private async void pbBotaoSkip_Click(object sender, EventArgs e)
        {
            dialogoAtual++;
            if (dialogoAtual == 5)
            {
                await IniciarBatalha();
                return;
            }
            Dialogo();
        }
        #endregion

        private async void TelaBatalhaDialogo_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                koalaBoy.Visible = false;
                gato.Visible = false;
                Dialogo();
                panelDialogo.Visible = true;
            }
        }
    }
}
