public class Solution {
    public int MaximumLength(string s) {
        int n = s.Length;
        int maxLength = -1;

        // Helper fucntion
        bool IsSpecial(string sub)
        {
            HashSet<char> uniqueChars = new HashSet<char>(sub);
            return uniqueChars.Count == 1;
        }

        // Iterate through possible substring lengths
        for (int length = n; length > 0; length--)
        {
            Dictionary<string, int> seen = new Dictionary<string, int>();

            for (int i = 0; i <= n - length; i++)
            {
                string substring = s.Substring(i, length);

                if (IsSpecial(substring))
                {
                    if (seen.ContainsKey(substring))
                        seen[substring]++;
                    else
                        seen[substring] = 1;

                    if (seen[substring] == 3)
                        return length;
                }
            }
        }

        return maxLength;
    }
}
