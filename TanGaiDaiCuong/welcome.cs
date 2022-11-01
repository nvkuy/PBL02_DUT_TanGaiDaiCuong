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
    public partial class welcome : Form
    {
        public welcome()
        {
            InitializeComponent();
        }

        private void goDict_Click(object sender, EventArgs e)
        {
            dict fDict = new dict();
            this.Hide();
            fDict.ShowDialog();
            this.Show();
        }

        private void goLearn_Click(object sender, EventArgs e)
        {
            learn fLearn = new learn();
            this.Hide();
            fLearn.ShowDialog();
            this.Show();
        }

        private void goNote_Click(object sender, EventArgs e)
        {
            note fNote = new note();
            this.Hide();
            fNote.ShowDialog();
            this.Show();
        }
    }
}
