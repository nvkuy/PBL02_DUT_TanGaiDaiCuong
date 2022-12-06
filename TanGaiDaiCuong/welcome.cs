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
        public static Trie dictTrie;

        public welcome()
        {
            InitializeComponent();
            loadData();
            //GenDict();
        }

        private void GenDict()
        {
            // sinh test kiem tra toc do tim kiem
            Random rd = new Random();
            for (int i = 0; i < 200000; i++)
            {
                for (int j = 0; j < 60; j++)
                    File.AppendAllText(@"database\dict.txt", "" + (char)(rd.Next(0, 26) + 'a'));
                File.AppendAllText(@"database\dict.txt", "|a|");
                File.AppendAllText(@"database\dict.txt", System.Environment.NewLine);

            }
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
            dictTrie = new Trie();
            for (int id = 0; id < dataDictDoc.Count; id++)
            {
                dictTrie.insert(dataDictDoc[id].Title, id);
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
            note.needUpdate = false;
            fNote.ShowDialog();
            this.Show();
            if (note.needUpdate)
                loadData();
        }
    }
}
