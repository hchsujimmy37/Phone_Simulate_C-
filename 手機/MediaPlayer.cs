using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace 手機
{
    public partial class MediaPlayer : Form
    {
        private List<ImageFile> files = new List<ImageFile>();
        public MediaPlayer()
        {
            InitializeComponent();
        }
        private Form1 form1;

        public MediaPlayer(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
            VideoList.ValueMember = "Path";
            VideoList.DisplayMember = "FileName";
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void MediaPlayer_Load(object sender, EventArgs e)
        {

        }

        private void VideoList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ImageFile file = VideoList.SelectedItem as ImageFile;
            if (file != null)
            {
                axWindowsMediaPlayer.URL = file.Path;
                axWindowsMediaPlayer.Ctlcontrols.play();
            }
        }

        private void Open_btn_Click(object sender, EventArgs e)
        {
            files.Clear();
            using (OpenFileDialog ofd = new OpenFileDialog() { Multiselect = true, ValidateNames = true, Filter = "WMV|*.wmv|WAV|*.wav|MP3|*.mp3|MP4|*.mp4|MKV|*.mkv" })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    
                    foreach (string FileName in ofd.FileNames)
                    {
                        FileInfo fo = new FileInfo(FileName);
                        files.Add(new ImageFile() { FileName = Path.GetFileNameWithoutExtension(fo.FullName), Path = fo.FullName });
                    }
                    VideoList.DataSource = null;
                    VideoList.DataSource = files;
                    VideoList.ValueMember = "Path";
                    VideoList.DisplayMember = "FileName";
                }
            }
        }

        private void MediaPlayer_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 f1 = (Form1)this.Owner;
            e.Cancel = true;
            f1.Show();
            Hide();
        }
    }
    public class ImageFile
    {
        public string FileName { get; set; }
        public string Path { get; set; }

    }
}
