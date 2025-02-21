public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        // warmer days is next > today // last day == 0
        
        int n = temperatures.Length;
        int[] result = new int[n]; // do we have to inst?
        Stack<int> stack = new Stack<int>();

        // we reset waitDays every >
        
        for(int i = 0; i < n; i++){
            // while stack is not empty
            // current temp is warmer than recent
            while (stack.Count > 0 && temperatures[i] > temperatures[stack.Peek()]) {
                int prevIndex = stack.Pop();
                result[prevIndex] = i - prevIndex;
            }
            stack.Push(i);
        }

        return result;
    }
}