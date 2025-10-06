public class Solution {
    public int ClimbStairs(int n) {
        if (n <= 2) {
            return n;  // Базовые случаи: n=1 -> 1, n=2 -> 2
        }
        
        int prev = 1;  // Способы для n=1
        int curr = 2;  // Способы для n=2
        
        for (int i = 3; i <= n; i++) {
            int next = prev + curr;  
            prev = curr;             
            curr = next;             
        }
        
        return curr;
    }
}