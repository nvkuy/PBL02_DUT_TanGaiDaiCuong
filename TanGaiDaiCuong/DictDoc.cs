using System.Linq.Expressions;
using System.Reflection;
using System.Text;

namespace TanGaiDaiCuong
{
    internal class DictDoc : Doc
    {
        private string response
        {
            get { return response; }
            set { response = value; }
        }

        DictDoc() { }

        DictDoc(ref string data) {
            string[] arr = data.Replace("#", System.Environment.NewLine).Split('|');
            title = arr[0];
            content = arr[1];
            response = arr[2];
        }

    }
}
