LinkedList<string> myQueue=  new LinkedList<string>();

myQueue.AddLast("Bryson");
myQueue.AddLast("Brandin");
myQueue.AddLast("James");

Console.WriteLine("Current call queue: \n");

foreach (var item in myQueue)
{
    Console.WriteLine(item);
}

Console.WriteLine("\nWorking through call list...\n");

while (myQueue.Count > 0)
{
   string nextCaller= myQueue.First();
    Console.Write($"Removing: {nextCaller}");
    myQueue.RemoveFirst();
    Console.WriteLine();
}

Console.WriteLine("\nAll calls complete!");
Console.ReadKey();