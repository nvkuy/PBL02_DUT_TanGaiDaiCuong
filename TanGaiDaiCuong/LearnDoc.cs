using System.IO;
using System.Runtime.InteropServices.ComTypes;

namespace TanGaiDaiCuong
{
    public class LearnDoc : Doc
    {
        private string linkVideo;

        public string LinkVideo { 
            get { return linkVideo; } 
            set {
                string t1 = value;
                if (t1.Length > 4) {
                    string t2 = t1.Substring(t1.Length - 3);
                    if ((t2 != "mp4" && t2 != "avi" && t2 != "wmv"))
                        t1 = "";
                } else
                    t1 = "";
                linkVideo = t1;
            } 
        }

        public LearnDoc() { }

        public LearnDoc(string encodedData)
        {
            string[] arr = encodedData.Replace("#", System.Environment.NewLine).Split('|');
            title = arr[0];
            content = arr[1];
            LinkVideo = arr[2];
        }

        public LearnDoc(string tt, string ct, string link)
        {
            title = tt;
            content = ct;
            LinkVideo = link;
        }

        public override string encode()
        {
            return title + '|'
                + content.Replace(System.Environment.NewLine, "#") + '|'
                + LinkVideo;
        }

        public override void saveFile()
        {
            Directory.CreateDirectory("database");
            if (linkVideo.Length > 0)
            {
                Directory.CreateDirectory(@"database\video");
                string[] tmp = linkVideo.Replace(@"\", "/").Split('/');
                string flink = @"database\video\" + tmp[tmp.Length - 1];
                if (!File.Exists(flink))
                    File.Copy(linkVideo, flink);
                linkVideo = flink;
            }
            File.AppendAllText(@"database\learn.txt", this.encode() + System.Environment.NewLine);
        }

    }
}
