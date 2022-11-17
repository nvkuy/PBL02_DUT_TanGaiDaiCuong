using OpinionatedCode.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TanGaiDaiCuong
{
    internal class TrieNode
    {
        private RedBlackTree<char, TrieNode> children;
        private List<int> endOf;
        private List<char> keys;

        public List<int> EndOf { get { return endOf; } }
        public List<char> Keys { get { return keys; } }

        public TrieNode()
        {
            children = new RedBlackTree<char, TrieNode>();
            endOf = new List<int>();
            keys = new List<char>();
        }

        public TrieNode getChild(char c)
        {
            if (children.Get(c) == default(TrieNode))
            {
                children.Add(c, new TrieNode());
                keys.Add(c);
            }
            return children.Get(c);
        }

        public int numOfChild()
        {
            return keys.Count;
        }

        public int anyEnd()
        {
            if (endOf.Count == 0)
                return -1;
            return endOf[0];
        }

        public char anyChild()
        {
            return keys[0];
        }

        public void addEnd(int id)
        {
            endOf.Add(id);
        }

    }
}
