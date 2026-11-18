using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Kalculate_KoalaBoy
{
    public partial class TelaLobby : UserControl
    {
        #region Componentes da mapa e koala

        private Panel panelMapa; // Variavel do panel do mapa.
        private PictureBox pbKoala; // Koala.
        private int faseSelecionada = 0; // 0 é o ponto inicial, na Biblioteca.
        private TelaPrincipal principal; // Janela responsável por abrir as batalhas.

        // Posições do koala
        private Point[] posicoesFases =
        {
            new Point(1027, 616), // Ponto inicial: Biblioteca.
            new Point(325, 326), // Fase 1: Arquitetura e Urbanismo.
            new Point(655, 163), // Fase 2: Biomedicina.
            new Point(670, 408), // Fase 3: Direito.
            new Point(299, 616), // Fase 4: Educação Física.
            new Point(662, 616), // Fase 5: Artes e Comunicações.
            new Point(988, 256), // Fase 6: Comércio Exterior.
            new Point(1027, 616) // Fase 7: Urubu, de volta à Biblioteca.
        };

        #endregion

        #region inicializa tela mapa
        // Inicia o Lobby.
        public TelaLobby()
        {
            InitializeComponent();
        }

        // Inicializa a tela com a tela principal nos parametros.
        public TelaLobby(TelaPrincipal telaPrincipal)
        {
            principal = telaPrincipal;
            // Prepara a estrutura básica do UserControl.
            InitializeComponent();

            // Monta o painel e coloca a imagem do mapa nele.
            CriarPainelMapa();

            // Cria o personagem e o coloca na Biblioteca.
            CriarKoala();
            CriarVidasPrincipais();
            CriarMenu();
            PosicionarKoala();

            // Permite usar as setas como teclas de movimento.
            this.PreviewKeyDown += new PreviewKeyDownEventHandler(TelaLobby_PreviewKeyDown);

            // Liga A, D e as setas à movimentação entre os pontos.
            this.KeyDown += new KeyEventHandler(TelaLobby_KeyDown);

        }
        #endregion

        #region Criação do painel do mapa

        private void CriarPainelMapa()
        {
            // Cria o painel
            panelMapa = new Panel();
            panelMapa.Name = "panelMapa";

            panelMapa.Dock = DockStyle.Fill; // Preenche a tela inteira com o painel.
            panelMapa.BackgroundImageLayout = ImageLayout.Stretch; // imagem esticada.

            // Carrega a imagem da pasta Imagens/TelaLobby.
            panelMapa.BackgroundImage = Image.FromFile(Path.Combine(
                AppContext.BaseDirectory,"Imagens","TelaLobby","TelaLobby.png"));

            // Add o painel.
            this.Controls.Add(panelMapa);

            // Ao clicar no mapa, o teclado continua controlando o Koala.
            panelMapa.Click += new EventHandler(FocarLobby);
        }

        #endregion

        #region Koala

        private void CriarKoala()
        {
            // Cria a PictureBox e define o tamanho do personagem no mapa.
            pbKoala = new PictureBox();
            pbKoala.Name = "pbKoala";
            pbKoala.Size = new Size(32, 50);
            pbKoala.SizeMode = PictureBoxSizeMode.Zoom;
            pbKoala.BackColor = Color.Transparent;
            pbKoala.TabStop = false;
            pbKoala.Image = Image.FromFile(Path.Combine(
                AppContext.BaseDirectory, "Imagens", "KoalaBoy", "KoalaBoy3.png"));

            // add koala.
            panelMapa.Controls.Add(pbKoala);
            pbKoala.Click += new EventHandler(FocarLobby);
        }
        #endregion

        #region Posição do Koala

        private void PosicionarKoala()
        {
            // A posição 0 da lista representa a Biblioteca.
            int indice = faseSelecionada;

            // Muda a posição.
            pbKoala.Location = posicoesFases[indice];
            pbKoala.BringToFront();
            AtualizarMenu();
        }

        #endregion

        #region Vidas principais

        // Vidas da partida.
        // A tela de resultados consulta este valor para saber se o jogo acabou.
        public int vidasPrincipais = 3;
        private PictureBox pbVidasPrincipais;

        private void CriarVidasPrincipais()
        {
            // Koala corações.
            pbVidasPrincipais = new PictureBox();
            pbVidasPrincipais.Name = "pbVidasPrincipais";
            pbVidasPrincipais.Location = new Point(1168, 8);
            pbVidasPrincipais.Size = new Size(100, 120);
            pbVidasPrincipais.SizeMode = PictureBoxSizeMode.Zoom;
            pbVidasPrincipais.BackColor = Color.Transparent;
            pbVidasPrincipais.TabStop = false;
            pbVidasPrincipais.Click += new EventHandler(FocarLobby);
            panelMapa.Controls.Add(pbVidasPrincipais);
            AtualizarVidasPrincipais();
        }

        private void AtualizarVidasPrincipais()
        {
            // Troca a imagem conforme a quantidade de vidas da partida.
            pbVidasPrincipais.Image = Image.FromFile(Path.Combine(
                AppContext.BaseDirectory, "Imagens", "KoalaBoy",
                "koala_" + vidasPrincipais + "hp.png"));
        }

        #endregion

        #region Teclas W, A, S, D e setas

        private void TelaLobby_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            // Faz as setas funcionarem.
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.Right ||
                e.KeyCode == Keys.Up || e.KeyCode == Keys.Down)
            {
                e.IsInputKey = true;
            }
        }

        private void TelaLobby_KeyDown(object sender, KeyEventArgs e)
        {
            // Avanço de fase (D, W, right e up).
            if (e.KeyCode == Keys.D || e.KeyCode == Keys.W ||
                e.KeyCode == Keys.Right || e.KeyCode == Keys.Up)
            {
                // Só pode avançar até a última fase liberada.
                if (faseSelecionada < ultimaFaseLiberada)
                {
                    faseSelecionada++;
                    PosicionarKoala();
                }

                e.SuppressKeyPress = true;
            }

            // volta de fase (A, S, left e down).
            if (e.KeyCode == Keys.A || e.KeyCode == Keys.S ||
                e.KeyCode == Keys.Left || e.KeyCode == Keys.Down)
            {
                if (faseSelecionada > 0)
                {
                    faseSelecionada--;
                    PosicionarKoala();
                }

                e.SuppressKeyPress = true;
            }
        }

        #endregion

        #region Foco do teclado

        private void FocarLobby(object sender, EventArgs e)
        {
            // Recupera o foco ao clicar no fundo ou no personagem.
            this.Focus();
        }

        #endregion

        #region Menu - componentes e dados das fases

        private Panel panelMenu;
        private Label lblInimigo;
        private PictureBox pbInimigoMenu;
        private PictureBox pbEstrelasMenu;
        private Label lblCurso;
        private Label lblOperacao;
        private Label lblRecorde;
        private Button btnStart;

        // Variaveis dos dados.
        // O índice 0 é a Biblioteca inicial. As batalhas usam os índices 1 a 7.
        private int[] recordes = new int[8];
        private int[] estrelasPorFase = new int[8];
        private bool[] inimigosConhecidos = new bool[8];
        private bool[] fasesConcluidas = new bool[8];
        private int ultimaFaseLiberada = 1; // Começa liberando somente o Gato.

        // Colunas: nome, curso, operação, pasta, imagem da luta e silhueta.
        private string[,] dadosFases =
        {
            { "Gato", "Arquitetura e Urbanismo", "Adição", "ArqUrb", "Gato3.png", "GatoSilhueta.png" },
            { "Lobo", "Biomedicina", "Subtração", "Biomed", "Lobo3.png", "LoboSilhueta.png" },
            { "Raposa", "Direito", "Multiplicação", "Direito", "Raposa3.png", "RaposaSilhueta.png" },
            { "Tutuba", "Educação Física", "Divisão", "Fefesp", "Tutuba3.png", "TutubaSilhueta.png" },
            { "Macaca", "Artes e Comunicações", "Porcentagem", "PubliPropag", "Macaca3.png", "MacacaSilhueta.png" },
            { "Pantera", "Comércio Exterior", "Operações combinadas", "Comex", "Pantera3.png", "PanteraSilhueta.png" },
            { "Junção dos fragmentos", "Biblioteca", "Operações combinadas", "Engenharia", "Urubu1.png", "UrubuSilhueta.png" }
        };

        #endregion

        #region Menu - criação do painel e dos textos

        private void CriarMenu()
        {
            // menu.
            panelMenu = new Panel();
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(280, 502);
            panelMenu.Location = new Point(12, 140);
            panelMenu.BackgroundImageLayout = ImageLayout.Stretch;
            panelMenu.BackgroundImage = Image.FromFile(Path.Combine(
                AppContext.BaseDirectory, "Imagens", "TelaLobby", "BattleCard.jpeg"));
            panelMapa.Controls.Add(panelMenu);

            // Nome do inimigo.
            lblInimigo = new Label();
            lblInimigo.Name = "lblInimigo";
            lblInimigo.Location = new Point(38, 44);
            lblInimigo.Size = new Size(204, 29);
            lblInimigo.BackColor = Color.Transparent;
            lblInimigo.TextAlign = ContentAlignment.MiddleCenter;
            lblInimigo.Font = new Font("Arial", 11);
            panelMenu.Controls.Add(lblInimigo);

            // Imagem central.
            pbInimigoMenu = new PictureBox();
            pbInimigoMenu.Name = "pbInimigoMenu";
            pbInimigoMenu.Location = new Point(40, 120);
            pbInimigoMenu.Size = new Size(200, 140);
            pbInimigoMenu.SizeMode = PictureBoxSizeMode.Zoom;
            pbInimigoMenu.BackColor = Color.Transparent;
            pbInimigoMenu.TabStop = false;
            panelMenu.Controls.Add(pbInimigoMenu);
            pbInimigoMenu.Click += new EventHandler(FocarLobby);

            // Curso.
            lblCurso = new Label();
            lblCurso.Name = "lblCurso";
            lblCurso.Location = new Point(38, 73);
            lblCurso.Size = new Size(204, 22);
            lblCurso.BackColor = Color.Transparent;
            lblCurso.TextAlign = ContentAlignment.MiddleCenter;
            lblCurso.Font = new Font("Arial", 6);
            panelMenu.Controls.Add(lblCurso);

            // estrelinhas.
            pbEstrelasMenu = new PictureBox();
            pbEstrelasMenu.Name = "pbEstrelasMenu";
            pbEstrelasMenu.Location = new Point(29, 273);
            pbEstrelasMenu.Size = new Size(222, 69);
            pbEstrelasMenu.SizeMode = PictureBoxSizeMode.Zoom;
            pbEstrelasMenu.BackColor = Color.Transparent;
            pbEstrelasMenu.TabStop = false;
            pbEstrelasMenu.Click += new EventHandler(FocarLobby);
            panelMenu.Controls.Add(pbEstrelasMenu);

            // Operação matemática da fase.
            lblOperacao = new Label();
            lblOperacao.Name = "lblOperacao";
            lblOperacao.Location = new Point(58, 396);
            lblOperacao.Size = new Size(164, 24);
            lblOperacao.BackColor = Color.Transparent;
            lblOperacao.TextAlign = ContentAlignment.MiddleCenter;
            lblOperacao.Font = new Font("Arial", 6);
            panelMenu.Controls.Add(lblOperacao);

            // Pontuação.
            lblRecorde = new Label();
            lblRecorde.Name = "lblRecorde";
            lblRecorde.Location = new Point(58, 351);
            lblRecorde.Size = new Size(164, 23);
            lblRecorde.BackColor = Color.Transparent;
            lblRecorde.TextAlign = ContentAlignment.MiddleCenter;
            lblRecorde.Font = new Font("Arial", 6);
            panelMenu.Controls.Add(lblRecorde);

            // Botão Jogar.
            btnStart = new Button();
            btnStart.Name = "btnStart";
            btnStart.Text = "JOGAR";
            btnStart.Location = new Point(66, 441);
            btnStart.Size = new Size(148, 37);
            btnStart.BackColor = Color.FromArgb(38, 171, 195);
            btnStart.ForeColor = Color.FromArgb(12, 38, 57);
            btnStart.FlatStyle = FlatStyle.Flat;
            btnStart.FlatAppearance.BorderSize = 3;
            btnStart.FlatAppearance.BorderColor = Color.FromArgb(12, 38, 57);
            btnStart.FlatAppearance.MouseOverBackColor = Color.FromArgb(81, 196, 216);
            btnStart.Cursor = Cursors.Hand;
            btnStart.TabStop = false;
            // Permite a fonte no botão.
            btnStart.UseCompatibleTextRendering = true;
            btnStart.Click += new EventHandler(btnStart_Click);
            panelMenu.Controls.Add(btnStart);

            FontesJogo.AplicarFonte(panelMenu); // fonte nos Labels.
            btnStart.Font = lblRecorde.Font; // fonte do botão.

            panelMenu.Click += new EventHandler(FocarLobby);
            panelMenu.Hide();
        }

        #endregion

        #region Menu - atualização da fase selecionada

        private void AtualizarMenu()
        {
            // Biblioteca.
            if (faseSelecionada == 0)
            {
                panelMenu.Hide();
                return;
            }

            int indice = faseSelecionada - 1;
            lblInimigo.Text = dadosFases[indice, 0];
            lblCurso.Text = dadosFases[indice, 1];

            // O título da última etapa é maior. Diminui a fonte só nessa etapa.
            if (faseSelecionada == 7)
            {
                lblInimigo.Font = new Font(lblInimigo.Font.FontFamily, 7);
            }
            else
            {
                lblInimigo.Font = new Font(lblInimigo.Font.FontFamily, 11);
            }

            // A nota exibida é a maior pontuação já alcançada nesta fase.
            lblOperacao.Text = dadosFases[indice, 2];
            lblRecorde.Text = "Nota: " + recordes[faseSelecionada];
            AtualizarEstrelas();
            AtualizarBotaoJogar();

            string caminhoImagem;
            if (inimigosConhecidos[faseSelecionada] == true)
            {
                // Depois da primeira tentativa, mostra o sprite normal da batalha.
                caminhoImagem = Path.Combine(AppContext.BaseDirectory, "Imagens",
                    dadosFases[indice, 3], dadosFases[indice, 4]);
            }
            else
            {
                // Antes da primeira tentativa, mostra apenas a silhueta.
                caminhoImagem = Path.Combine(AppContext.BaseDirectory, "Imagens",
                    "TelaLobby", "Silhouetas", dadosFases[indice, 5]);

                // A última etapa mostra os fragmentos para não revelar a surpresa.
                if (faseSelecionada == 7)
                {
                    caminhoImagem = Path.Combine(AppContext.BaseDirectory, "Imagens",
                        "TelaResultados", "FragmentosDropados.gif");
                }
            }

            // coloca a imagem imagem.
            Image novaImagem = Image.FromFile(caminhoImagem);
            pbInimigoMenu.Image = novaImagem;

            panelMenu.Show();
            panelMenu.BringToFront();
        }

        #endregion

        #region Menu - estrelas da fase

        private void AtualizarEstrelas()
        {
            
            // imagem das estrelas, de Estrela0.gif até Estrela3.gif.
            int estrelas = estrelasPorFase[faseSelecionada];
            Image novaImagem = Image.FromFile(Path.Combine(
                AppContext.BaseDirectory, "Imagens", "TelaResultados",
                "Estrela" + estrelas + ".gif"));

            pbEstrelasMenu.Image = novaImagem;
        }

        #endregion

        #region Menu - bloqueio das fases

        private void AtualizarBotaoJogar()
        {
            // Começa desativado. Só libera o botão depois de verificar as regras.
            btnStart.Enabled = false;

            if (fasesConcluidas[faseSelecionada] == true)
            {
                btnStart.Text = "CONCLUÍDA";
                return;
            }

            btnStart.Text = "JOGAR";
            btnStart.Enabled = true;
        }

        #endregion

        #region Menu - botão Jogar

        private void btnStart_Click(object sender, EventArgs e)
        {
            // Confere as regras também aqui, antes de abrir qualquer batalha.
            if (faseSelecionada == 0)
            {
                return; // A Biblioteca inicial não tem luta.
            }
            if (vidasPrincipais == 0)
            {
                return;
            }
            if (faseSelecionada > ultimaFaseLiberada)
            {
                return;
            }
            if (fasesConcluidas[faseSelecionada] == true)
            {
                return; // Uma fase vencida não pode ser repetida.
            }

            // Reinicia os controles para não reaproveitar HP ou falas da luta anterior.
            if (principal.telaResultados != null)
            {
                principal.telaResultados.Dispose();
                principal.telaResultados = null;
            }
            if (principal.telaPerguntas != null)
            {
                principal.telaPerguntas.Dispose();
                principal.telaPerguntas = null;
            }
            if (principal.telaDialogo != null)
            {
                principal.telaDialogo.Dispose();
                principal.telaDialogo = null;
            }

            // passa a fase escolhida.
            principal.BatalhaAtual = faseSelecionada;
            inimigosConhecidos[faseSelecionada] = true;

            // Esconde o lobby e abre os diálogos da batalha selecionada.
            this.Hide();
            principal.MostrarTelaBatalhaDialogo();
        }

        #endregion

        #region Resultado da batalha - vidas, estrelas e próxima fase

        // A tela de resultados chama esta função ao clicar no botão de voltar.
        public void RegistrarResultado(int fase, bool venceu, int vidasDaBatalha, int pontos)
        {
            // Não registra novamente uma fase que já foi concluída.
            if (fasesConcluidas[fase] == true)
            {
                return;
            }

            if (venceu == true)
            {
                fasesConcluidas[fase] = true;
                recordes[fase] = pontos;
                estrelasPorFase[fase] = vidasDaBatalha;

                // Libera a próxima fase, até chegar ao Urubu (fase 7).
                if (fase == ultimaFaseLiberada && fase < posicoesFases.Length - 1)
                {
                    ultimaFaseLiberada++;
                }
            }
            else
            {
                // Uma derrota tira só uma vida principal, sem bloquear a nova tentativa.
                if (vidasPrincipais > 0)
                {
                    vidasPrincipais--;
                }
            }

            AtualizarVidasPrincipais();
            AtualizarMenu();
        }

        #endregion

    }
}
