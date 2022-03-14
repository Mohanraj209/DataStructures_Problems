using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_structures
{
    internal class BinarySearchTree<T> where T : IComparable<T>
    {
        public INode<T> root;
        /// <summary>
        /// insert the node into bst.
        /// </summary>
        public void CreateNode(T value)
        {
            INode<T> newNode = new INode<T>(value);
            if (root == null)
            {
                root = newNode;
            }
            else
            {
                INode<T> parentNode = root;
                INode<T> currentNode = root;
                while (true)
                {
                    parentNode = currentNode;
                    if (currentNode.data.CompareTo(value) >= 0)
                    {
                        currentNode = currentNode.left;
                        if (currentNode == null)
                        {
                            parentNode.left = newNode;
                            break;
                        }
                    }
                    else
                    {
                        currentNode = currentNode.right;
                        if (currentNode == null)
                        {
                            parentNode.right = newNode;
                            break;
                        }
                    }
                }
            }
        }
        //Display Root Node.
        public void Root()
        {
            do
            {
                Console.WriteLine("BST Root Node:" + root.data);
                break;
            } while (root != null);
        }
        /// <summary>
        /// Displays Nodes in BST
        /// </summary>
        public void Display(INode<T> parent)
        {
            if (parent != null)
            {
                Display(parent.left);
                Display(parent.right);
                Console.WriteLine("{0} is BST Node", parent.data);
            }
        }
        /// <summary>
        /// length of bst
        /// </summary>
        public int Size(INode<T> root)
        {
            if (root == null)
                return 0;
            else
                return (Size(root.left) + 1 + Size(root.right));
        }
    }
}
