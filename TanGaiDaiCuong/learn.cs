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
    public partial class learn : Form
    {
        public learn()
        {
            InitializeComponent();
            loadListView();
        }

        private void loadListView()
        {
            foreach (LearnDoc ld in welcome.dataLearnDoc)
            {
                lvLearn.Items.Add(ld.title);
            }
        }

        private void lvLearn_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView lv = sender as ListView;
            if (lv.SelectedItems.Count > 0)
            {
                ListViewItem lvi = lv.SelectedItems[0];
                detailDoc ddoc = new detailDoc();
                this.Hide();
                ddoc.displayDoc(welcome.dataLearnDoc[lvi.Index]);
                ddoc.ShowDialog();
                this.Show();
            }
        }
    }
}
