public class Solution {
    public int ArraySign(int[] nums) {
        int sign = 1; //assume positive

        foreach (int num in nums) {
            if(num == 0) return 0;
            sign *= signFunc(num);
        }

        int answer = signFunc(sign);
        return answer;
    }

    public int signFunc(int x)
        {
            if(x < 0) return -1;
            if(x > 0) return 1;
            return 0; //shouldn't reach here   
        }

}
