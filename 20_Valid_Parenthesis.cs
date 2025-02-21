public class Solution {
    public bool IsValid(string s) {
        Stack<char> parenthesis = new Stack<char>();

        foreach (char c in s){
            if (c == '(' || c == '{' || c == '['){
                parenthesis.Push(c);
            } 
            else if (c == ')' || c == '}' || c == ']'){
                if(parenthesis.Count == 0){ //if closing came before
                    return false; //invalid
                }

                char top = parenthesis.Pop();

                if (c == ')' && top != '(' || //if the closing doesn't match the pair
                    c == '}' && top != '{' || 
                    c == ']' && top != '[' ){
                        return false; //invalid
                }
            }
        }

        return parenthesis.Count == 0; //if the stack is empty, then it always has a pair!
    }
}