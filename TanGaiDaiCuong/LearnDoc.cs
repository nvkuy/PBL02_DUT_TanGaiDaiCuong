namespace TanGaiDaiCuong
{
    internal class LearnDoc : Doc
    {
        private string linkVideo
        {
            get { return linkVideo; }
            set { linkVideo = value; }
        }
        
        LearnDoc() { }

        LearnDoc(ref string data)
        {
            string[] arr = data.Replace('#', '\n').Split('|');
            title = arr[0];
            content = arr[1];
            linkVideo = arr[2];
        }

    }
}
