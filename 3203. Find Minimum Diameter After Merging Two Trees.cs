public class Solution {
    public int MinimumDiameterAfterMerge(int[][] edges1, int[][] edges2) {
        // Get properties of the first tree: diameter and max depth
        (int diameter1, int maxDepth1) = GetTreeProperties(edges1);
        
        // Get properties of the second tree: diameter and max depth
        (int diameter2, int maxDepth2) = GetTreeProperties(edges2);
        
        // The minimum possible diameter after merging the trees
        return Math.Max(Math.Max(diameter1, diameter2), maxDepth1 + maxDepth2 + 1);
    }

    private (int diameter, int maxDepth) GetTreeProperties(int[][] edges) {
        int n = edges.Length + 1; // Number of nodes in the tree
        List<int>[] graph = new List<int>[n];
        
        for (int i = 0; i < n; i++) {
            graph[i] = new List<int>();
        }
        
        foreach (var edge in edges) {
            graph[edge[0]].Add(edge[1]);
            graph[edge[1]].Add(edge[0]);
        }
        
        // Perform BFS twice to find the diameter
        int farthestNode1 = BFS(0, graph, out int[] dist1);
        int farthestNode2 = BFS(farthestNode1, graph, out int[] dist2);
        
        // Diameter is the maximum distance found in the second BFS
        int diameter = dist2[farthestNode2];
        
        // Maximum depth is the maximum distance found in the first BFS
        int maxDepth = 0;
        for (int i = 0; i < n; i++) {
            maxDepth = Math.Max(maxDepth, dist1[i]);
        }
        
        return (diameter, maxDepth);
    }

    private int BFS(int start, List<int>[] graph, out int[] dist) {
        int n = graph.Length;
        dist = new int[n];
        Array.Fill(dist, -1);
        Queue<int> queue = new Queue<int>();
        
        dist[start] = 0;
        queue.Enqueue(start);
        
        int farthestNode = start;
        
        while (queue.Count > 0) {
            int node = queue.Dequeue();
            
            foreach (var neighbor in graph[node]) {
                if (dist[neighbor] == -1) {
                    dist[neighbor] = dist[node] + 1;
                    queue.Enqueue(neighbor);
                    
                    if (dist[neighbor] > dist[farthestNode]) {
                        farthestNode = neighbor;
                    }
                }
            }
        }
        
        return farthestNode;
    }
}
