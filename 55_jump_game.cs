public class Solution {
    public bool CanJump(int[] nums) {
        //Edge cases
        //  Can not reach last index
        //  Why?? the jumpPower is LOWER than last index
        //  how?? calculate current index + jumpPower >= size || This is end goal
        //        so if current index + jumpPower < size, jump furthest first
        //        and check again if you satisfy the condition

        //  but should I check the furthest or the closest jump first?
        //        this is a big(O) problem
        //        so instead of checking all. I need to check the best jump
        //        track this with farthest and see if it ever get to last index

        int farthest = 0;

        for(int i = 0; i < nums.Length; i++){
            if(farthest < i) return false; // we can check before update
            farthest = Math.Max(farthest, i + nums[i]); // update farthest jump            
            if(farthest >= nums.Length - 1) return true;
        }

        return false; // if nums is just [0] it won't check again so we need to gaurantee exit
    }
}
