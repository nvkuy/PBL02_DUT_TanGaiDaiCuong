using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Xml.Linq;
using System.IO;

namespace TanGaiDaiCuong
{
    internal class DictDoc : Doc
    {
        private string response { get; set; }

        public DictDoc() { }

        public DictDoc(ref string encodedData) {
            string[] arr = encodedData.Replace("#", System.Environment.NewLine).Split('|');
            title = arr[0];
            content = arr[1];
            response = arr[2];
        }

        public DictDoc(string tt, string ct, string rp) {
            title = tt;
            content = ct;
            response = rp;
        }

        public override string encode()
        {
            return title + '|' 
                + content.Replace(System.Environment.NewLine, "#") + '|' 
                + response.Replace(System.Environment.NewLine, "#");
        }

        public override void saveFile()
        {
            Directory.CreateDirectory("database");
            File.AppendAllText(@"database\dict.txt", this.encode() + System.Environment.NewLine);
        }

    }
}
