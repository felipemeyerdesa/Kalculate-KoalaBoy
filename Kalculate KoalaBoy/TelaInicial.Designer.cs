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
            this.pbStart = new System.Windows.Forms.PictureBox();
            this.timerBotao = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbStart)).BeginInit();
            this.SuspendLayout();
            // 
            // pbStart
            // 
            this.pbStart.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pbStart.BackColor = System.Drawing.Color.Transparent;
            this.pbStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbStart.Image = ((System.Drawing.Image)(resources.GetObject("pbStart.Image")));
            this.pbStart.Location = new System.Drawing.Point(465, 368);
            this.pbStart.Margin = new System.Windows.Forms.Padding(0);
            this.pbStart.Name = "pbStart";
            this.pbStart.Size = new System.Drawing.Size(350, 117);
            this.pbStart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbStart.TabIndex = 0;
            this.pbStart.TabStop = false;
            this.pbStart.Click += new System.EventHandler(this.pbStart_Click);
            this.pbStart.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbStart_MouseDown);
            this.pbStart.MouseEnter += new System.EventHandler(this.pbStart_MouseEnter);
            this.pbStart.MouseLeave += new System.EventHandler(this.pbStart_MouseLeave);
            this.pbStart.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbStart_MouseUp);
            // 
            // timerBotao
            // 
            this.timerBotao.Interval = 15;
            this.timerBotao.Tick += new System.EventHandler(this.timerBotao_Tick);
            // 
            // TelaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.pbStart);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "TelaInicial";
            this.Size = new System.Drawing.Size(1280, 720);
            ((System.ComponentModel.ISupportInitialize)(this.pbStart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbStart;
        private System.Windows.Forms.Timer timerBotao;
    }
}
