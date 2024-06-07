using Extensions;

var hashTable = new HashTable<int, string>(3);
hashTable.Add(1, "1");
hashTable.Add(2, "2");
hashTable.Add(3, "3");

Console.WriteLine("Before delete");
Print(hashTable);

Console.WriteLine("After delete");
hashTable.Remove(2);
Print(hashTable);


void Print<TKey, TValue>(HashTable<TKey, TValue> table) where TKey : notnull
{
    foreach (var key in table.Keys)
    {
        var item = table.GetValue(key);
        Console.WriteLine(item);
    }
}

public class HashTable<TKey, TValue> 
    where TKey : notnull
{
    private readonly int _size;
    private TKey[] _keys;
    private TValue[] _values;
    private readonly bool[] _occupied;

    public HashTable(int size)
    {
        _size = size;
        _keys = new TKey[size];
        _values = new TValue[size];
        _occupied = new bool[size];
    }

    public void Add(TKey key, TValue value)
    {
        var position = GetPosition(key);
        
        if (_occupied[position])
            throw new Exception("value with this key already exists");

        _values[position] = value;
        _keys[position] = key;
        _occupied[position] = true;
    }

    public void Remove(TKey key)
    {
        var position = GetPosition(key);
        
        if (!_occupied[position])
            throw new Exception("value with this key does not exists");

        ArrayExtensions.RemoveAt(ref _keys, position);
        ArrayExtensions.RemoveAt(ref _values, position);
        _occupied[position] = false;
    }

    public TValue GetValue(TKey key)
    {
        var position = GetPosition(key);
        
        if (!_occupied[position])
            throw new Exception("value with this key does not exists");

        var value = _values[position];
        
        if (value is null)
            throw new Exception("value with this key does not exists");

        return value;
    }

    public IEnumerable<TKey> Keys => _keys;
    
    public IEnumerable<TValue> Values => _values;

    public int Size => _size;
    
    private int GetPosition(TKey item)
    {
        // get hash code of passed item
        var hashcode = item.GetHashCode();

        // you need to do modulo to ensure it bounds in array size
        var position = hashcode % _size;

        // it should be negative so i would use Math.Abs
        return Math.Abs(position);
    }
}