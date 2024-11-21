public class Solution {
    public int MaxPower(string s) {
        int maxPower = 1;
        int currentPower =1;

        for (int i = 1; i < s.Length; i++)
        {
            if (s[i] == s[i - 1])
            {
                currentPower++;
            }
            else
            {
                currentPower = 1;
            }

            maxPower = Math.Max(maxPower,currentPower);
        }

        return maxPower;
    }
}
