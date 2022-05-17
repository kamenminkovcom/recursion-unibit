namespace BST
{
    internal class Node
    {
        public int Value { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }

        public Node(int value, Node left, Node rigth)
        {
            Value = value;
            Left = left;
            Right = rigth;
        }
    }
}
