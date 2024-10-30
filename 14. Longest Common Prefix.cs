//https://leetcode.com/problems/longest-common-prefix/
public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        if (strs.Length == 0)
        {
            return "";
        }

        string SS = strs[0];
        foreach (string str in strs)
        {
            if (str.Length < SS.Length)
            {
                SS = str;
            }
        }

        string commonprefix = "";
        for (int i = 0; i < SS.Length; i++)
        {
            char current = SS[i];
            bool allm = true;

            foreach (string str in strs)
            {
                if (str[i] != current)
                {
                    allm = false;
                    break;
                }
            }

            if (allm)
            {
                commonprefix += current;
            }
            else
            {
                break;
            }
        }

        return commonprefix;
    }
}
//1ms