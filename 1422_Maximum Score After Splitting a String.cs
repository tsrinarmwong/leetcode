public class Solution {
    public int MaxScore(string s) {
        int totalOnes = 0;
        foreach (char c in s) {
            if (c == '1') totalOnes++;
        }

        int maxScore = 0;
        int leftZeros = 0, rightOnes = totalOnes;

        for (int i = 0; i < s.Length - 1; i++) { // Stop at length - 1 to ensure two non-empty substrings
            if (s[i] == '0') {
                leftZeros++;
            } else {
                rightOnes--;
            }

            int currentScore = leftZeros + rightOnes;
            maxScore = Math.Max(maxScore, currentScore);
        }

        return maxScore;
    }
}
