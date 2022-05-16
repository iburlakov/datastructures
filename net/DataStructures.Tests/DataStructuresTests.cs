using System;

using Xunit;

namespace DataStructures.Tests;

public class DataStructuresTests
{
    [Fact]
    public void LinkedList()
    {
        var list = new DataStructures.LinkedList<int>();
        list.Add(1);
        list.Add(2);
        list.Add(3);
        list.Add(4);
        list.Add(5);

        Console.Write("LinkedList: ");
        foreach(var item in list)
        {
            Console.Write($"{item} ");
        }
        Console.WriteLine();
    }

    [Fact]
    public void Queue()
    {
        var queue = new DataStructures.Queue<int>();
        queue.Enqueue(1);
        queue.Enqueue(2);
        queue.Enqueue(3);
        queue.Enqueue(4);
        queue.Enqueue(5);

        Console.Write("Queue: ");
        while (!queue.IsEmpty)
        {
            Console.Write($"{queue.Dequeue()} ");
        }
        Console.WriteLine();
    }

    [Fact]
    public void Stack()
    {
        var stack = new DataStructures.Stack<int>();
        stack.Push(1);
        stack.Push(2);
        stack.Push(3);
        stack.Push(4);
        stack.Push(5);

        Console.Write("Stack: ");
        while (!stack.IsEmpty)
        {
            Console.Write($"{stack.Pop()} ");
        }
        Console.WriteLine();
    }
}
