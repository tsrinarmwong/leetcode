public class Solution {
    public bool ContainsDuplicate(int[] nums) {        
        HashSet<int> seen = new HashSet<int>();
        
        foreach (int num in nums) {
            if (!seen.Add(num)){
                return true;
            }
        }
        
        return false;
    }
}

//         // Dictionary<int,int> dupDict = new Dictionary(int,int);
//         Dictionary<int,int> dupDict = new Dictionary<int,int>();

//         for(int i = 0; i < nums.Length; i++) {
//             // if(dupDict.Contains(nums[i]) != true){
//             if(dupDict.ContainsKey(nums[i])){
//                 return true;
//             }
//             dupDict.Add(nums[i], i);
//         }
