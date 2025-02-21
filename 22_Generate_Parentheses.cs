public class Solution {
    public IList<string> GenerateParenthesis(int n) {
        IList<string> result = new List<string>();
        GenerateParenthesisHelper(n, 0, 0, "", result);
        return result;
    }

    private void GenerateParenthesisHelper(int n, int openCount, int closeCount, string current, IList<string> result){
            //base case: reached max length
            if (current.Length == 2 * n) {
                result.Add(current);
                return;
            }

            // Recursive case:
            // 1. if we can still add opening parenthesis
            if (openCount < n) {
                GenerateParenthesisHelper(n, openCount + 1, closeCount, current + "(", result);
            }
            // 2. if we can add a closing parenthesis
            if (closeCount < openCount) {
                GenerateParenthesisHelper(n, openCount, closeCount + 1, current + ")", result);
            }
        }
}


// This is a RECURSION!
// IList<string> result = new List<string>();
//         Stack<char> stack = new Stack<cahr>();
        
//         string parentheses = "";
//         // we need to generate out own strings based on pairs.
//         for(i = 0; i < n; i++){
//             parentheses += "()";
//         }

//         ()()()
//         (((
//         // now then... We need to like count every possible combination.
//         for(int i = 0; i < n*2; i++){
//             while(parenthesis[i] == '('){
//                 stack.Push(parenthesis[i]);
//                 // delete this opener so search wouldn't duplicate
//                 int nextOpen = parentheses.IndexOf('(');
//                 if (nextOpen != -1){ // still has more openers
//                     stack.Push(parenthesis[nextOpen]); //add to the next one
//                 }
//             }
//             //once all ( are used, close with )
//             stack.Push(parenthesis)
//         }


//         // adding starts from (
//             // add (
//                 // add (
//                 // match )
//             // match )
//         // match )

//         // if combination is found && not found in list
//         // add to list