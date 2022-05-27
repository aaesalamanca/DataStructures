using DataStructures;

UsingMyStack();

static void UsingMyStack()
{
    var myIntStack = new MyStack<int>();

    myIntStack.Push(1);
    myIntStack.Push(2);
    myIntStack.Push(3);

    Console.WriteLine(myIntStack.Pop());
    Console.WriteLine(myIntStack.Pop());
    Console.WriteLine(myIntStack.Pop());

    var myStringStack = new MyStack<string>();

    myStringStack.Push("String1");
    myStringStack.Push("String2");
    myStringStack.Push("String3");

    Console.WriteLine(myStringStack.Pop());
    Console.WriteLine(myStringStack.Pop());
    Console.WriteLine(myStringStack.Pop());
}