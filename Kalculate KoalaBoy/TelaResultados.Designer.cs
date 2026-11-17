namespace Kalculate_KoalaBoy
{
    partial class TelaResultados
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaResultados));
            this.pbKoalaBoy = new System.Windows.Forms.PictureBox();
            this.pbInimigo = new System.Windows.Forms.PictureBox();
            this.pbFragmento = new System.Windows.Forms.PictureBox();
            this.timerAnimacao = new System.Windows.Forms.Timer(this.components);
            this.panelResultados = new System.Windows.Forms.Panel();
            this.pbBotaoLobby = new System.Windows.Forms.PictureBox();
            this.lblPontuacaoValor = new System.Windows.Forms.Label();
            this.lblAcertosValor = new System.Windows.Forms.Label();
            this.pbNota = new System.Windows.Forms.PictureBox();
            this.lblNota = new System.Windows.Forms.Label();
            this.pbResultado = new System.Windows.Forms.PictureBox();
            this.lblInimigoBatalha = new System.Windows.Forms.Label();
            this.pbInimigoResultado = new System.Windows.Forms.PictureBox();
            this.lblInimigo = new System.Windows.Forms.Label();
            this.lblAcertos = new System.Windows.Forms.Label();
            this.lblPontuacao = new System.Windows.Forms.Label();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.pbKoalaBoyUrubu = new System.Windows.Forms.PictureBox();
            this.timerBotaoLobby = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbKoalaBoy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbInimigo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFragmento)).BeginInit();
            this.panelResultados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBotaoLobby)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNota)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbResultado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbInimigoResultado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbKoalaBoyUrubu)).BeginInit();
            this.SuspendLayout();
            // 
            // pbKoalaBoy
            // 
            this.pbKoalaBoy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pbKoalaBoy.BackColor = System.Drawing.Color.Transparent;
            this.pbKoalaBoy.Image = ((System.Drawing.Image)(resources.GetObject("pbKoalaBoy.Image")));
            this.pbKoalaBoy.Location = new System.Drawing.Point(120, 252);
            this.pbKoalaBoy.Margin = new System.Windows.Forms.Padding(2);
            this.pbKoalaBoy.Name = "pbKoalaBoy";
            this.pbKoalaBoy.Size = new System.Drawing.Size(220, 335);
            this.pbKoalaBoy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbKoalaBoy.TabIndex = 7;
            this.pbKoalaBoy.TabStop = false;
            // 
            // pbInimigo
            // 
            this.pbInimigo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pbInimigo.BackColor = System.Drawing.Color.Transparent;
            this.pbInimigo.Image = ((System.Drawing.Image)(resources.GetObject("pbInimigo.Image")));
            this.pbInimigo.Location = new System.Drawing.Point(905, 252);
            this.pbInimigo.Margin = new System.Windows.Forms.Padding(2);
            this.pbInimigo.Name = "pbInimigo";
            this.pbInimigo.Size = new System.Drawing.Size(255, 335);
            this.pbInimigo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbInimigo.TabIndex = 8;
            this.pbInimigo.TabStop = false;
            // 
            // pbFragmento
            // 
            this.pbFragmento.BackColor = System.Drawing.Color.Transparent;
            this.pbFragmento.Image = ((System.Drawing.Image)(resources.GetObject("pbFragmento.Image")));
            this.pbFragmento.Location = new System.Drawing.Point(748, 354);
            this.pbFragmento.Name = "pbFragmento";
            this.pbFragmento.Size = new System.Drawing.Size(65, 84);
            this.pbFragmento.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFragmento.TabIndex = 10;
            this.pbFragmento.TabStop = false;
            // 
            // timerAnimacao
            // 
            this.timerAnimacao.Interval = 15;
            this.timerAnimacao.Tick += new System.EventHandler(this.timerAnimacao_Tick);
            // 
            // panelResultados
            // 
            this.panelResultados.BackColor = System.Drawing.Color.Transparent;
            this.panelResultados.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelResultados.BackgroundImage")));
            this.panelResultados.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelResultados.Controls.Add(this.pbBotaoLobby);
            this.panelResultados.Controls.Add(this.lblPontuacaoValor);
            this.panelResultados.Controls.Add(this.lblAcertosValor);
            this.panelResultados.Controls.Add(this.pbNota);
            this.panelResultados.Controls.Add(this.lblNota);
            this.panelResultados.Controls.Add(this.pbResultado);
            this.panelResultados.Controls.Add(this.lblInimigoBatalha);
            this.panelResultados.Controls.Add(this.pbInimigoResultado);
            this.panelResultados.Controls.Add(this.lblInimigo);
            this.panelResultados.Controls.Add(this.lblAcertos);
            this.panelResultados.Controls.Add(this.lblPontuacao);
            this.panelResultados.Controls.Add(this.pbLogo);
            this.panelResultados.Controls.Add(this.pbKoalaBoyUrubu);
            this.panelResultados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelResultados.Location = new System.Drawing.Point(0, 0);
            this.panelResultados.Name = "panelResultados";
            this.panelResultados.Size = new System.Drawing.Size(1280, 720);
            this.panelResultados.TabIndex = 11;
            this.panelResultados.Visible = false;
            // 
            // pbBotaoLobby
            // 
            this.pbBotaoLobby.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbBotaoLobby.Image = ((System.Drawing.Image)(resources.GetObject("pbBotaoLobby.Image")));
            this.pbBotaoLobby.Location = new System.Drawing.Point(655, 546);
            this.pbBotaoLobby.Name = "pbBotaoLobby";
            this.pbBotaoLobby.Size = new System.Drawing.Size(234, 84);
            this.pbBotaoLobby.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBotaoLobby.TabIndex = 12;
            this.pbBotaoLobby.TabStop = false;
            this.pbBotaoLobby.Click += new System.EventHandler(this.pbBotaoLobby_Click);
            this.pbBotaoLobby.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbBotaoLobby_MouseDown);
            this.pbBotaoLobby.MouseEnter += new System.EventHandler(this.pbBotaoLobby_MouseEnter);
            this.pbBotaoLobby.MouseLeave += new System.EventHandler(this.pbBotaoLobby_MouseLeave);
            this.pbBotaoLobby.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbBotaoLobby_MouseUp);
            // 
            // lblPontuacaoValor
            // 
            this.lblPontuacaoValor.AutoSize = true;
            this.lblPontuacaoValor.Font = new System.Drawing.Font("Press Start 2P", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPontuacaoValor.ForeColor = System.Drawing.Color.White;
            this.lblPontuacaoValor.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblPontuacaoValor.Location = new System.Drawing.Point(1126, 387);
            this.lblPontuacaoValor.Name = "lblPontuacaoValor";
            this.lblPontuacaoValor.Size = new System.Drawing.Size(34, 29);
            this.lblPontuacaoValor.TabIndex = 10;
            this.lblPontuacaoValor.Text = "0";
            this.lblPontuacaoValor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAcertosValor
            // 
            this.lblAcertosValor.AutoSize = true;
            this.lblAcertosValor.Font = new System.Drawing.Font("Press Start 2P", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcertosValor.ForeColor = System.Drawing.Color.White;
            this.lblAcertosValor.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblAcertosValor.Location = new System.Drawing.Point(1087, 308);
            this.lblAcertosValor.Name = "lblAcertosValor";
            this.lblAcertosValor.Size = new System.Drawing.Size(34, 29);
            this.lblAcertosValor.TabIndex = 9;
            this.lblAcertosValor.Text = "0";
            this.lblAcertosValor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbNota
            // 
            this.pbNota.Image = ((System.Drawing.Image)(resources.GetObject("pbNota.Image")));
            this.pbNota.Location = new System.Drawing.Point(905, 529);
            this.pbNota.Name = "pbNota";
            this.pbNota.Size = new System.Drawing.Size(279, 100);
            this.pbNota.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbNota.TabIndex = 8;
            this.pbNota.TabStop = false;
            // 
            // lblNota
            // 
            this.lblNota.AutoSize = true;
            this.lblNota.Font = new System.Drawing.Font("Press Start 2P", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNota.ForeColor = System.Drawing.Color.White;
            this.lblNota.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblNota.Location = new System.Drawing.Point(900, 466);
            this.lblNota.Name = "lblNota";
            this.lblNota.Size = new System.Drawing.Size(118, 29);
            this.lblNota.TabIndex = 7;
            this.lblNota.Text = "Nota:";
            this.lblNota.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbResultado
            // 
            this.pbResultado.Image = ((System.Drawing.Image)(resources.GetObject("pbResultado.Image")));
            this.pbResultado.Location = new System.Drawing.Point(91, 63);
            this.pbResultado.Name = "pbResultado";
            this.pbResultado.Size = new System.Drawing.Size(418, 121);
            this.pbResultado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbResultado.TabIndex = 6;
            this.pbResultado.TabStop = false;
            // 
            // lblInimigoBatalha
            // 
            this.lblInimigoBatalha.Font = new System.Drawing.Font("Press Start 2P", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInimigoBatalha.ForeColor = System.Drawing.Color.White;
            this.lblInimigoBatalha.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblInimigoBatalha.Location = new System.Drawing.Point(689, 514);
            this.lblInimigoBatalha.Name = "lblInimigoBatalha";
            this.lblInimigoBatalha.Size = new System.Drawing.Size(160, 29);
            this.lblInimigoBatalha.TabIndex = 5;
            this.lblInimigoBatalha.Text = "Inimigo";
            this.lblInimigoBatalha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbInimigoResultado
            // 
            this.pbInimigoResultado.Image = ((System.Drawing.Image)(resources.GetObject("pbInimigoResultado.Image")));
            this.pbInimigoResultado.Location = new System.Drawing.Point(699, 308);
            this.pbInimigoResultado.Name = "pbInimigoResultado";
            this.pbInimigoResultado.Size = new System.Drawing.Size(135, 188);
            this.pbInimigoResultado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbInimigoResultado.TabIndex = 4;
            this.pbInimigoResultado.TabStop = false;
            // 
            // lblInimigo
            // 
            this.lblInimigo.AutoSize = true;
            this.lblInimigo.Font = new System.Drawing.Font("Press Start 2P", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInimigo.ForeColor = System.Drawing.Color.White;
            this.lblInimigo.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblInimigo.Location = new System.Drawing.Point(689, 276);
            this.lblInimigo.Name = "lblInimigo";
            this.lblInimigo.Size = new System.Drawing.Size(181, 29);
            this.lblInimigo.TabIndex = 3;
            this.lblInimigo.Text = "Inimigo:";
            this.lblInimigo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAcertos
            // 
            this.lblAcertos.AutoSize = true;
            this.lblAcertos.Font = new System.Drawing.Font("Press Start 2P", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcertos.ForeColor = System.Drawing.Color.White;
            this.lblAcertos.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblAcertos.Location = new System.Drawing.Point(900, 308);
            this.lblAcertos.Name = "lblAcertos";
            this.lblAcertos.Size = new System.Drawing.Size(181, 29);
            this.lblAcertos.TabIndex = 2;
            this.lblAcertos.Text = "Acertos:";
            this.lblAcertos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPontuacao
            // 
            this.lblPontuacao.AutoSize = true;
            this.lblPontuacao.Font = new System.Drawing.Font("Press Start 2P", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPontuacao.ForeColor = System.Drawing.Color.White;
            this.lblPontuacao.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblPontuacao.Location = new System.Drawing.Point(900, 387);
            this.lblPontuacao.Name = "lblPontuacao";
            this.lblPontuacao.Size = new System.Drawing.Size(223, 29);
            this.lblPontuacao.TabIndex = 1;
            this.lblPontuacao.Text = "Pontuação:";
            this.lblPontuacao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbLogo
            // 
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(838, 91);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(200, 93);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // pbKoalaBoyUrubu
            // 
            this.pbKoalaBoyUrubu.Image = ((System.Drawing.Image)(resources.GetObject("pbKoalaBoyUrubu.Image")));
            this.pbKoalaBoyUrubu.Location = new System.Drawing.Point(87, 263);
            this.pbKoalaBoyUrubu.Name = "pbKoalaBoyUrubu";
            this.pbKoalaBoyUrubu.Size = new System.Drawing.Size(470, 325);
            this.pbKoalaBoyUrubu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbKoalaBoyUrubu.TabIndex = 11;
            this.pbKoalaBoyUrubu.TabStop = false;
            // 
            // timerBotaoLobby
            // 
            this.timerBotaoLobby.Interval = 15;
            this.timerBotaoLobby.Tick += new System.EventHandler(this.timerBotaoLobby_Tick);
            // 
            // TelaResultados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.panelResultados);
            this.Controls.Add(this.pbFragmento);
            this.Controls.Add(this.pbInimigo);
            this.Controls.Add(this.pbKoalaBoy);
            this.DoubleBuffered = true;
            this.Name = "TelaResultados";
            this.Size = new System.Drawing.Size(1280, 720);
            this.Load += new System.EventHandler(this.TelaResultados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbKoalaBoy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbInimigo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFragmento)).EndInit();
            this.panelResultados.ResumeLayout(false);
            this.panelResultados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBotaoLobby)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbNota)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbResultado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbInimigoResultado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbKoalaBoyUrubu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbKoalaBoy;
        private System.Windows.Forms.PictureBox pbInimigo;
        private System.Windows.Forms.PictureBox pbFragmento;
        private System.Windows.Forms.Timer timerAnimacao;
        private System.Windows.Forms.Panel panelResultados;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label lblPontuacao;
        private System.Windows.Forms.Label lblInimigoBatalha;
        private System.Windows.Forms.PictureBox pbInimigoResultado;
        private System.Windows.Forms.Label lblInimigo;
        private System.Windows.Forms.Label lblAcertos;
        private System.Windows.Forms.PictureBox pbResultado;
        private System.Windows.Forms.Label lblPontuacaoValor;
        private System.Windows.Forms.Label lblAcertosValor;
        private System.Windows.Forms.PictureBox pbNota;
        private System.Windows.Forms.Label lblNota;
        private System.Windows.Forms.PictureBox pbKoalaBoyUrubu;
        private System.Windows.Forms.PictureBox pbBotaoLobby;
        private System.Windows.Forms.Timer timerBotaoLobby;
    }
}
