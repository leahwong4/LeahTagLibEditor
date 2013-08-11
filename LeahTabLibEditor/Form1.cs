using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeahTagLibEditor
{
    public partial class Form1 : Form
    {
        private MusicAlbum ma;

        public Form1()
        {
            InitializeComponent();
            ma = new MusicAlbum();

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(songFolderTB.Text) || string.IsNullOrEmpty(songFormatTB.Text) || string.IsNullOrEmpty(textFileTB.Text)) {
                MessageBox.Show("Song Foler, Text File, Song Format cannot be empty!");
                return;
            }

            ma.album = AlbumTB.Text;
            ma.author = authorTB.Text;
            ma.songFormat = songFormatTB.Text;
            ma.songFolder = songFolderTB.Text;
            ma.mp3TextFileName = textFileTB.Text;
            ma.rtb = richTextBox1;

            if (checkBox1.Checked)
                ma.previewResult = true;
            else
                ma.previewResult = false;

            ma.readFile();
            ma.getMediaFromFolder();
        }

        private void AlbumTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        
    }
}
