using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_structures
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("-----------** Binary Search Tree **----------");
            BinarySearchTree<int> bst = new BinarySearchTree<int>(56);
            bst.Insert(30);
            bst.Insert(70);
            bst.Display();
        }
    }
}
