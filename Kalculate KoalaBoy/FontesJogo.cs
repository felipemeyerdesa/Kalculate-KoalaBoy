
using System;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Windows.Forms;

namespace Kalculate_KoalaBoy
{
    internal static class FontesJogo
    {
        // Coleção que armazena as fontes personalizadas
        private static readonly PrivateFontCollection fontes = new PrivateFontCollection();

        static FontesJogo()
        {
            // Localiza e carrega a fonte da pasta Fontes
            string caminho = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Fontes", "PressStart2P-Regular.ttf");
            fontes.AddFontFile(caminho);
        }

        public static void AplicarFonte(Control controle)
        {
            // Percorre os controles e procura Labels
            foreach (Control controleFilho in controle.Controls)
            {
                if (controleFilho is Label label)
                {
                    Font fonteOriginal = label.Font;

                    label.UseCompatibleTextRendering = true;

                    // Aplica a fonte mantendo o tamanho original
                    label.Font = new Font(fontes.Families[0], fonteOriginal.Size, FontStyle.Regular, fonteOriginal.Unit);
                }

                // Procura também dentro de outros controles
                if (controleFilho.HasChildren)
                {
                    AplicarFonte(controleFilho);
                }
            }
        }
    }
}
