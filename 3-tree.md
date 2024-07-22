
## Tree

```markdown
# Trees

## Introduction to Trees

A tree is a hierarchical data structure that consists of nodes connected by edges. Each tree has a root node and zero or more child nodes.

### Definition and Characteristics
- **Root**: The top node of the tree.
- **Node**: Contains data and references to child nodes.
- **Edge**: Connection between nodes.
- **Height**: The number of edges on the longest path from the root to a leaf.

### Types of Trees
- **Binary Trees**: Each node has at most two children.
- **Binary Search Trees (BST)**: Nodes are arranged so that for any node, left children are smaller and right children are larger.
- **AVL Trees**: A self-balancing BST where the difference in heights of left and right subtrees is at most one.

### Tree Operations
- **Insertion**: Add nodes while maintaining tree properties.
- **Deletion**: Remove nodes and rebalance if needed.
- **Traversal**: Pre-order, in-order, and post-order traversals.

### Implementing a Binary Search Tree

```csharp
public class TreeNode<T>
{
    public T Data { get; set; }
    public TreeNode<T> Left { get; set; }
    public TreeNode<T> Right { get; set; }
}

public class BinarySearchTree<T> where T : IComparable<T>
{
    private TreeNode<T> _root;

    public void Insert(T data)
    {
        _root = InsertRec(_root, data);
    }

    private TreeNode<T> InsertRec(TreeNode<T> root, T data)
    {
        if (root == null)
        {
            root = new TreeNode<T> { Data = data };
            return root;
        }

        if (data.CompareTo(root.Data) < 0)
            root.Left = InsertRec(root.Left, data);
        else if (data.CompareTo(root.Data) > 0)
            root.Right = InsertRec(root.Right, data);

        return root;
    }

    public int GetHeight()
    {
        return GetHeightRec(_root);
    }

    private int GetHeightRec(TreeNode<T> node)
    {
        if (node == null)
            return 0;

        int leftHeight = GetHeightRec(node.Left);
        int rightHeight = GetHeightRec(node.Right);

        return Math.Max(leftHeight, rightHeight) + 1;
    }
}
