using System;

/* 
* The problem description could be found in IsBST.md file
* IsBST.md is located in the root directory of the project
* Link to the description - https://github.com/kamenminkovcom/recursion-unibit/blob/master/IsBST.md
*/

namespace BST
{
    internal class BST
    {
        static void Main()
        {
            var node = new Node(10, new Node(15, null, null), new Node(11, null, null));
            Console.WriteLine(IsBST(node, int.MinValue, int.MaxValue));
        }

        public static bool IsBST(Node node, int min, int max)
        {
            if (node == null)
            {
                return true;
            }

            if (node.Value > max || node.Value <= min)
            {
                return false;
            }

            return IsBST(node.Left, min, node.Value) && IsBST(node.Right, node.Value, max);
        }
    }
}
