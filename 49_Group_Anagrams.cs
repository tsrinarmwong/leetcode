public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> anagramGroups = new Dictionary<string, List<string>>();

        foreach (string word in strs) {
            char[] chars = word.ToCharArray(); //convert indv str to char
            Array.Sort(chars); //why? : forge key
            string sortedWord = new string(chars); //why? : pass key to check

            if (!anagramGroups.ContainsKey(sortedWord)) { //if key not found
                anagramGroups[sortedWord] = new List<string>(); //create new key woth empty list
            }
            anagramGroups[sortedWord].Add(word); //add the word to key
        }
        
        return new List<IList<string>>(anagramGroups.Values); //List of List
    }
}
        // WRONG
        // int[] alphabetsCount = new int[26];
        // //backthen we have s and t
        // //now it's index bt index
        // for(int i = 0; i < strs.Length-1;i++){
        //     for(int j = 0; j < strs.Length;j++){
        //         alphabetsCount[i[j]-'a']++;
        //         alphabetsCount[i+1[j]-'a']--;
        //     }
        // }
        // string[][] answer = new string[][];
        // foreach(int count in alphabetCount){
        //     if(count != 0){ // how do we save???
        //         answer[0][strs.];
        //     }
        // }