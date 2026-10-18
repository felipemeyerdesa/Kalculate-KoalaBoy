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
    public partial class TelaInicial : UserControl
    {
        public TelaInicial()
        {
            InitializeComponent();

        }

        #region AnimaçãoBotãoStart

        private int larguraAlvoStart = 270;
        private int alturaAlvoStart = 85;
        private bool mouseEmCimaStart = false;

        //animação hover
        private void pbStart_MouseEnter(object sender, EventArgs e)
        {
            mouseEmCimaStart = true;

            larguraAlvoStart = 302;
            alturaAlvoStart = 95;

            timerBotaoStart.Start();
        }

        private void pbStart_MouseLeave(object sender, EventArgs e)
        {
            mouseEmCimaStart = false;

            larguraAlvoStart = 270;
            alturaAlvoStart = 85;

            timerBotaoStart.Start();
        }

        //animação clique
        private void pbStart_MouseDown(object sender, MouseEventArgs e)
        {
            larguraAlvoStart = 262;
            alturaAlvoStart = 81;

            timerBotaoStart.Start();
        }

        private void pbStart_MouseUp(object sender, MouseEventArgs e)
        {
            if (mouseEmCimaStart == true)
            {
                larguraAlvoStart = 302;
                alturaAlvoStart = 95;
            }
            else
            {
                larguraAlvoStart = 270;
                alturaAlvoStart = 85;
            }

            timerBotaoStart.Start();
        }

        private void timerBotao_Tick(object sender, EventArgs e)
        {
            //largura

            if (pbBotaoStart.Width < larguraAlvoStart)
            {
                pbBotaoStart.Width += 2;
                pbBotaoStart.Left -= 1;
            }
            else if(pbBotaoStart.Width > larguraAlvoStart)
            {
                pbBotaoStart.Width -= 2;
                pbBotaoStart.Left += 1;
            }

            //altura

            if (pbBotaoStart.Height < alturaAlvoStart)
            {
                pbBotaoStart.Height += 2;
                pbBotaoStart.Top -= 1;
            }
            else if (pbBotaoStart.Height > alturaAlvoStart)
            {
                pbBotaoStart.Height -= 2;
                pbBotaoStart.Top += 1;
            }

            if (pbBotaoStart.Width == larguraAlvoStart && pbBotaoStart.Height == alturaAlvoStart)
            {
                timerBotaoStart.Stop();
            }
        }

        #endregion

        #region Botão Start
        private void pbStart_Click(object sender, EventArgs e)
        {
            TelaPrincipal principal = (TelaPrincipal)this.FindForm();

            principal.MostrarTelaBatalha();
        }
        #endregion

        #region Gif Logo
        private void TelaInicial_Load(object sender, EventArgs e)
        {
            pbLogo.Image = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "TelaInicial", "KoalaLogo.gif"));
        }
        #endregion
    }
}
