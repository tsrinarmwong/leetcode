public class Solution
{
    public IList<string> WordSubsets(string[] words1, string[] words2)
    {
        int[] maxFreq = new int[26];
        
        // Build the maximum frequency map for words2
        foreach (string word in words2)
        {
            int[] freq = GetFrequency(word);
            for (int i = 0; i < 26; i++)
            {
                maxFreq[i] = Math.Max(maxFreq[i], freq[i]);
            }
        }

        List<string> result = new List<string>();

        // Check each word in words1
        foreach (string word in words1)
        {
            int[] freq = GetFrequency(word);
            bool isUniversal = true;

            for (int i = 0; i < 26; i++)
            {
                if (freq[i] < maxFreq[i])
                {
                    isUniversal = false;
                    break;
                }
            }

            if (isUniversal)
            {
                result.Add(word);
            }
        }

        return result;
    }

    // Helper method to get frequency of characters in a word
    private int[] GetFrequency(string word)
    {
        int[] freq = new int[26];
        foreach (char c in word)
        {
            freq[c - 'a']++;
        }
        return freq;
    }
}
