//https://leetcode.com/problems/remove-duplicates-from-sorted-array/
public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int i=0;
        for(int j=1;j<nums.Length; j++)
        {
            if(nums[i]!=nums[j])
            {
                i++;
                nums[i]=nums[j];
            }
        }
        return i+1;
    }
}
//0ms