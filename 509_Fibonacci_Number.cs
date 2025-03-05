public class Solution {
    Dictionary<int,int> dict = new Dictionary<int,int>();
    // reduce the recursion stack by storing answers
    public int Fib(int n) {
        int sum = 0;
        if(dict.ContainsKey(n))
        return dict[n];

        if (n<=1) {
            dict[n] = n;
            return n;
        }
        
        if(!dict.ContainsKey(n)) {
            sum = Fib(n-1)+Fib(n-2);
            dict[n] = sum;
            return sum;
        }
        
        return sum;
    }
}

// public class Solution {
//     public int Fib(int n) {
//         if(n == 0) return 0;
//         if(n == 1) return 1;

//         return Fib(n-1) + Fib(n-2);
//     }
// }