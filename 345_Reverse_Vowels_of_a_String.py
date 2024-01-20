'''
345. Reverse Vowels of a String

Given a string s, reverse only all the vowels in the string and return it.

The vowels are 'a', 'e', 'i', 'o', and 'u', and they can appear in both lower and upper cases, more than once.

 

Example 1:

Input: s = "hello"
Output: "holle"
Example 2:

Input: s = "leetcode"
Output: "leotcede"

'''

class Solution:
    def reverseVowels(self, s: str) -> str:
        s = list(s) #create a list of s
        n = len(s) #prepare for length of string
        left = 0
        right = n-1
        vowels = set('AEIOUaeiou')
        while left<right: 
            while left<right and s[left] not in vowels:
                left += 1 #check left
            while left<right and s[right] not in vowels:
                right -= 1 #check right
            s[left], s[right] = s[right], s[left]
            left += 1
            right -= 1
        s=''.join(s)
        return s