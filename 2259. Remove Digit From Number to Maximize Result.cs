public class Solution {
    public string RemoveDigit(string number, char digit) {
        // Traverse through the string to find the first smaller digit followed by a larger one.
        for (int i = 0; i < number.Length - 1; i++) {
            // If the current digit is the one to remove and the next digit is larger, remove it
            if (number[i] == digit && number[i] < number[i + 1]) {
                return number.Substring(0, i) + number.Substring(i + 1);
            }
        }

        // If no such case is found, remove the last occurrence of the digit
        int lastIndex = number.LastIndexOf(digit);
        return number.Substring(0, lastIndex) + number.Substring(lastIndex + 1);
    }
}
