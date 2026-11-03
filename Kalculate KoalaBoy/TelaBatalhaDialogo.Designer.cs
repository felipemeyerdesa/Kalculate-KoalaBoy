namespace Kalculate_KoalaBoy
{
    partial class TelaBatalhaDialogo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaBatalhaDialogo));
            this.pbKoalaBoy = new System.Windows.Forms.PictureBox();
            this.pbInimigo = new System.Windows.Forms.PictureBox();
            this.panelDialogo = new System.Windows.Forms.Panel();
            this.pbPersonagem = new System.Windows.Forms.PictureBox();
            this.panelBoxDialogo = new System.Windows.Forms.Panel();
            this.lblDialogo = new System.Windows.Forms.Label();
            this.pbBotaoSkip = new System.Windows.Forms.PictureBox();
            this.timerBotaoSkip = new System.Windows.Forms.Timer(this.components);
            this.pb321Battle = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbKoalaBoy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbInimigo)).BeginInit();
            this.panelDialogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonagem)).BeginInit();
            this.panelBoxDialogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBotaoSkip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb321Battle)).BeginInit();
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
            this.pbKoalaBoy.TabIndex = 0;
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
            this.pbInimigo.TabIndex = 1;
            this.pbInimigo.TabStop = false;
            // 
            // panelDialogo
            // 
            this.panelDialogo.BackColor = System.Drawing.Color.Transparent;
            this.panelDialogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelDialogo.Controls.Add(this.pbPersonagem);
            this.panelDialogo.Controls.Add(this.panelBoxDialogo);
            this.panelDialogo.Location = new System.Drawing.Point(195, 82);
            this.panelDialogo.Margin = new System.Windows.Forms.Padding(2);
            this.panelDialogo.Name = "panelDialogo";
            this.panelDialogo.Size = new System.Drawing.Size(890, 592);
            this.panelDialogo.TabIndex = 5;
            this.panelDialogo.Visible = false;
            // 
            // pbPersonagem
            // 
            this.pbPersonagem.Image = ((System.Drawing.Image)(resources.GetObject("pbPersonagem.Image")));
            this.pbPersonagem.Location = new System.Drawing.Point(266, 30);
            this.pbPersonagem.Name = "pbPersonagem";
            this.pbPersonagem.Size = new System.Drawing.Size(441, 345);
            this.pbPersonagem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPersonagem.TabIndex = 6;
            this.pbPersonagem.TabStop = false;
            // 
            // panelBoxDialogo
            // 
            this.panelBoxDialogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelBoxDialogo.BackgroundImage")));
            this.panelBoxDialogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelBoxDialogo.Controls.Add(this.lblDialogo);
            this.panelBoxDialogo.Controls.Add(this.pbBotaoSkip);
            this.panelBoxDialogo.Location = new System.Drawing.Point(0, 334);
            this.panelBoxDialogo.Name = "panelBoxDialogo";
            this.panelBoxDialogo.Size = new System.Drawing.Size(887, 255);
            this.panelBoxDialogo.TabIndex = 5;
            // 
            // lblDialogo
            // 
            this.lblDialogo.BackColor = System.Drawing.Color.Transparent;
            this.lblDialogo.Font = new System.Drawing.Font("Press Start 2P", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDialogo.Location = new System.Drawing.Point(196, 83);
            this.lblDialogo.Name = "lblDialogo";
            this.lblDialogo.Size = new System.Drawing.Size(609, 120);
            this.lblDialogo.TabIndex = 2;
            this.lblDialogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbBotaoSkip
            // 
            this.pbBotaoSkip.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbBotaoSkip.Image = ((System.Drawing.Image)(resources.GetObject("pbBotaoSkip.Image")));
            this.pbBotaoSkip.Location = new System.Drawing.Point(828, 96);
            this.pbBotaoSkip.Name = "pbBotaoSkip";
            this.pbBotaoSkip.Size = new System.Drawing.Size(59, 62);
            this.pbBotaoSkip.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBotaoSkip.TabIndex = 3;
            this.pbBotaoSkip.TabStop = false;
            this.pbBotaoSkip.Click += new System.EventHandler(this.pbBotaoSkip_Click);
            this.pbBotaoSkip.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbBotaoStart_MouseDown);
            this.pbBotaoSkip.MouseEnter += new System.EventHandler(this.pbBotaoStart_MouseEnter);
            this.pbBotaoSkip.MouseLeave += new System.EventHandler(this.pbBotaoStart_MouseLeave);
            this.pbBotaoSkip.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbBotaoStart_MouseUp);
            // 
            // timerBotaoSkip
            // 
            this.timerBotaoSkip.Interval = 15;
            this.timerBotaoSkip.Tick += new System.EventHandler(this.timerBotaoSkip_Tick);
            // 
            // pb321Battle
            // 
            this.pb321Battle.BackColor = System.Drawing.Color.Transparent;
            this.pb321Battle.Image = ((System.Drawing.Image)(resources.GetObject("pb321Battle.Image")));
            this.pb321Battle.Location = new System.Drawing.Point(410, 225);
            this.pb321Battle.Name = "pb321Battle";
            this.pb321Battle.Size = new System.Drawing.Size(425, 270);
            this.pb321Battle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb321Battle.TabIndex = 7;
            this.pb321Battle.TabStop = false;
            this.pb321Battle.Visible = false;
            // 
            // TelaBatalhaDialogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.panelDialogo);
            this.Controls.Add(this.pbKoalaBoy);
            this.Controls.Add(this.pbInimigo);
            this.Controls.Add(this.pb321Battle);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "TelaBatalhaDialogo";
            this.Size = new System.Drawing.Size(1280, 720);
            this.Load += new System.EventHandler(this.TelaBatalha_Load);
            this.VisibleChanged += new System.EventHandler(this.TelaBatalhaDialogo_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.pbKoalaBoy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbInimigo)).EndInit();
            this.panelDialogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonagem)).EndInit();
            this.panelBoxDialogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbBotaoSkip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb321Battle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbKoalaBoy;
        private System.Windows.Forms.PictureBox pbInimigo;
        private System.Windows.Forms.Panel panelDialogo;
        private System.Windows.Forms.PictureBox pbBotaoSkip;
        private System.Windows.Forms.Timer timerBotaoSkip;
        private System.Windows.Forms.Label lblDialogo;
        private System.Windows.Forms.Panel panelBoxDialogo;
        private System.Windows.Forms.PictureBox pbPersonagem;
        private System.Windows.Forms.PictureBox pb321Battle;
    }
}
