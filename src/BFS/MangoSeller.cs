namespace BFS;

internal static class MangoSeller
{
    private static readonly Dictionary<string, List<string>> Friends = new()
    {
        { "you", ["alice", "bob", "claire"] },
        { "bob", ["anuj", "peggy"] },
        { "alice", ["peggy"] },
        { "claire", ["thom", "jonny"] },
        { "anuj", [] },
        { "peggy", [] },
        { "thom", [] },
        { "jonny", [] },
    };

    internal static bool Bfs(string nameToStartWith)
    {
        var queue = new Queue<string>();
        HashSet<string> visited = new HashSet<string>();

        queue.Enqueue(nameToStartWith);

        while (queue.Count != 0)
        {
            var name = queue.Dequeue();

            // we do not want to check already visited name
            if (visited.Contains(name))
                continue;
            
            if (IsMangoSeller(name))
                return true;

            visited.Add(name);
            
            var friends = Friends[name];
            friends.ForEach(friend => queue.Enqueue(friend));
        }

        return false;
    }

    private static bool IsMangoSeller(string name) => name.ToLower().Last() == 'm';
}