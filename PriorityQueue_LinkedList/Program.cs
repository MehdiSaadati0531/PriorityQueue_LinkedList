// See https://aka.ms/new-console-template for more information
using PriorityQueue_LinkedList;

ModelsAndImplement a = new ModelsAndImplement();

a.Enqueue(1,1);
a.Enqueue(2,2);
a.Enqueue(3,1);

a.Print();

a.DeQueue();
a.DeQueue();

a.Enqueue(4, 1);
a.Enqueue(5, 2);

Console.WriteLine("-----------------------------");
a.Print();

