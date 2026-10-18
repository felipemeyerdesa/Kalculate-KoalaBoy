namespace Kalculate_KoalaBoy
{
    partial class TelaInicial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaInicial));
            this.pbBotaoStart = new System.Windows.Forms.PictureBox();
            this.timerBotaoStart = new System.Windows.Forms.Timer(this.components);
            this.pbLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbBotaoStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pbBotaoStart
            // 
            this.pbBotaoStart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbBotaoStart.BackColor = System.Drawing.Color.Transparent;
            this.pbBotaoStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbBotaoStart.Image = ((System.Drawing.Image)(resources.GetObject("pbBotaoStart.Image")));
            this.pbBotaoStart.Location = new System.Drawing.Point(345, 302);
            this.pbBotaoStart.Margin = new System.Windows.Forms.Padding(0);
            this.pbBotaoStart.Name = "pbBotaoStart";
            this.pbBotaoStart.Size = new System.Drawing.Size(270, 85);
            this.pbBotaoStart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBotaoStart.TabIndex = 0;
            this.pbBotaoStart.TabStop = false;
            this.pbBotaoStart.Click += new System.EventHandler(this.pbStart_Click);
            this.pbBotaoStart.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbStart_MouseDown);
            this.pbBotaoStart.MouseEnter += new System.EventHandler(this.pbStart_MouseEnter);
            this.pbBotaoStart.MouseLeave += new System.EventHandler(this.pbStart_MouseLeave);
            this.pbBotaoStart.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbStart_MouseUp);
            // 
            // timerBotaoStart
            // 
            this.timerBotaoStart.Interval = 15;
            this.timerBotaoStart.Tick += new System.EventHandler(this.timerBotao_Tick);
            // 
            // pbLogo
            // 
            this.pbLogo.BackColor = System.Drawing.Color.Transparent;
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(236, 12);
            this.pbLogo.Margin = new System.Windows.Forms.Padding(2);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(488, 228);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 1;
            this.pbLogo.TabStop = false;
            // 
            // TelaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.pbBotaoStart);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "TelaInicial";
            this.Size = new System.Drawing.Size(960, 585);
            this.Load += new System.EventHandler(this.TelaInicial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbBotaoStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbBotaoStart;
        private System.Windows.Forms.Timer timerBotaoStart;
        private System.Windows.Forms.PictureBox pbLogo;
    }
}
