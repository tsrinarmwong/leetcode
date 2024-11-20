public class Solution {
    public int DeleteGreatestValue(int[][] grid) {
        int answer = 0;
        int m = grid.Length; // Number of rows
        int n = grid[0].Length; // Number of columns

        // Sort each row in ascending order
        foreach (var row in grid) {
            Array.Sort(row);
        }

        // Perform deletion until all columns are processed
        while (n > 0) {
            int maxInStep = 0;

            for (int row = 0; row < m; row++) {
                // Remove the greatest value in the current row (last element in sorted row)
                maxInStep = Math.Max(maxInStep, grid[row][n - 1]);
            }

            // Add the maximum value of this step to the answer
            answer += maxInStep;

            // Decrease column count to simulate deletion
            n--;
        }

        return answer;
    }
}
