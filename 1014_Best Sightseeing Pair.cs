public class Solution {
    public int MaxScoreSightseeingPair(int[] values) {
        int maxScore = 0;
        int maxSeen = values[0] + 0; //init with values[0]

        for (int j = 1; j < values.Length; j++) {
            // Calculate the current score
            maxScore = Math.Max(maxScore, maxSeen + values[j] - j);

            // Update maxSeen to include the current index
            maxSeen = Math.Max(maxSeen, values[j] + j);
        }

        return maxScore;
    }
}
