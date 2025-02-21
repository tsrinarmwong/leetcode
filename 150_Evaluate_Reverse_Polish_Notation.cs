public class Solution {
    public int EvalRPN(string[] tokens) {
        Stack<int> stack = new Stack<int>();
        int output = 0;

        foreach(string c in tokens){
            if( c == "+" || c == "-" || c == "*" || c == "/"){
                int laterInt = stack.Pop();
                int firstInt = stack.Pop();

                switch(c){
                    case "+":
                        stack.Push(firstInt + laterInt); break;
                    case "-":
                        stack.Push(firstInt - laterInt); break;
                    case "*":
                        stack.Push(firstInt * laterInt); break;
                    case "/":
                        stack.Push(firstInt / laterInt); break;
                }         
            }
            else {
                stack.Push(int.Parse(c));
            }
        }

        return stack.Pop();
    }
}