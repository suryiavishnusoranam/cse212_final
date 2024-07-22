public class AVLTree<T> where T : IComparable<T>
{
    private TreeNode<T> _root;

    public void Insert(T data)
    {
        _root = InsertRec(_root, data);
    }

    private TreeNode<T> InsertRec(TreeNode<T> node, T data)
    {
        if (node == null)
            return new TreeNode<T> { Data = data };

        int cmp = data.CompareTo(node.Data);

        if (cmp < 0)
            node.Left = InsertRec(node.Left, data);
        else if (cmp > 0)
            node.Right = InsertRec(node.Right, data);
        else
            return node; // Duplicate values are not allowed

        // Update height
        node.Height = 1 + Math.Max(GetHeight(node.Left), GetHeight(node.Right));

        // Balance the node
        return Balance(node);
    }

    private TreeNode<T> Balance(TreeNode<T> node)
    {
        int balanceFactor = GetBalanceFactor(node);

        if (balanceFactor > 1)
        {
            if (GetBalanceFactor(node.Left) < 0)
                node.Left = RotateLeft(node.Left);
            return RotateRight(node);
        }

        if (balanceFactor < -1)
        {
            if (GetBalanceFactor(node.Right) > 0)
                node.Right = RotateRight(node.Right);
            return RotateLeft(node);
        }

        return node;
    }

    private TreeNode<T> RotateRight(TreeNode<T> y)
    {
        TreeNode<T> x = y.Left;
        TreeNode<T> T2 = x.Right;

        x.Right = y;
        y.Left = T2;

        // Update heights
        y.Height = 1 + Math.Max(GetHeight(y.Left), GetHeight(y.Right));
        x.Height = 1 + Math.Max(GetHeight(x.Left), GetHeight(x.Right));

        return x;
    }

    private TreeNode<T> RotateLeft(TreeNode<T> x)
    {
        TreeNode<T> y = x.Right;
        TreeNode<T> T2 = y.Left;

        y.Left = x;
        x.Right = T2;

        // Update heights
        x.Height = 1 + Math.Max(GetHeight(x.Left), GetHeight(x.Right));
        y.Height = 1 + Math.Max(GetHeight(y.Left), GetHeight(y.Right));

        return y;
    }

    private int GetHeight(TreeNode<T> node)
    {
        return node?.Height ?? 0;
    }

    private int GetBalanceFactor(TreeNode<T> node)
    {
        return node == null ? 0 : GetHeight(node.Left) - GetHeight(node.Right);
    }

    // In-order traversal to print the tree
    public void PrintInOrder()
    {
        PrintInOrderRec(_root);
    }

    private void PrintInOrderRec(TreeNode<T> node)
    {
        if (node != null)
        {
            PrintInOrderRec(node.Left);
            Console.WriteLine(node.Data);
            PrintInOrderRec(node.Right);
        }
    }
}
