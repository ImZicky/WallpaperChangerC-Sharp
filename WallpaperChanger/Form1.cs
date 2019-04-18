using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Microsoft.Win32;
using System.IO;
using Newtonsoft.Json;

namespace WallpaperChanging
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();

        }


        private void Form1_Load(object sender, EventArgs e)
        {


        }

        string FileName;
        const int SetDeskWallpaper = 20;
        const int UpdateIniFile = 0x01;
        const int SendWinIniChange = 0x02;
        int index = 0;
        string nmUsuario = Environment.UserName;
        public string RestoCaminho { get; private set; }
        public bool NaoAlterouPasta { get; set; }
        public int IntervaloTempo;
        bool tenhoQueSalvarNovoCaminho = false;

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        static extern int SystemParametersInfo(int uAction, int uParam, string lpvParam, int fuWinIni);

        public void Set()
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Control Panel\Desktop", true);

            SystemParametersInfo(SetDeskWallpaper, 0, FileName, UpdateIniFile | SendWinIniChange);
        }

        private void UpdateWallpaper()
        {

            string relativePath = null;
            if (NaoAlterouPasta == false)
            {
                relativePath = string.Format(@"C:\Users\{1}\Pictures", 1, nmUsuario);

                string conteudo = PegarArquivoJson(relativePath);
                if (string.IsNullOrEmpty(conteudo))
                {
                    relativePath = string.Format(@"C:\Users\{1}\Pictures", 1, nmUsuario);
                }
                else {
                    relativePath = conteudo;
                }
            }
            else {
                relativePath = relativePath = string.Format(@"C:\Users\{1}", 1, RestoCaminho);
                if (tenhoQueSalvarNovoCaminho) {
                    SalvaCaminho(relativePath);
                    tenhoQueSalvarNovoCaminho = false;
                }
            }

            string path = relativePath;

            var directory = new DirectoryInfo(path);
            int totalFiles = directory.GetFiles().Count<FileInfo>();
            var fileName = (from f in directory.GetFiles() orderby f.LastWriteTime descending select f).First<FileInfo>();
            if (index < totalFiles)
            {
                fileName = (from f in directory.GetFiles() orderby f.LastWriteTime descending select f).ElementAt<FileInfo>(index);
                index++;
            }
            else {
                index = 0;
            }


            FileName = string.Format("{1}\\{2} ", 2, relativePath, fileName);

            LabelFileName.Text = FileName.Substring(FileName.LastIndexOf("\\")+1);
            LabelPastaImagens.Text = FileName.Substring(0,FileName.LastIndexOf(LabelFileName.Text)-1);
            Set();

        }

        private string PegarArquivoJson(string relativePath)
        {
            string pastaRelativePathJson = string.Format(@"C:\Users\{1}\Documents\WallpaperChanger\relativePathJson.txt", 1, nmUsuario);
            string conteudo = string.Empty;

            if (!File.Exists(pastaRelativePathJson))
            {
                return null;
            }
            else {
                using (StreamReader sr = new StreamReader(pastaRelativePathJson))
                {
                    while (sr.Peek() >= 0)
                    {
                        conteudo = sr.ReadLine();
                    }
                    sr.Close();
                }
            }
            string relativePathDevolvido = JsonConvert.DeserializeObject<string>(conteudo);
            return relativePathDevolvido;
        }

        private void SalvaCaminho(string relativePath)
        {
            string relativePathJson = JsonConvert.SerializeObject(relativePath);
            string pastaRelativePathJson = string.Format(@"C:\Users\{1}\Documents\WallpaperChanger\", 1, nmUsuario);
            if (!Directory.Exists(pastaRelativePathJson))
            {
                Directory.CreateDirectory(pastaRelativePathJson);
            }
            FileStream fs = new FileStream(string.Format(@"C:\Users\{1}\Documents\WallpaperChanger\relativePathJson.txt", 1, nmUsuario), FileMode.Append);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine(relativePathJson);
            sw.Flush();
            sw.Close();
            fs.Close();
        }

        private void BtnAlteraImagem_Click(object sender, EventArgs e)
        {
            TimerAlteraImagem.Stop();
            TimerAlteraImagem.Interval = IntervaloTempo < 10000 ? 10000 : IntervaloTempo;
            TimerAlteraImagem.Start();
            UpdateWallpaper();
        }

        private void LabelFileName_Click(object sender, EventArgs e)
        {
        }

        private void TimerAlteraImagem_Tick(object sender, EventArgs e)
        {
            UpdateWallpaper();
        }

        private void BtnAlteraIntervalo_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtTempo.Text) || IntervaloTempo < 10000)
            {
                IntervaloTempo = 10000;
            }
            else {
                IntervaloTempo = Convert.ToInt32(TxtTempo.Text);
            }

            if (string.IsNullOrEmpty(TxtTempo.Text) || IntervaloTempo < 10000)
            {
                TimerAlteraImagem.Interval = 10000;
                LabelIntervaloTempo.Text = "10s";
                MessageBox.Show("o minimo que aceitamos é 10 segundos :)");
            }
            else
            {
                if ((Convert.ToInt32(TxtTempo.Text) / 1000) < 60)
                {
                    TimerAlteraImagem.Interval = IntervaloTempo;
                    LabelIntervaloTempo.Text = string.Format("{1}s", 1, Convert.ToInt32(TxtTempo.Text) / 1000);
                }
                else
                {
                    TimerAlteraImagem.Interval = IntervaloTempo;
                    LabelIntervaloTempo.Text = string.Format("{1:#,0.00} min", 1, (Convert.ToDecimal(TxtTempo.Text) / 1000) / 60);
                }


            }
        }

        private void TxtTempo_TextChanged(object sender, EventArgs e)
        {

        }


        private void BtnAlteraPasta_Click(object sender, EventArgs e)
        {
            EscolherPasta.ShowDialog();
            string pasta = EscolherPasta.SelectedPath;

            if (pasta.Length != 0)
            {
                RestoCaminho = pasta.Substring(pasta.LastIndexOf(nmUsuario));
                NaoAlterouPasta = true;
                UpdateWallpaper();
                LabelPastaImagens.Text = pasta;
                tenhoQueSalvarNovoCaminho = true;
            }
            else
            {
                MessageBox.Show("por favor, insira uma pasta valida");
            }
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void LabelPastaImagens_Click(object sender, EventArgs e)
        {

        }

        private void EscolherPasta_HelpRequest(object sender, EventArgs e)
        {

        }

        private void LabelIntervaloTempo_Click(object sender, EventArgs e)
        {

        }
    }
}