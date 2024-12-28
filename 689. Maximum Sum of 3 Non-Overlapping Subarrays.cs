public class Solution {
    public int[] MaxSumOfThreeSubarrays(int[] nums, int k) {
        int n = nums.Length;
        int[] result = new int[3];
        int[] prefixSums = new int[n + 1];

        // Calculate prefix sums
        for (int i = 0; i < n; i++) {
            prefixSums[i + 1] = prefixSums[i] + nums[i];
        }

        // Arrays to store the best starting indices for left and right subarrays
        int[] left = new int[n];
        int[] right = new int[n];

        // Fill left array
        int maxSum = 0;
        for (int i = k - 1; i < n; i++) {
            int currSum = prefixSums[i + 1] - prefixSums[i + 1 - k];
            if (currSum > maxSum) {
                maxSum = currSum;
                left[i] = i - k + 1;
            } else {
                left[i] = left[i - 1];
            }
        }

        // Fill right array
        maxSum = 0;
        for (int i = n - k; i >= 0; i--) {
            int currSum = prefixSums[i + k] - prefixSums[i];
            if (currSum >= maxSum) {
                maxSum = currSum;
                right[i] = i;
            } else {
                right[i] = right[i + 1];
            }
        }

        // Iterate over the middle subarray
        maxSum = 0;
        for (int i = k; i <= n - 2 * k; i++) {
            int leftIndex = left[i - 1];
            int rightIndex = right[i + k];
            int leftSum = prefixSums[leftIndex + k] - prefixSums[leftIndex];
            int middleSum = prefixSums[i + k] - prefixSums[i];
            int rightSum = prefixSums[rightIndex + k] - prefixSums[rightIndex];
            int totalSum = leftSum + middleSum + rightSum;

            if (totalSum > maxSum) {
                maxSum = totalSum;
                result[0] = leftIndex;
                result[1] = i;
                result[2] = rightIndex;
            }
        }

        return result;
    }
}
