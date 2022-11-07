using AxWMPLib;
using System;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Policy;
using System.Windows.Forms;
using System.Xml.Linq;
using TanGaiDaiCuong.Properties;
using WMPLib;

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
            Title = arr[0];
            Content = arr[1];
            LinkVideo = arr[2];
        }

        public LearnDoc(string tt, string ct, string link)
        {
            Title = tt;
            Content = ct;
            LinkVideo = link;
        }

        public override string encode()
        {
            return Title + '|'
                + Content.Replace(System.Environment.NewLine, "#") + '|'
                + LinkVideo;
        }

        public override void saveFile()
        {
            Directory.CreateDirectory("database");
            if (LinkVideo.Length > 0)
            {
                Directory.CreateDirectory(@"database\video");
                string[] tmp = LinkVideo.Replace(@"\", "/").Split('/');
                string flink = @"database\video\" + tmp[tmp.Length - 1];
                if (!File.Exists(flink))
                    File.Copy(LinkVideo, flink);
                LinkVideo = flink;
            }
            File.AppendAllText(@"database\learn.txt", this.encode() + System.Environment.NewLine);
        }

        public override void display()
        {
            base.display();
            detailDoc.video_player.Visible = false;
            detailDoc.lb_response.Visible = false;
            if (File.Exists(LinkVideo))
            {
                detailDoc.video_player.settings.autoStart = false;
                //detailDoc.video_player.settings.setMode("Loop", true);
                detailDoc.video_player.Visible = true;
                detailDoc.video_player.Size = new Size(detailDoc.instance.Width, detailDoc.instance.Height);
                detailDoc.video_player.URL = LinkVideo;
            }
        }

    }
}
