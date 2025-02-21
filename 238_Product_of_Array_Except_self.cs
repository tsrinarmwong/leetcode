public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int len = nums.Length;
        
        int[] result = new int[len];

        result[0] = 1;
        for (int i = 1; i < len; i++){
            result[i] = result[i - 1] * nums[i - 1];
        }

        int rightProduct = 1;
        for (int i = len - 2; i >= 0; i--){
            rightProduct *= nums[i + 1];
            result[i] *= rightProduct;
        }

        return result;
    }
}

// space not O(1)

// int n = nums.Length;
//         int[] result = new int[n];

//         for (int i = 0; i < n; i++) { //init all with 1
//             result[i] = 1;
//         }

//         for (int i = 1; i < n; i++) {
//             result[i] = result[i - 1] * nums[i -1];
//         }

        // [ , , , ]
        // [1,2,3,4]
        // [1,1,2,3]

//         int rightProduct = 1;
//         for (int i = n - 2; i >= 0; i--) {
//             rightProduct *= nums[i + 1];
//             result[i] *= rightProduct;
//         }

        // [ i, , , ]
        // [1,2,3,4]
        // [1,1,2,3]
        // rpd = 1*4 = 4*3 = 12*2
        // [24,12,6,3]

//         return result;