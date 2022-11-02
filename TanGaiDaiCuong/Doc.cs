using System.Windows.Forms;

namespace TanGaiDaiCuong
{
    public class Doc
    {
        public string title { get; set; }

        public string content { get; set; }

        public virtual string encode() { return ""; }
        public virtual void saveFile() { }

    }
}
