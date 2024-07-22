public static SinglyLinkedList<T> ReverseList(SinglyLinkedList<T> list)
{
    Node<T> prev = null;
    Node<T> current = list._head;
    Node<T> next = null;
    while (current != null)
    {
        next = current.Next;
        current.Next = prev;
        prev = current;
        current = next;
    }
    list._head = prev;
    return list;
}