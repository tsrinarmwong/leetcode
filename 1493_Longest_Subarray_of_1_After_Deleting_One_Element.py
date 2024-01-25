'''
1493. Longest Subarray of 1's After Deleting One Element
Given a binary array nums, you should delete one element from it.

Return the size of the longest non-empty subarray containing only 1's in the resulting array. Return 0 if there is no such subarray.

 

Example 1:

Input: nums = [1,1,0,1]
Output: 3
Explanation: After deleting the number in position 2, [1,1,1] contains 3 numbers with value of 1's.
Example 2:

Input: nums = [0,1,1,1,0,1,1,0,1]
Output: 5
Explanation: After deleting the number in position 4, [0,1,1,1,1,1,0,1] longest subarray with value of 1's is [1,1,1,1,1].
Example 3:

Input: nums = [1,1,1]
Output: 2
Explanation: You must delete one element.

'''
class Solution:
    def longestSubarray(self, nums: list[int]) -> int:
        streaks_of_1s = accumulate(nums, lambda a, x: (a + 1) * (x != 0), initial=0)
        streaks_at_0 = compress(streaks_of_1s, map(not_, chain(nums, (0,))))
        return max(starmap(add, pairwise(streaks_at_0)), default=len(nums) - 1)