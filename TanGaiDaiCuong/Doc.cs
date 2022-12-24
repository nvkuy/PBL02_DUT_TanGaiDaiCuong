using System;
using System.Drawing;
using System.Windows.Forms;

namespace TanGaiDaiCuong
{
    public class Doc : FileController
    {
        private string title;

        private string content;

        public string Title { get { return title; } set { title = value; } }
        public string Content { get { return content; } set { content = value; } }

        public virtual string encode() { return ""; }
        public virtual void saveFile() { }

        public virtual void display() {
            detailDoc.lb_title.Text = Title;
            detailDoc.lb_content.Text = Content;
            Size size = TextRenderer.MeasureText(detailDoc.lb_content.Text, detailDoc.lb_content.Font);
            detailDoc.lb_content.Width = Math.Max(detailDoc.instance.Width, size.Width);
            detailDoc.lb_content.Height = size.Height;
        }

    }
}
