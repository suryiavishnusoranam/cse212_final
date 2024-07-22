# Stacks

## Introduction to Stacks

A stack is a collection of elements that follows the Last In, First Out (LIFO) principle. This means the last element added to the stack will be the first one to be removed.

### Definition and Characteristics
- **LIFO Order**: Last In, First Out.
- **Operations**: Push, Pop, Peek.
- **Implementation**: Can be implemented using arrays or linked lists.

### Stack Operations
- **Push**: Adds an item to the top of the stack.
- **Pop**: Removes the item from the top of the stack.
- **Peek**: Returns the item at the top of the stack without removing it.

### Implementing a Stack

#### Array-Based Implementation

```csharp
public class StackArray<T>
{
    private T[] _array;
    private int _top;
    private int _capacity;

    public StackArray(int capacity)
    {
        _capacity = capacity;
        _array = new T[_capacity];
        _top = -1;
    }

    public void Push(T item)
    {
        if (_top == _capacity - 1)
            throw new InvalidOperationException("Stack is full");
        _array[++_top] = item;
    }

    public T Pop()
    {
        if (_top == -1)
            throw new InvalidOperationException("Stack is empty");
        return _array[_top--];
    }

    public T Peek()
    {
        if (_top == -1)
            throw new InvalidOperationException("Stack is empty");
        return _array[_top];
    }
}
