using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace OpinionatedCode.Collections
{
    public sealed class RedBlackTree<TKey, TValue>
    {
        private readonly RedBlackTreeNode<TKey, TValue> _leaf = RedBlackTreeNode<TKey, TValue>.CreateLeaf();

        public RedBlackTree()
        {
            Root = _leaf;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public TValue Get(TKey key)
        {
            int hashedKey = key.GetHashCode();
            RedBlackTreeNode<TKey, TValue> node = Root;
            do
            {
                if (node == null)
                    return default(TValue);
                if (node.HashedKey == hashedKey)
                    return node.Value;
                node = hashedKey < node.HashedKey ? node.Left : node.Right;
            } while (true);
            if (node == null)
                return default(TValue);
            return node.Value;
        }

        internal RedBlackTreeNode<TKey, TValue> Root { get; private set; }

        public void Add(TKey key, TValue value)
        {
            RedBlackTreeNode<TKey, TValue> newNode = RedBlackTreeNode<TKey, TValue>.CreateNode(key, value, RedBlackTreeNode<TKey, TValue>.ColorEnum.Red, key.GetHashCode());
            Insert(newNode);
        }

        private void Insert(RedBlackTreeNode<TKey, TValue> z)
        {
            var y = _leaf;
            var x = Root;
            while (x != _leaf)
            {
                y = x;
                x = z.HashedKey < x.HashedKey ? x.Left : x.Right;
            }

            z.Parent = y;
            if (y == _leaf)
            {
                Root = z;
            }
            else if (z.HashedKey < y.HashedKey)
            {
                y.Left = z;
            }
            else
            {
                y.Right = z;
            }

            z.Left = _leaf;
            z.Right = _leaf;
            z.Color = RedBlackTreeNode<TKey, TValue>.ColorEnum.Red;
            InsertFixup(z);
        }

        private void InsertFixup(RedBlackTreeNode<TKey, TValue> z)
        {
            while (z.Parent.Color == RedBlackTreeNode<TKey, TValue>.ColorEnum.Red)
            {
                if (z.Parent == z.Parent.Parent.Left)
                {
                    var y = z.Parent.Parent.Right;
                    if (y.Color == RedBlackTreeNode<TKey, TValue>.ColorEnum.Red)
                    {
                        z.Parent.Color = RedBlackTreeNode<TKey, TValue>.ColorEnum.Black;
                        y.Color = RedBlackTreeNode<TKey, TValue>.ColorEnum.Black;
                        z.Parent.Parent.Color = RedBlackTreeNode<TKey, TValue>.ColorEnum.Red;
                        z = z.Parent.Parent;
                    }
                    else {
                        if (z == z.Parent.Right)
                        {
                            z = z.Parent;
                            RotateLeft(z);
                        }

                        z.Parent.Color = RedBlackTreeNode<TKey, TValue>.ColorEnum.Black;
                        z.Parent.Parent.Color = RedBlackTreeNode<TKey, TValue>.ColorEnum.Red;
                        RotateRight(z.Parent.Parent);
                    }
                }
                else
                {
                    var y = z.Parent.Parent.Left;
                    if (y.Color == RedBlackTreeNode<TKey, TValue>.ColorEnum.Red)
                    {
                        z.Parent.Color = RedBlackTreeNode<TKey, TValue>.ColorEnum.Black;
                        y.Color = RedBlackTreeNode<TKey, TValue>.ColorEnum.Black;
                        z.Parent.Parent.Color = RedBlackTreeNode<TKey, TValue>.ColorEnum.Red;
                        z = z.Parent.Parent;
                    }
                    else
                    {
                        if (z == z.Parent.Left)
                        {
                            z = z.Parent;
                            RotateRight(z);
                        }

                        z.Parent.Color = RedBlackTreeNode<TKey, TValue>.ColorEnum.Black;
                        z.Parent.Parent.Color = RedBlackTreeNode<TKey, TValue>.ColorEnum.Red;
                        RotateLeft(z.Parent.Parent);
                    }
                }
            }

            Root.Color = RedBlackTreeNode<TKey, TValue>.ColorEnum.Black;
        }

        private void RotateLeft(RedBlackTreeNode<TKey, TValue> x)
        {
            var y = x.Right;
            x.Right = y.Left;
            if (y.Left != _leaf)
            {
                y.Left.Parent = x;
            }

            y.Parent = x.Parent;
            if (x.Parent == _leaf)
            {
                Root = y;
            }
            else if (x == x.Parent.Left)
            {
                x.Parent.Left = y;
            }
            else
            {
                x.Parent.Right = y;
            }

            y.Left = x;
            x.Parent = y;
        }

        private void RotateRight(RedBlackTreeNode<TKey, TValue> x)
        {
            var y = x.Left;
            x.Left = y.Right;
            if (y.Right != _leaf)
            {
                y.Right.Parent = x;
            }
            y.Parent = x.Parent;
            if (x.Parent == _leaf)
            {
                Root = y;
            }
            else if (x == x.Parent.Left)
            {
                x.Parent.Left = y;
            }
            else
            {
                x.Parent.Right = y;
            }

            y.Right = x;
            x.Parent = y;
        }
    }
}
