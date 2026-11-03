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
    public partial class TelaBatalhaPerguntas : UserControl
    {
        private TelaPrincipal principal;

        public TelaBatalhaPerguntas(TelaPrincipal telaPrincipal)
        {
            InitializeComponent();
            principal = telaPrincipal;
            FontesJogo.AplicarFonte(this);
            ConfigurarEfeitoDano();
            DefinirImagensInimigo();
        }

        private async void TelaBatalhaPerguntas_Load(object sender, EventArgs e)
        {
            principal = (TelaPrincipal)this.FindForm();
            await Perguntas();
        }

        #region Variaveis
        private int inimigohp = 3;
        private int koalahp = 3;
        private Random random = new Random();
        private int perguntaAtual = 1;
        private int respostaCorreta;
        private int A;
        private int B;
        private int C;
        private int AlternativaErrada1;
        private int AlternativaErrada2;
        int limiteMaximo;
        int limiteMinimo;
        #endregion

        #region Perguntas
        private async Task Perguntas()
        {
            if (inimigohp == 0)
            {
                await principal.telaDialogo.EncerrarBatalha(1);
                principal.MostrarTelaBatalhaDialogo();
                return;
            }

            if (koalahp == 0)
            {
                await principal.telaDialogo.EncerrarBatalha(2);
                principal.MostrarTelaBatalhaDialogo();
                return;
            }

            #region ArqUrb
            //SOMA
            if (principal.BatalhaAtual == 1)
            {
                if (perguntaAtual == 1)
                {
                    A = random.Next(1, 11);
                    B = random.Next(1, 11);

                    respostaCorreta = A + B;

                    limiteMinimo = Math.Max(1, respostaCorreta - 3);
                    limiteMaximo = respostaCorreta + 4;

                    AlternativaErrada1 = random.Next(limiteMinimo, limiteMaximo);
                    AlternativaErrada2 = random.Next(limiteMinimo, limiteMaximo);

                    // Exibe o enunciado da pergunta 1
                    lblCaixaDialogo.Text = "O Gato separou " + A + " blocos azuis e " + B + " blocos vermelhos para uma construção. Quantos blocos são ao todo?";
                }
                else if (perguntaAtual == 2)
                {
                    A = random.Next(1, 21);
                    B = random.Next(1, 21);

                    respostaCorreta = A + B;

                    limiteMinimo = Math.Max(1, respostaCorreta - 3);
                    limiteMaximo = respostaCorreta + 4;

                    AlternativaErrada1 = random.Next(limiteMinimo, limiteMaximo);
                    AlternativaErrada2 = random.Next(limiteMinimo, limiteMaximo);


                    // Exibe o enunciado da pergunta 2
                    lblCaixaDialogo.Text = "Uma fachada possui " + A + " janelas e outra possui " + B + " janelas. Quantas janelas existem nas duas fachadas?";
                }
                else if (perguntaAtual == 3)
                {
                    A = random.Next(1, 31);
                    B = random.Next(1, 31);

                    respostaCorreta = A + B;

                    limiteMinimo = Math.Max(1, respostaCorreta - 3);
                    limiteMaximo = respostaCorreta + 4;

                    AlternativaErrada1 = random.Next(limiteMinimo, limiteMaximo);
                    AlternativaErrada2 = random.Next(limiteMinimo, limiteMaximo);

                    // Exibe o enunciado da pergunta 3
                    lblCaixaDialogo.Text = "Duas vigas de madeira medem " + A + " metros e " + B + " metros. Se forem colocadas uma após a outra, qual será o comprimento total?";
                }
                else if (perguntaAtual == 4)
                {
                    A = random.Next(1, 16);
                    B = random.Next(1, 16);
                    C = random.Next(1, 16);

                    respostaCorreta = A + B + C;

                    limiteMinimo = Math.Max(1, respostaCorreta - 3);
                    limiteMaximo = respostaCorreta + 4;

                    AlternativaErrada1 = random.Next(limiteMinimo, limiteMaximo);
                    AlternativaErrada2 = random.Next(limiteMinimo, limiteMaximo);

                    // Exibe o enunciado da pergunta 4
                    lblCaixaDialogo.Text = "Uma maquete terá " + A + " árvores, " + B + " bancos e " + C + " postes. Quantos elementos serão colocados no total?";
                }
                else if (perguntaAtual == 5)
                {
                    A = random.Next(1, 31);
                    B = random.Next(1, 31);
                    C = random.Next(1, 31);

                    respostaCorreta = A + B + C;

                    limiteMinimo = Math.Max(1, respostaCorreta - 3);
                    limiteMaximo = respostaCorreta + 4;

                    AlternativaErrada1 = random.Next(limiteMinimo, limiteMaximo);
                    AlternativaErrada2 = random.Next(limiteMinimo, limiteMaximo);

                    // Exibe o enunciado da pergunta 5
                    lblCaixaDialogo.Text = "O Gato recebeu " + A + " azulejos verdes, " + B + " azulejos amarelos e " + C + " azulejos azuis. Quantos azulejos ele recebeu?";
                }
            }
            #endregion

            #region Biomed
            //SUBTRAÇÃO
            else if (principal.BatalhaAtual == 2)
            {

                if (perguntaAtual == 1)
                {
                    A = random.Next(6, 16);
                    B = random.Next(1, A);

                    respostaCorreta = A - B;

                    limiteMinimo = Math.Max(1, respostaCorreta - 3);
                    limiteMaximo = Math.Min(A, respostaCorreta + 4);

                    AlternativaErrada1 = random.Next(limiteMinimo, limiteMaximo);
                    AlternativaErrada2 = random.Next(limiteMinimo, limiteMaximo);

                    // Exibe o enunciado da pergunta 1
                    lblCaixaDialogo.Text = "Havia " + A + " tubos de ensaio no laboratório. O Lobo utilizou " + B + " tubos. Quantos tubos sobraram?";
                }
                else if (perguntaAtual == 2)
                {
                    A = random.Next(8, 26);
                    B = random.Next(1, A);

                    respostaCorreta = A - B;

                    limiteMinimo = Math.Max(1, respostaCorreta - 3);
                    limiteMaximo = Math.Min(A, respostaCorreta + 4);

                    AlternativaErrada1 = random.Next(limiteMinimo, limiteMaximo);
                    AlternativaErrada2 = random.Next(limiteMinimo, limiteMaximo);

                    // Exibe o enunciado da pergunta 2
                    lblCaixaDialogo.Text = "O laboratório recebeu " + A + " amostras para análise. Após examinar " + B + " amostras, quantas ainda precisam ser analisadas?";
                }
                else if (perguntaAtual == 3)
                {
                    A = random.Next(12, 41);
                    B = random.Next(1, A);

                    respostaCorreta = A - B;

                    limiteMinimo = Math.Max(1, respostaCorreta - 3);
                    limiteMaximo = Math.Min(A, respostaCorreta + 4);

                    AlternativaErrada1 = random.Next(limiteMinimo, limiteMaximo);
                    AlternativaErrada2 = random.Next(limiteMinimo, limiteMaximo);

                    // Exibe o enunciado da pergunta 3
                    lblCaixaDialogo.Text = "O laboratório tinha " + A + " luvas disponíveis. Foram utilizadas " + B + " luvas. Quantas luvas restaram?";
                }
                else if (perguntaAtual == 4)
                {
                    A = random.Next(15, 51);
                    B = random.Next(1, A);

                    respostaCorreta = A - B;

                    limiteMinimo = Math.Max(1, respostaCorreta - 3);
                    limiteMaximo = Math.Min(A, respostaCorreta + 4);

                    AlternativaErrada1 = random.Next(limiteMinimo, limiteMaximo);
                    AlternativaErrada2 = random.Next(limiteMinimo, limiteMaximo);

                    // Exibe o enunciado da pergunta 4
                    lblCaixaDialogo.Text = "Uma bancada possuía " + A + " frascos. O Lobo guardou " + B + " frascos em um armário. Quantos permaneceram na bancada?";
                }
                else if (perguntaAtual == 5)
                {
                    A = random.Next(20, 61);
                    B = random.Next(1, A);

                    respostaCorreta = A - B;

                    limiteMinimo = Math.Max(1, respostaCorreta - 3);
                    limiteMaximo = Math.Min(A, respostaCorreta + 4);

                    AlternativaErrada1 = random.Next(limiteMinimo, limiteMaximo);
                    AlternativaErrada2 = random.Next(limiteMinimo, limiteMaximo);

                    // Exibe o enunciado da pergunta 5
                    lblCaixaDialogo.Text = "O Lobo preparou " + A + " lâminas para observação. Durante o experimento, " + B + " lâminas foram descartadas. Quantas lâminas restaram?";
                }
            }
            #endregion

            #region Direito
            //MULTIPLICAÇÃO
            else if (principal.BatalhaAtual == 3)
            {

                if (perguntaAtual == 1)
                {
                    A = random.Next(3, 7);
                    B = random.Next(3, 7);

                    respostaCorreta = A * B;

                    limiteMinimo = Math.Max(1, respostaCorreta - 3);
                    limiteMaximo = respostaCorreta + 4;

                    AlternativaErrada1 = random.Next(limiteMinimo, limiteMaximo);
                    AlternativaErrada2 = random.Next(limiteMinimo, limiteMaximo);

                    // Exibe o enunciado da pergunta 1
                    lblCaixaDialogo.Text = "Existem " + A + " pastas, cada uma contendo " + B + " processos. Quantos processos existem no total?";
                }
                else if (perguntaAtual == 2)
                {
                    A = random.Next(4, 9);
                    B = random.Next(4, 9);

                    respostaCorreta = A * B;

                    limiteMinimo = Math.Max(1, respostaCorreta - 3);
                    limiteMaximo = respostaCorreta + 4;

                    AlternativaErrada1 = random.Next(limiteMinimo, limiteMaximo);
                    AlternativaErrada2 = random.Next(limiteMinimo, limiteMaximo);

                    // Exibe o enunciado da pergunta 2
                    lblCaixaDialogo.Text = "Um cartório precisa organizar " + B + " documentos em cada uma das " + A + " pilhas. Quantos documentos serão organizados?";

                }
                else if (perguntaAtual == 3)
                {
                    A = random.Next(5, 10);
                    B = random.Next(5, 10);

                    respostaCorreta = A * B;

                    limiteMinimo = Math.Max(1, respostaCorreta - 3);
                    limiteMaximo = respostaCorreta + 4;

                    AlternativaErrada1 = random.Next(limiteMinimo, limiteMaximo);
                    AlternativaErrada2 = random.Next(limiteMinimo, limiteMaximo);


                    // Exibe o enunciado da pergunta 3
                    lblCaixaDialogo.Text = "A Raposa possui " + A + " caixas, cada uma contendo " + B + " livros jurídicos. Quantos livros existem no total?";
                }
                else if (perguntaAtual == 4)
                {
                    A = random.Next(6, 11);
                    B = random.Next(6, 11);

                    respostaCorreta = A * B;

                    limiteMinimo = Math.Max(1, respostaCorreta - 3);
                    limiteMaximo = respostaCorreta + 4;

                    AlternativaErrada1 = random.Next(limiteMinimo, limiteMaximo);
                    AlternativaErrada2 = random.Next(limiteMinimo, limiteMaximo);

                    // Exibe o enunciado da pergunta 4
                    lblCaixaDialogo.Text = "Em um tribunal, " + A + " advogados receberam " + B + " documentos cada um. Quantos documentos foram distribuídos?";
                }
                else if (perguntaAtual == 5)
                {
                    A = random.Next(7, 12);
                    B = random.Next(7, 12);

                    respostaCorreta = A * B;

                    limiteMinimo = Math.Max(1, respostaCorreta - 3);
                    limiteMaximo = respostaCorreta + 4;

                    AlternativaErrada1 = random.Next(limiteMinimo, limiteMaximo);
                    AlternativaErrada2 = random.Next(limiteMinimo, limiteMaximo);

                    // Exibe o enunciado da pergunta 5
                    lblCaixaDialogo.Text = "Uma biblioteca jurídica possui " + A + " estantes, cada uma com " + B + " códigos de legislação. Quantos códigos existem ao todo?";
                }
            }
            #endregion

            #region Educação Física
            //Divisão
            else if (principal.BatalhaAtual == 4)
            {

                if (perguntaAtual == 1)
                {
                    B = 10;
                    int quociente = random.Next(5, 15);

                    A = B * quociente;
                    respostaCorreta = A / B;

                    limiteMinimo = Math.Max(1, respostaCorreta - 3);
                    limiteMaximo = respostaCorreta + 4;

                    AlternativaErrada1 = random.Next(limiteMinimo, limiteMaximo);
                    AlternativaErrada2 = random.Next(limiteMinimo, limiteMaximo);

                    // Exibe o enunciado da pergunta 1
                    lblCaixaDialogo.Text = "O Tutuba possui " + A + " bolas para distribuir igualmente entre " + B + " equipes. Quantas bolas cada equipe receberá?";
                }
                else if (perguntaAtual == 2)
                {
                    B = 5;
                    int quociente = random.Next(6, 13);

                    A = B * quociente;
                    respostaCorreta = A / B;

                    limiteMinimo = Math.Max(1, respostaCorreta - 3);
                    limiteMaximo = respostaCorreta + 4;

                    AlternativaErrada1 = random.Next(limiteMinimo, limiteMaximo);
                    AlternativaErrada2 = random.Next(limiteMinimo, limiteMaximo);

                    // Exibe o enunciado da pergunta 2
                    lblCaixaDialogo.Text = "Um treinador precisa dividir " + A + " atletas igualmente entre " + B + " grupos. Quantos atletas ficarão em cada grupo?";
                }
                else if (perguntaAtual == 3)
                {
                    B = 2;
                    int quociente = random.Next(20, 45);

                    A = B * quociente;
                    respostaCorreta = A / B;

                    limiteMinimo = Math.Max(1, respostaCorreta - 3);
                    limiteMaximo = respostaCorreta + 4;

                    AlternativaErrada1 = random.Next(limiteMinimo, limiteMaximo);
                    AlternativaErrada2 = random.Next(limiteMinimo, limiteMaximo);


                    // Exibe o enunciado da pergunta 3
                    lblCaixaDialogo.Text = "Existem " + A + " medalhas para distribuir igualmente entre " + B + " equipes. Quantas medalhas cada equipe receberá?";
                }
                else if (perguntaAtual == 4)
                {
                    B = 11;
                    int quociente = random.Next(3, 10);

                    A = B * quociente;
                    respostaCorreta = A / B;

                    limiteMinimo = Math.Max(1, respostaCorreta - 3);
                    limiteMaximo = respostaCorreta + 4;

                    AlternativaErrada1 = random.Next(limiteMinimo, limiteMaximo);
                    AlternativaErrada2 = random.Next(limiteMinimo, limiteMaximo);

                    // Exibe o enunciado da pergunta 4
                    lblCaixaDialogo.Text = "O Tutuba organizou " + A + " cones em " + B + " fileiras iguais. Quantos cones ficarão em cada fileira?";
                }
                else if (perguntaAtual == 5)
                {
                    B = random.Next(3, 5);
                    int quociente = random.Next(15, 26);

                    A = B * quociente;
                    respostaCorreta = A / B;

                    limiteMinimo = Math.Max(1, respostaCorreta - 3);
                    limiteMaximo = respostaCorreta + 4;

                    AlternativaErrada1 = random.Next(limiteMinimo, limiteMaximo);
                    AlternativaErrada2 = random.Next(limiteMinimo, limiteMaximo);


                    // Exibe o enunciado da pergunta 5
                    lblCaixaDialogo.Text = "Um atleta precisa completar " + A + " voltas em " + B + " dias. Fazendo a mesma quantidade por dia, quantas voltas fará diariamente?";
                }
            }
            #endregion

            #region PubliPropag
            //PORCENTAGEM
            if (principal.BatalhaAtual == 5)
            {
                if (perguntaAtual == 1)
                {
                    A = random.Next(1, 7) * 10;

                    respostaCorreta = A / 2;

                    limiteMinimo = Math.Max(1, respostaCorreta - 3);
                    limiteMaximo = respostaCorreta + 4;

                    AlternativaErrada1 = random.Next(limiteMinimo, limiteMaximo);
                    AlternativaErrada2 = random.Next(limiteMinimo, limiteMaximo);

                    // Exibe o enunciado da pergunta 1
                    lblCaixaDialogo.Text = "A Macaca produziu " + A + " cartazes. Se 50% serão utilizados em uma exposição, quantos cartazes serão usados?";
                }
                else if (perguntaAtual == 2)
                {
                    A = random.Next(1, 6) * 20;

                    respostaCorreta = A / 4;

                    limiteMinimo = Math.Max(1, respostaCorreta - 3);
                    limiteMaximo = respostaCorreta + 4;

                    AlternativaErrada1 = random.Next(limiteMinimo, limiteMaximo);
                    AlternativaErrada2 = random.Next(limiteMinimo, limiteMaximo);

                    // Exibe o enunciado da pergunta 2
                    lblCaixaDialogo.Text = "Foram tiradas " + A + " fotografias e 25% serão escolhidas para uma galeria. Quantas fotografias serão selecionadas?";
                }
                else if (perguntaAtual == 3)
                {
                    A = random.Next(2, 11) * 10;

                    respostaCorreta = A / 10;

                    limiteMinimo = Math.Max(1, respostaCorreta - 3);
                    limiteMaximo = respostaCorreta + 4;

                    AlternativaErrada1 = random.Next(limiteMinimo, limiteMaximo);
                    AlternativaErrada2 = random.Next(limiteMinimo, limiteMaximo);

                    // Exibe o enunciado da pergunta 3
                    lblCaixaDialogo.Text = "Um evento vendeu " + A + " ingressos. Se 10% foram vendidos para estudantes, quantos ingressos foram esses?";
                }
                else if (perguntaAtual == 4)
                {
                    A = random.Next(1, 6) * 20;

                    respostaCorreta = A / 5;

                    limiteMinimo = Math.Max(1, respostaCorreta - 3);
                    limiteMaximo = respostaCorreta + 4;

                    AlternativaErrada1 = random.Next(limiteMinimo, limiteMaximo);
                    AlternativaErrada2 = random.Next(limiteMinimo, limiteMaximo);

                    // Exibe o enunciado da pergunta 4
                    lblCaixaDialogo.Text = "Uma campanha publicitária alcançou " + A + " pessoas. Se 20% demonstraram interesse, quantas pessoas ficaram interessadas?";
                }
                else if (perguntaAtual == 5)
                {
                    A = random.Next(1, 5) * 20;

                    respostaCorreta = A - (A / 10);

                    limiteMinimo = Math.Max(1, respostaCorreta - 3);
                    limiteMaximo = respostaCorreta + 4;

                    AlternativaErrada1 = random.Next(limiteMinimo, limiteMaximo);
                    AlternativaErrada2 = random.Next(limiteMinimo, limiteMaximo);

                    // Exibe o enunciado da pergunta 5
                    lblCaixaDialogo.Text = "A Macaca preparou " + A + " ilustrações. Se 90% foram aprovadas para uma exposição, quantas ilustrações foram aprovadas?";
                }
            }
            #endregion

            #region Comex
            //OPERAÇÕES COMBINADAS
            if (principal.BatalhaAtual == 6)
            {
                if (perguntaAtual == 1)
                {
                    A = random.Next(2, 6);
                    B = random.Next(3, 8);
                    C = random.Next(1, 5);

                    respostaCorreta = A * B - C;

                    limiteMinimo = Math.Max(1, respostaCorreta - 3);
                    limiteMaximo = respostaCorreta + 4;

                    AlternativaErrada1 = random.Next(limiteMinimo, limiteMaximo);
                    AlternativaErrada2 = random.Next(limiteMinimo, limiteMaximo);

                    // Exibe o enunciado da pergunta 1
                    lblCaixaDialogo.Text = "O Puma enviou " + A + " caixas com " + B + " produtos cada. Se " + C + " produtos quebraram, quantos restaram?";
                }
                else if (perguntaAtual == 2)
                {
                    C = random.Next(2, 5);
                    int quociente = random.Next(3, 8);
                    int total = C * quociente;

                    A = random.Next(1, total);
                    B = total - A;

                    respostaCorreta = (A + B) / C;

                    limiteMinimo = Math.Max(1, respostaCorreta - 3);
                    limiteMaximo = respostaCorreta + 4;

                    AlternativaErrada1 = random.Next(limiteMinimo, limiteMaximo);
                    AlternativaErrada2 = random.Next(limiteMinimo, limiteMaximo);

                    // Exibe o enunciado da pergunta 2
                    lblCaixaDialogo.Text = "Dois portos enviaram " + A + " e " + B + " caixas. Dividindo tudo entre " + C + " caminhões, quantas caixas cada um receberá?";
                }
                else if (perguntaAtual == 3)
                {
                    A = random.Next(2, 7);
                    B = random.Next(3, 10);
                    C = random.Next(2, 11);

                    respostaCorreta = A * B + C;

                    limiteMinimo = Math.Max(1, respostaCorreta - 3);
                    limiteMaximo = respostaCorreta + 4;

                    AlternativaErrada1 = random.Next(limiteMinimo, limiteMaximo);
                    AlternativaErrada2 = random.Next(limiteMinimo, limiteMaximo);

                    // Exibe o enunciado da pergunta 3
                    lblCaixaDialogo.Text = "O Puma comprou " + A + " produtos por R$ " + B + " cada e pagou R$ " + C + " de frete. Qual foi o total?";
                }
                else if (perguntaAtual == 4)
                {
                    A = random.Next(2, 10) * 10;
                    B = random.Next(1, 5) * 5;

                    respostaCorreta = A + (A / 10) + B;

                    limiteMinimo = Math.Max(1, respostaCorreta - 3);
                    limiteMaximo = respostaCorreta + 4;

                    AlternativaErrada1 = random.Next(limiteMinimo, limiteMaximo);
                    AlternativaErrada2 = random.Next(limiteMinimo, limiteMaximo);

                    // Exibe o enunciado da pergunta 4
                    lblCaixaDialogo.Text = "Uma mercadoria custa R$ " + A + " e recebe uma taxa de 10%, mais R$ " + B + " de frete. Qual é o preço final?";
                }
                else if (perguntaAtual == 5)
                {
                    A = random.Next(2, 6);
                    B = random.Next(1, 4) * 4;

                    respostaCorreta = A * B / 4 * 3;

                    limiteMinimo = Math.Max(1, respostaCorreta - 3);
                    limiteMaximo = respostaCorreta + 4;

                    AlternativaErrada1 = random.Next(limiteMinimo, limiteMaximo);
                    AlternativaErrada2 = random.Next(limiteMinimo, limiteMaximo);

                    // Exibe o enunciado da pergunta 5
                    lblCaixaDialogo.Text = "O Puma recebeu " + A + " caixas com " + B + " produtos cada. Se vendeu 25% dos produtos, quantos sobraram?";
                }
            }
            #endregion

            #region Engenharia
            //OPERAÇOES COMBINADAS
            else if (principal.BatalhaAtual == 7)
            {

                if (perguntaAtual == 1)
                {
                    A = random.Next(2, 5) * 2;
                    B = random.Next(3, 8);
                    C = random.Next(1, 4) * 2;

                    respostaCorreta = (A * B - C) / 2;

                    limiteMinimo = Math.Max(1, respostaCorreta - 3);
                    limiteMaximo = respostaCorreta + 4;

                    AlternativaErrada1 = random.Next(limiteMinimo, limiteMaximo);
                    AlternativaErrada2 = random.Next(limiteMinimo, limiteMaximo);

                    // Exibe o enunciado da pergunta 1 - Civil
                    lblCaixaDialogo.Text = "O Urubu separou " + A + " estruturas com " + B + " vigas cada. Após descartar " + C + " vigas, dividiu as restantes igualmente entre 2 obras. Quantas vigas cada obra recebeu?";
                }
                else if (perguntaAtual == 2)
                {
                    A = random.Next(2, 5);
                    B = random.Next(1, 4) * 4;
                    C = random.Next(2, 10);

                    respostaCorreta = A * B / 4 * 3 + C;

                    limiteMinimo = Math.Max(1, respostaCorreta - 3);
                    limiteMaximo = respostaCorreta + 4;

                    AlternativaErrada1 = random.Next(limiteMinimo, limiteMaximo);
                    AlternativaErrada2 = random.Next(limiteMinimo, limiteMaximo);

                    // Exibe o enunciado da pergunta 2 - Produção
                    lblCaixaDialogo.Text = "O Urubu organizou " + A + " linhas de produção, cada uma fabricando " + B + " peças. Após descartar 25% das peças, produziu mais " + C + ". Quantas peças ficaram disponíveis?";
                }
                else if (perguntaAtual == 3)
                {
                    B = random.Next(2, 6);
                    int quociente = random.Next(5, 11);

                    A = B * quociente;
                    C = random.Next(1, quociente);

                    respostaCorreta = A / B - C;

                    limiteMinimo = Math.Max(1, respostaCorreta - 3);
                    limiteMaximo = respostaCorreta + 4;

                    AlternativaErrada1 = random.Next(limiteMinimo, limiteMaximo);
                    AlternativaErrada2 = random.Next(limiteMinimo, limiteMaximo);

                    // Exibe o enunciado da pergunta 3 - Mecânica
                    lblCaixaDialogo.Text = "O Urubu distribuiu " + A + " litros de óleo lubrificante igualmente entre " + B + " máquinas. Cada máquina utilizou " + C + " litros. Quantos litros sobraram em cada máquina?";
                }
                else if (perguntaAtual == 4)
                {
                    A = random.Next(1, 4) * 2;
                    B = random.Next(3, 9);
                    C = random.Next(2, 11);

                    respostaCorreta = A * B / 2 + C;

                    limiteMinimo = Math.Max(1, respostaCorreta - 3);
                    limiteMaximo = respostaCorreta + 4;

                    AlternativaErrada1 = random.Next(limiteMinimo, limiteMaximo);
                    AlternativaErrada2 = random.Next(limiteMinimo, limiteMaximo);

                    // Exibe o enunciado da pergunta 4 - Computação
                    lblCaixaDialogo.Text = "O Urubu montou " + A + " computadores com " + B + " módulos de memória cada. Metade dos módulos foi enviada para testes e chegaram mais " + C + ". Quantos módulos ficaram disponíveis?";
                }
                else if (perguntaAtual == 5)
                {
                    A = random.Next(2, 5);
                    B = random.Next(2, 7);
                    C = random.Next(2, 6);

                    respostaCorreta = A * B * C;

                    limiteMinimo = Math.Max(1, respostaCorreta - 3);
                    limiteMaximo = respostaCorreta + 4;

                    AlternativaErrada1 = random.Next(limiteMinimo, limiteMaximo);
                    AlternativaErrada2 = random.Next(limiteMinimo, limiteMaximo);

                    // Exibe o enunciado da pergunta 5 - Química
                    lblCaixaDialogo.Text = "O Urubu preparou " + A + " lotes de soluções químicas. Cada lote possui " + B + " frascos com " + C + " litros de solução cada. Quantos litros foram preparados ao todo?";
                }
                else if (perguntaAtual == 6)
                {
                    C = random.Next(2, 6);
                    int quociente = random.Next(3, 10);

                    B = random.Next(3, 15);
                    A = B + C * quociente;

                    respostaCorreta = (A - B) / C;

                    limiteMinimo = Math.Max(1, respostaCorreta - 3);
                    limiteMaximo = respostaCorreta + 4;

                    AlternativaErrada1 = random.Next(limiteMinimo, limiteMaximo);
                    AlternativaErrada2 = random.Next(limiteMinimo, limiteMaximo);

                    // Exibe o enunciado da pergunta 6 - Elétrica
                    lblCaixaDialogo.Text = "O Urubu tinha " + A + " metros de fio elétrico e utilizou " + B + " metros em uma instalação. Dividindo o restante igualmente entre " + C + " circuitos, quantos metros cada circuito recebeu?";
                }
                else if (perguntaAtual == 7)
                {
                    A = random.Next(2, 11);
                    B = random.Next(2, 11);
                    C = random.Next(2, 6);

                    respostaCorreta = (A + B) * C;

                    limiteMinimo = Math.Max(1, respostaCorreta - 3);
                    limiteMaximo = respostaCorreta + 4;

                    AlternativaErrada1 = random.Next(limiteMinimo, limiteMaximo);
                    AlternativaErrada2 = random.Next(limiteMinimo, limiteMaximo);

                    // Exibe o enunciado da pergunta 7 - Eletrônica
                    lblCaixaDialogo.Text = "O Urubu tinha " + A + " placas eletrônicas e recebeu mais " + B + ". Cada placa precisa de " + C + " resistores. Quantos resistores serão necessários ao todo?";
                }
                else if (perguntaAtual == 8)
                {
                    A = random.Next(2, 7);
                    B = random.Next(6, 13);
                    C = random.Next(1, 5);

                    respostaCorreta = A * (B - C);

                    limiteMinimo = Math.Max(1, respostaCorreta - 3);
                    limiteMaximo = respostaCorreta + 4;

                    AlternativaErrada1 = random.Next(limiteMinimo, limiteMaximo);
                    AlternativaErrada2 = random.Next(limiteMinimo, limiteMaximo);

                    // Exibe o enunciado da pergunta 8 - Controle e Automação
                    lblCaixaDialogo.Text = "O Urubu programou " + A + " robôs industriais. Cada robô inspeciona " + B + " peças, mas seus sensores identificam " + C + " peças defeituosas por robô. Quantas peças boas são aprovadas ao todo?";
                }
            }
            #endregion

            // Verifica as alternativas erradas
            while (AlternativaErrada1 == respostaCorreta)
            {
                AlternativaErrada1 = random.Next(limiteMinimo, limiteMaximo);
            }

            while (AlternativaErrada2 == respostaCorreta || AlternativaErrada2 == AlternativaErrada1)
            {
                AlternativaErrada2 = random.Next(limiteMinimo, limiteMaximo);
            }

            OrdenarAlternativas();
        }
        #endregion

        #region Verificar Resposta
        int respostaEscolhida;
        private async Task verificarResposta(object sender)
        {
                if (sender is Label label)
                {
                    respostaEscolhida = int.Parse(label.Text);

                    if (respostaEscolhida == respostaCorreta)
                    {
                        await RespostaCorreta();
                    }
                    else
                    {
                        await RespostaErrada();
                    }
                }
        }
        #endregion

        #region Resposta Correta
        private async Task RespostaCorreta()
        {
            panelCaixaPerguntas.Visible = false;
            panelAlternativas.Visible = false;
            await Ataque();
            perguntaAtual++;
            panelCaixaPerguntas.Visible = true;
            panelAlternativas.Visible = true;
            await Perguntas();
        }
        #endregion

        #region Resposta Errada
        private async Task RespostaErrada()
        {
            panelCaixaPerguntas.Visible = false;
            panelAlternativas.Visible = false;
            await AtaqueInimigo();
            perguntaAtual++;
            panelCaixaPerguntas.Visible = true;
            panelAlternativas.Visible = true;
            await Perguntas();
        }
        #endregion

        #region Ordem das Alternativas
        private int AlternativaCerta;

        private void OrdenarAlternativas()
        {
            AlternativaCerta = random.Next(1,4);

            // Distribui as respostas
            if (AlternativaCerta == 1)
            {
                lblAlternativaA.Text = respostaCorreta.ToString();
                lblAlternativaB.Text = AlternativaErrada1.ToString();
                lblAlternativaC.Text = AlternativaErrada2.ToString();

            }
            else if (AlternativaCerta == 2)
            {
                lblAlternativaA.Text = AlternativaErrada1.ToString();
                lblAlternativaB.Text = respostaCorreta.ToString();
                lblAlternativaC.Text = AlternativaErrada2.ToString();
            }
            else
            {
                lblAlternativaA.Text = AlternativaErrada1.ToString();
                lblAlternativaB.Text = AlternativaErrada2.ToString();
                lblAlternativaC.Text = respostaCorreta.ToString();
            }
        }
        #endregion

        #region Animação de Ataque
        private bool indoParaDireita;
        private bool indoParaEsquerda;

        #region Ataque KoalaBoy
        private async Task Ataque()
        {
            DefinirImagensInimigo();

            indoParaDireita = true;
            timerAtaque.Start();

            while (timerAtaque.Enabled)
            {
                await Task.Delay(15);
            }

            pbKoalaBoy.Size = new Size(325, 335);

            if (koalahp == 3)
            {
                pbKoalaBoy.Image = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "KoalaBoy", "KoalaBoyAtacando.gif"));
            }
            else
            {
                pbKoalaBoy.Image = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "KoalaBoy", "KoalaBoyAtacandoFerido.gif"));
            }

            await Task.Delay(850);

            pbInimigo.Image = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", pastaInimigo, imagemRecebendoDano));

            pbEfeitoDanoInimigo.Visible = true;
            await Task.Delay(1000);
            pbEfeitoDanoInimigo.Visible = false;

            await Task.Delay(400);

            inimigohp--;

            pbInimigoHp.Image = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", pastaInimigo, imagemHp + inimigohp + "hp.png"));

            pbKoalaBoy.Size = new Size(220, 335);
            pbKoalaBoy.Image = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "KoalaBoy", "KoalaBoy" + koalahp + ".png"));
            pbInimigo.Image = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", pastaInimigo, imagemNormal + inimigohp + ".png"));

            indoParaDireita = false;
            timerAtaque.Start();

            while (timerAtaque.Enabled)
            {
                await Task.Delay(15);
            }

            await Task.Delay(500);
        }
        #endregion

        #region Ataque Inimigo
        private async Task AtaqueInimigo()
        {
            DefinirImagensInimigo();

            indoParaEsquerda = true;
            timerAtaque.Start();

            while (timerAtaque.Enabled)
            {
                await Task.Delay(15);
            }

            if (principal.BatalhaAtual == 3)
            {
                pbInimigo.Size = new Size(389, 396);
                pbInimigo.Top = 164;
            }
            else
            {
                pbInimigo.Size = new Size(350, 335);
            }

            if (inimigohp == 3)
            {
                pbInimigo.Image = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", pastaInimigo, imagemAtacando));
            }
            else
            {
                pbInimigo.Image = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", pastaInimigo, imagemAtacandoFerido));
            }


            await Task.Delay(850);

            pbKoalaBoy.Image = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "KoalaBoy", "KoalaBoyDefendendo.png"));

            pbEfeitoDanoKoala.Visible = true;
            await Task.Delay(1000);
            pbEfeitoDanoKoala.Visible = false;

            await Task.Delay(400);

            koalahp--;

            pbKoalaHp.Image = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "KoalaBoy", "koala_" + koalahp + "hp.png"));

            pbInimigo.Size = new Size(255, 335);
            pbInimigo.Top = 225;
            pbKoalaBoy.Image = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "KoalaBoy", "KoalaBoy" + koalahp + ".png"));
            pbInimigo.Image = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", pastaInimigo, imagemNormal + inimigohp + ".png"));

            indoParaEsquerda = false;
            timerAtaque.Start();

            while (timerAtaque.Enabled)
            {
                await Task.Delay(15);
            }

            await Task.Delay(500);
        }
        #endregion

        #region Timer Ataque
        private void timerAtaque_Tick(object sender, EventArgs e)
        {
                if (indoParaDireita == true && respostaEscolhida == respostaCorreta)
                {
                    pbKoalaBoy.Left += 25;

                    if (pbKoalaBoy.Left >= 580)
                    {
                        pbKoalaBoy.Left = 580;
                        timerAtaque.Stop();
                    }
                }
                else if (indoParaDireita == false && respostaEscolhida == respostaCorreta)
                {
                    pbKoalaBoy.Left -= 25;

                    if (pbKoalaBoy.Left <= 120)
                    {
                        pbKoalaBoy.Left = 120;
                        timerAtaque.Stop();
                    }
                }
                else if (indoParaEsquerda == true && respostaEscolhida != respostaCorreta)
                {
                    pbInimigo.Left -= 25;

                    if (pbInimigo.Left <= 340)
                    {
                        pbInimigo.Left = 340;
                        timerAtaque.Stop();
                    }
                }
                else if (indoParaEsquerda == false && respostaEscolhida != respostaCorreta)
                {
                    pbInimigo.Left += 25;

                    if (pbInimigo.Left >= 905)
                    {
                        pbInimigo.Left = 905;
                        timerAtaque.Stop();
                    }
                }
        }
        #endregion

        #endregion

        #region Animação Botão Alternativa

        // Alternativa A
        private int larguraAlvoA = 140;
        private int alturaAlvoA = 120;

        // Alternativa B
        private int larguraAlvoB = 140;
        private int alturaAlvoB = 120;

        // Alternativa C
        private int larguraAlvoC = 140;
        private int alturaAlvoC = 120;

        bool mouseEmCimaAlternativas;

        // MOUSE ENTER
        private void AnimarBotao_MouseEnter(object sender, EventArgs e)
        {
            mouseEmCimaAlternativas = true;

            if (sender == panelAlternativaA || sender == lblAlternativaA)
            {
                larguraAlvoA = 156;
                alturaAlvoA = 136;
            }
            else if (sender == panelAlternativaB || sender == lblAlternativaB)
            {
                larguraAlvoB = 156;
                alturaAlvoB = 136;
            }
            else if (sender == panelAlternativaC || sender == lblAlternativaC)
            {
                larguraAlvoC = 156;
                alturaAlvoC = 136;
            }

            timerBotaoAlternativas.Start();
        }

        // MOUSE LEAVE
        private void AnimarBotao_MouseLeave(object sender, EventArgs e)
        {
            mouseEmCimaAlternativas = false;

            if (sender == panelAlternativaA || sender == lblAlternativaA)
            {
                larguraAlvoA = 140;
                alturaAlvoA = 120;
            }
            else if (sender == panelAlternativaB || sender == lblAlternativaB)
            {
                larguraAlvoB = 140;
                alturaAlvoB = 120;
            }
            else if (sender == panelAlternativaC || sender == lblAlternativaC)
            {
                larguraAlvoC = 140;
                alturaAlvoC = 120;
            }

            timerBotaoAlternativas.Start();
        }

        // MOUSE DOWN
        private void AnimarBotao_MouseDown(object sender, MouseEventArgs e)
        {
            if (sender == panelAlternativaA || sender == lblAlternativaA)
            {
                larguraAlvoA = 132;
                alturaAlvoA = 112;
            }
            else if (sender == panelAlternativaB || sender == lblAlternativaB)
            {
                larguraAlvoB = 132;
                alturaAlvoB = 112;
            }
            else if (sender == panelAlternativaC || sender == lblAlternativaC)
            {
                larguraAlvoC = 132;
                alturaAlvoC = 112;
            }

            timerBotaoAlternativas.Start();
        }

        // MOUSE UP
        private void AnimarBotao_MouseUp(object sender, MouseEventArgs e)
        {
            if (mouseEmCimaAlternativas == true)
            {
                if (sender == panelAlternativaA || sender == lblAlternativaA)
                {
                    larguraAlvoA = 156;
                    alturaAlvoA = 136;
                }
                else if (sender == panelAlternativaB || sender == lblAlternativaB)
                {
                    larguraAlvoB = 156;
                    alturaAlvoB = 136;
                }
                else if (sender == panelAlternativaC || sender == lblAlternativaC)
                {
                    larguraAlvoC = 156;
                    alturaAlvoC = 136;
                }
            }
            else
            {
                if (sender == panelAlternativaA || sender == lblAlternativaA)
                {
                    larguraAlvoA = 140;
                    alturaAlvoA = 120;
                }
                else if (sender == panelAlternativaB || sender == lblAlternativaB)
                {
                    larguraAlvoB = 140;
                    alturaAlvoB = 120;
                }
                else if (sender == panelAlternativaC || sender == lblAlternativaC)
                {
                    larguraAlvoC = 140;
                    alturaAlvoC = 120;
                }
            }

            timerBotaoAlternativas.Start();
        }

        // TIMER
        private void timerBotaoAlternativas_Tick(object sender, EventArgs e)
        {
            // ALTERNATIVA A

            // Largura
            if (panelAlternativaA.Width < larguraAlvoA)
            {
                panelAlternativaA.Width += 4;
                panelAlternativaA.Left -= 2;
            }
            else if (panelAlternativaA.Width > larguraAlvoA)
            {
                panelAlternativaA.Width -= 4;
                panelAlternativaA.Left += 2;
            }

            // Altura
            if (panelAlternativaA.Height < alturaAlvoA)
            {
                panelAlternativaA.Height += 4;
                panelAlternativaA.Top -= 2;
            }
            else if (panelAlternativaA.Height > alturaAlvoA)
            {
                panelAlternativaA.Height -= 4;
                panelAlternativaA.Top += 2;
            }

            // ALTERNATIVA B

            // Largura
            if (panelAlternativaB.Width < larguraAlvoB)
            {
                panelAlternativaB.Width += 4;
                panelAlternativaB.Left -= 2;
            }
            else if (panelAlternativaB.Width > larguraAlvoB)
            {
                panelAlternativaB.Width -= 4;
                panelAlternativaB.Left += 2;
            }

            // Altura
            if (panelAlternativaB.Height < alturaAlvoB)
            {
                panelAlternativaB.Height += 4;
                panelAlternativaB.Top -= 2;
            }
            else if (panelAlternativaB.Height > alturaAlvoB)
            {
                panelAlternativaB.Height -= 4;
                panelAlternativaB.Top += 2;
            }

            // ALTERNATIVA C

            // Largura
            if (panelAlternativaC.Width < larguraAlvoC)
            {
                panelAlternativaC.Width += 4;
                panelAlternativaC.Left -= 2;
            }
            else if (panelAlternativaC.Width > larguraAlvoC)
            {
                panelAlternativaC.Width -= 4;
                panelAlternativaC.Left += 2;
            }

            // Altura
            if (panelAlternativaC.Height < alturaAlvoC)
            {
                panelAlternativaC.Height += 4;
                panelAlternativaC.Top -= 2;
            }
            else if (panelAlternativaC.Height > alturaAlvoC)
            {
                panelAlternativaC.Height -= 4;
                panelAlternativaC.Top += 2;
            }

            if (panelAlternativaA.Width == larguraAlvoA &&
                panelAlternativaA.Height == alturaAlvoA &&
                panelAlternativaB.Width == larguraAlvoB &&
                panelAlternativaB.Height == alturaAlvoB &&
                panelAlternativaC.Width == larguraAlvoC &&
                panelAlternativaC.Height == alturaAlvoC)
            {
                timerBotaoAlternativas.Stop();
            }
        }

        #endregion

        #region Cria e configura os Efeitos de Dano
        private PictureBox pbEfeitoDanoInimigo;
        private PictureBox pbEfeitoDanoKoala;
        private void ConfigurarEfeitoDano()
        {
            pbEfeitoDanoKoala = new PictureBox();

            pbEfeitoDanoKoala.Parent = pbKoalaBoy;
            pbEfeitoDanoKoala.Location = new Point(12,90);
            pbEfeitoDanoKoala.Size = new Size(208, 186);
            pbEfeitoDanoKoala.BackColor = Color.Transparent;
            pbEfeitoDanoKoala.SizeMode = PictureBoxSizeMode.StretchImage;
            pbEfeitoDanoKoala.Visible = false;
            pbEfeitoDanoKoala.Image = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "TelaBatalha", "EfeitoDano.gif"));

            pbEfeitoDanoInimigo = new PictureBox();

            pbEfeitoDanoInimigo.Parent = pbInimigo;
            pbEfeitoDanoInimigo.Size = new Size(208, 186);
            pbEfeitoDanoInimigo.BackColor = Color.Transparent;
            pbEfeitoDanoInimigo.SizeMode = PictureBoxSizeMode.StretchImage;
            pbEfeitoDanoInimigo.Visible = false;
            pbEfeitoDanoInimigo.Image = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "TelaBatalha", "EfeitoDano.gif"));

            if (principal.BatalhaAtual == 1)
            {
                pbEfeitoDanoInimigo.Location = new Point(50, 90);
            }
            else if (principal.BatalhaAtual == 3)
            {
                pbEfeitoDanoInimigo.Location = new Point(10, 90);
            }
        }
        #endregion

        #region Configura Cenario
        public void ConfigurarCenario()
        {
            BackgroundImage = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", pastaInimigo, cenario));

            pbKoalaBoy.Image = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "KoalaBoy", "KoalaBoy3.png"));
            pbKoalaHp.Image = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "KoalaBoy", "koala_3hp.png"));

            pbInimigo.Image = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", pastaInimigo, imagemNormal + inimigohp + ".png"));
            pbInimigoHp.Image = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", pastaInimigo, imagemHp + inimigohp + "hp.png"));

            //ArqUrb
            if (principal.BatalhaAtual == 1)
            {
                pbKoalaBoy.Location = new Point(120, 252);
                pbInimigo.Location = new Point(905, 252);
            }
            //Biomed
            else if (principal.BatalhaAtual == 2)
            {
                pbKoalaBoy.Location = new Point(120, 252);
                pbInimigo.Location = new Point(905, 252);
            }
            //Direito
            else if (principal.BatalhaAtual == 3)
            {
                pbKoalaBoy.Location = new Point(120, 225);
                pbInimigo.Location = new Point(905, 225);
            }
            //Educação Física
            else if (principal.BatalhaAtual == 4)
            {
                pbKoalaBoy.Location = new Point(120, 252);
                pbInimigo.Location = new Point(905, 252);
            }
            //Artes e Comunicação
            else if (principal.BatalhaAtual == 5)
            {
                pbKoalaBoy.Location = new Point(120, 225);
                pbInimigo.Location = new Point(905, 225);
            }
            //Comércio Exterior
            else if (principal.BatalhaAtual == 6)
            {
                pbKoalaBoy.Location = new Point(120, 225);
                pbInimigo.Location = new Point(905, 225);
            }
            //Engenharia
            else if (principal.BatalhaAtual == 7)
            {
                pbKoalaBoy.Location = new Point(120, 225);
                pbInimigo.Location = new Point(905, 225);
            }
        }
        #endregion

        #region Imagens Inimigo
        private string pastaInimigo;
        private string cenario;
        private string imagemAtacando;
        private string imagemAtacandoFerido;
        private string imagemRecebendoDano;
        private string imagemNormal;
        private string imagemHp;

        private void DefinirImagensInimigo()
        {
            //ArqUrb
            if (principal.BatalhaAtual == 1)
            {
                pastaInimigo = "ArqUrb";
                cenario = "ArqUrb.png";
                imagemAtacando = "GatoAtacando.gif";
                imagemAtacandoFerido = "GatoAtacandoFerido.gif";
                imagemRecebendoDano = "GatoDefendendo.png";
                imagemNormal = "Gato";
                imagemHp = "gato_";
            }
            //Biomed
            else if (principal.BatalhaAtual == 2)
            {
                pastaInimigo = "Biomed";
                cenario = "Biomed.png";
                imagemAtacando = "LoboAtacando.gif";
                imagemAtacandoFerido = "LoboAtacandoFerido.gif";
                imagemRecebendoDano = "loboDefendendo.png";
                imagemNormal = "Lobo";
                imagemHp = "lobo_";
            }
            //Direito
            else if (principal.BatalhaAtual == 3)
            {
                pastaInimigo = "Direito";
                cenario = "Direito.png";
                imagemAtacando = "RaposaAtacando.gif";
                imagemAtacandoFerido = "RaposaAtacandoFerida.gif";
                imagemRecebendoDano = "RaposaDefendendo.png";
                imagemNormal = "Raposa";
                imagemHp = "raposa_";
            }
            //Fefesp
            else if (principal.BatalhaAtual == 4)
            {
                pastaInimigo = "Fefesp";
                cenario = "Fefesp.png";
                imagemAtacando = "TutubaAtacando.gif";
                imagemAtacandoFerido = "TutubaAtacandoFerido.gif";
                imagemRecebendoDano = "TutubaDefendendo.png";
                imagemNormal = "Tutuba";
                imagemHp = "tutuba_";
            }
            //PubliPropag
            else if (principal.BatalhaAtual == 5)
            {
                pastaInimigo = "";
                cenario = ".png";
                imagemAtacando = ".gif";
                imagemAtacandoFerido = ".gif";
                imagemRecebendoDano = ".png";
                imagemNormal = "";
                imagemHp = "";
            }
            //Comex
            else if (principal.BatalhaAtual == 6)
            {
                pastaInimigo = "";
                cenario = ".png";
                imagemAtacando = ".gif";
                imagemAtacandoFerido = ".gif";
                imagemRecebendoDano = ".png";
                imagemNormal = "";
                imagemHp = "";
            }
            //Engenharia
            else if (principal.BatalhaAtual == 7)
            {
                pastaInimigo = "";
                imagemAtacando = ".gif";
                imagemAtacandoFerido = ".gif";
                imagemRecebendoDano = ".png";
                imagemNormal = "";
                imagemHp = "";
            }
        }
        #endregion

        #region Botão Alternativa
        private async void Alternativa_Click(object sender, EventArgs e)
        {
            await verificarResposta(sender);
        }
        #endregion
    }
}
