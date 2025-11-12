class Solution {
    public int minOperations(int[] nums) {
        int n = nums.length;
        int ones = 0;
        int overallGcd = nums[0];
        
        for (int num : nums) {
            overallGcd = gcd(overallGcd, num);
            if (num == 1) {
                ones++;
            }
        }
        
        // if there's already 1 in nums[i] -> return n - count(1s)
        if (ones > 0){
            return n - ones;
        }

        // if there's no 1 && gcd_all > 1 -> it's impossible
        if (overallGcd > 1) {
            return -1;
        }

        // if gcd_all == 1, but there's no 1 -> find shortest sub array.
        int shortestLen = Integer.MAX_VALUE;
        
        for (int i = 0; i < n; i++) {
            int currentGcd = nums[i];
            for (int j = i + 1; j < n; j++) {
                currentGcd = gcd(currentGcd, nums[j]);
                if (currentGcd == 1) {
                    shortestLen = Math.min(shortestLen, j - i + 1);
                    break;
                }
            }
        }
        return (shortestLen - 1) + (n - 1);
    }
    int gcd(int a, int b) {
        while (b != 0) {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }
}
