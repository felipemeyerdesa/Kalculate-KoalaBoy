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
        private TelaPrincipal principal;

        public TelaInicial(TelaPrincipal telaPrincipal)
        {
            InitializeComponent();
            principal = telaPrincipal;

        }

        #region Botão Start
        private void pbStart_Click(object sender, EventArgs e)
        {
            principal.MostrarTelaHistoria();
        }
        #endregion

        #region AnimaçãoBotãoStart
        private int larguraAlvoStart = 300;
        private int alturaAlvoStart = 115;
        private bool mouseEmCimaStart = false;

        // MOUSE ENTER
        private void pbStart_MouseEnter(object sender, EventArgs e)
        {
            mouseEmCimaStart = true;

            larguraAlvoStart = 332;
            alturaAlvoStart = 125;

            timerBotaoStart.Start();
        }

        // MOUSE LEAVE
        private void pbStart_MouseLeave(object sender, EventArgs e)
        {
            mouseEmCimaStart = false;

            larguraAlvoStart = 300;
            alturaAlvoStart = 115;

            timerBotaoStart.Start();
        }

        // MOUSE DOWN
        private void pbStart_MouseDown(object sender, MouseEventArgs e)
        {
            larguraAlvoStart = 272;
            alturaAlvoStart = 99;

            timerBotaoStart.Start();
        }

        // MOUSE UP
        private void pbStart_MouseUp(object sender, MouseEventArgs e)
        {
            if (mouseEmCimaStart == true)
            {
                larguraAlvoStart = 332;
                alturaAlvoStart = 125;
            }
            else
            {
                larguraAlvoStart = 300;
                alturaAlvoStart = 115;
            }

            timerBotaoStart.Start();
        }

        // TIMER
        private void timerBotaoStart_Tick(object sender, EventArgs e)
        {
            //largura

            if (pbBotaoStart.Width < larguraAlvoStart)
            {
                pbBotaoStart.Width += 4;
                pbBotaoStart.Left -= 2;
            }
            else if (pbBotaoStart.Width > larguraAlvoStart)
            {
                pbBotaoStart.Width -= 4;
                pbBotaoStart.Left += 2;
            }

            //altura

            if (pbBotaoStart.Height < alturaAlvoStart)
            {
                pbBotaoStart.Height += 4;
                pbBotaoStart.Top -= 2;
            }
            else if (pbBotaoStart.Height > alturaAlvoStart)
            {
                pbBotaoStart.Height -= 4;
                pbBotaoStart.Top += 2;
            }

            if (pbBotaoStart.Width == larguraAlvoStart && pbBotaoStart.Height == alturaAlvoStart)
            {
                timerBotaoStart.Stop();
            }
        }
        #endregion

        #region Gif Logo
        private void TelaInicial_Load(object sender, EventArgs e)
        {
            pbLogo.Image = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "TelaInicial", "KoalaLogo.gif"));
        }

        #endregion
        // Fora dos métodos

        #region Botão Tutorial
        private TelaTutorial tutorial;

        private void pbBotaoTutorial_Click(object sender, EventArgs e)
        {
            if (this.FindForm() is TelaPrincipal principal)
            {
                if (tutorial == null || tutorial.IsDisposed)
                {
                    tutorial = new TelaTutorial(principal);
                    tutorial.Visible = false;
                    principal.Controls.Add(tutorial);
                }

                tutorial.Left =
                    (principal.ClientSize.Width - tutorial.Width) / 2;

                tutorial.Top =
                    (principal.ClientSize.Height - 710) ;

                tutorial.Show();
                tutorial.BringToFront();
            }
        }
        #endregion

        #region AnimaçãoBotãoTutorial
        private int larguraAlvoTutorial = 300;
        private int alturaAlvoTutorial = 115;
        private bool mouseEmCimaTutorial = false;

        // MOUSE ENTER
        private void pbBotaoTutorial_MouseEnter(object sender, EventArgs e)
        {
            mouseEmCimaTutorial = true;

            larguraAlvoTutorial = 332;
            alturaAlvoTutorial = 125;

            timerBotaoTutorial.Start();
        }

        // MOUSE LEAVE
        private void pbBotaoTutorial_MouseLeave(object sender, EventArgs e)
        {
            mouseEmCimaTutorial = false;

            larguraAlvoTutorial = 300;
            alturaAlvoTutorial = 115;

            timerBotaoTutorial.Start();
        }

        // MOUSE DOWN
        private void pbBotaoTutorial_MouseDown(object sender, MouseEventArgs e)
        {
            larguraAlvoTutorial = 272;
            alturaAlvoTutorial = 99;

            timerBotaoTutorial.Start();
        }

        // MOUSE UP
        private void pbBotaoTutorial_MouseUp(object sender, MouseEventArgs e)
        {
            if (mouseEmCimaTutorial)
            {
                larguraAlvoTutorial = 332;
                alturaAlvoTutorial = 125;
            }
            else
            {
                larguraAlvoTutorial = 300;
                alturaAlvoTutorial = 115;
            }

            timerBotaoTutorial.Start();
        }

        // TIMER
        private void timerBotaoTutorial_Tick(object sender, EventArgs e)
        {
            int larguraAnterior = pbBotaoTutorial.Width;
            int alturaAnterior = pbBotaoTutorial.Height;

            // LARGURA
            if (pbBotaoTutorial.Width < larguraAlvoTutorial)
            {
                pbBotaoTutorial.Width =
                    Math.Min(pbBotaoTutorial.Width + 4, larguraAlvoTutorial);
            }
            else if (pbBotaoTutorial.Width > larguraAlvoTutorial)
            {
                pbBotaoTutorial.Width =
                    Math.Max(pbBotaoTutorial.Width - 4, larguraAlvoTutorial);
            }

            // ALTURA
            if (pbBotaoTutorial.Height < alturaAlvoTutorial)
            {
                pbBotaoTutorial.Height =
                    Math.Min(pbBotaoTutorial.Height + 4, alturaAlvoTutorial);
            }
            else if (pbBotaoTutorial.Height > alturaAlvoTutorial)
            {
                pbBotaoTutorial.Height =
                    Math.Max(pbBotaoTutorial.Height - 4, alturaAlvoTutorial);
            }

            // Mantém o botão centralizado durante a animação
            pbBotaoTutorial.Left -=
                (pbBotaoTutorial.Width - larguraAnterior) / 2;

            pbBotaoTutorial.Top -=
                (pbBotaoTutorial.Height - alturaAnterior) / 2;

            if (pbBotaoTutorial.Width == larguraAlvoTutorial &&
                pbBotaoTutorial.Height == alturaAlvoTutorial)
            {
                timerBotaoTutorial.Stop();
            }
        }
        #endregion

    }
}
