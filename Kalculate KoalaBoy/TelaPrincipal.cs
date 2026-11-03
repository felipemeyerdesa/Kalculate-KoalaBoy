using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace Kalculate_KoalaBoy
{
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal()
        {
            InitializeComponent();

            AtivarDoubleBuffered(this);
            MostrarTelaInicial();
        }

        #region Variaveis
        public int BatalhaAtual = 3;
        public TelaBatalhaDialogo telaDialogo;
        public TelaBatalhaPerguntas telaPerguntas;
        #endregion

        #region Exibir TelaInicial
        public void MostrarTelaInicial()
        {
            panelPrincipal.Controls.Clear();

            TelaInicial tela = new TelaInicial();
            tela.Dock = DockStyle.Fill;

            panelPrincipal.Controls.Add(tela);
        }
        #endregion

        #region Exibir TelaBatalhaDialogo
        public void MostrarTelaBatalhaDialogo()
        {
            if (telaDialogo == null)
            { 
                telaDialogo = new TelaBatalhaDialogo(this);
                telaDialogo.Dock = DockStyle.Fill;
                panelPrincipal.Controls.Add(telaDialogo);
            }

            if (telaPerguntas != null)
            {
                telaPerguntas.Hide();
            }

            telaDialogo.ConfigurarCenario();
            telaDialogo.Show();
            telaDialogo.BringToFront();
        }
        #endregion

        #region Exibir TelaBatalhaPerguntas
        public void MostrarTelaBatalhaPerguntas()
        {
            if (telaPerguntas == null)
            {
                telaPerguntas = new TelaBatalhaPerguntas(this);
                telaPerguntas.Dock = DockStyle.Fill;
                panelPrincipal.Controls.Add(telaPerguntas);
            }

            if (telaDialogo != null)
            {
                telaDialogo.Hide();
            }

            telaPerguntas.ConfigurarCenario();
            telaPerguntas.Show();
            telaPerguntas.BringToFront();
        }
        #endregion

        #region DoubleBuffered em Paineis
        public void AtivarDoubleBuffered(Control controle)
        {
            if (controle is Panel)
            {
                typeof(Control)
                    .GetProperty("DoubleBuffered",BindingFlags.Instance | BindingFlags.NonPublic)
                    ?.SetValue(controle, true);
            }

            controle.ControlAdded -= ControleAdicionado;
            controle.ControlAdded += ControleAdicionado;

            foreach (Control controleFilho in controle.Controls)
            {
                AtivarDoubleBuffered(controleFilho);
            }
        }

        private void ControleAdicionado(object sender, ControlEventArgs e)
        {
            AtivarDoubleBuffered(e.Control);
        }
        #endregion
    }
}
