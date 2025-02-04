public class Solution {
    public int MaxAscendingSum(int[] nums) {
        int currentSum = 0;
        int subArrCount = 0;
        List<int> subSum = new List<int>(); // instead of array we need to use List for dynamic array
    
        for(int i = 0; i < nums.Length; i++) {
            currentSum += nums[i];

            // if it's the last index OR the next number isn't greater
            if (i == nums.Length - 1 || nums[i] >= nums[i+1]){
                subSum.Add(currentSum);
                currentSum = 0;
            }
        }

        int highestSum = 0;
        foreach(int sum in subSum){
            highestSum = Math.Max(highestSum, sum);
        }

        return highestSum;
    }
}
  //so we need to track the highest sum in sub array
        // how?? can we know it's the end of sub array?
        //  -> the next i is NOT GREATER than current || end of the array
        // when?? to add?
        //  -> we add to the sum if the next index is GREATER than
        //  IF the next isn't larger || IS NOT end of array
        //      add to a new variable for compare in the future
        //  IF the next isn't larger || IS end of array
        //      compare high to current
        // Ok there's a problem of like what about the last index? i+1 will result in array index error

        // visualizing space
        // [ 0, 1, 2, 3, 4, 5, 6]
        // [12,17,|15,|13,|10,11,12]
        // [29,15,13,33] //oh yes put it in an array!!!
        // [ 0, 1, 2, 3]
        // -------
        // [ 0, 1, 2, 3, 4, 5, 6]
        // [12,17,|15,|13,|10,11,|9]
        // [29,15,13,21,] //oh yes put it in an array!!!
        // [ 0, 1, 2, 3,]

        // Well I tried this complicated ass loop because I couldn't think of List
        //     if(i < nums.Length-1){//check if it's last index?
        //         if(nums[i] >= nums[i+1]){ // next index is NOT GREATER
        //             currentSum += nums[i];
        //             subSum[subArrCount] = currentSum; //how can we dynamically count it?
        //             subArrCount++; //by counting at the condition of end of subArr!
        //             currentSum = 0;
        //         }
        //         if(nums[i] < nums[i+1]){ //next index is GREATER
        //             currentSum += nums[i];
        //         }
        //     }
        //     else if (i == nums.Length){ // for the very last index
        //         if(nums[i] > nums[i-1]){ //it is bigger than the previous index
        //             currentSum += nums[i]; // we need to save our progress here
        //             subSum[subArrCount] = currentSum;
        //         }
        //         else if (nums[i] <= nums[i-1]){
        //             currentSum += nums[i];
        //             subSum[subArrCount] = currentSum; 
        //             // subArrCount++; // Don't need to update index anymore
        //             // currentSum = 0;
        //         }
        //     }
        // }
