using DataStructures;

UsingMyStack();
UsingMyList();

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

static void UsingMyList()
{
    var myIntList = new MyList<int>();

    myIntList.Changed += (sender, args) => Console.WriteLine("Item added to MyList<int>.");

    myIntList.Add(1);
    myIntList.Add(2);
    myIntList.Add(3);

    for (int i = 0; i < myIntList.Count; i++)
        Console.WriteLine(myIntList[i]);
    
    myIntList[3] = 4;
}