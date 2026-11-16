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
        private async void timerAnimacao_Tick(object sender, EventArgs e)
        {

            pbUrubu.Left += 25;

            if (pbUrubu.Left >= 310 && pausaUrubuFeita == false)
            {
                
                pausaUrubuFeita = true;
                timerAnimacao.Stop();
                await Task.Delay(2850);
                pbUrubu.Size = new Size(220, 335);
                pbUrubu.Location = new Point(310, 256);
                pbUrubu.Image = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "TelaHistoria", "UrubuFrameFinal.png"));
                timerAnimacao.Start();
            }
            else if (pbUrubu.Left >= 630 && pausaUrubuFeita == true)
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
            pbBotaoFecharLenda.SizeMode = PictureBoxSizeMode.StretchImage;
            pbBotaoFecharLenda.Cursor = Cursors.Hand;
            pbBotaoFecharLenda.Click += pbBotaoFecharLenda_Click;
            pbBotaoFecharLenda.Visible = false;
            pbBotaoFecharLenda.Image = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "TelaHistoria", "LendaFragmento.png"));
        }
        #endregion

        #region Botão Fechar Lenda
        private void pbBotaoFecharLenda_Click(object sender, EventArgs e)
        {
            pbLendaFragmento.Visible = false;
            principal.MostrarTelaBatalhaDialogo();
        }
        #endregion

        private async void TelaHistoria_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible && mostrarLendaFragmento == true)
            {
                pbKoalaBoy.Visible = false;
                pbUrubu.Visible = false;
                pbLendaFragmento.Visible = true;
                pbBotaoFecharLenda.Visible = true;
            }
        }
    }
}