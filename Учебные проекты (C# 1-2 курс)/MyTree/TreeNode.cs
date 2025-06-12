using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTree
{
    internal class TreeNode<T>
    {
        public TreeNode(T value, TreeNode<T> parent = null)
        {
            this.value = value;
            this.parent = parent;
        }
        public T value;
        public TreeNode<T> left;
        public TreeNode<T> right;
        public TreeNode<T> parent;
    }
}
