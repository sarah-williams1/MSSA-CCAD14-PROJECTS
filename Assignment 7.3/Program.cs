using BinaryTree;
using Microsoft.VisualBasic;

namespace Assignment_7._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var binaryTree = new BinaryTree<int>();

            binaryTree.Add(8);
            binaryTree.Add(5);
            binaryTree.Add(12);
            binaryTree.Add(27);
            binaryTree.Add(35);
            binaryTree.Add(11);
            binaryTree.Add(22);
            binaryTree.Add(15);
            binaryTree.Add(10);
            binaryTree.Add(2);
            binaryTree.Add(1);
            binaryTree.Add(3);

            foreach (var item in binaryTree)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            binaryTree.PrintAsTree();
            Console.WriteLine();

            Console.WriteLine(binaryTree.Contains(12));
            //Console.WriteLine();
            //binaryTree.OrderDescending(); // This did nothing
            //binaryTree.PrintAsTree();
            Console.WriteLine();
           
            
        }

        
    }

    //public class FindSubTree
    //{
    //    public FindSubTree(BinaryTree<int> binaryTree)
    //    {
    //        binaryTree.OrderDescending();
    //        int treeRoot = root;
    //        int root = 12;
    //        if (root = 12) {
    //            binaryTree.PrintAsTree(root);
    //        }
    //    }
    //}
}
