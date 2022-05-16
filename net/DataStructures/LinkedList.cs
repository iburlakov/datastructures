using System.Collections;

namespace DataStructures;

public class LinkedList<T> : ILinkedList<T>
{
    public class Node
    {
        internal T Value { get; }

        internal Node Next { get; set; } 

        public Node(T value)
        {
            Value = value;
        }
    }

    public Node Start;

    public void Add(T value)
    {
        var node = new Node(value);
       
        if (Start == null)
        { 
            Start = node;
            return;
        }

        var current = Start;
        while(current.Next != null)
        {
            current = current.Next;
        }

        current.Next = node;
    }

    public void Remove(T value)
    {
        var next = Start;
        Node last = null;

        while (next != null)
        {
            if (next.Value.Equals(value))
            {
                if (last is null)
                {
                    Start = next.Next;
                }
                else
                {
                    last = next.Next;
                }

                return;
            }
            last = next;
            next = next.Next;
        }
    }

    public bool Contains(T value)
    {
        var next = Start;

        while (next != null)
        {
            if (next.Value.Equals(value))
            {
                return true;
            }

            next = next.Next;
        }

        return false;
    }

    public class LinkedListEnumerator : IEnumerator<T>
    {
        private readonly LinkedList<T> _list;

        private Node _current = null;

        private bool _isStarted = false;

        public LinkedListEnumerator(LinkedList<T> list)
        {
            _list = list;
        }

        public T Current => _current.Value;

        object IEnumerator.Current => Current;

        public void Dispose()
        {
          
        }

        public bool MoveNext()
        {

            if (!_isStarted)
            {
                _current = _list.Start;

                _isStarted = true;
            }
            else
            {
                _current = _current.Next;
            }

            return _current != null;
        }

        public void Reset()
        {
            _current = _list.Start;
        }
    }

    public IEnumerator<T> GetEnumerator()
    {
        return new LinkedListEnumerator(this);
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}

public interface ILinkedList<T> : IEnumerable<T>
{
    public void Add(T value);
    public void Remove(T value);
    public bool Contains(T value);
}
