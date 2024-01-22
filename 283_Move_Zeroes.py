'''
283. Move Zeroes
Given an integer array nums, move all 0's to the end of it while maintaining the relative order of the non-zero elements.

Note that you must do this in-place without making a copy of the array.

 

Example 1:

Input: nums = [0,1,0,3,12]
Output: [1,3,12,0,0]
Example 2:

Input: nums = [0]
Output: [0]

'''

class Solution:
    def moveZeroes(self, nums: List[int]) -> None:
        lastNonZeroFoundAt = 0
        
        # Move all the non-zero elements to the beginning of the array
        for cur in range(len(nums)):
            if nums[cur] != 0:
                nums[lastNonZeroFoundAt], nums[cur] = nums[cur], nums[lastNonZeroFoundAt]
                lastNonZeroFoundAt += 1
        
        # The non-zero elements are now at the beginning of the array in their original order.
        # After the last non-zero element, all elements are zeros.
