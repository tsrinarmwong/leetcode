'''
1679. Max Number of K-Sum Pairs
You are given an integer array nums and an integer k.

In one operation, you can pick two numbers from the array whose sum equals k and remove them from the array.

Return the maximum number of operations you can perform on the array.

 

Example 1:

Input: nums = [1,2,3,4], k = 5
Output: 2
Explanation: Starting with nums = [1,2,3,4]:
- Remove numbers 1 and 4, then nums = [2,3]
- Remove numbers 2 and 3, then nums = []
There are no more pairs that sum up to 5, hence a total of 2 operations.
Example 2:

Input: nums = [3,1,3,4,3], k = 6
Output: 1
Explanation: Starting with nums = [3,1,3,4,3]:
- Remove the first two 3's, then nums = [1,4,3]
There are no more pairs that sum up to 6, hence a total of 1 operation.
'''

class Solution:
    def maxOperations(self, nums: List[int], k: int) -> int:
        num_count = {}  # Dictionary to store the frequency of each number
        operations = 0  # Initialize the number of operations to 0

        # First, create a frequency dictionary for nums
        for num in nums:
            if num in num_count:
                num_count[num] += 1
            else:
                num_count[num] = 1

        # Now, iterate through nums and find pairs that sum up to k
        for num in nums:
            complement = k - num  # The number required to sum up to k
            # Check if the complement is present and there are enough counts to form a pair
            if complement in num_count and num_count[complement] > 0 and num_count[num] > 0:
                # If num and complement are the same, we need at least two instances
                if num == complement and num_count[num] < 2:
                    continue
                operations += 1  # We have found a valid pair
                num_count[num] -= 1  # Decrease the count for num
                num_count[complement] -= 1  # Decrease the count for the complement

        return operations  # Return the total number of operations performed
