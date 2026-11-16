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
            //MostrarTelaInicial();
            MostrarTelaHistoria();
            
        }

        #region Variaveis
        public int BatalhaAtual = 0;
        public TelaInicial telaInicial;
        public TelaHistoria telaHistoria;
        public TelaLobby telaLobby;
        public TelaBatalhaDialogo telaDialogo;
        public TelaBatalhaPerguntas telaPerguntas;
        public TelaResultados telaResultados;
        public int pontuacaoTotal = 0;
        #endregion

        #region Exibir TelaInicial
        public void MostrarTelaInicial()
        {
            panelPrincipal.Controls.Clear();

            telaInicial = new TelaInicial();
            telaInicial.Dock = DockStyle.Fill;

            panelPrincipal.Controls.Add(telaInicial);
        }
        #endregion

        #region Exibir TelaHistoria
        public void MostrarTelaHistoria()
        {
            if (telaHistoria == null)
            {
                telaHistoria = new TelaHistoria(this);
                telaHistoria.Dock = DockStyle.Fill;
                panelPrincipal.Controls.Add(telaHistoria);
            }

            if (telaDialogo != null)
            {
                telaDialogo.Hide();
            }

            telaHistoria.Show();
            telaHistoria.BringToFront();
        }
        #endregion

        #region Exibir TelaLobby
        public void MostrarTelaLobby()
        {
            if (telaLobby == null)
            {
                telaLobby = new TelaLobby(this);
                telaLobby.Dock = DockStyle.Fill;
                panelPrincipal.Controls.Add(telaLobby);
            }

            if (telaHistoria != null)
            {
                telaHistoria.Hide();
            }
            if (telaResultados != null)
            {
                telaResultados.Hide();
            }

            telaLobby.Show();
            telaLobby.BringToFront();
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

            if (telaHistoria != null)
            {
                telaHistoria.Hide();
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

            telaPerguntas.ReiniciarPontuacao();
            telaPerguntas.ConfigurarCenario();
            telaPerguntas.Show();
            telaPerguntas.BringToFront();
        }
        #endregion

        #region Exibir TelaResultados
        public void MostrarTelaResultados()
        {
            if (telaResultados == null)
            {
                telaResultados = new TelaResultados(this);
                telaResultados.Dock = DockStyle.Fill;
                panelPrincipal.Controls.Add(telaResultados);
            }

            if (telaDialogo != null)
            {
                telaDialogo.Hide();
            }

            telaResultados.ConfigurarCenario();
            telaResultados.Show();
            telaResultados.BringToFront();
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
