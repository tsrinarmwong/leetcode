'''
392. Is Subsequence

Given two strings s and t, return true if s is a subsequence of t, or false otherwise.

A subsequence of a string is a new string that is formed from the original string by deleting some (can be none) of the characters without disturbing the relative positions of the remaining characters. (i.e., "ace" is a subsequence of "abcde" while "aec" is not).

 

Example 1:

Input: s = "abc", t = "ahbgdc"
Output: true
Example 2:

Input: s = "axc", t = "ahbgdc"
Output: false
'''

class Solution:
    def isSubsequence(self, s: str, t: str) -> bool:
        # Create a map to store the next occurrence of each character in t
        next_char_map = {char: [] for char in set(t)}
        for index, char in enumerate(reversed(t)):
            next_char_map[char].append(len(t) - 1 - index)

        # Current position in t
        current_position = -1

        for char in s:
            if char not in next_char_map:
                return False  # Character not in t at all

            # Find the next occurrence of char after current_position
            occurrences = next_char_map[char]
            next_position = None
            while occurrences and (next_position is None or next_position <= current_position):
                next_position = occurrences.pop()

            if next_position is None or next_position <= current_position:
                return False  # No valid next occurrence found
            current_position = next_position

        return True
