using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeahTagLibEditor
{
    class MusicAlbum
    {
        private List<string> mp3Names;
        public string songFolder { get; set; }
        public string author { get; set; }
        public string album { get; set; }
        public string mp3TextFileName { get; set; }
        public string songFormat { get; set; }
        public RichTextBox rtb { get; set;  }

        public Boolean previewResult { get; set; }

        public void readFile()
        {
            if (string.IsNullOrEmpty(mp3TextFileName))
                return;

            mp3Names = new List<string>();

            string line = null;
            StreamReader sr = new StreamReader(mp3TextFileName);
            int i = 0;
            
            //rtb. += "Read mp3 names from text file\n";
            while ((line = sr.ReadLine()) != null)
            {
                //string[] line_split = line.Split('.');
                //string single_split = line_split[1].Trim();
                string single_split = line.Trim();

                //rtb.AppendText("" + (++i) + "  " + single_split + "\n");
                //s += "" + (++i) + "  " + single_split + "\n";
                mp3Names.Add(single_split);
            }
            sr.Close();
        }

        public void getMediaFromFolder()
        {
            int i = 0;
            rtb.Text="";
            foreach (string f in Directory.GetFiles(songFolder))
            {
                string ext = Path.GetExtension(f);

                if (!ext.Contains(songFormat))
                    continue;

                updateMp3Name(f, mp3Names[i]);
                rtb.AppendText("" + (++i) + " [" + f + "]\n");
                rtb.AppendText("--------------------------\n");
                //hello_div.InnerHtml += "<p>" + (++i) + f + "</p>";
            }

        }

        public void updateMp3Name(string path, string newMp3Name)
        {

            TagLib.File f = TagLib.File.Create(path);
            
            //hello_div.InnerHtml += "<p>updating " + f.Tag.Title + " to " + newMp3Name + "</p>";
            rtb.AppendText("updating [" + f.Tag.Title + "] to [" + newMp3Name + "].\n");

            if (!string.IsNullOrEmpty(author))
                rtb.AppendText("performer from [" + sArrayToString(f.Tag.Performers) + "] to [" + author + "].\n");

            if (!string.IsNullOrEmpty(album))
            rtb.AppendText("album from [" + f.Tag.Album + "] to [" + album + "]\n");
            

            if (!previewResult) {
                f.Tag.Title = newMp3Name;

                if (!(string.IsNullOrEmpty(author)))
                {
                    f.Tag.Performers = author.Split(',');
                }

                if (!(string.IsNullOrEmpty(album)))
                {
                    f.Tag.Album=  album;
                }

                f.Save();
            }

        }

        public string sArrayToString(string[] sArray) {
            string s = "";
            for (int i = 0; i < sArray.Length; i++) {
                s += sArray[i] + " ";
            }
            return s;
        }
    }
}
