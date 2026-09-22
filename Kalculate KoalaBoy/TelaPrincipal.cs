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

            TelaInicial telaInicial = new TelaInicial();

            telaInicial.Dock = DockStyle.Fill;

            panelPrincipal.Controls.Add(telaInicial);
        }
    }
}
