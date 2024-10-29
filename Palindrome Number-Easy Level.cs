public class Solution {
    public bool IsPalindrome(int x) {
        if (x<0 || (x%10==0 && x !=0))
        {
            return false;
        }
        int revers = 0;
        while(x>revers)
        {
            revers = revers * 10 + x%10;
            x/=10;
        }
        return x == revers || x == revers/10;

    }
}