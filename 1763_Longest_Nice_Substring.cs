public class Solution {
    public string LongestNiceSubstring(string s) {
        if (s.Length < 2) return ""; // No nice substring possible for strings with length < 2

        string longestNice = "";

        // Generate all substrings
        for (int i = 0; i < s.Length; i++)
        {
            for (int j = i + 1; j <= s.Length; j++) // j starts from i + 1 to ensure non-empty substrings
            {
                string substring = s.Substring(i, j - i); // Get the substring
                bool isNice = true; // Assume the substring is nice

                // Check if the substring is "nice"
                foreach (char c in substring)
                {
                    if (!substring.Contains(char.IsLower(c) ? char.ToUpper(c) : char.ToLower(c)))
                    {
                        isNice = false; // Mark as not nice and break out
                        break;
                    }
                }

                // Update longestNice if conditions are met
                if (isNice && substring.Length > longestNice.Length)
                {
                    longestNice = substring;
                }
            }
        }

        return longestNice;
    }
}
