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
    public partial class TelaInicial : UserControl
    {
        public TelaInicial()
        {
            InitializeComponent();

            DoubleBuffered = true;
        }


        #region AnimaçãoStart

        int larguraAlvo = 350;
        int alturaAlvo = 117;
        bool mouseEmCima = false;


        //animação hover
        private void pbStart_MouseEnter(object sender, EventArgs e)
        {   
            mouseEmCima = true;

            larguraAlvo = 382;
            alturaAlvo = 127;

            timerBotao.Start();
        }

        private void pbStart_MouseLeave(object sender, EventArgs e)
        {
            mouseEmCima = false;

            larguraAlvo = 350;
            alturaAlvo = 117;

            timerBotao.Start();
        }

        //animação clique
        private void pbStart_MouseDown(object sender, MouseEventArgs e)
        {
            larguraAlvo = 342;
            alturaAlvo = 113;

            timerBotao.Start();
        }

        private void pbStart_MouseUp(object sender, MouseEventArgs e)
        {
            if (mouseEmCima == true)
            {
                larguraAlvo = 382;
                alturaAlvo = 127;
            }
            else
            {
                larguraAlvo = 350;
                alturaAlvo = 117;
            }

            timerBotao.Start();
        }

        private void timerBotao_Tick(object sender, EventArgs e)
        {
            //largura

            if (pbStart.Width < larguraAlvo)
            {
                pbStart.Width += 4;
                pbStart.Left -= 2;
            }
            else if(pbStart.Width > larguraAlvo)
            {
                pbStart.Width -= 4;
                pbStart.Left += 2;
            }

            //altura

            if (pbStart.Height < alturaAlvo)
            {
                pbStart.Height += 2;
                pbStart.Top -= 1;
            }
            else if (pbStart.Height > alturaAlvo)
            {
                pbStart.Height -= 2;
                pbStart.Top += 1;
            }

            if (pbStart.Width == larguraAlvo && pbStart.Height == alturaAlvo)
            {
                timerBotao.Stop();
            }
        }

        #endregion

        private void pbStart_Click(object sender, EventArgs e)
        {

        }
    }
}
