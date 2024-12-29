public class Solution {
    public int NumWays(string[] words, string target) {
        int MOD = 1_000_000_007;
        int m = words[0].Length; // Length of each word
        int tLen = target.Length;

         // Step 1: Precompute character frequencies for each column
        int[,] charCount = new int[m, 26];
        foreach (var word in words) {
            for (int i = 0; i < m; i++) {
                charCount[i, word[i] - 'a']++;
            }
        }

        // Step 2: Define the DP array
        long[,] dp = new long[m + 1, tLen + 1];

        // Base case: There is exactly one way to form an empty target
        for (int i = 0; i <= m; i++) {
            dp[i, tLen] = 1;
        }

        // Step 3: Fill the DP table from right to left, bottom to top
        for (int i = m - 1; i >= 0; i--) {
            for (int j = tLen - 1; j >= 0; j--) {
                // Skip the current column
                dp[i, j] = dp[i + 1, j];

                // Use the current column if the target character matches
                char targetChar = target[j];
                int charIndex = targetChar - 'a';
                if (charCount[i, charIndex] > 0) {
                    dp[i, j] += charCount[i, charIndex] * dp[i + 1, j + 1];
                    dp[i, j] %= MOD;
                }
            }
        }

        // Step 4: Return the result
        return (int)dp[0, 0];
    }
}
