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

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        static extern int SystemParametersInfo(int uAction, int uParam, string lpvParam, int fuWinIni);

        public void Set()
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey(@"Control Panel\Desktop", true);

            SystemParametersInfo(SetDeskWallpaper, 0, FileName, UpdateIniFile | SendWinIniChange);
        }

        private void UpdateWallpaper()
        {
            string path = @"C:\Users\T-Gamer\Pictures\walpapers-sao";

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


            FileName = @"C:\Users\T-Gamer\Pictures\walpapers-sao\" + fileName;

            labelFileName.Text = FileName;

            Set();

        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            UpdateWallpaper();
        }

        private void labelFileName_Click(object sender, EventArgs e)
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            UpdateWallpaper();
        }
    }
}