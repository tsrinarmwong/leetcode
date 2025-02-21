public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length) return false;

        int[] charCount = new int[26];

        for (int i = 0; i < s.Length; i++) {
            charCount[s[i] - 'a']++;
            charCount[t[i] - 'a']--;
        }

        foreach (int count in charCount){
            if (count != 0) return false; // there are unused char left
        }

        return true;
    }
}

// if (s.Length != t.Length) return false; //first check if length doesn't match then can't be true

//         Dictionary<char, int> charCount = new Dictionary<char, int>();

//         foreach (char c in s){
//             if (!charCount.ContainsKey(c)){ //don't found c
//                 charCount[c] = 1; //add to dict with 1 count
//             } else {
//                 charCount[c]++; //if found then increment count
//             }    
//         }

//         foreach (char c in t){
//             if (!charCount.ContainsKey(c)) return false; //check if it has extra
//             charCount[c]--; //used

//             if (charCount[c] == 0){ //remove is count reaches zero
//                 charCount.Remove(c);
//             }
//         }

//         return charCount.Count == 0; //if dictionary is empty, pair are anagram
//     }