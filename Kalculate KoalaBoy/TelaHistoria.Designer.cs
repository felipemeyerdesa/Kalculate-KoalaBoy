namespace Kalculate_KoalaBoy
{
    partial class TelaHistoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaHistoria));
            this.pbKoalaBoy = new System.Windows.Forms.PictureBox();
            this.pbUrubu = new System.Windows.Forms.PictureBox();
            this.timerAnimacao = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbKoalaBoy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUrubu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pbKoalaBoy
            // 
            this.pbKoalaBoy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pbKoalaBoy.BackColor = System.Drawing.Color.Transparent;
            this.pbKoalaBoy.Image = ((System.Drawing.Image)(resources.GetObject("pbKoalaBoy.Image")));
            this.pbKoalaBoy.Location = new System.Drawing.Point(864, 256);
            this.pbKoalaBoy.Margin = new System.Windows.Forms.Padding(2);
            this.pbKoalaBoy.Name = "pbKoalaBoy";
            this.pbKoalaBoy.Size = new System.Drawing.Size(220, 335);
            this.pbKoalaBoy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbKoalaBoy.TabIndex = 1;
            this.pbKoalaBoy.TabStop = false;
            // 
            // pbUrubu
            // 
            this.pbUrubu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pbUrubu.BackColor = System.Drawing.Color.Transparent;
            this.pbUrubu.Image = ((System.Drawing.Image)(resources.GetObject("pbUrubu.Image")));
            this.pbUrubu.Location = new System.Drawing.Point(0, 205);
            this.pbUrubu.Margin = new System.Windows.Forms.Padding(2);
            this.pbUrubu.Name = "pbUrubu";
            this.pbUrubu.Size = new System.Drawing.Size(220, 386);
            this.pbUrubu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbUrubu.TabIndex = 2;
            this.pbUrubu.TabStop = false;
            // 
            // timerAnimacao
            // 
            this.timerAnimacao.Interval = 25;
            this.timerAnimacao.Tick += new System.EventHandler(this.timerAnimacao_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(255, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(770, 602);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Location = new System.Drawing.Point(910, 80);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 45);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // TelaHistoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pbUrubu);
            this.Controls.Add(this.pbKoalaBoy);
            this.DoubleBuffered = true;
            this.Name = "TelaHistoria";
            this.Size = new System.Drawing.Size(1280, 720);
            this.Load += new System.EventHandler(this.TelaHistoria_Load);
            this.VisibleChanged += new System.EventHandler(this.TelaHistoria_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.pbKoalaBoy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUrubu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbKoalaBoy;
        private System.Windows.Forms.PictureBox pbUrubu;
        private System.Windows.Forms.Timer timerAnimacao;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
