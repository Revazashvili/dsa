
// simple graph example

// var graph = new Graph(5);
// graph.AddEdge(0, 1);
// graph.AddEdge(0, 2);
// graph.AddEdge(1, 3);
// graph.AddEdge(1, 4);
// graph.AddEdge(2, 4);
//
// graph.Bfs(0);

// mango seller example

using BFS;

var haveMangoSellerFriend = MangoSeller.Bfs("you");

Console.WriteLine($"HaveMangoSellerFriend: {haveMangoSellerFriend}");