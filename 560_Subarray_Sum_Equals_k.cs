public class Solution {
    public int SubarraySum(int[] nums, int k) {
        int result = 0;
        int prefixSum = 0;
        Dictionary<int, int> dict = new Dictionary<int, int>();
        dict[0] = 1;

        for (int i = 0; i < nums.Length; i++){
            prefixSum += nums[i];

            if(dict.ContainsKey(prefixSum - k)){
                result += dict[prefixSum - k];
            }
            if(dict.ContainsKey(prefixSum)){
                dict[prefixSum]++;
            } else {
                dict[prefixSum] = 1;
            }
        }
       return result;
    }
}

    

// S - int[] and target. Find all possibles sum to target
//   - sum must have at least 1 number

// T - find sum of the subarray
//   - track all subarr that sums to target

//  PrefixSum  nums[i..j] = prefix[j+1] - prefix[i]
// if we prefixSum we'll have the sum of all previous i
//     HashSet can help we see which subarray ending at j

// A - result
//   - prefixSum
//   - dict<int,int> to handle first target reach
//   - dict[0] = 1
//   -- loop
//   -- add prefixSum += nums[i]
//   -- if dict.ContainsKey(pfSum - k) -> result += dict[pfSum - k];
//   -- if dict.ContainsKey(pfSum) -> dict[pfSum]++;
//   -- if !dict.ContainsKey(pfSum) -> dict[pfSum] = 1;
//   - return result

// R