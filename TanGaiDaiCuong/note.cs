using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TanGaiDaiCuong
{
    public partial class note : Form
    {
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
    }
}
