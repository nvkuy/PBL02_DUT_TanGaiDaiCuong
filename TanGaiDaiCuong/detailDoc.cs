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
    
    public partial class detailDoc : Form
    {
        public detailDoc()
        {
            InitializeComponent();
        }

        public void displayDoc(Doc md)
        {
            lbTitle.Text = md.title;
            Label lb_content = new Label();
            lb_content.Text = md.content;
            lb_content.AutoSize = true;
            flowContent.Controls.Add(lb_content);
        }
    }
}
