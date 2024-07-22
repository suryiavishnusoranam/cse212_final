public class StackLinkedList<T>
{
    private LinkedList<T> _list = new LinkedList<T>();

    public void Push(T item)
    {
        _list.AddLast(item);
    }

    public T Pop()
    {
        if (_list.Count == 0)
            throw new InvalidOperationException("Stack is empty");
        var value = _list.Last.Value;
        _list.RemoveLast();
        return value;
    }

    public T Peek()
    {
        if (_list.Count == 0)
            throw new InvalidOperationException("Stack is empty");
        return _list.Last.Value;
    }
}