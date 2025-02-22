public class Solution {
    public int CarFleet(int target, int[] position, int[] speed) {
    }
}

// public class Solution {
//     public int CarFleet(int target, int[] position, int[] speed) {
//         int n = position.Length;
//         int[][] pair = new int[n][];
                
//         for(int i = 0; i < n; i++) {
//             pair[i] = new int[] { position[i], speed[i] };
//         }        
//         Array.Sort(pair, (a, b) => b[0].CompareTo(a[0]));

//         Stack<double> stack = new Stack<double>();

//         foreach (var p in pair) {
            
//             stack.Push((double)(target - p[0]) / p[1]);
//             if (stack.Count >= 2 && stack.Peek() <= stack.ElementAt(1)) {
//                 stack.Pop();
//             }
//         }

//         return stack.Count;
//     }
// }

// public class Solution {
//     public int CarFleet(int target, int[] position, int[] speed) {
//         int n = position.Length;
//         var cars = new List<(int pos, double time)>();

//         // Pair positions with times and sort by position descending
//         for (int i = 0; i < n; i++) {
//             double time = (double)(target - position[i]) / speed[i];
//             cars.Add((position[i], time));
//         }
//         cars.Sort((a, b) => b.pos.CompareTo(a.pos)); // Sort cars by position in descending order

//         Stack<double> stack = new Stack<double>();

//         foreach (var car in cars) {
//             double arrivalTime = car.time;

//             // If a car takes longer, it's a new fleet
//             if (stack.Count == 0 || arrivalTime > stack.Peek()) {
//                 stack.Push(arrivalTime);
//             }
//         }

//         return stack.Count; // Number of fleets
//     }
// }