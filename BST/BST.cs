using System;

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
