using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTree
{
    internal class MyTree<T> where T : IComparable
    {
        TreeNode<T> root;
        public void Insert(T val)
        {
            if (root != null)
            {
                FindToInsert(root, val);
            }
            else root = new TreeNode<T>(val);
        }

        void FindToInsert(TreeNode<T> root, T val)
        {
            if (val.CompareTo(root.value) < 0) // val меньше root
            {
                if (root.left != null)
                {
                    FindToInsert(root.left, val);
                }
                else
                {
                    root.left = new TreeNode<T>(val, root);
                }
            }
            else if (val.CompareTo(root.value) > 0)
            {
                if (root.right != null)
                {
                    FindToInsert(root.left, val);
                }
                else
                {
                    root.right = new TreeNode<T>(val, root);
                }
            }
        }

        public T[] CLR()
        {
            List<T> tree = new List<T>();
            return new T[10];
        }

        public T[] Across()
        {
            List<T> tree = new List<T>();
            tree[0] = root.value;
        }
    }
}
