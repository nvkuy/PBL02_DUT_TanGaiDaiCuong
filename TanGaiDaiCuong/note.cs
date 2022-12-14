using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace TanGaiDaiCuong
{
    public partial class note : Form
    {

        public static bool needUpdate;
        private const int max_digit_title = 60;

        public note()
        {
            InitializeComponent();
        }

        private void rbDict_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            if (rb.Checked)
            {
                lbSubContent.Text = "Cách xử lí:";
                btnChooseFile.Visible = false;
            } else
            {
                lbSubContent.Text = "File video hướng dẫn:";
                btnChooseFile.Visible = true;
            }
        }

        bool isValid(string title, string content, string subcontent) {
            if (title.Length == 0 || content.Length == 0 || title.Length > max_digit_title)
                return false;
            foreach (char c in (title + content + subcontent))
                if (c == '|' || c == '#')
                    return false;
            return true;
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            if (!isValid(tbTitle.Text, tbContent.Text, tbSubContent.Text))
            {
                MessageBox.Show("Dữ liệu tiêu đề hoặc nội dung không được rỗng, " +
                    "không được chứa kí tự # hoặc | tiêu đề không được quá " + 
                    max_digit_title + " kí tự");
                return;
            }
            Doc md;
            if (rbDict.Checked)
                md = new DictDoc(tbTitle.Text, tbContent.Text, tbSubContent.Text);
            else
                md = new LearnDoc(tbTitle.Text, tbContent.Text, tbSubContent.Text);
            md.saveFile();
            MessageBox.Show("Lưu thành công!");
            needUpdate = true;
        }

        private void btnChooseFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Chọn file video";
            ofd.Multiselect = false;
            ofd.ShowDialog();
            if (ofd.FileName == "")
                return;
            tbSubContent.Text = ofd.FileName;
            string tmp = tbSubContent.Text.Substring(tbSubContent.Text.Length - 3);
            if (tmp != "mp4" && tmp != "avi" && tmp != "wmv")
                tbSubContent.Text = "";
        }
    }
}
