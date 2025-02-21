public class Solution {
    public int MaxChunksToSorted(int[] arr) {
        int maxSoFar = 0;
        int chunks = 0;

        for (int i = 0; i < arr.Length; i++) {
            maxSoFar = Math.Max(maxSoFar, arr[i]);

            if (maxSoFar == i) {
                chunks++;
            }
        }

        return chunks;
    }
}
