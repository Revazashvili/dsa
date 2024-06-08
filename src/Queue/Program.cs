var queue = new Queue<int>([1, 2, 3]);

Console.WriteLine("Start dequeue");
Console.WriteLine(queue.Dequeue());
Console.WriteLine(queue.Dequeue());
Console.WriteLine(queue.Dequeue());

Console.ReadKey();


/// <summary>
/// Data structure which uses FIFO(First in, First out) principle,
/// you have to process items in order they're added.
///
/// it only has two methods, enqueue and dequeue
/// </summary>
public class Queue<T>
    where T : notnull
{
    private readonly T[] _entries;
    private int _head;
    private int _tail;
    private int _size;

    public Queue(int capacity)
    {
        _entries = new T[capacity];
        _tail = 0;
        _head = 0;
        _size = 0;
    }

    public Queue() : this(10) { }

    public Queue(IEnumerable<T> source) 
        : this(source.TryGetNonEnumeratedCount(out var count) ? count : source.Count())
    {
        foreach (var item in source)
            Enqueue(item);
    }

    public int Count => _size;

    public void Enqueue(T item)
    {
        _entries[_tail] = item;
        
        if (_tail == 0)
            _head = _tail;
        
        _tail++;
        _size++;
    }
    
    public T Dequeue()
    {
        if (Count == 0)
            throw new Exception("empty queue");
        
        var itemToRemove = _entries[_head];
        _head++;
        _size--;
        
        return itemToRemove;
    }

    public void Clear()
    {
        Array.Clear(_entries);
        _tail = 0;
        _head = 0;
        _size = 0;
    }

    public T Peek()
    {
        if (Count == 0)
            throw new Exception("empty queue");

        return _entries[_head];
    }
}

