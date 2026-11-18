namespace Kalculate_KoalaBoy
{
    partial class TelaTutorial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaTutorial));
            this.timerBotaoFechar = new System.Windows.Forms.Timer(this.components);
            this.pbVoltarTutorial = new System.Windows.Forms.PictureBox();
            this.pbIrPontuacao = new System.Windows.Forms.PictureBox();
            this.pbFechar = new System.Windows.Forms.PictureBox();
            this.pbConteudo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbVoltarTutorial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIrPontuacao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFechar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbConteudo)).BeginInit();
            this.SuspendLayout();
            // 
            // timerBotaoFechar
            // 
            this.timerBotaoFechar.Interval = 15;
            this.timerBotaoFechar.Tick += new System.EventHandler(this.timerBotaoFechar_Tick);
            // 
            // pbVoltarTutorial
            // 
            this.pbVoltarTutorial.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbVoltarTutorial.BackgroundImage = global::Kalculate_KoalaBoy.Properties.Resources.Seta_Esquerda;
            this.pbVoltarTutorial.Image = ((System.Drawing.Image)(resources.GetObject("pbVoltarTutorial.Image")));
            this.pbVoltarTutorial.Location = new System.Drawing.Point(474, 3);
            this.pbVoltarTutorial.Name = "pbVoltarTutorial";
            this.pbVoltarTutorial.Size = new System.Drawing.Size(40, 40);
            this.pbVoltarTutorial.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbVoltarTutorial.TabIndex = 3;
            this.pbVoltarTutorial.TabStop = false;
            this.pbVoltarTutorial.Click += new System.EventHandler(this.pbVoltarTutorial_Click);
            // 
            // pbIrPontuacao
            // 
            this.pbIrPontuacao.BackgroundImage = global::Kalculate_KoalaBoy.Properties.Resources.SetaDireita;
            this.pbIrPontuacao.Image = global::Kalculate_KoalaBoy.Properties.Resources.SetaDireita;
            this.pbIrPontuacao.Location = new System.Drawing.Point(474, 3);
            this.pbIrPontuacao.Name = "pbIrPontuacao";
            this.pbIrPontuacao.Size = new System.Drawing.Size(40, 40);
            this.pbIrPontuacao.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbIrPontuacao.TabIndex = 1;
            this.pbIrPontuacao.TabStop = false;
            this.pbIrPontuacao.Click += new System.EventHandler(this.pbIrPontuacao_Click);
            // 
            // pbFechar
            // 
            this.pbFechar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbFechar.BackColor = System.Drawing.Color.Transparent;
            this.pbFechar.BackgroundImage = global::Kalculate_KoalaBoy.Properties.Resources.X_amarelo_em_pixel_art_retrô;
            this.pbFechar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbFechar.Image = ((System.Drawing.Image)(resources.GetObject("pbFechar.Image")));
            this.pbFechar.Location = new System.Drawing.Point(43, 3);
            this.pbFechar.Name = "pbFechar";
            this.pbFechar.Size = new System.Drawing.Size(40, 40);
            this.pbFechar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFechar.TabIndex = 0;
            this.pbFechar.TabStop = false;
            this.pbFechar.Click += new System.EventHandler(this.pbFecharTutorial_Click);
            // 
            // pbConteudo
            // 
            this.pbConteudo.Image = global::Kalculate_KoalaBoy.Properties.Resources.Tutorial;
            this.pbConteudo.Location = new System.Drawing.Point(0, 0);
            this.pbConteudo.Name = "pbConteudo";
            this.pbConteudo.Size = new System.Drawing.Size(550, 650);
            this.pbConteudo.TabIndex = 2;
            this.pbConteudo.TabStop = false;
            // 
            // TelaTutorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pbVoltarTutorial);
            this.Controls.Add(this.pbIrPontuacao);
            this.Controls.Add(this.pbFechar);
            this.Controls.Add(this.pbConteudo);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "TelaTutorial";
            this.Size = new System.Drawing.Size(550, 650);
            ((System.ComponentModel.ISupportInitialize)(this.pbVoltarTutorial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIrPontuacao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFechar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbConteudo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbFechar;
        private System.Windows.Forms.Timer timerBotaoFechar;
        private System.Windows.Forms.PictureBox pbIrPontuacao;
        private System.Windows.Forms.PictureBox pbConteudo;
        private System.Windows.Forms.PictureBox pbVoltarTutorial;
    }
}
