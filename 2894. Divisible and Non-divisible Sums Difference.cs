//https://leetcode.com/problems/divisible-and-non-divisible-sums-difference/description/
public class Solution {
    public int DifferenceOfSums(int n, int m) {
        int num1 = 0;
        for(int i=1;i<=n;i++)
        {
            if(i%m!=0)
            {
                num1+=i;
            }
            else
            {
                num1-=i;
            }
        }
        return num1;
    }
}

//0ms