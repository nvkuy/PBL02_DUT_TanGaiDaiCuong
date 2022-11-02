using System.Windows.Forms;

namespace TanGaiDaiCuong
{
    internal class Doc
    {
        protected string title { get; set; }

        protected string content { get; set; }

        public virtual string encode() { return ""; }
        public virtual void saveFile() { }

    }
}
