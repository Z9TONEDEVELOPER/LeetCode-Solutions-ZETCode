//https://leetcode.com/problems/final-value-of-variable-after-performing-operations/description/
public class Solution {
    public int FinalValueAfterOperations(string[] operations) {
        int result=0;
        for(int i=0;i<operations.Length;i++)
        {
            if(operations[i].Contains("++"))
            {
                result+=1;
            }
            else
            {
                result-=1;
            }
        }
        return result;
    }
}
//0ms