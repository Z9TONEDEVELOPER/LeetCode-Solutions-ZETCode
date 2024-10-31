//https://leetcode.com/problems/valid-parentheses/description/
public class Solution {
    public bool IsValid(string s) {
        Stack<char> stack = new Stack<char>();
        
        foreach (char c in s) {
            if (c == '(' || c == '[' || c == '{') {
                stack.Push(c);
            } else {
                if (stack.Count == 0) {
                    return false; // Нет открывающей скобки для текущей закрывающей
                }
                
                char top = stack.Pop();
                if ((c == ')' && top != '(') ||
                    (c == ']' && top != '[') ||
                    (c == '}' && top != '{')) {
                    return false; // Несоответствие типов скобок
                }
            }
        }
        
        return stack.Count == 0;
    }
}
//2ms