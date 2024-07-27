Console.WriteLine("Bfs");
FileDirectories.BfsPrint(Directory.GetCurrentDirectory());

Console.WriteLine("Dfs");
FileDirectories.DfsPrint(Directory.GetCurrentDirectory());


internal static class FileDirectories
{
    internal static void BfsPrint(string startDirectory)
    {
        var queue = new Queue<string>();
        queue.Enqueue(startDirectory);

        while (queue.Count != 0)
        {
            var directory = queue.Dequeue();
            var fileSystemEntries = Directory.GetFileSystemEntries(directory);
            
            foreach (var subDirectory in fileSystemEntries)
            {
                if (IsFile(subDirectory))
                    Console.WriteLine(subDirectory);
                else
                    queue.Enqueue(subDirectory);
            }
            
        }
    }
    
    internal static void DfsPrint(string startDirectory)
    {
        var stack = new Stack<string>();
        stack.Push(startDirectory);

        while (stack.Count != 0)
        {
            var directory = stack.Pop();
            var fileSystemEntries = Directory.GetFileSystemEntries(directory);
            
            foreach (var subDirectory in fileSystemEntries)
            {
                if (IsFile(subDirectory))
                    Console.WriteLine(subDirectory);
                else
                    stack.Push(subDirectory);
            }
            
        }
    }

    private static bool IsFile(string path) => File.Exists(path);
}