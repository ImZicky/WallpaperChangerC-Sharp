﻿namespace WallpaperChanging
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
            this.SuspendLayout();
            // 
            // BtnAlteraImagem
            // 
            this.BtnAlteraImagem.BackColor = System.Drawing.Color.DarkSlateGray;
            this.BtnAlteraImagem.Location = new System.Drawing.Point(10, 69);
            this.BtnAlteraImagem.Name = "BtnAlteraImagem";
            this.BtnAlteraImagem.Size = new System.Drawing.Size(129, 22);
            this.BtnAlteraImagem.TabIndex = 0;
            this.BtnAlteraImagem.Text = "Alterar Imagem";
            this.BtnAlteraImagem.UseVisualStyleBackColor = false;
            this.BtnAlteraImagem.Click += new System.EventHandler(this.BtnAlteraImagem_Click);
            // 
            // LabelFileName
            // 
            this.LabelFileName.AutoSize = true;
            this.LabelFileName.BackColor = System.Drawing.Color.DarkKhaki;
            this.LabelFileName.ForeColor = System.Drawing.Color.SaddleBrown;
            this.LabelFileName.Location = new System.Drawing.Point(149, 74);
            this.LabelFileName.Name = "LabelFileName";
            this.LabelFileName.Size = new System.Drawing.Size(91, 13);
            this.LabelFileName.TabIndex = 1;
            this.LabelFileName.Text = "[ imagem padrão ]";
            this.LabelFileName.Click += new System.EventHandler(this.LabelFileName_Click);
            // 
            // TimerAlteraImagem
            // 
            this.TimerAlteraImagem.Enabled = true;
            this.TimerAlteraImagem.Interval = 300000;
            this.TimerAlteraImagem.Tick += new System.EventHandler(this.TimerAlteraImagem_Tick);
            // 
            // BtnAlteraIntervalo
            // 
            this.BtnAlteraIntervalo.BackColor = System.Drawing.Color.DarkSlateGray;
            this.BtnAlteraIntervalo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BtnAlteraIntervalo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnAlteraIntervalo.Location = new System.Drawing.Point(10, 128);
            this.BtnAlteraIntervalo.Margin = new System.Windows.Forms.Padding(0);
            this.BtnAlteraIntervalo.Name = "BtnAlteraIntervalo";
            this.BtnAlteraIntervalo.Size = new System.Drawing.Size(128, 23);
            this.BtnAlteraIntervalo.TabIndex = 2;
            this.BtnAlteraIntervalo.Text = "Alterar Intervalo";
            this.BtnAlteraIntervalo.UseVisualStyleBackColor = false;
            this.BtnAlteraIntervalo.Click += new System.EventHandler(this.BtnAlteraIntervalo_Click);
            // 
            // TxtTempo
            // 
            this.TxtTempo.Location = new System.Drawing.Point(150, 130);
            this.TxtTempo.Name = "TxtTempo";
            this.TxtTempo.Size = new System.Drawing.Size(91, 20);
            this.TxtTempo.TabIndex = 3;
            this.TxtTempo.TextChanged += new System.EventHandler(this.TxtTempo_TextChanged);
            // 
            // LabelTitulo
            // 
            this.LabelTitulo.AutoSize = true;
            this.LabelTitulo.BackColor = System.Drawing.Color.Olive;
            this.LabelTitulo.Location = new System.Drawing.Point(34, 9);
            this.LabelTitulo.Name = "LabelTitulo";
            this.LabelTitulo.Padding = new System.Windows.Forms.Padding(150, 1, 150, 1);
            this.LabelTitulo.Size = new System.Drawing.Size(439, 15);
            this.LabelTitulo.TabIndex = 4;
            this.LabelTitulo.Text = "BACKGROUND CHANGER";
            // 
            // LabelAlteraImagem
            // 
            this.LabelAlteraImagem.AutoSize = true;
            this.LabelAlteraImagem.Location = new System.Drawing.Point(12, 47);
            this.LabelAlteraImagem.Name = "LabelAlteraImagem";
            this.LabelAlteraImagem.Padding = new System.Windows.Forms.Padding(3);
            this.LabelAlteraImagem.Size = new System.Drawing.Size(150, 19);
            this.LabelAlteraImagem.TabIndex = 5;
            this.LabelAlteraImagem.Text = "Mudar Imagem Manualmente";
            // 
            // LabelAlteraIntervalo
            // 
            this.LabelAlteraIntervalo.AutoSize = true;
            this.LabelAlteraIntervalo.Location = new System.Drawing.Point(12, 105);
            this.LabelAlteraIntervalo.Name = "LabelAlteraIntervalo";
            this.LabelAlteraIntervalo.Padding = new System.Windows.Forms.Padding(3);
            this.LabelAlteraIntervalo.Size = new System.Drawing.Size(140, 19);
            this.LabelAlteraIntervalo.TabIndex = 6;
            this.LabelAlteraIntervalo.Text = "Alterar Intervalo De Tempo";
            // 
            // BtnAlteraPasta
            // 
            this.BtnAlteraPasta.BackColor = System.Drawing.Color.DarkSlateGray;
            this.BtnAlteraPasta.Location = new System.Drawing.Point(11, 186);
            this.BtnAlteraPasta.Name = "BtnAlteraPasta";
            this.BtnAlteraPasta.Size = new System.Drawing.Size(128, 23);
            this.BtnAlteraPasta.TabIndex = 7;
            this.BtnAlteraPasta.Text = "Alterar Pasta";
            this.BtnAlteraPasta.UseVisualStyleBackColor = false;
            this.BtnAlteraPasta.Click += new System.EventHandler(this.BtnAlteraPasta_Click);
            // 
            // LabelAlteraPasta
            // 
            this.LabelAlteraPasta.AutoSize = true;
            this.LabelAlteraPasta.Location = new System.Drawing.Point(12, 164);
            this.LabelAlteraPasta.Name = "LabelAlteraPasta";
            this.LabelAlteraPasta.Padding = new System.Windows.Forms.Padding(3);
            this.LabelAlteraPasta.Size = new System.Drawing.Size(133, 19);
            this.LabelAlteraPasta.TabIndex = 8;
            this.LabelAlteraPasta.Text = "Alterar Pasta De Imagens";
            // 
            // LabelPastaImagens
            // 
            this.LabelPastaImagens.AutoSize = true;
            this.LabelPastaImagens.BackColor = System.Drawing.Color.DarkKhaki;
            this.LabelPastaImagens.ForeColor = System.Drawing.Color.SaddleBrown;
            this.LabelPastaImagens.Location = new System.Drawing.Point(145, 191);
            this.LabelPastaImagens.Name = "LabelPastaImagens";
            this.LabelPastaImagens.Size = new System.Drawing.Size(81, 13);
            this.LabelPastaImagens.TabIndex = 9;
            this.LabelPastaImagens.Text = "[ pasta padrão ]";
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
            this.LabelIntervaloTempo.Location = new System.Drawing.Point(247, 133);
            this.LabelIntervaloTempo.Name = "LabelIntervaloTempo";
            this.LabelIntervaloTempo.Size = new System.Drawing.Size(84, 13);
            this.LabelIntervaloTempo.TabIndex = 10;
            this.LabelIntervaloTempo.Text = "[ tempo padrão ]";
            this.LabelIntervaloTempo.Click += new System.EventHandler(this.LabelIntervaloTempo_Click);
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.Teal;
            this.BackgroundImage = global::WallpaperChanger.Properties.Resources.back;
            this.ClientSize = new System.Drawing.Size(509, 241);
            this.Controls.Add(this.LabelIntervaloTempo);
            this.Controls.Add(this.LabelPastaImagens);
            this.Controls.Add(this.LabelAlteraPasta);
            this.Controls.Add(this.BtnAlteraPasta);
            this.Controls.Add(this.LabelAlteraIntervalo);
            this.Controls.Add(this.LabelAlteraImagem);
            this.Controls.Add(this.LabelTitulo);
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
    }
}

