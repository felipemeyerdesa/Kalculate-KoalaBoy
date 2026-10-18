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
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal()
        {
            InitializeComponent();
            AtivarDoubleBuffered(this);
            MostrarTelaInicial();
        }

        #region Exibir TelaInicial
        public void MostrarTelaInicial()
        {
            panelPrincipal.Controls.Clear();

            TelaInicial tela = new TelaInicial();
            tela.Dock = DockStyle.Fill;

            panelPrincipal.Controls.Add(tela);
        }
        #endregion

        #region Exibir TelaBatalha
        public void MostrarTelaBatalha()
        {
            panelPrincipal.Controls.Clear();

            TelaBatalha tela = new TelaBatalha();
            tela.Dock = DockStyle.Fill;

            panelPrincipal.Controls.Add(tela);
        }
        #endregion

        #region DoubleBuffered em Paineis
        private void AtivarDoubleBuffered(Control controle)
        {
            if (controle is Panel)
            {
                typeof(Control)
                    .GetProperty("DoubleBuffered",
                        System.Reflection.BindingFlags.Instance |
                        System.Reflection.BindingFlags.NonPublic)
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
