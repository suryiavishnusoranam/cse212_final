## Linked List

```markdown
# Linked Lists

## Introduction to Linked Lists

A linked list is a linear data structure where each element is a separate object, and each object contains a reference (link) to the next object in the sequence.

### Definition and Characteristics
- **Node**: Contains data and a reference to the next node.
- **Dynamic Size**: Can grow or shrink as needed.
- **Types**: Singly Linked List, Doubly Linked List, Circular Linked List.

### Types of Linked Lists
- **Singly Linked List**: Each node points to the next node.
- **Doubly Linked List**: Each node points to both the next and the previous node.
- **Circular Linked List**: The last node points back to the first node.

### Linked List Operations
- **Insertion**: Add nodes at various positions.
- **Deletion**: Remove nodes.
- **Traversal**: Visit nodes in sequence.

### Implementing a Singly Linked List

```csharp
public class Node<T>
{
    public T Data { get; set; }
    public Node<T> Next { get; set; }
}

public class SinglyLinkedList<T>
{
    private Node<T> _head;

    public void InsertFirst(T data)
    {
        var newNode = new Node<T> { Data = data, Next = _head };
        _head = newNode;
    }

    public void DeleteFirst()
    {
        if (_head != null)
            _head = _head.Next;
    }

    public void Traverse()
    {
        var current = _head;
        while (current != null)
        {
            Console.WriteLine(current.Data);
            current = current.Next;
        }
    }
}
