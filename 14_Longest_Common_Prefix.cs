public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        //different string have different length
        //iteratively we can collect what ever that we read
        // and then if it doesn't match on next read. discard.
        //if no prefix then empty
      
        if (strs.Length == 1) return strs[0]; //if single string then it is the common prefix.

        int n = strs.Length;
        string commonPrefix = strs[0]; //start with first string as the prefix
        
        for (int i = 0; i < n; i++)
        {
            //iterate through the string.
            while (strs[i].IndexOf(commonPrefix) !=0) { // str.IndexOf(substr) is checking substr exist int the main str
                commonPrefix = commonPrefix.Substring(0, commonPrefix.Length -1);
                if (commonPrefix == "") return ""; 
            }
        }

        return commonPrefix;
    }
}
