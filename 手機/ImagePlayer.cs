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
    public partial class ImagePlayer : Form
    {
        public ImagePlayer()
        {
            InitializeComponent();
        }
        private Form1 form1;
        private List<PhotoFile> files = new List<PhotoFile>();
        private int photo_number = 0;
        public ImagePlayer(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
            PhotoList.ValueMember = "Path";
            PhotoList.DisplayMember = "FileName";
        }

        private void ImagePlayer_Load(object sender, EventArgs e)
        {

        }

        private void Prev_btn_Click(object sender, EventArgs e)
        {
            if (photo_number.Equals(0))
            {
                photo_number = files.Count - 1;
                PhotoBox.Image = Image.FromFile(files[photo_number].Path);
            }
            else
            {
                photo_number -= 1;
                PhotoBox.Image = Image.FromFile(files[photo_number].Path);
            }
        }

        private void Next_btn_Click(object sender, EventArgs e)
        {
            if (photo_number.Equals(files.Count - 1))
            {
                photo_number = 0;
                PhotoBox.Image = Image.FromFile(files[photo_number].Path);
            }
            else
            {
                photo_number += 1;
                PhotoBox.Image = Image.FromFile(files[photo_number].Path);
            }
        }

        private void Open_btn_Click(object sender, EventArgs e)
        {
            if (files.Count > 0) {
                files.Clear();
            }
            
            using (OpenFileDialog ofd = new OpenFileDialog() { Multiselect = true, ValidateNames = true, Filter = "PNG|*.png|JPEG|*.jpeg|GIF|*.gif|JPG|*.jpg|BMP|*.bmp" })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    foreach (string FileName in ofd.FileNames)
                    {
                        FileInfo fo = new FileInfo(FileName);
                        files.Add(new PhotoFile() { FileName = Path.GetFileNameWithoutExtension(fo.FullName), Path = fo.FullName });
                    }
                    PhotoList.DataSource = null;
                    PhotoList.DataSource = files;
                    PhotoList.ValueMember = "Path";
                    PhotoList.DisplayMember = "FileName";
                    Console.WriteLine(PhotoList.Controls.Count);
                }
            }
        }

        private void PhotoList_SelectedIndexChanged(object sender, EventArgs e)
        {
            PhotoFile file = PhotoList.SelectedItem as PhotoFile;
            if (file != null)
            {
                PhotoBox.Image = Image.FromFile(file.Path);
                photo_number = files.FindIndex(item => item.Path.Equals(file.Path));
            }
        }

        private void ImagePlayer_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 f1 = (Form1)this.Owner;
            e.Cancel = true;
            f1.Show();
            Hide();
        }
    }
    public class PhotoFile
    {
        public string FileName { get; set; }
        public string Path { get; set; }

    }
}
