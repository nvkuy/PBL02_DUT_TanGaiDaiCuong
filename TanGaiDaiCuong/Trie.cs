using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TanGaiDaiCuong
{
    public class Trie
    {
        private TrieNode root;

        public Trie() { root = new TrieNode(); }

        private TrieNode find(string data)
        {
            TrieNode node = root;
            for (int i = 0; i < data.Length; i++)
            {
                node = node.getChild(data[i]);
            }
            return node;
        }

        private void dfs(TrieNode node, List<int> rs)
        {
            List<int> t1 = node.EndOf;
            List<char> t2 = node.Keys;
            foreach (int t3 in t1)
                rs.Add(t3);
            foreach (char t3 in t2)
                dfs(node.getChild(t3), rs);
        }

        public void insert(string data, int id) {
            TrieNode node = find(data);
            node.addEnd(id);
        }

        public List<int> findAll(string data)
        {
            List<int> rs = new List<int>();
            TrieNode node = find(data);
            dfs(node, rs);
            return rs;
        }

        public int findAny(string data)
        {
            TrieNode node = find(data);
            while (node.anyEnd() == -1)
            {
                if (node.numOfChild() == 0)
                    return -1;
                node = node.getChild(node.anyChild());
            }
            return node.anyEnd();
        }

    }
}
