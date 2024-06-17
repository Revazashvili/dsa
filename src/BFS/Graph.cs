internal class Graph
{
    private readonly int _vertices;
    private readonly List<int>[] _adjacencyList;

    public Graph(int v)
    {
        _vertices = v;
        
        _adjacencyList = new List<int>[v];
        for (int i = 0; i < v; ++i)
            _adjacencyList[i] = [];
        
    }
    
    public void AddEdge(int v, int w)
    {
        _adjacencyList[v].Add(w);
    }

    /// <summary>
    /// start node is passed, marks start node as visited and travers graph,
    /// for each node takes adjacent nodes, marks them as visited
    /// and adds its adjacent nodes in queue.
    ///
    /// traversing happens until there is no element in queue
    /// </summary>
    /// <param name="startNode"></param>
    public void Bfs(int startNode)
    {
        var queue = new Queue<int>();
        var visited = new bool[_vertices];
        visited[startNode] = true;

        queue.Enqueue(startNode);
        while (queue.Count != 0)
        {
            var current = queue.Dequeue();
            
            Console.Write(current + " ");

            foreach (var adj in _adjacencyList[current])
            {
                if (!visited[adj])
                {
                    visited[adj] = true;
                    queue.Enqueue(adj);
                }
            }
        }
    }
}