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
    }
}
