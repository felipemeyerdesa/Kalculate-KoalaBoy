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
    public partial class TelaBatalhaDialogo : UserControl
    {
        private TelaPrincipal principal;

        public TelaBatalhaDialogo(TelaPrincipal telaPrincipal)
        {
            InitializeComponent();
            principal = telaPrincipal;
            FontesJogo.AplicarFonte(this);
            DefinirImagensInimigo();
        }

        private async void TelaBatalha_Load(object sender, EventArgs e)
        {
            await Task.Delay(2100);
            pbKoalaBoy.Visible = false;
            pbInimigo.Visible = false;
            Dialogo();
            panelDialogo.Visible = true;
        }

        #region Dialogos
        private int dialogoAtual = 1;

        private void Dialogo()
        {
            BackgroundImage = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", pastaInimigo, cenarioDesfocado));

            #region TelaHistoria
            if (principal.BatalhaAtual == 0)
            {
                if (dialogoAtual == 1)
                {
                    pbPersonagem.Image = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "Engenharia", "UrubuFalando1.png"));
                    panelBoxDialogo.BackgroundImage = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "TelaBatalha", "BoxUrubu.png"));
                    lblDialogo.Text = "Mas ora, ora... KoalaBoy? Que cara é essa? Parece que foi atropelado por uma semana de provas!";
                }
                else if (dialogoAtual == 2)
                {
                    pbPersonagem.Image = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "KoalaBoy", "KoalaBoyFalando2.png"));
                    panelBoxDialogo.BackgroundImage = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "TelaBatalha", "BoxKoalaBoy.png"));
                    lblDialogo.Text = "Nem me fale, Urubu... É trabalho, é prova, é aluno folgado ... Já não aguento mais!";
                }
                else if (dialogoAtual == 3)
                {
                    pbPersonagem.Image = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "Engenharia", "UrubuFalando1.png"));
                    panelBoxDialogo.BackgroundImage = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "TelaBatalha", "BoxUrubu.png"));
                    lblDialogo.Text = "Mas que situação lamentável! E o que pretende fazer a respeito, meu caro?";
                }
                else if (dialogoAtual == 4)
                {
                    pbPersonagem.Image = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "KoalaBoy", "KoalaBoyFalando2.png"));
                    panelBoxDialogo.BackgroundImage = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "TelaBatalha", "BoxKoalaBoy.png"));
                    lblDialogo.Text = "Ahhh... Eu só precisava tirar férias remuneradas! Uma praia, uma rede e ficar bem longe de tranqueir-- alunos... por uns tempos!";
                }
                else if (dialogoAtual == 5)
                {
                    pbPersonagem.Image = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "Engenharia", "UrubuFalando4.png"));
                    panelBoxDialogo.BackgroundImage = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "TelaBatalha", "BoxUrubu.png"));
                    lblDialogo.Text = "Férias? Pois é, porque não?? Me parece uma solução bastante razoável!";
                }
                else if (dialogoAtual == 6)
                {
                    pbPersonagem.Image = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "KoalaBoy", "KoalaBoyFalando2.png"));
                    panelBoxDialogo.BackgroundImage = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "TelaBatalha", "BoxKoalaBoy.png"));
                    lblDialogo.Text = "Até parece que é fácil, né!? Tenho um monte de responsabilidades! Não posso simplesmente sumir!";
                }
                else if (dialogoAtual == 7)
                {
                    pbPersonagem.Image = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "Engenharia", "UrubuFalando2.png"));
                    panelBoxDialogo.BackgroundImage = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "TelaBatalha", "BoxUrubu.png"));
                    lblDialogo.Text = "Hmmm... Puxa, mas que dilema! Mas talvez exista uma maneira de resolver esse seu pequeno 'problema'...";
                }
                else if (dialogoAtual == 8)
                {
                    pbPersonagem.Image = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "KoalaBoy", "KoalaBoyFalando3.png"));
                    panelBoxDialogo.BackgroundImage = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "TelaBatalha", "BoxKoalaBoy.png"));
                    lblDialogo.Text = "Se for sugerir pra corrigir prova mais rápido, pode esquecer! Já tentei de tudo!";
                }
                else if (dialogoAtual == 9)
                {
                    pbPersonagem.Image = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "Engenharia", "UrubuFalando3.png"));
                    panelBoxDialogo.BackgroundImage = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "TelaBatalha", "BoxUrubu.png"));
                    lblDialogo.Text = "Não seja tão limitado, KoalaBoy! Recentemente, ouvi certos rumores sobre lendários Fragmentos misteriosos.";
                }
                else if (dialogoAtual == 10)
                {
                    pbPersonagem.Image = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "Engenharia", "UrubuFalando3.png"));
                    panelBoxDialogo.BackgroundImage = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "TelaBatalha", "BoxUrubu.png"));
                    lblDialogo.Text = "Então, fiz minha própria pesquisa na biblioteca da UNISANTA, e achei um registro antigo sobre tais fragmentos";
                }
                else if (dialogoAtual == 11)
                {
                    pbPersonagem.Image = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "KoalaBoy", "KoalaBoyFalando3.png"));
                    panelBoxDialogo.BackgroundImage = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "TelaBatalha", "BoxKoalaBoy.png"));
                    lblDialogo.Text = "Fragmentos misteriosos? Que história é essa? Agora inventaram uma nova matéria e esqueceram de me avisar?";
                }
                else if (dialogoAtual == 12)
                {
                    pbPersonagem.Image = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "Engenharia", "UrubuFalando1.png"));
                    panelBoxDialogo.BackgroundImage = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "TelaBatalha", "BoxUrubu.png"));
                    lblDialogo.Text = "Não, não seja tonto! Diz a lenda que esses fragmentos ESPECIAIS escondem um poder extraordinário!";
                }
                else if (dialogoAtual == 13)
                {
                    pbPersonagem.Image = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "KoalaBoy", "KoalaBoyFalando4.png"));
                    panelBoxDialogo.BackgroundImage = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "TelaBatalha", "BoxKoalaBoy.png"));
                    lblDialogo.Text = "Poder extraordinário?! Está dizendo que essas pedrinhas podem me ajudar a conseguir minhas férias?";
                }
                else if (dialogoAtual == 14)
                {
                    pbPersonagem.Image = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "Engenharia", "UrubuFalando5.png"));
                    panelBoxDialogo.BackgroundImage = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "TelaBatalha", "BoxUrubu.png"));
                    lblDialogo.Text = "Talvez... Mas não precisa acreditar na minha palavra! Leia este livro e tire suas próprias conclusões!";
                }
                else if (dialogoAtual == 15)
                {
                    pbPersonagem.Image = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "KoalaBoy", "KoalaBoyFalando4.png"));
                    panelBoxDialogo.BackgroundImage = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "TelaBatalha", "BoxKoalaBoy.png"));
                    lblDialogo.Text = "Um livro? Ah, ótimo! Mais leitura... Era exatamente o que faltava na minha vida!";
                }
                else if (dialogoAtual == 16)
                {
                    pbPersonagem.Image = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "Engenharia", "UrubuFalando1.png"));
                    panelBoxDialogo.BackgroundImage = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "TelaBatalha", "BoxUrubu.png"));
                    lblDialogo.Text = "Pare de reclamar e abra logo! Garanto que esta descoberta será muito mais interessante que suas provas!";
                }
                else if (dialogoAtual == 17)
                {
                    pbPersonagem.Image = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "KoalaBoy", "KoalaBoyFalando1.png"));
                    panelBoxDialogo.BackgroundImage = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "TelaBatalha", "BoxKoalaBoy.png"));
                    lblDialogo.Text = "Então é verdade?! Os Fragmentos ESPECIAIS estão protegidos pelos mascotes das atléticas da UNISANTA?!";
                }
                else if (dialogoAtual == 18)
                {
                    pbPersonagem.Image = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "Engenharia", "UrubuFalando3.png"));
                    panelBoxDialogo.BackgroundImage = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "TelaBatalha", "BoxUrubu.png"));
                    lblDialogo.Text = "Exatamente! Cada mascote protege um fragmento. Reuni-los, porém, não será uma tarefa nada simples!";
                }
                else if (dialogoAtual == 19)
                {
                    pbPersonagem.Image = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "KoalaBoy", "KoalaBoyFalando7.png"));
                    panelBoxDialogo.BackgroundImage = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "TelaBatalha", "BoxKoalaBoy.png"));
                    lblDialogo.Text = "Peraê, então... Se eu conseguir juntar todos, posso finalmente tirar minhas férias?!";
                }
                else if (dialogoAtual == 20)
                {
                    pbPersonagem.Image = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "Engenharia", "UrubuFalando3.png"));
                    panelBoxDialogo.BackgroundImage = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "TelaBatalha", "BoxUrubu.png"));
                    lblDialogo.Text = "Precisamente, meu caro! Mas terá que enfrentar cada um dos guardiões para conquistar seus fragmentos!";
                }
                else if (dialogoAtual == 21)
                {
                    pbPersonagem.Image = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "KoalaBoy", "KoalaBoyFalando4.png"));
                    panelBoxDialogo.BackgroundImage = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "TelaBatalha", "BoxKoalaBoy.png"));
                    lblDialogo.Text = "Enfrentar os mascotes das atléticas?! Tá maluco? Não quero arrumar mais trabalho!";
                }
                else if (dialogoAtual == 22)
                {
                    pbPersonagem.Image = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "Engenharia", "UrubuFalando4.png"));
                    panelBoxDialogo.BackgroundImage = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "TelaBatalha", "BoxUrubu.png"));
                    lblDialogo.Text = "Ora, pense pelo lado positivo! Um pequeno esforço agora pode lhe render um descanso digno!";
                }
                else if (dialogoAtual == 23)
                {
                    pbPersonagem.Image = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "KoalaBoy", "KoalaBoyFalando6.png"));
                    panelBoxDialogo.BackgroundImage = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "TelaBatalha", "BoxKoalaBoy.png"));
                    lblDialogo.Text = "Hmmm... Pensando bem, umas férias sem alunos me chamando a cada cinco minutos parecem irresistíveis!";
                }
                else if (dialogoAtual == 24)
                {
                    pbPersonagem.Image = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "KoalaBoy", "KoalaBoyFalando7.png"));
                    panelBoxDialogo.BackgroundImage = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "TelaBatalha", "BoxKoalaBoy.png"));
                    lblDialogo.Text = "Está decidido! Vou atrás desses fragmentos, nem que tenha que enfrentar a UNISANTA INTEIRINHA!";
                }
                else if (dialogoAtual == 25)
                {
                    pbPersonagem.Image = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "Engenharia", "UrubuFalando2.png"));
                    panelBoxDialogo.BackgroundImage = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "TelaBatalha", "BoxUrubu.png"));
                    lblDialogo.Text = "Excelente decisão, KoalaBoy!!! E não se preocupe, estarei ao seu lado durante toda essa jornada!";
                }
                else if (dialogoAtual == 26)
                {
                    pbPersonagem.Image = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "KoalaBoy", "KoalaBoyFalando1.png"));
                    panelBoxDialogo.BackgroundImage = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "TelaBatalha", "BoxKoalaBoy.png"));
                    lblDialogo.Text = "Sério?! Você vai me ajudar? Poxa, Urubu! Nem sabia que você se importava tanto comigo";
                }
                else if (dialogoAtual == 27)
                {
                    pbPersonagem.Image = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "Engenharia", "UrubuFalando2.png"));
                    panelBoxDialogo.BackgroundImage = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "TelaBatalha", "BoxUrubu.png"));
                    lblDialogo.Text = "Mas é clarooo! Afinal, quando todos os fragmentos estiverem reunidos, eu finalmente poderei...";
                }
                else if (dialogoAtual == 28)
                {
                    pbPersonagem.Image = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "KoalaBoy", "KoalaBoyFalando1.png"));
                    panelBoxDialogo.BackgroundImage = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "TelaBatalha", "BoxKoalaBoy.png"));
                    lblDialogo.Text = "Finalmente poderá o quê?";
                }
                else if (dialogoAtual == 29)
                {
                    pbPersonagem.Image = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "Engenharia", "UrubuFalando7.png"));
                    panelBoxDialogo.BackgroundImage = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "TelaBatalha", "BoxUrubu.png"));
                    lblDialogo.Text = "EU?! Cof* Cof*, nada, nada! Digo... Finalmente poderei vê-lo desfrutando de suas merecidas férias! Hehehe...";
                }
                else if (dialogoAtual == 30)
                {
                    pbPersonagem.Image = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "KoalaBoy", "KoalaBoyFalando7.png"));
                    panelBoxDialogo.BackgroundImage = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "TelaBatalha", "BoxKoalaBoy.png"));
                    lblDialogo.Text = "Então chega de conversa! Que venham os duelos! Essas férias não vão se conquistar sozinhas!";
                }
            }
            #endregion

            #region ArqUrb
            if (principal.BatalhaAtual == 1)
            {
                if (dialogoAtual == 1)
                {
                    pbPersonagem.Image = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "KoalaBoy", "KoalaBoyFalando1.png"));
                    panelBoxDialogo.BackgroundImage = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "TelaBatalha", "BoxKoalaBoy.png"));
                    lblDialogo.Text = "Chega de brincar de arquiteto, seu Bafo de Leite! Vim capturar seu fragmento ESPECIAL";
                }
                else if (dialogoAtual == 2)
                {
                    pbPersonagem.Image = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "KoalaBoy", "KoalaBoyFalando1.png"));
                    panelBoxDialogo.BackgroundImage = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "TelaBatalha", "BoxKoalaBoy.png"));
                    lblDialogo.Text = "Vamos batalhar aqui e agora!";
                }
                else if (dialogoAtual == 3)
                {
                    pbPersonagem.Image = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "ArqUrb", "GatoFalando.png"));
                    panelBoxDialogo.BackgroundImage = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "TelaBatalha", "BoxGato.png"));
                    lblDialogo.Text = "Tenho um projeto de arranhador atrasado por sua culpa. Vamos acabar com isso de uma vez - Miau!";
                }
                else if (dialogoAtual == 4)
                {
                    pbPersonagem.Image = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "Engenharia", "UrubuFalando1.png"));
                    panelBoxDialogo.BackgroundImage = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "TelaBatalha", "BoxUrubu.png"));
                    lblDialogo.Text = "Fique esperto, KoalaBoy! Esse adversário utiliza a SOMA em suas batalhas. Não deixe os problemas se acumularem!";
                }
                // KoalaBoy Venceu
                else if (dialogoAtual == 5)
                {
                    pbPersonagem.Image = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "KoalaBoy", "KoalaBoyFalando1.png"));
                    panelBoxDialogo.BackgroundImage = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "TelaBatalha", "BoxKoalaBoy.png"));
                    lblDialogo.Text = "Parece que seu projeto de vitória desabou! Passa o fragmento e volta pro lixão, seu arquiteto de meia-tigela!";
                }
                else if (dialogoAtual == 6)
                {
                    pbPersonagem.Image = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "ArqUrb", "GatoFalandoDerrotado.png"));
                    panelBoxDialogo.BackgroundImage = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "TelaBatalha", "BoxGatoDerrotado.png"));
                    lblDialogo.Text = "Isso não vai ficar assim! Ainda tenho mais 4 vidas e muitos projetos pela frente! Você vai se arrepender disso - Miau!";
                }
                // KoalaBoy Perdeu
                else if (dialogoAtual == 7)
                {
                    pbPersonagem.Image = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "ArqUrb", "GatoFalando.png"));
                    panelBoxDialogo.BackgroundImage = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "TelaBatalha", "BoxGato.png"));
                    lblDialogo.Text = "Sua derrota já estava na planta baixa! Volta quando aprender a construir uma estratégia decente, seu Koala mané - Miau!";
                }
                else if (dialogoAtual == 8)
                {
                    pbPersonagem.Image = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "KoalaBoy", "KoalaBoyFalandoDerrotado.png"));
                    panelBoxDialogo.BackgroundImage = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "TelaBatalha", "BoxKoalaBoyDerrotado.png"));
                    lblDialogo.Text = "Pode comemorar, seu gato de obra! Na próxima, quem vai sair demolido é você!";
                }
            }
            #endregion

            #region Biomed
            if (principal.BatalhaAtual == 2)
            {
                if (dialogoAtual == 1)
                {
                    pbPersonagem.Image = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "Biomed", "LoboFalando.png"));
                    panelBoxDialogo.BackgroundImage = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "TelaBatalha", "BoxLobo.png"));
                    lblDialogo.Text = "Ora, ora... o que temos aqui? Uma cobaia ambulante! Perfeito, estava mesmo precisando de material para meus experimentos";
                }
                else if (dialogoAtual == 2)
                {
                    pbPersonagem.Image = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "KoalaBoy", "KoalaBoyFalando1.png"));
                    panelBoxDialogo.BackgroundImage = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "TelaBatalha", "BoxKoalaBoy.png"));
                    lblDialogo.Text = "Não sou sua cobaia coisa nenhuma! Passa logo esse fragmento ESPECIAL pra cá";
                }
                else if (dialogoAtual == 3)
                {
                    pbPersonagem.Image = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "Biomed", "LoboFalando.png"));
                    panelBoxDialogo.BackgroundImage = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "TelaBatalha", "BoxLobo.png"));
                    lblDialogo.Text = "Pelo visto, sua insolência não tem cura! Vou coletar uma amostra da sua derrota para estudar no laboratório";
                }
                else if (dialogoAtual == 4)
                {
                    pbPersonagem.Image = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "Engenharia", "UrubuFalando1.png"));
                    panelBoxDialogo.BackgroundImage = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "TelaBatalha", "BoxUrubu.png"));
                    lblDialogo.Text = "Atenção, KoalaBoy! Esse lobo domina a SUBTRAÇÃO. Cuidado para não sair com menos hemácias do que entrou!";
                }
                // KoalaBoy Venceu
                else if (dialogoAtual == 5)
                {
                    pbPersonagem.Image = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "KoalaBoy", "KoalaBoyFalando1.png"));
                    panelBoxDialogo.BackgroundImage = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "TelaBatalha", "BoxKoalaBoy.png"));
                    lblDialogo.Text = "Seu diagnóstico estava errado, doutor pulguento! Quem precisava de tratamento era você!";
                }
                else if (dialogoAtual == 6)
                {
                    pbPersonagem.Image = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "Biomed", "LoboFalandoDerrotado.png"));
                    panelBoxDialogo.BackgroundImage = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "TelaBatalha", "BoxLoboDerrotado.png"));
                    lblDialogo.Text = "Isso desafia todas as leis da ciência! Preciso analisar esses resultados imediatamente!";
                }
                // KoalaBoy Perdeu
                else if (dialogoAtual == 7)
                {
                    pbPersonagem.Image = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "Biomed", "LoboFalando.png"));
                    panelBoxDialogo.BackgroundImage = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "TelaBatalha", "BoxLobo.png"));
                    lblDialogo.Text = "Seu exame deu positivo para incompetência! Recomendo repouso e distância do meu laboratório!";
                }
                else if (dialogoAtual == 8)
                {
                    pbPersonagem.Image = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "KoalaBoy", "KoalaBoyFalandoDerrotado.png"));
                    panelBoxDialogo.BackgroundImage = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "TelaBatalha", "BoxKoalaBoyDerrotado.png"));
                    lblDialogo.Text = "Pode guardar esse diagnóstico. Na próxima vou voltar para provar que você está errado!";
                }
            }
            #endregion

            #region Direito
            if (principal.BatalhaAtual == 3)
            {
                if (dialogoAtual == 1)
                {
                    pbPersonagem.Image = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "KoalaBoy", "KoalaBoyFalando1.png"));
                    panelBoxDialogo.BackgroundImage = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "TelaBatalha", "BoxKoalaBoy.png"));
                    lblDialogo.Text = "Nem o DIABO vai te defender hoje! Vim confiscar seu fragmento ESPECIAL";
                }
                else if (dialogoAtual == 2)
                {
                    pbPersonagem.Image = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "Direito", "RaposaFalando.png"));
                    panelBoxDialogo.BackgroundImage = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "TelaBatalha", "BoxRaposa.png"));
                    lblDialogo.Text = "Confiscar?! Sem mandado judicial?! Isso é um absurdo! Vou resolver esse caso na base da porrada!";
                }
                else if (dialogoAtual == 3)
                {
                    pbPersonagem.Image = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "KoalaBoy", "KoalaBoyFalando1.png"));
                    panelBoxDialogo.BackgroundImage = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "TelaBatalha", "BoxKoalaBoy.png"));
                    lblDialogo.Text = "Então chega de conversa! Te vejo no tribunal";
                }
                else if (dialogoAtual == 4)
                {
                    pbPersonagem.Image = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "Engenharia", "UrubuFalando1.png"));
                    panelBoxDialogo.BackgroundImage = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "TelaBatalha", "BoxUrubu.png"));
                    lblDialogo.Text = "Cuidado, KoalaBoy! Essa raposa usa a MULTIPLICAÇÃO em suas batalhas. Um pequeno erro pode multiplicar seus problemas!";
                }
                // KoalaBoy Venceu
                else if (dialogoAtual == 5)
                {
                    pbPersonagem.Image = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "KoalaBoy", "KoalaBoyFalando1.png"));
                    panelBoxDialogo.BackgroundImage = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "TelaBatalha", "BoxKoalaBoy.png"));
                    lblDialogo.Text = "Parece que sua defesa não foi tão boa assim, seu engravatado de araque. Passa o fragmento!";
                }
                else if (dialogoAtual == 6)
                {
                    pbPersonagem.Image = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "Direito", "RaposaFalandoDerrotada.png"));
                    panelBoxDialogo.BackgroundImage = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "TelaBatalha", "BoxRaposaDerrotada.png"));
                    lblDialogo.Text = "IMPOSSÍVEL! Exijo uma revisão dessa sentença! Meu advogado vai falar com o seu...";
                }
                // KoalaBoy Perdeu
                else if (dialogoAtual == 7)
                {
                    pbPersonagem.Image = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "Direito", "RaposaFalando.png"));
                    panelBoxDialogo.BackgroundImage = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "TelaBatalha", "BoxRaposa.png"));
                    lblDialogo.Text = "HA! Nem com mil recursos judiciais você conseguiria escapar dessa derrota!";
                }
                else if (dialogoAtual == 8)
                {
                    pbPersonagem.Image = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "KoalaBoy", "KoalaBoyFalandoDerrotado.png"));
                    panelBoxDialogo.BackgroundImage = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "TelaBatalha", "BoxKoalaBoyDerrotado.png"));
                    lblDialogo.Text = "Isso foi um julgamento injusto! Eu ainda vou voltar para acertar as contas!";
                }
            }
            #endregion 

            #region Educação Física
            if (principal.BatalhaAtual == 4)
            {
                if (dialogoAtual == 1)
                {
                    pbPersonagem.Image = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "Fefesp", "TutubaFalando.png"));
                    panelBoxDialogo.BackgroundImage = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "TelaBatalha", "BoxTutuba.png"));
                    lblDialogo.Text = "Olha só o que a maré me trouxe! Já devorei peixes maiores que você no café da manhã";
                    
                }
                else if (dialogoAtual == 2)
                {
                    pbPersonagem.Image = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "Fefesp", "TutubaFalando.png"));
                    panelBoxDialogo.BackgroundImage = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "TelaBatalha", "BoxTutuba.png"));
                    lblDialogo.Text = "Até uma sardinha tem mais força que você, HAHA! Seu koala frangote!";
                }
                else if (dialogoAtual == 3)
                {
                    pbPersonagem.Image = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "KoalaBoy", "KoalaBoyFalando1.png"));
                    panelBoxDialogo.BackgroundImage = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "TelaBatalha", "BoxKoalaBoy.png"));
                    lblDialogo.Text = "Chega de falar besteira, seu atum anabolizado. Vim pescar seu fragmento ESPECIAL!";
                }
                else if (dialogoAtual == 4)
                {
                    pbPersonagem.Image = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "Engenharia", "UrubuFalando1.png"));
                    panelBoxDialogo.BackgroundImage = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "TelaBatalha", "BoxUrubu.png"));
                    lblDialogo.Text = "Fique esperto, KoalaBoy! Esse brutamontes utiliza a DIVISÃO em suas batalhas. Não deixe ele dividir suas chances de vitória!";
                }
                // KoalaBoy Venceu
                else if (dialogoAtual == 5)
                {
                    pbPersonagem.Image = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "KoalaBoy", "KoalaBoyFalando1.png"));
                    panelBoxDialogo.BackgroundImage = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "TelaBatalha", "BoxKoalaBoy.png"));
                    lblDialogo.Text = "Parece que esses músculos são só de enfeite! Passa o fragmento, seu saco de whey";
                }
                else if (dialogoAtual == 6)
                {
                    pbPersonagem.Image = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "Fefesp", "TutubaFalandoDerrotado.png"));
                    panelBoxDialogo.BackgroundImage = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "TelaBatalha", "BoxTutubaDerrotado.png"));
                    lblDialogo.Text = "MAS QUE VERGONHA! Treinei peito, costas e pernas pra isso?! Minha reputação foi por água abaixo";
                }
                // KoalaBoy Perdeu
                else if (dialogoAtual == 7)
                {
                    pbPersonagem.Image = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "Fefesp", "TutubaFalando.png"));
                    panelBoxDialogo.BackgroundImage = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "TelaBatalha", "BoxTutuba.png"));
                    lblDialogo.Text = "Isso foi tão fácil que nem contou como cardio! Volta quando tiver algum músculo HAHA!";
                }
                else if (dialogoAtual == 8)
                {
                    pbPersonagem.Image = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "KoalaBoy", "KoalaBoyFalandoDerrotado.png"));
                    panelBoxDialogo.BackgroundImage = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "TelaBatalha", "BoxKoalaBoyDerrotado.png"));
                    lblDialogo.Text = "Pode comemorar enquanto pode, seu peixe de academia! Eu vou voltar mais forte";
                }
            }
            #endregion

            #region PubliPropag
            if (principal.BatalhaAtual == 5)
            {
                if (dialogoAtual == 1)
                {
                    pbPersonagem.Image = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "KoalaBoy", "KoalaBoyFalando1.png"));
                    panelBoxDialogo.BackgroundImage = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "TelaBatalha", "BoxKoalaBoy.png"));
                    lblDialogo.Text = "Tenho que admitir, seus quadros são incríveis! Até que você tem um bom gosto";
                }
                else if (dialogoAtual == 2)
                {
                    pbPersonagem.Image = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "KoalaBoy", "KoalaBoyFalando1.png"));
                    panelBoxDialogo.BackgroundImage = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "TelaBatalha", "BoxKoalaBoy.png"));
                    lblDialogo.Text = "Mas não vim aqui pra admirar arte. Vim levar seu fragmento ESPECIAL, Macaca!";
                }
                else if (dialogoAtual == 3)
                {
                    pbPersonagem.Image = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "PubliPropag", "MacacaFalando.png"));
                    panelBoxDialogo.BackgroundImage = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "TelaBatalha", "BoxMacaca.png"));
                    lblDialogo.Text = "A arte imita a vida meu pequeno gafanhoto, e sua derrota sera minha mais proxima obra-prima, Koalaboy! ";
                }
                else if (dialogoAtual == 4)
                {
                    pbPersonagem.Image = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "Engenharia", "UrubuFalando1.png"));
                    panelBoxDialogo.BackgroundImage = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "TelaBatalha", "BoxUrubu.png"));
                    lblDialogo.Text = "Não se distraia com macaquices, KoalaBoy! Esse gorila domina a PORCENTAGEM. Não deixe ele elevar sua derrota a 100%!";
                }
                // KoalaBoy Venceu
                else if (dialogoAtual == 5)
                {
                    pbPersonagem.Image = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "KoalaBoy", "KoalaBoyFalando.png"));
                    panelBoxDialogo.BackgroundImage = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "TelaBatalha", "BoxKoalaBoy.png"));
                    lblDialogo.Text = "Parece que sua obra-prima foi um fracasso! Passa o fragmento pra cá e volte pra sua jaula, seu Picasso de zoológico!";
                }
                else if (dialogoAtual == 6)
                {
                    pbPersonagem.Image = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "PubliPropag", "MacacaFalandoDerrotada.png"));
                    panelBoxDialogo.BackgroundImage = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "TelaBatalha", "BoxMacacaFerida.png"));
                    lblDialogo.Text = "Minha perfeição... destruída por um koala sem o menor senso artístico!? Que tragédia";
                }
                // KoalaBoy Perdeu
                else if (dialogoAtual == 7)
                {
                    pbPersonagem.Image = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "PubliPropag", "MacacaFalando.png"));
                    panelBoxDialogo.BackgroundImage = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "TelaBatalha", "BoxMacaca.png"));
                    lblDialogo.Text = "Sua derrota foi uma verdadeira obra de arte! Pena que você não tenha bom gosto para apreciá-la!";
                }
                else if (dialogoAtual == 8)
                {
                    pbPersonagem.Image = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "KoalaBoy", "KoalaBoyFalandoDerrotado.png"));
                    panelBoxDialogo.BackgroundImage = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "TelaBatalha", "BoxKoalaBoyDerrotado.png"));
                    lblDialogo.Text = "Não se ache Da Vinci só porque você venceu. Sua próxima obra vai ser um retrato de sua derrota!";
                }
            }
            #endregion

            #region Comércio Exterior
            if (principal.BatalhaAtual == 6)
            {
                if (dialogoAtual == 1)
                {
                    pbPersonagem.Image = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "Comex", "PanteraFalando.png"));
                    panelBoxDialogo.BackgroundImage = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "TelaBatalha", "BoxPantera.png"));
                    lblDialogo.Text = "Excuse me?! Quem deixou esse classe econômica entrar aqui? Você está contaminando meu ambiente!!";
                }
                else if (dialogoAtual == 2)
                {
                    pbPersonagem.Image = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "KoalaBoy", "KoalaBoyFalando1.png"));
                    panelBoxDialogo.BackgroundImage = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "TelaBatalha", "BoxKoalaBoy.png"));
                    lblDialogo.Text = "Baixa essa bola, filhinho de papai! Vim levar seu fragmento ESPECIAL, não pedir visto!";
                }
                else if (dialogoAtual == 3)
                {
                    pbPersonagem.Image = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "Comex", "PanteraFalando.png"));
                    panelBoxDialogo.BackgroundImage = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "TelaBatalha", "BoxPantera.png"));
                    lblDialogo.Text = "Que lástima! Além da ralé, é mal-educado! Vou te deportar diretamente para de onde veio!";
                }
                else if (dialogoAtual == 4)
                {
                    pbPersonagem.Image = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "Engenharia", "UrubuFalando1.png"));
                    panelBoxDialogo.BackgroundImage = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "TelaBatalha", "BoxUrubu.png"));
                    lblDialogo.Text = "Fique esperto com as equações dele, KoalaBoy! Ele domina a arte dos OPERADORES COMBINADOS. Não perca a viagem!";
                }
                // KoalaBoy Venceu
                else if (dialogoAtual == 5)
                {
                    pbPersonagem.Image = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "KoalaBoy", "KoalaBoyFalando1.png"));
                    panelBoxDialogo.BackgroundImage = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "TelaBatalha", "BoxKoalaBoy.png"));
                    lblDialogo.Text = "Parece que sua primeira classe não te salvou! Me entregue agora o seu fragmento";
                }
                else if (dialogoAtual == 6)
                {
                    pbPersonagem.Image = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "Comex", "PanteraFalandoDerrotada.png"));
                    panelBoxDialogo.BackgroundImage = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "TelaBatalha", "BoxPanteraDerrotada.png"));
                    lblDialogo.Text = "Unbelievable! Perder para um koala sem pedigree?! Vou exigir o reembolso dessa batalha!";
                }
                // KoalaBoy Perdeu
                else if (dialogoAtual == 7)
                {
                    pbPersonagem.Image = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "Comex", "PanteraFalando.png"));
                    panelBoxDialogo.BackgroundImage = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "TelaBatalha", "BoxPanteraDerrotada.png"));
                    lblDialogo.Text = "Sorry, my Darling! Sua tentativa de vitória foi recusada por falta de classe!";
                }
                else if (dialogoAtual == 8)
                {
                    pbPersonagem.Image = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "KoalaBoy", "KoalaBoyFalandoDerrotado.png"));
                    panelBoxDialogo.BackgroundImage = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "TelaBatalha", "BoxKoalaBoyDerrotado.png"));
                    lblDialogo.Text = "Pode poupar esse seu inglês de aeroporto! Na próxima, quem vai ser despachado é você!";
                }
            }
            #endregion

            #region Engenharia
            if (principal.BatalhaAtual == 7)
            {
                if (dialogoAtual == 1)
                {
                    pbPersonagem.Image = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "KoalaBoy", "KoalaBoyFalando1.png"));
                    panelBoxDialogo.BackgroundImage = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "TelaBatalha", "BoxKoalaBoy.png"));
                    lblDialogo.Text = "Vim aqui para capturar o seu fragmento ESPECIAL, seu Bafo de Leite!";
                }
                else if (dialogoAtual == 2)
                {
                    pbPersonagem.Image = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "KoalaBoy", "KoalaBoyFalando1.png"));
                    panelBoxDialogo.BackgroundImage = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "TelaBatalha", "BoxKoalaBoy.png"));
                    lblDialogo.Text = "Vamos batalhar aqui e agora!";
                }
                else if (dialogoAtual == 3)
                {
                    pbPersonagem.Image = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "ArqUrb", "GatoFalando.png"));
                    panelBoxDialogo.BackgroundImage = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "TelaBatalha", "BoxGato.png"));
                    lblDialogo.Text = "Tenho um projeto de arranhador atrasado por sua culpa, vamos acabar com isso de uma vez - Miau!";
                }
                else if (dialogoAtual == 4)
                {
                    pbPersonagem.Image = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "Engenharia", "UrubuFalando1.png"));
                    panelBoxDialogo.BackgroundImage = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "TelaBatalha", "BoxUrubu.png"));
                    lblDialogo.Text = "Fique esperto com o operador matemático dele, KoalaBoy. Ele utiliza a SOMA em suas batalhas";
                }
                // KoalaBoy Venceu
                else if (dialogoAtual == 5)
                {
                    pbPersonagem.Image = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "KoalaBoy", "KoalaBoyFalando1.png"));
                    panelBoxDialogo.BackgroundImage = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "TelaBatalha", "BoxKoalaBoy.png"));
                    lblDialogo.Text = "Eu venci, seu fragmento agora é meu. Volte para o lixão de onde você veio";
                }
                else if (dialogoAtual == 6)
                {
                    pbPersonagem.Image = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "ArqUrb", "GatoFalandoDerrotado.png"));
                    panelBoxDialogo.BackgroundImage = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "TelaBatalha", "BoxGatoDerrotado.png"));
                    lblDialogo.Text = "Isso não ficará assim, ainda tenho mais 4 vidas, voltarei para me vingar - Miau!";
                }
                // KoalaBoy Perdeu
                else if (dialogoAtual == 7)
                {
                    pbPersonagem.Image = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "ArqUrb", "GatoFalando.png"));
                    panelBoxDialogo.BackgroundImage = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "TelaBatalha", "BoxGato.png"));
                    lblDialogo.Text = "Você não é páreo para me derrotar. Tente novamente seu Koala mané - Miau!";
                }
                else if (dialogoAtual == 8)
                {
                    pbPersonagem.Image = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "KoalaBoy", "KoalaBoyFalandoDerrotado.png"));
                    panelBoxDialogo.BackgroundImage = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "TelaBatalha", "BoxKoalaBoyDerrotado.png"));
                    lblDialogo.Text = "Eu voltarei e me vingarei de você!";
                }
            }
            #endregion
        }
        #endregion

        #region Batalha Encerrada
        private bool batalhaEncerrada = false;
        public bool koalaVenceu;
        public async Task EncerrarBatalha (bool Koalavenceu)
        {
            batalhaEncerrada = true;
            koalaVenceu = Koalavenceu;

            #region ArqUrb
            if (principal.BatalhaAtual == 1)
            {
                // Koala venceu
                if (Koalavenceu == true)
                {
                    dialogoAtual = 5;
                    Dialogo();
                }

                // Gato venceu
                else if (Koalavenceu == false)
                {
                    dialogoAtual = 7;
                    Dialogo();
                }
            }
            #endregion

            #region Biomed
            else if (principal.BatalhaAtual == 2)
            {
                // Koala venceu
                if (Koalavenceu == true)
                {
                    dialogoAtual = 5;
                    Dialogo();
                }

                // Lobo venceu
                else if (Koalavenceu == false)
                {
                    dialogoAtual = 7;
                    Dialogo();
                }
            }
            #endregion

            #region Direito
            else if (principal.BatalhaAtual == 3)
            {
                // Koala venceu
                if (Koalavenceu == true)
                {
                    dialogoAtual = 5;
                    Dialogo();
                }

                // Raposa venceu
                else if (Koalavenceu == false)
                {
                    dialogoAtual = 7;
                    Dialogo();
                }
            }
            #endregion

            #region Fefesp
            else if (principal.BatalhaAtual == 4)
            {
                // Koala venceu
                if (Koalavenceu == true)
                {
                    dialogoAtual = 5;
                    Dialogo();
                }

                // Tutuba venceu
                else if (Koalavenceu == false)
                {
                    dialogoAtual = 7;
                    Dialogo();
                }
            }
            #endregion

            #region PubliPropag
            else if (principal.BatalhaAtual == 5)
            {
                // Koala venceu
                if (Koalavenceu == true)
                {
                    dialogoAtual = 5;
                    Dialogo();
                }

                // Macaca venceu
                else if (Koalavenceu == false)
                {
                    dialogoAtual = 7;
                    Dialogo();
                }
            }
            #endregion

            #region Comex
            else if (principal.BatalhaAtual == 6)
            {
                // Koala venceu
                if (Koalavenceu == true)
                {
                    dialogoAtual = 5;
                    Dialogo();
                }

                // Pantera venceu
                else if (Koalavenceu == false)
                {
                    dialogoAtual = 7;
                    Dialogo();
                }
            }
            #endregion

            #region Engenharia
            else if (principal.BatalhaAtual == 7)
            {
                // Koala venceu
                if (Koalavenceu == true)
                {
                    dialogoAtual = 5;
                    Dialogo();
                }

                // Urubu venceu
                else if (Koalavenceu == false)
                {
                    dialogoAtual = 7;
                    Dialogo();
                }
            }
            #endregion
        }
        #endregion

        #region Iniciar Batalha
        private async Task IniciarBatalha()
        {
            ConfigurarCenario();

            panelDialogo.Visible = false;
            pbKoalaBoy.Visible = true;
            pbInimigo.Visible = true;
            pb321Battle.Visible = true;

            pb321Battle.Image = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "TelaBatalha", "3.png"));
            await Task.Delay(1000);
            pb321Battle.Image = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "TelaBatalha", "2.png"));
            await Task.Delay(1000);
            pb321Battle.Image = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "TelaBatalha", "1.png"));
            await Task.Delay(1000);
            pb321Battle.Image = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "TelaBatalha", "Battle.png"));
            await Task.Delay(1000);
            pb321Battle.Visible = false;


            principal.MostrarTelaBatalhaPerguntas();
        }
        #endregion

        #region AnimaçãoBotãoSkip
        private int larguraAlvoSkip = 59;
        private int alturaAlvoSkip = 62;
        private bool mouseEmCimaSkip = false;

        // MOUSE ENTER
        private void pbBotaoStart_MouseEnter(object sender, EventArgs e)
        {
            mouseEmCimaSkip = true;

            larguraAlvoSkip = 65;
            alturaAlvoSkip = 68;

            timerBotaoSkip.Start();
        }

        // MOUSE LEAVE
        private void pbBotaoStart_MouseLeave(object sender, EventArgs e)
        {
            mouseEmCimaSkip = false;

            larguraAlvoSkip = 59;
            alturaAlvoSkip = 62;

            timerBotaoSkip.Start();
        }

        // MOUSE DOWN
        private void pbBotaoStart_MouseDown(object sender, MouseEventArgs e)
        {
            larguraAlvoSkip = 55;
            alturaAlvoSkip = 58;

            timerBotaoSkip.Start();
        }

        // MOUSE UP
        private void pbBotaoStart_MouseUp(object sender, MouseEventArgs e)
        {
            if (mouseEmCimaSkip == true)
            {
                larguraAlvoSkip = 65;
                alturaAlvoSkip = 68;
            }
            else
            {
                larguraAlvoSkip = 59;
                alturaAlvoSkip = 62;
            }

            timerBotaoSkip.Start();
        }

        // TIMER
        private void timerBotaoSkip_Tick(object sender, EventArgs e)
        {
            // largura

            if (pbBotaoSkip.Width < larguraAlvoSkip)
            {
                pbBotaoSkip.Width += 2;
                pbBotaoSkip.Left -= 1;
            }
            else if (pbBotaoSkip.Width > larguraAlvoSkip)
            {
                pbBotaoSkip.Width -= 2;
                pbBotaoSkip.Left += 1;
            }

            // altura

            if (pbBotaoSkip.Height < alturaAlvoSkip)
            {
                pbBotaoSkip.Height += 2;
                pbBotaoSkip.Top -= 1;
            }
            else if (pbBotaoSkip.Height > alturaAlvoSkip)
            {
                pbBotaoSkip.Height -= 2;
                pbBotaoSkip.Top += 1;
            }

            if (pbBotaoSkip.Width == larguraAlvoSkip && pbBotaoSkip.Height == alturaAlvoSkip)
            {
                timerBotaoSkip.Stop();
            }
        }

        #endregion

        #region Botão Skip
        private async void pbBotaoSkip_Click(object sender, EventArgs e)
        {
            dialogoAtual++;
            if (principal.BatalhaAtual == 0 && dialogoAtual == 17)
            {
                principal.MostrarTelaHistoria();
            }
            else if (principal.BatalhaAtual == 0 && dialogoAtual > 30)
            {
                principal.MostrarTelaLobby();
            }
            else if (batalhaEncerrada == false && principal.BatalhaAtual > 0 && dialogoAtual > 4)
            {
                await IniciarBatalha();
                return;
            }
            else if (batalhaEncerrada == true && koalaVenceu == true && dialogoAtual > 6)
            {
                principal.MostrarTelaResultados();
                return;
            }
            else if (batalhaEncerrada == true && koalaVenceu == false && dialogoAtual > 8)
            {
                principal.MostrarTelaResultados();
                return;
            }
            Dialogo();
        }
        #endregion

        #region Configura Cenario
        public void ConfigurarCenario()
        {
            BackgroundImage = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", pastaInimigo, cenario));

            pbKoalaBoy.Image = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "KoalaBoy", "KoalaBoy3.png"));

            pbInimigo.Image = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", pastaInimigo, imagemNormal));

            pbKoalaBoy.SizeMode = PictureBoxSizeMode.StretchImage;

            // TelaHistoria
            if (principal.BatalhaAtual == 0)
            {
                
                pbKoalaBoy.Location = new Point(864, 256);
                pbKoalaBoy.SizeMode = PictureBoxSizeMode.Zoom;

                pbInimigo.Size = new Size(220, 335);
                pbInimigo.Location = new Point(630, 256);

                pbKoalaBoy.Image = Image.FromFile(Path.Combine(AppContext.BaseDirectory, "Imagens", "TelaHistoria", "KoalaBoyFrameFinal.png"));
            }
            // ArqUrb
            if (principal.BatalhaAtual == 1)
            {
                pbKoalaBoy.Location = new Point(120, 252);
                pbInimigo.Location = new Point(905, 252);
            }
            // Biomed
            else if (principal.BatalhaAtual == 2)
            {
                pbKoalaBoy.Location = new Point(120, 252);
                pbInimigo.Location = new Point(905, 252);
            }
            // Direito
            else if (principal.BatalhaAtual == 3)
            {
                pbKoalaBoy.Location = new Point(120, 225);
                pbInimigo.Location = new Point(905, 225);
            }
            // Educação Física
            else if (principal.BatalhaAtual == 4)
            {
                pbKoalaBoy.Location = new Point(120, 252);
                pbInimigo.Location = new Point(905, 252);
            }
            // Artes e Comunicação
            else if (principal.BatalhaAtual == 5)
            {
                pbKoalaBoy.Location = new Point(120, 352);
                pbInimigo.Location = new Point(905, 352);
            }
            // Comércio Exterior
            else if (principal.BatalhaAtual == 6)
            {
                pbKoalaBoy.Location = new Point(120, 300);
                pbInimigo.Location = new Point(905, 300);
            }
            // Engenharia
            else if (principal.BatalhaAtual == 7)
            {
                pbKoalaBoy.Location = new Point(120, 252);
                pbInimigo.Location = new Point(905, 252);
            }
        }

        #region Imagens Inimigo
        private string pastaInimigo;
        private string cenario;
        private string cenarioDesfocado;
        private string imagemNormal;

        private void DefinirImagensInimigo()
        {
            // TelaHistoria
            if (principal.BatalhaAtual == 0)
            {
                pastaInimigo = "TelaHistoria";
                cenario = "Biblioteca.png";
                cenarioDesfocado = "BibliotecaDesfocada.png";
                imagemNormal = "UrubuFrameFinal.png";
            }
            // ArqUrb
            if (principal.BatalhaAtual == 1)
            {
                pastaInimigo = "ArqUrb";
                cenario = "ArqUrb.png";
                cenarioDesfocado = "ArqUrbDesfocado.png";
                imagemNormal = "Gato3.png";
            }
            // Biomed
            else if (principal.BatalhaAtual == 2)
            {
                pastaInimigo = "Biomed";
                cenario = "Biomed.png";
                cenarioDesfocado = "BiomedDesfocado.png";
                imagemNormal = "Lobo3.png";
            }
            // Direito
            else if (principal.BatalhaAtual == 3)
            {
                pastaInimigo = "Direito";
                cenario = "Direito.png";
                cenarioDesfocado = "DireitoDesfocado.png";
                imagemNormal = "Raposa3.png";
            }
            // Fefesp
            else if (principal.BatalhaAtual == 4)
            {
                pastaInimigo = "Fefesp";
                cenario = "Fefesp.png";
                cenarioDesfocado = "FefespDesfocado.png";
                imagemNormal = "Tutuba3.png";

            }
            // PubliPropag
            else if (principal.BatalhaAtual == 5)
            {
                pastaInimigo = "PubliPropag";
                cenario = "PubliPropag.png";
                cenarioDesfocado = "PubliPropagDesfocado.png";
                imagemNormal = "Macaca3.png";
            }
            // Comex
            else if (principal.BatalhaAtual == 6)
            {
                pastaInimigo = "Comex";
                cenario = "Comex.png";
                cenarioDesfocado = "ComexDesfocado.png";
                imagemNormal = "Pantera3.png";
            }
            // Engenharia
            else if (principal.BatalhaAtual == 7)
            {
                pastaInimigo = "Engenharia";
                cenario = "Engenharia.png";
                cenarioDesfocado = "EngenhariaDesfocado.png";
                imagemNormal = "Urubu8.png";
            }
        }
        #endregion

        private void TelaBatalhaDialogo_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                pbKoalaBoy.Visible = false;
                pbInimigo.Visible = false;
                Dialogo();
                panelDialogo.Visible = true;
            }
        }
        #endregion
    }
}
