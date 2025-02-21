public class Solution {
    public int LongestConsecutive(int[] nums) {
        //we use hashset so that we avoid sorting
        HashSet<int> numSet = new HashSet<int>(nums); // this is how you inst with array
        int longestStreak = 0;

        foreach(int num in numSet){ //there maybe many sequences
            if(!numSet.Contains(num - 1)){ //only start with the beginning of sub-sequence
                int currentNum = num;
                int currentStreak = 1;

                while(numSet.Contains(currentNum + 1)){ //there is sequence, we keep counting
                    currentNum++;
                    currentStreak++;
                }

                longestStreak = Math.Max(currentStreak, longestStreak);
            }
        }

        return longestStreak;
        
    }
}