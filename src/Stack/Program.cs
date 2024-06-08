using Extensions;


var stack = new Stack<int>(3);
stack.Push(1);
stack.Push(2);
stack.Push(3);
stack.Push(4);

Console.WriteLine(stack.Pop());
Console.WriteLine(stack.Pop());
Console.WriteLine(stack.Pop());
Console.WriteLine(stack.Peek());
Console.WriteLine(stack.Pop());

/// <summary>
/// Data structure which uses LIFO(Last in, First out) principle,
/// you have to process items in opposite order they're added.
///
/// it only has three Pop, Push and Peek
/// </summary>
public class Stack<T> where T : notnull
{
    private T[] _entries;
    private int _tail;
    private int _size;
    private int _capacity;
    
    public Stack(int capacity)
    {
        _entries = new T[capacity];
        _tail = -1;
        _size = 0;
        _capacity = capacity;
    }
    
    public Stack() : this(10) { }

    public int Count => _size;

    public T Peek()
    {
        if (Count == 0)
            throw new StackEmptyException();

        return _entries[_tail];
    }

    public T Pop()
    {
        if (Count == 0)
            throw new StackEmptyException();
        
        var itemToRemove = _entries[_tail];
        ArrayExtensions.RemoveAt(ref _entries, _tail);
        _size--;
        _tail--;

        return itemToRemove;
    }

    public void Push(T item)
    {
        if (_capacity == _size)
        {
            // if entries if full double it's size
            _capacity = _entries.Length * 2;
            var newEntries = new T[_capacity];
            Array.Copy(_entries, newEntries, _size);
            _entries = newEntries;
        }
        
        _tail++;
        _entries[_tail] = item;
        _size++;
    }
}

public class StackEmptyException : Exception
{
    public StackEmptyException() : base("Stack is empty") { }
}