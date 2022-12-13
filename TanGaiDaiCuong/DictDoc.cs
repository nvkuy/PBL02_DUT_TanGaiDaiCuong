using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Xml.Linq;
using System.IO;
using System.Windows.Forms;
using System.Drawing;
using System;

namespace TanGaiDaiCuong
{
    public class DictDoc : Doc
    {
        private string response;

        public string Response { get { return response; } set { response = value; } }

        public DictDoc() { }

        public DictDoc(string encodedData) {
            string[] arr = encodedData.Replace("#", System.Environment.NewLine).Split('|');
            Title = arr[0];
            Content = arr[1];
            Response = arr[2];
        }

        public DictDoc(string tt, string ct, string rp) {
            Title = tt;
            Content = ct;
            Response = rp;
        }

        public override string encode()
        {
            return Title + '|' 
                + Content.Replace(System.Environment.NewLine, "#") + '|' 
                + Response.Replace(System.Environment.NewLine, "#");
        }

        public override void saveFile()
        {
            Directory.CreateDirectory("database");
            File.AppendAllText(@"database\dict.txt", this.encode() + System.Environment.NewLine);
        }

        public override void display()
        {
            base.display();
            detailDoc.video_player.Visible = false;
            detailDoc.lb_response.Visible = false;
            if (Response.Length > 0)
            {
                detailDoc.lb_response.Visible = true;
                detailDoc.lb_response.Text = "Cách xử lí: " + Response;
                Size size = TextRenderer.MeasureText(detailDoc.lb_response.Text, detailDoc.lb_response.Font);
                detailDoc.lb_response.Width = Math.Max(detailDoc.instance.Width, size.Width);
                detailDoc.lb_response.Height = size.Height;
            }
        }

    }
}
