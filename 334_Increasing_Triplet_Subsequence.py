'''
334. Increasing Triplet Subsequence

Given an integer array nums, return true if there exists a triple of indices (i, j, k) such that i < j < k and nums[i] < nums[j] < nums[k]. If no such indices exists, return false.

 

Example 1:

Input: nums = [1,2,3,4,5]
Output: true
Explanation: Any triplet where i < j < k is valid.
Example 2:

Input: nums = [5,4,3,2,1]
Output: false
Explanation: No triplet exists.
Example 3:

Input: nums = [2,1,5,0,4,6]
Output: true
Explanation: The triplet (3, 4, 5) is valid because nums[3] == 0 < nums[4] == 4 < nums[5] == 6.
'''

class Solution:
    def increasingTriplet(self, nums: List[int]) -> bool:
        first_num = float('inf')
        second_num = float('inf')
        
        for n in nums:
            if n <= first_num:  # Find the smallest number
                first_num = n
            elif n <= second_num:  # Find the second smallest number
                second_num = n
            else:  # If we find a number greater than both, return True
                return True
        
        return False  # If no increasing triplet is found, return False
