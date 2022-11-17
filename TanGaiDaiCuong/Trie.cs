using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TanGaiDaiCuong
{
    public class Trie
    {
        private const int max_suggestion = 11, inf = (int)1e9 + 7;
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

        private void dfs(TrieNode node, List<int> rs, int max_size)
        {
            foreach (int t3 in node.EndOf)
            {
                if (rs.Count >= max_size)
                    return;
                rs.Add(t3);
            }
            foreach (char t3 in node.Keys)
                dfs(node.getChild(t3), rs, max_size);
        }

        public void insert(string data, int id) {
            TrieNode node = find(data);
            node.addEnd(id);
        }

        public List<int> findAll(string data)
        {
            List<int> rs = new List<int>();
            TrieNode node = find(data);
            dfs(node, rs, inf);
            return rs;
        }

        public List<int> findAny(string data)
        {
            /*TrieNode node = find(data);
            while (node.anyEnd() == -1)
            {
                if (node.numOfChild() == 0)
                    return -1;
                node = node.getChild(node.anyChild());
            }
            return node.anyEnd();*/
            List<int> rs = new List<int>();
            TrieNode node = find(data);
            dfs(node, rs, max_suggestion);
            return rs;
        }

    }
}
