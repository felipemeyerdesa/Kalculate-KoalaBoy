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
    public partial class TelaBatalha : UserControl
    {
        public TelaBatalha()
        {
            InitializeComponent();

            FontesJogo.AplicarEmLabels(this);
        }

        private async void TelaBatalha_Load(object sender, EventArgs e)
        {
            await Task.Delay(2100);

            koalaBoy.Visible = false;
            gato.Visible = false;
            koalaHp.Visible = false;
            gatoHp.Visible = false;
            await Dialogo();
            panelDialogo.Visible = true;
        }

        #region Dialogos
        private int dialogoAtual = 1;

        private async Task Dialogo()
        {
            if (dialogoAtual == 1)
            {
                this.BackgroundImage  = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "ArqUrb", "ArqUrb Desfocado.png"));
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
            else
            {
                this.BackgroundImage = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "ArqUrb", "ArqUrb.png"));
                await IniciarBatalha();
            }
        }
        #endregion

        #region Inicia Batalha
        private async Task IniciarBatalha()
        {
            panelDialogo.Visible = false;
            koalaBoy.Visible = true;
            gato.Visible = true;
            koalaHp.Visible = true;
            gatoHp.Visible = true;
            pb321Battle.Visible = true;

            pb321Battle.Image = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "TelaBatalha", "3.png"));
            await Task.Delay(1000);
            pb321Battle.Image = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "TelaBatalha", "2.png"));
            await Task.Delay(1000);
            pb321Battle.Image = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "TelaBatalha", "1.png"));
            await Task.Delay(1000);
            pb321Battle.Image = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "TelaBatalha", "Battle.png"));
            await Task.Delay(1000);
            pb321Battle.Visible = false;

        }
        #endregion

        #region AnimaçãoBotãoSkip
        private int larguraAlvoSkip = 59;
        private int alturaAlvoSkip = 62;
        private bool mouseEmCimaSkip = false;

        //animação hover
        private void pbBotaoStart_MouseEnter(object sender, EventArgs e)
        {
            mouseEmCimaSkip = true;

            larguraAlvoSkip = 65;
            alturaAlvoSkip = 68;

            timerBotaoSkip.Start();
        }

        private void pbBotaoStart_MouseLeave(object sender, EventArgs e)
        {
            mouseEmCimaSkip = false;

            larguraAlvoSkip = 59;
            alturaAlvoSkip = 62;

            timerBotaoSkip.Start();
        }

        //animação clique
        private void pbBotaoStart_MouseDown(object sender, MouseEventArgs e)
        {
            larguraAlvoSkip = 55;
            alturaAlvoSkip = 58;

            timerBotaoSkip.Start();
        }

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
            await Dialogo();
        }
        #endregion
    }
}
