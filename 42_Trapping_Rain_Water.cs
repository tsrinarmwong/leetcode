public class Solution {
    public int Trap(int[] height) {
        int left = 0; 
        int right = height.Length - 1;
        int leftMax = height[left];
        int rightMax = height[right];
        int totalWater = 0;

        while (left < right) {            
            if (leftMax < rightMax) {
                left++;
                leftMax = Math.Max(leftMax, height[left]);
                totalWater += leftMax - height[left];
            } else {
                right--;
                rightMax = Math.Max(rightMax, height[right]);
                totalWater += rightMax - height[right];
            }
        }
        return totalWater;
    }
}

// input int[]
// output int

// ** can't resort array **

// The thing is we need to find the deepest place that we can hold first
// if we use i as starting point,
//    we use j as water holder
//    we use k as border finder    
//  HOW: if (n[i+j] < n[i] <= n[i+k]) -> can hold end of the hold 
//          distance of k - i is the amount the water can hold!
//          record the space 
//          then go up 
//
// if we have many puddles. then add all to the counts.            	