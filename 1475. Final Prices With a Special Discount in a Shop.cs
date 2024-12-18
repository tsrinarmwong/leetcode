public class Solution {
    public int[] FinalPrices(int[] prices) {
        // compare [i] with [j] only discount if the next item is lower in value

        
        // Create an array to store the final prices
        int[] result = new int[prices.Length];

        for (int i = 0; i < prices.Length; i++) {
            // Assume no discount initially
            int discount = 0;

            // Check for the first qualifying discount
            for (int j = i + 1; j < prices.Length; j++) {
                if (prices[j] <= prices[i]) {
                    discount = prices[j];
                    break;
                }
            }

            // Calculate the final price
            result[i] = prices[i] - discount;
        }


        return result;
    }
}
