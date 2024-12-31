public class Solution {
    public int MincostTickets(int[] days, int[] costs) {
        int n = days.Length;
        int lastDay = days[n - 1];
        int[] dp = new int[lastDay + 1];
        bool[] travelDays = new bool[lastDay + 1];
        
        // Mark travel days
        foreach (int day in days) {
            travelDays[day] = true;
        }

        // Dynamic Programming
        for (int i = 1; i <= lastDay; i++) {
            if (!travelDays[i]) {
                dp[i] = dp[i - 1]; // No cost if it's not a travel day
            } else {
                dp[i] = Math.Min(dp[i - 1] + costs[0], 
                         Math.Min(dp[Math.Max(0, i - 7)] + costs[1], 
                                  dp[Math.Max(0, i - 30)] + costs[2]));
            }
        }

        return dp[lastDay];
    }
}
