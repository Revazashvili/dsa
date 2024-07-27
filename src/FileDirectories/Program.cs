FileDirectories.Run(Directory.GetCurrentDirectory());

internal static class FileDirectories
{
    internal static void Run(string startDirectory)
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

    private static bool IsFile(string path) => File.Exists(path);
}