public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> seen = new Dictionary<int,int>();

        for(int i = 0; i < nums.Length; i++){
            int complement = target - nums[i];

            if(!seen.ContainsKey(complement)){
                seen[nums[i]] = i;
            } else {
                // new int[] answer = int[nums[i], seen.GeT(complement)]
                return new int[]{i, seen[complement]};
            }            
        }

        return new int[0];
    }
}
        // O(n^2)
        // int currentSum = 0;
        // int[] answer = new int[2]; 
        // for(int i = 0; i < nums.Length-1; i++){
        //     for(int j = i+1; j < nums.Length; j++){
        //         currentSum = nums[i]+nums[j];
        //         if(target == currentSum){
        //             answer[0] = i;
        //             answer[1] = j;
        //             return answer;
        //         }
        //     }
        // }
        // // This shouldn't be reached because the input will gaurantee to end within loop
        // return answer;