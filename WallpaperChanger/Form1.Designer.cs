namespace WallpaperChanging
{
    partial class Form1
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BtnAlteraImagem = new System.Windows.Forms.Button();
            this.LabelFileName = new System.Windows.Forms.Label();
            this.TimerAlteraImagem = new System.Windows.Forms.Timer(this.components);
            this.BtnAlteraIntervalo = new System.Windows.Forms.Button();
            this.TxtTempo = new System.Windows.Forms.TextBox();
            this.LabelTitulo = new System.Windows.Forms.Label();
            this.LabelAlteraImagem = new System.Windows.Forms.Label();
            this.LabelAlteraIntervalo = new System.Windows.Forms.Label();
            this.BtnAlteraPasta = new System.Windows.Forms.Button();
            this.LabelAlteraPasta = new System.Windows.Forms.Label();
            this.LabelPastaImagens = new System.Windows.Forms.Label();
            this.EscolherPasta = new System.Windows.Forms.FolderBrowserDialog();
            this.LabelIntervaloTempo = new System.Windows.Forms.Label();
            this.imagemExemplo = new System.Windows.Forms.FlowLayoutPanel();
            this.labelDownload = new System.Windows.Forms.Label();
            this.textBoxAnime = new System.Windows.Forms.TextBox();
            this.buttonDownload = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPersonagem = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxPasta = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxQtd = new System.Windows.Forms.TextBox();
            this.imagemExemplo.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnAlteraImagem
            // 
            this.BtnAlteraImagem.BackColor = System.Drawing.Color.DarkSlateGray;
            this.BtnAlteraImagem.FlatAppearance.BorderColor = System.Drawing.Color.MediumSpringGreen;
            this.BtnAlteraImagem.FlatAppearance.BorderSize = 0;
            this.BtnAlteraImagem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAlteraImagem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnAlteraImagem.Location = new System.Drawing.Point(12, 224);
            this.BtnAlteraImagem.Margin = new System.Windows.Forms.Padding(0);
            this.BtnAlteraImagem.Name = "BtnAlteraImagem";
            this.BtnAlteraImagem.Size = new System.Drawing.Size(154, 26);
            this.BtnAlteraImagem.TabIndex = 0;
            this.BtnAlteraImagem.Text = "Alterar";
            this.BtnAlteraImagem.UseVisualStyleBackColor = false;
            this.BtnAlteraImagem.Click += new System.EventHandler(this.BtnAlteraImagem_Click);
            // 
            // LabelFileName
            // 
            this.LabelFileName.AutoSize = true;
            this.LabelFileName.BackColor = System.Drawing.Color.DarkKhaki;
            this.LabelFileName.ForeColor = System.Drawing.Color.SaddleBrown;
            this.LabelFileName.Location = new System.Drawing.Point(165, 205);
            this.LabelFileName.Margin = new System.Windows.Forms.Padding(0);
            this.LabelFileName.Name = "LabelFileName";
            this.LabelFileName.Padding = new System.Windows.Forms.Padding(3);
            this.LabelFileName.Size = new System.Drawing.Size(97, 19);
            this.LabelFileName.TabIndex = 1;
            this.LabelFileName.Text = "[ imagem padrão ]";
            this.LabelFileName.Click += new System.EventHandler(this.LabelFileName_Click);
            // 
            // TimerAlteraImagem
            // 
            this.TimerAlteraImagem.Enabled = true;
            this.TimerAlteraImagem.Interval = 30000;
            this.TimerAlteraImagem.Tick += new System.EventHandler(this.TimerAlteraImagem_Tick);
            // 
            // BtnAlteraIntervalo
            // 
            this.BtnAlteraIntervalo.BackColor = System.Drawing.Color.DarkSlateGray;
            this.BtnAlteraIntervalo.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.BtnAlteraIntervalo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAlteraIntervalo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnAlteraIntervalo.Location = new System.Drawing.Point(12, 283);
            this.BtnAlteraIntervalo.Margin = new System.Windows.Forms.Padding(0);
            this.BtnAlteraIntervalo.Name = "BtnAlteraIntervalo";
            this.BtnAlteraIntervalo.Size = new System.Drawing.Size(153, 25);
            this.BtnAlteraIntervalo.TabIndex = 2;
            this.BtnAlteraIntervalo.Text = "Alterar";
            this.BtnAlteraIntervalo.UseVisualStyleBackColor = false;
            this.BtnAlteraIntervalo.Click += new System.EventHandler(this.BtnAlteraIntervalo_Click);
            // 
            // TxtTempo
            // 
            this.TxtTempo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtTempo.Location = new System.Drawing.Point(167, 286);
            this.TxtTempo.Name = "TxtTempo";
            this.TxtTempo.Size = new System.Drawing.Size(94, 20);
            this.TxtTempo.TabIndex = 3;
            this.TxtTempo.TextChanged += new System.EventHandler(this.TxtTempo_TextChanged);
            // 
            // LabelTitulo
            // 
            this.LabelTitulo.AutoSize = true;
            this.LabelTitulo.BackColor = System.Drawing.Color.DarkSlateGray;
            this.LabelTitulo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LabelTitulo.Location = new System.Drawing.Point(0, 0);
            this.LabelTitulo.Margin = new System.Windows.Forms.Padding(0);
            this.LabelTitulo.Name = "LabelTitulo";
            this.LabelTitulo.Padding = new System.Windows.Forms.Padding(77, 5, 77, 5);
            this.LabelTitulo.Size = new System.Drawing.Size(293, 23);
            this.LabelTitulo.TabIndex = 4;
            this.LabelTitulo.Text = "BACKGROUND CHANGER";
            // 
            // LabelAlteraImagem
            // 
            this.LabelAlteraImagem.AutoSize = true;
            this.LabelAlteraImagem.Location = new System.Drawing.Point(12, 205);
            this.LabelAlteraImagem.Name = "LabelAlteraImagem";
            this.LabelAlteraImagem.Padding = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.LabelAlteraImagem.Size = new System.Drawing.Size(154, 19);
            this.LabelAlteraImagem.TabIndex = 5;
            this.LabelAlteraImagem.Text = "Alterar Imagem Manualmente";
            this.LabelAlteraImagem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelAlteraIntervalo
            // 
            this.LabelAlteraIntervalo.AutoSize = true;
            this.LabelAlteraIntervalo.Location = new System.Drawing.Point(12, 264);
            this.LabelAlteraIntervalo.Name = "LabelAlteraIntervalo";
            this.LabelAlteraIntervalo.Padding = new System.Windows.Forms.Padding(9, 3, 10, 3);
            this.LabelAlteraIntervalo.Size = new System.Drawing.Size(153, 19);
            this.LabelAlteraIntervalo.TabIndex = 6;
            this.LabelAlteraIntervalo.Text = "Alterar Intervalo De Tempo";
            this.LabelAlteraIntervalo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BtnAlteraPasta
            // 
            this.BtnAlteraPasta.BackColor = System.Drawing.Color.DarkSlateGray;
            this.BtnAlteraPasta.FlatAppearance.BorderSize = 0;
            this.BtnAlteraPasta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAlteraPasta.Location = new System.Drawing.Point(12, 344);
            this.BtnAlteraPasta.Margin = new System.Windows.Forms.Padding(0);
            this.BtnAlteraPasta.Name = "BtnAlteraPasta";
            this.BtnAlteraPasta.Size = new System.Drawing.Size(153, 22);
            this.BtnAlteraPasta.TabIndex = 7;
            this.BtnAlteraPasta.Text = "Alterar";
            this.BtnAlteraPasta.UseVisualStyleBackColor = false;
            this.BtnAlteraPasta.Click += new System.EventHandler(this.BtnAlteraPasta_Click);
            // 
            // LabelAlteraPasta
            // 
            this.LabelAlteraPasta.AutoSize = true;
            this.LabelAlteraPasta.Location = new System.Drawing.Point(12, 325);
            this.LabelAlteraPasta.Margin = new System.Windows.Forms.Padding(0);
            this.LabelAlteraPasta.Name = "LabelAlteraPasta";
            this.LabelAlteraPasta.Padding = new System.Windows.Forms.Padding(13, 3, 13, 3);
            this.LabelAlteraPasta.Size = new System.Drawing.Size(153, 19);
            this.LabelAlteraPasta.TabIndex = 8;
            this.LabelAlteraPasta.Text = "Alterar Pasta De Imagens";
            this.LabelAlteraPasta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelPastaImagens
            // 
            this.LabelPastaImagens.AutoSize = true;
            this.LabelPastaImagens.BackColor = System.Drawing.Color.DarkKhaki;
            this.LabelPastaImagens.ForeColor = System.Drawing.Color.SaddleBrown;
            this.LabelPastaImagens.Location = new System.Drawing.Point(165, 325);
            this.LabelPastaImagens.Name = "LabelPastaImagens";
            this.LabelPastaImagens.Padding = new System.Windows.Forms.Padding(3);
            this.LabelPastaImagens.Size = new System.Drawing.Size(96, 19);
            this.LabelPastaImagens.TabIndex = 9;
            this.LabelPastaImagens.Text = "  [ pasta padrão ] ";
            this.LabelPastaImagens.Click += new System.EventHandler(this.LabelPastaImagens_Click);
            // 
            // EscolherPasta
            // 
            this.EscolherPasta.HelpRequest += new System.EventHandler(this.EscolherPasta_HelpRequest);
            // 
            // LabelIntervaloTempo
            // 
            this.LabelIntervaloTempo.AutoSize = true;
            this.LabelIntervaloTempo.BackColor = System.Drawing.Color.DarkKhaki;
            this.LabelIntervaloTempo.ForeColor = System.Drawing.Color.SaddleBrown;
            this.LabelIntervaloTempo.Location = new System.Drawing.Point(165, 264);
            this.LabelIntervaloTempo.Name = "LabelIntervaloTempo";
            this.LabelIntervaloTempo.Padding = new System.Windows.Forms.Padding(3);
            this.LabelIntervaloTempo.Size = new System.Drawing.Size(30, 19);
            this.LabelIntervaloTempo.TabIndex = 10;
            this.LabelIntervaloTempo.Text = "30s";
            // 
            // imagemExemplo
            // 
            this.imagemExemplo.AutoSize = true;
            this.imagemExemplo.BackColor = System.Drawing.Color.White;
            this.imagemExemplo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imagemExemplo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imagemExemplo.Controls.Add(this.LabelTitulo);
            this.imagemExemplo.Location = new System.Drawing.Point(125, 12);
            this.imagemExemplo.Name = "imagemExemplo";
            this.imagemExemplo.Size = new System.Drawing.Size(295, 177);
            this.imagemExemplo.TabIndex = 11;
            this.imagemExemplo.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // labelDownload
            // 
            this.labelDownload.AutoSize = true;
            this.labelDownload.Location = new System.Drawing.Point(12, 379);
            this.labelDownload.Name = "labelDownload";
            this.labelDownload.Padding = new System.Windows.Forms.Padding(31, 3, 30, 3);
            this.labelDownload.Size = new System.Drawing.Size(153, 19);
            this.labelDownload.TabIndex = 14;
            this.labelDownload.Text = "Baixar Wallpapers";
            this.labelDownload.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxAnime
            // 
            this.textBoxAnime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxAnime.Location = new System.Drawing.Point(168, 401);
            this.textBoxAnime.Name = "textBoxAnime";
            this.textBoxAnime.Size = new System.Drawing.Size(97, 20);
            this.textBoxAnime.TabIndex = 13;
            // 
            // buttonDownload
            // 
            this.buttonDownload.BackColor = System.Drawing.Color.DarkSlateGray;
            this.buttonDownload.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.buttonDownload.FlatAppearance.BorderSize = 0;
            this.buttonDownload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDownload.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonDownload.Location = new System.Drawing.Point(12, 398);
            this.buttonDownload.Margin = new System.Windows.Forms.Padding(0);
            this.buttonDownload.Name = "buttonDownload";
            this.buttonDownload.Size = new System.Drawing.Size(153, 23);
            this.buttonDownload.TabIndex = 12;
            this.buttonDownload.Text = "Baixar";
            this.buttonDownload.UseVisualStyleBackColor = false;
            this.buttonDownload.Click += new System.EventHandler(this.buttonDownload_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(168, 379);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(31, 3, 30, 3);
            this.label1.Size = new System.Drawing.Size(97, 19);
            this.label1.TabIndex = 15;
            this.label1.Text = "Anime";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(271, 379);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(15, 3, 15, 3);
            this.label2.Size = new System.Drawing.Size(96, 19);
            this.label2.TabIndex = 17;
            this.label2.Text = "Personagem";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxPersonagem
            // 
            this.textBoxPersonagem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPersonagem.Location = new System.Drawing.Point(271, 401);
            this.textBoxPersonagem.Name = "textBoxPersonagem";
            this.textBoxPersonagem.Size = new System.Drawing.Size(96, 20);
            this.textBoxPersonagem.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(420, 379);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(31, 3, 30, 3);
            this.label3.Size = new System.Drawing.Size(95, 19);
            this.label3.TabIndex = 19;
            this.label3.Text = "Pasta";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxPasta
            // 
            this.textBoxPasta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPasta.Location = new System.Drawing.Point(420, 401);
            this.textBoxPasta.Name = "textBoxPasta";
            this.textBoxPasta.Size = new System.Drawing.Size(95, 20);
            this.textBoxPasta.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(370, 379);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.label4.Size = new System.Drawing.Size(44, 19);
            this.label4.TabIndex = 21;
            this.label4.Text = "Qtd";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxQtd
            // 
            this.textBoxQtd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxQtd.Location = new System.Drawing.Point(370, 401);
            this.textBoxQtd.Name = "textBoxQtd";
            this.textBoxQtd.Size = new System.Drawing.Size(44, 20);
            this.textBoxQtd.TabIndex = 20;
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.Teal;
            this.BackgroundImage = global::WallpaperChanger.Properties.Resources.back;
            this.ClientSize = new System.Drawing.Size(544, 433);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxQtd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxPasta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxPersonagem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelDownload);
            this.Controls.Add(this.textBoxAnime);
            this.Controls.Add(this.buttonDownload);
            this.Controls.Add(this.imagemExemplo);
            this.Controls.Add(this.LabelIntervaloTempo);
            this.Controls.Add(this.LabelPastaImagens);
            this.Controls.Add(this.LabelAlteraPasta);
            this.Controls.Add(this.BtnAlteraPasta);
            this.Controls.Add(this.LabelAlteraIntervalo);
            this.Controls.Add(this.LabelAlteraImagem);
            this.Controls.Add(this.TxtTempo);
            this.Controls.Add(this.BtnAlteraIntervalo);
            this.Controls.Add(this.LabelFileName);
            this.Controls.Add(this.BtnAlteraImagem);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "BackgroundChanger";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.imagemExemplo.ResumeLayout(false);
            this.imagemExemplo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion


        private System.Windows.Forms.Button BtnAlteraImagem;
        private System.Windows.Forms.Label LabelFileName;
        public System.Windows.Forms.Timer TimerAlteraImagem;
        private System.Windows.Forms.Button BtnAlteraIntervalo;
        private System.Windows.Forms.TextBox TxtTempo;
        private System.Windows.Forms.Label LabelTitulo;
        private System.Windows.Forms.Label LabelAlteraImagem;
        private System.Windows.Forms.Label LabelAlteraIntervalo;
        private System.Windows.Forms.Button BtnAlteraPasta;
        private System.Windows.Forms.Label LabelAlteraPasta;
        private System.Windows.Forms.Label LabelPastaImagens;
        private System.Windows.Forms.FolderBrowserDialog EscolherPasta;
        private System.Windows.Forms.Label LabelIntervaloTempo;
        private System.Windows.Forms.FlowLayoutPanel imagemExemplo;
        private System.Windows.Forms.Label labelDownload;
        private System.Windows.Forms.TextBox textBoxAnime;
        private System.Windows.Forms.Button buttonDownload;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPersonagem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxPasta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxQtd;
    }
}

