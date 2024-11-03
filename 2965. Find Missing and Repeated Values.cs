//https://leetcode.com/problems/find-missing-and-repeated-values/description/
public class Solution {
    public int[] FindMissingAndRepeatedValues(int[][] grid) {
       int n = grid.Length;
       int[] count = new int[n*n+1];
       foreach(var row in grid){
        foreach(var num in row){
            count[num]++;
        }
       }
       int dup = 0;
       int mis = 0;
       for(int i = 1; i <= n * n; i++)
       {
            if(count[i]==2)
            {
                dup+=i;
            }
            else if(count[i]==0)
            {
                mis += i;
            }

       }
        return new int[] { dup, mis};

    }
}
//2ms