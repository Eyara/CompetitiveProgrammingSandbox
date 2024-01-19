using SolutionRunner.Base;

namespace SolutionRunner.LinkedList;

/// <summary>
///     https://leetcode.com/problems/lru-cache/
/// </summary>
public class LruCache : BaseSolution
{
    public override void Solve()
    {
        var lRUCache = new LRUCache(2);
        lRUCache.Put(1, 1);
        lRUCache.Put(2, 2);
        lRUCache.Get(1);
        lRUCache.Put(3, 3);
        Console.WriteLine(lRUCache.Get(2));
        lRUCache.Put(4, 4);
        Console.WriteLine(lRUCache.Get(1));
        lRUCache.Get(3);
        Console.WriteLine(lRUCache.Get(4));
    }
}

public class CacheObject
{
    public int Key;
    public int Value;
}

public class LRUCache
{
    private readonly Dictionary<int, CacheObject> _cacheDictionary;
    private readonly LinkedList<CacheObject> _cacheList;
    private readonly int _capacity;

    public LRUCache(int capacity)
    {
        _cacheDictionary = new Dictionary<int, CacheObject>();
        _cacheList = new LinkedList<CacheObject>();
        _capacity = capacity;
    }

    public int Get(int key)
    {
        if (_cacheDictionary.ContainsKey(key))
        {
            var dictValue = _cacheDictionary[key];

            _cacheList.Remove(dictValue);
            _cacheList.AddFirst(dictValue);

            return dictValue.Value;
        }

        return -1;
    }

    public void Put(int key, int value)
    {
        if (_cacheDictionary.ContainsKey(key))
        {
            _cacheDictionary[key].Value = value;

            var dictValue = _cacheDictionary[key];

            _cacheList.Remove(dictValue);
            _cacheList.AddFirst(dictValue);
        }
        else
        {
            if (_cacheDictionary.Count == _capacity)
            {
                var oldest = _cacheList.Last;
                _cacheList.RemoveLast();
                _cacheDictionary.Remove(oldest.Value.Key);
            }

            var dictValue = new CacheObject { Key = key, Value = value };
            _cacheDictionary.Add(key, dictValue);
            _cacheList.AddFirst(dictValue);
        }
    }
}
