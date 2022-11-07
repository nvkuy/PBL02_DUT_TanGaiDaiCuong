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
    public partial class dict : Form
    {
        private List<int> found_data;
        public dict()
        {
            InitializeComponent();
        
        }

        private void loadListView()
        {
            lvDict.Items.Clear();
            if (found_data.Count == 0 || found_data[0] == -1)
            {
                lvDict.Items.Add("Không tìm thấy từ nào bắt đầu bằng: " + tbSearch.Text);
                return;
            }
            foreach (int id in found_data)
            {
                lvDict.Items.Add(welcome.dataDictDoc[id].Title);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            found_data = new List<int>();
            found_data = welcome.dictTrie.findAll(tbSearch.Text);
            loadListView();
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            found_data = new List<int>();
            found_data.Add(welcome.dictTrie.findAny(tb.Text));
            loadListView();
        }

        private void lvDict_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView lv = sender as ListView;
            if (lv.SelectedItems.Count > 0 && found_data.Count > 0 && found_data[lv.SelectedItems[0].Index] != -1)
            {
                ListViewItem lvi = lv.SelectedItems[0];
                detailDoc ddoc = new detailDoc();
                this.Hide();
                ddoc.displayDoc(welcome.dataDictDoc[lvi.Index]);
                ddoc.ShowDialog();
                this.Show();
            }
        }
    }
}
