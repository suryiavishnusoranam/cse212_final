public class TreeNode<T> where T : IComparable<T>
{
    public T Data { get; set; }
    public TreeNode<T> Left { get; set; }
    public TreeNode<T> Right { get; set; }
    public int Height { get; set; } = 1; // Height of the node
}