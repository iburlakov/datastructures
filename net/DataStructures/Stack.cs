namespace DataStructures;
public class Stack<T> : IStack<T>
{
    private class Item
    {
        public T Value { get; }
        public Item? Next { get; }

        public Item( T value, Stack<T>.Item? next = null)
        {
            Value = value;
            Next = next;   
        }
    }

    private Item? _next;

    public void Push(T item)
    {
        var node = new Item(item, _next);
        _next = node;
    }

    public T Pop()
    {
        var current = _next;
        if (current is null) throw new Exception("Stack is empty");

        _next = current.Next;

        return current.Value;
    }

    public bool IsEmpty => _next is null;
}

public interface IStack<T>
{
    void Push(T item);
    T Pop();
    bool IsEmpty { get; }
}
