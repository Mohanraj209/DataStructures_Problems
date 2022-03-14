using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_structures
{
    internal class BinarySearchTree<T> where T : IComparable<T>
    {
        public T Nodedata { get; set; }
        public BinarySearchTree<T> leftTree { get; set; }
        public BinarySearchTree<T> rightTree { get; set; }
        public BinarySearchTree(T nodedata)
        {
            this.Nodedata = nodedata;
            this.leftTree = null;
            this.rightTree = null;
        }
        int leftCount = 0, rightCount = 0;
        bool result = false;

        public void Insert(T Item)
        {
            T currNodeValueData = this.Nodedata;
            if ((currNodeValueData.CompareTo(Item)) > 0)
            {
                if (this.leftTree == null)
                    this.leftTree = new BinarySearchTree<T>(Item);
                else
                    this.leftTree.Insert(Item);
            }
            else
            {
                if (this.rightTree == null)
                    this.rightTree = new BinarySearchTree<T>(Item);
                else
                    this.rightTree.Insert(Item);
            }
        }
        public void Display()
        {
            if (this.leftTree != null)
            {
                this.leftCount++;
                this.leftTree.Display();

            }
            Console.WriteLine(this.Nodedata.ToString());
            if (this.rightTree != null)
            {
                this.rightCount++;
                this.rightTree.Display();
            }
        }
    }
}
