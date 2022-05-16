namespace DataStructures;

public class Queue<T> : IQueue<T>
{
    private class Item
    {
        public Item(T value)
        {
            Value = value;
        }

        public Item? Next { get; set; }
        public T Value { get; }
    }

    private Item? _last;
    private Item? _first;

    public void Enqueue(T item)
    {
        var t = new Item(item);

        if (_last != null)
        {
            _last.Next = t;
        }
        _last = t;

        if (_first is null)
        { 
            _first = _last;
        }
    }

    public T Dequeue()
    {
        if (_first is null) throw new Exception("Queue is empty");

        var t = _first;

        _first = _first.Next;

        if (_first is null)
        { 
            _last = null;
        }

        return t.Value;
    }

    public bool IsEmpty => _first is null;
}

public interface IQueue<T>
{
    T Dequeue();
    void Enqueue(T item);

    bool IsEmpty { get; }
}
