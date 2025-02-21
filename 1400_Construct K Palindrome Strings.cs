public class Solution
{
    public bool CanConstruct(string s, int k)
    {
        // If k is greater than the length of the string, it's impossible
        if (k > s.Length)
            return false;

        // Dictionary to count character frequencies
        Dictionary<char, int> charCount = new Dictionary<char, int>();
        foreach (char c in s)
        {
            if (!charCount.ContainsKey(c))
                charCount[c] = 0;
            charCount[c]++;
        }

        // Count characters with odd frequencies
        int oddCount = 0;
        foreach (var count in charCount.Values)
        {
            if (count % 2 != 0)
                oddCount++;
        }

        // It's possible if k >= oddCount (we can use even-count characters to fill in)
        return k >= oddCount;
    }
}
