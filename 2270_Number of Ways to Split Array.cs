public class Solution {
    public int WaysToSplitArray(int[] nums) {
        long totalSum = 0;
        foreach (var num in nums) {
            totalSum += num;
        }

        long leftSum = 0;
        int validSplits = 0;

        // Iterate through the array except the last element
        for (int i = 0; i < nums.Length - 1; i++) {
            leftSum += nums[i];
            long rightSum = totalSum - leftSum;

            if (leftSum >= rightSum) {
                validSplits++;
            }
        }

        return validSplits;
    }
}
