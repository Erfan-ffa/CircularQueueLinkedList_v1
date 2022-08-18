// See https://aka.ms/new-console-template for more information
using CircularLinkedList;

Operation x = new Operation();
x.Dequeue();
x.Enqueue(0);
x.Dequeue();
x.Dequeue();
x.Enqueue(1);
x.Enqueue(2);
x.Dequeue();
x.Enqueue(3);
x.Enqueue(4);
x.Dequeue();
x.Enqueue(5);

x.Print();
