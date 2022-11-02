using System;
using System.Windows.Forms;
using System.IO;
using System.Linq;
using System.Collections.Generic;


namespace TanGaiDaiCuong
{
    public partial class welcome : Form
    {
        public static List<LearnDoc> dataLearnDoc;
        public static List<DictDoc> dataDictDoc;

        public welcome()
        {
            InitializeComponent();
            loadData();
        }

        private void loadData()
        {
            Directory.CreateDirectory(@"database");
            File.AppendAllText(@"database\learn.txt", "");
            File.AppendAllText(@"database\dict.txt", "");
            dataLearnDoc = new List<LearnDoc>();
            dataDictDoc = new List<DictDoc>();
            string[] dataLinesLearn = File.ReadAllLines(@"database\learn.txt");
            foreach (string line in dataLinesLearn)
            {
                dataLearnDoc.Add(new LearnDoc(line));
            }
            string[] dataLinesDict = File.ReadAllLines(@"database\dict.txt");
            foreach (string line in dataLinesDict)
            {
                dataDictDoc.Add(new DictDoc(line));
            }
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
            loadData();
        }
    }
}
