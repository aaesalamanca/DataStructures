namespace DataStructures;

public class MyList<T>
{
    const int c_defaultCapacity = 4;

    T[] _items;
    int _count;

    public int Count => _count;
    public int Capacity
    {
        get => _items.Length;
        set
        {
            if (value < _count) value = _count;
            if (value != _items.Length)
            {
                T[] newItems = new T[value];
                Array.Copy(_items, 0, newItems, 0, _count);
                _items = newItems;
            }
        }
    }

    public void Add(T? item)
    {
        if (_count == _items.Length) Capacity = _count * 2;
        _items[_count++] = item;
        OnChanged();
    }

    public MyList(int capacity = c_defaultCapacity) => _items = new T[capacity];

    public T? this[int index]
    {
        get => _items[index];
        set
        {
            _items[index] = value;
            OnChanged();
        }
    }

    protected virtual void OnChanged() => Changed?.Invoke(this, EventArgs.Empty);

    public event EventHandler? Changed;

    public override bool Equals(object? obj) => Equals(this, obj as MyList<T>);

    public static bool Equals(MyList<T>? a, MyList<T>? b)
    {
        if (ReferenceEquals(a, null)) return ReferenceEquals(b, null);
        if (ReferenceEquals(b, null) || a._count != b._count) return false;
        for (int i = 0; i < a._count; i++)
            if (!Equals(a._items[i], b._items[i])) return false;
        return true;
    }

    public static bool operator ==(MyList<T>? a, MyList<T>? b) => Equals(a, b);
    public static bool operator !=(MyList<T>? a, MyList<T>? b) => !Equals(a, b);
}

