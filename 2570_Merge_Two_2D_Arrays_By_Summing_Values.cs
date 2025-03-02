public class Solution {
    public int[][] MergeArrays(int[][] nums1, int[][] nums2) {
        Dictionary<int, int> dict = new Dictionary<int, int>(); // Stores {id -> value}

        // Merge values from nums1
        foreach (var pair in nums1) {
            int id = pair[0], value = pair[1];
            dict[id] = value;
        }

        // Merge values from nums2
        foreach (var pair in nums2) {
            int id = pair[0], value = pair[1];
            if (dict.ContainsKey(id)) {
                dict[id] += value;  // Sum values if id exists
            } else {
                dict[id] = value;  // Otherwise, insert
            }
        }

        // Convert dictionary to a sorted array
        int[][] result = new int[dict.Count][];
        int index = 0;

        foreach (var kvp in dict) {
            result[index++] = new int[] { kvp.Key, kvp.Value };
        }

        // Sort result by ID (ensures correct order)
        Array.Sort(result, (a, b) => a[0].CompareTo(b[0]));

        return result;
    }
}


// ---------- Can't use for non contiguous IDs
// public class Solution {
//     public int[][] MergeArrays(int[][] nums1, int[][] nums2) {
//         Dictionary<int,int> dictOne = new Dictionary<int,int>(); //id, value
//         Dictionary<int,int> dictTwo = new Dictionary<int,int>();
        
//         int maxID = 0; // To track the highest ID found

//         // store the IDs
//         foreach(var pair in nums1){
//             int id = pair[0];
//             int value = pair[1];
//             dictOne[id] = value;
//             maxID = Math.Max(maxID, id); // record the last ID found
//         }
//          // store the IDs
//         foreach(var pair in nums2){
//             int id = pair[0];
//             int value = pair[1];
//             dictTwo[id] = value;
//             maxID = Math.Max(maxID, id); // see if this is higher?
//         }

//         // construct the array
//         int[][] result = new int[maxID][]; // Create the outer array
//         for (int i = 0; i < maxID; i++) {
//             result[i] = new int[] { i + 1, 0 }; // Initialize each inner array separately
//         }
            
//         // ✅ Fix: Correct loop condition (include maxID)
//         for (int currID = 1; currID <= maxID; currID++) {
//             int index = currID - 1; // ✅ Convert ID to zero-based index

//             if (dictOne.ContainsKey(currID) || dictTwo.ContainsKey(currID)) {
//                 int sum = dictOne.GetValueOrDefault(currID, 0) + dictTwo.GetValueOrDefault(currID, 0);
//                 result[index][1] = sum; // ✅ Correctly assign to result array
//             }
//         }
        
//         return result;
//     }
// }