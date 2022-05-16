using DataStructures.Algorithms;

Console.WriteLine("MCMXCIV".FromRomanToInt());

return;

var coins = new CoinChange();


//15
Console.WriteLine(coins.Ways(4, new List<int> { 1, 2, 3 }));

return;


var s = new TicTacToeValidator();

Console.WriteLine(s.ValidTicTacToe(new string[] { "XXX", "XOO", "OO " }));


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