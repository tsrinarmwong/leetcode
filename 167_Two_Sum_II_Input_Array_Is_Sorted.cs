public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int start = 0;
        int end = numbers.Length - 1;

        while ( start < end ){
            // Find complement
            int pair = numbers[start] + numbers[end]; 
            
            if (pair > target) { // move end closer
                end--;
            } else if (pair < target) { // move start closer
                start++;
            } else if (pair == target) { // save into result array
                return new int[] { start + 1, end + 1 }; // Return immediately
            }
        }
        // answer pair is gauranteed to exists so this will never return [0,0]
        return new int[0];
    }
}
// ----------------------------------------
								
// optimize2: use two-pointers, and look at the result to determine what's next best move.
// 			IF (pair > target )-> move the end closer
// 			IF (pair < target )-> move the start closer
// 			IF (pair = target )-> found it!

// Input: numbers = [s,e]
// Input: numbers = [-1,0], target = -1
// -1+0 == -1 == -1

// ----------------------------------------

// instead of looking through all, we can just use complement
// complement = 17 - 2 = 15
// TODOs: find 15

// naively: linear search, slow if answer is at the end.
// optimize: using Binary search. //if complement is first -> fast
// 				counter case: what if complement is not the first element 
// 				// How can we find the complement the fastest?
// 				// How can we be sure there exists a complement in the array?
				
// 				// Hint: Since the array is already sorted, you can optimize further by using the two-pointer technique instead of binary search.
