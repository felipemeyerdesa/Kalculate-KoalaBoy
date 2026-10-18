
using System;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Windows.Forms;

namespace Kalculate_KoalaBoy
{
    internal static class FontesJogo
    {
        private static readonly PrivateFontCollection fontes = new PrivateFontCollection();

        static FontesJogo()
        {
            string caminho = Path.Combine( AppDomain.CurrentDomain.BaseDirectory,"Fontes","PressStart2P-Regular.ttf");
            fontes.AddFontFile(caminho);
        }

        public static void AplicarEmLabels(Control controle)
        {
            foreach (Control controleFilho in controle.Controls)
            {
                if (controleFilho is Label label)
                {
                    Font fonteOriginal = label.Font;

                    label.UseCompatibleTextRendering = true;

                    label.Font = new Font(fontes.Families[0],fonteOriginal.Size,FontStyle.Regular,fonteOriginal.Unit);
                }

                if (controleFilho.HasChildren)
                {
                    AplicarEmLabels(controleFilho);
                }
            }
        }
    }
}
