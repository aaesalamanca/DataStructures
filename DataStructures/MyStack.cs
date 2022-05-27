namespace DataStructures;

public class MyStack<T>
{
    Entry _top;

    public void Push(T data) => _top = new Entry
    {
        Next = _top,
        Data = data
    };

    public T Pop()
    {
        if (_top is null) throw new InvalidOperationException();
        T data = _top.Data;
        _top = _top.Next;
        return data;
    }

    class Entry
    {
        public Entry Next { get; set; }
        public T Data { get; set; }
    }
}
