//https://leetcode.com/problems/find-the-index-of-the-first-occurrence-in-a-string/description/
public class Solution {
    public int StrStr(string haystack, string needle) {
        if(needle.Length==0)
        {
            return 0;
        }
        for(int i=0;i<=haystack.Length-needle.Length;i++)
        {
            if(haystack.Substring(i, needle.Length) == needle)
            {
                return i;
            }
        }
        return -1;
    }
}
//0ms