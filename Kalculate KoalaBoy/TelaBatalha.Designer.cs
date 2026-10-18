namespace Kalculate_KoalaBoy
{
    partial class TelaBatalha
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaBatalha));
            this.koalaBoy = new System.Windows.Forms.PictureBox();
            this.gato = new System.Windows.Forms.PictureBox();
            this.koalaHp = new System.Windows.Forms.PictureBox();
            this.gatoHp = new System.Windows.Forms.PictureBox();
            this.panelDialogo = new System.Windows.Forms.Panel();
            this.pbPersonagem = new System.Windows.Forms.PictureBox();
            this.panelBoxDialogo = new System.Windows.Forms.Panel();
            this.lblDialogo = new System.Windows.Forms.Label();
            this.pbBotaoSkip = new System.Windows.Forms.PictureBox();
            this.timerBotaoSkip = new System.Windows.Forms.Timer(this.components);
            this.pb321Battle = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.koalaBoy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gato)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.koalaHp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gatoHp)).BeginInit();
            this.panelDialogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonagem)).BeginInit();
            this.panelBoxDialogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbBotaoSkip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb321Battle)).BeginInit();
            this.SuspendLayout();
            // 
            // koalaBoy
            // 
            this.koalaBoy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.koalaBoy.BackColor = System.Drawing.Color.Transparent;
            this.koalaBoy.Image = ((System.Drawing.Image)(resources.GetObject("koalaBoy.Image")));
            this.koalaBoy.Location = new System.Drawing.Point(72, 201);
            this.koalaBoy.Margin = new System.Windows.Forms.Padding(2);
            this.koalaBoy.Name = "koalaBoy";
            this.koalaBoy.Size = new System.Drawing.Size(215, 265);
            this.koalaBoy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.koalaBoy.TabIndex = 0;
            this.koalaBoy.TabStop = false;
            // 
            // gato
            // 
            this.gato.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.gato.BackColor = System.Drawing.Color.Transparent;
            this.gato.Image = ((System.Drawing.Image)(resources.GetObject("gato.Image")));
            this.gato.Location = new System.Drawing.Point(658, 201);
            this.gato.Margin = new System.Windows.Forms.Padding(2);
            this.gato.Name = "gato";
            this.gato.Size = new System.Drawing.Size(215, 265);
            this.gato.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gato.TabIndex = 1;
            this.gato.TabStop = false;
            // 
            // koalaHp
            // 
            this.koalaHp.BackColor = System.Drawing.Color.Transparent;
            this.koalaHp.Image = ((System.Drawing.Image)(resources.GetObject("koalaHp.Image")));
            this.koalaHp.Location = new System.Drawing.Point(0, 0);
            this.koalaHp.Margin = new System.Windows.Forms.Padding(2);
            this.koalaHp.Name = "koalaHp";
            this.koalaHp.Size = new System.Drawing.Size(116, 115);
            this.koalaHp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.koalaHp.TabIndex = 2;
            this.koalaHp.TabStop = false;
            this.koalaHp.Visible = false;
            // 
            // gatoHp
            // 
            this.gatoHp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gatoHp.BackColor = System.Drawing.Color.Transparent;
            this.gatoHp.Image = ((System.Drawing.Image)(resources.GetObject("gatoHp.Image")));
            this.gatoHp.Location = new System.Drawing.Point(844, 2);
            this.gatoHp.Margin = new System.Windows.Forms.Padding(2);
            this.gatoHp.Name = "gatoHp";
            this.gatoHp.Size = new System.Drawing.Size(116, 115);
            this.gatoHp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gatoHp.TabIndex = 4;
            this.gatoHp.TabStop = false;
            this.gatoHp.Visible = false;
            // 
            // panelDialogo
            // 
            this.panelDialogo.BackColor = System.Drawing.Color.Transparent;
            this.panelDialogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelDialogo.Controls.Add(this.pbPersonagem);
            this.panelDialogo.Controls.Add(this.panelBoxDialogo);
            this.panelDialogo.Location = new System.Drawing.Point(86, 44);
            this.panelDialogo.Margin = new System.Windows.Forms.Padding(2);
            this.panelDialogo.Name = "panelDialogo";
            this.panelDialogo.Size = new System.Drawing.Size(789, 513);
            this.panelDialogo.TabIndex = 5;
            this.panelDialogo.Visible = false;
            // 
            // pbPersonagem
            // 
            this.pbPersonagem.Image = ((System.Drawing.Image)(resources.GetObject("pbPersonagem.Image")));
            this.pbPersonagem.Location = new System.Drawing.Point(240, 2);
            this.pbPersonagem.Name = "pbPersonagem";
            this.pbPersonagem.Size = new System.Drawing.Size(383, 300);
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
            this.panelBoxDialogo.Location = new System.Drawing.Point(0, 264);
            this.panelBoxDialogo.Name = "panelBoxDialogo";
            this.panelBoxDialogo.Size = new System.Drawing.Size(789, 229);
            this.panelBoxDialogo.TabIndex = 5;
            // 
            // lblDialogo
            // 
            this.lblDialogo.BackColor = System.Drawing.Color.Transparent;
            this.lblDialogo.Font = new System.Drawing.Font("Press Start 2P", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDialogo.Location = new System.Drawing.Point(176, 72);
            this.lblDialogo.Name = "lblDialogo";
            this.lblDialogo.Size = new System.Drawing.Size(531, 107);
            this.lblDialogo.TabIndex = 2;
            this.lblDialogo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pbBotaoSkip
            // 
            this.pbBotaoSkip.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbBotaoSkip.Image = ((System.Drawing.Image)(resources.GetObject("pbBotaoSkip.Image")));
            this.pbBotaoSkip.Location = new System.Drawing.Point(730, 83);
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
            this.pb321Battle.Location = new System.Drawing.Point(258, 170);
            this.pb321Battle.Name = "pb321Battle";
            this.pb321Battle.Size = new System.Drawing.Size(388, 245);
            this.pb321Battle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb321Battle.TabIndex = 7;
            this.pb321Battle.TabStop = false;
            this.pb321Battle.Visible = false;
            // 
            // TelaBatalha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.panelDialogo);
            this.Controls.Add(this.gato);
            this.Controls.Add(this.pb321Battle);
            this.Controls.Add(this.koalaBoy);
            this.Controls.Add(this.koalaHp);
            this.Controls.Add(this.gatoHp);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "TelaBatalha";
            this.Size = new System.Drawing.Size(960, 585);
            this.Load += new System.EventHandler(this.TelaBatalha_Load);
            ((System.ComponentModel.ISupportInitialize)(this.koalaBoy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gato)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.koalaHp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gatoHp)).EndInit();
            this.panelDialogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonagem)).EndInit();
            this.panelBoxDialogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbBotaoSkip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb321Battle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox koalaBoy;
        private System.Windows.Forms.PictureBox gato;
        private System.Windows.Forms.PictureBox koalaHp;
        private System.Windows.Forms.PictureBox gatoHp;
        private System.Windows.Forms.Panel panelDialogo;
        private System.Windows.Forms.PictureBox pbBotaoSkip;
        private System.Windows.Forms.Timer timerBotaoSkip;
        private System.Windows.Forms.Label lblDialogo;
        private System.Windows.Forms.Panel panelBoxDialogo;
        private System.Windows.Forms.PictureBox pbPersonagem;
        private System.Windows.Forms.PictureBox pb321Battle;
    }
}
