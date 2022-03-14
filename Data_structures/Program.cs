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
            Create_BST();
            Console.ReadLine();
        }
          public static void Create_BST()
            {
                BinarySearchTree<int> mybinarynode = new BinarySearchTree<int>();
                mybinarynode.CreateNode(56);
                mybinarynode.CreateNode(30);
                mybinarynode.CreateNode(70);
                mybinarynode.CreateNode(22);
                mybinarynode.CreateNode(40);
                mybinarynode.CreateNode(60);
                mybinarynode.CreateNode(95);
                mybinarynode.CreateNode(11);
                mybinarynode.CreateNode(65);
                mybinarynode.CreateNode(3);
                mybinarynode.CreateNode(16);
                mybinarynode.CreateNode(63);
                mybinarynode.CreateNode(67);
                mybinarynode.Root();
                mybinarynode.Display(mybinarynode.root);
                Console.WriteLine("The number of nodes in BST:{0}", mybinarynode.Size(mybinarynode.root));
            }
        
    }
}
