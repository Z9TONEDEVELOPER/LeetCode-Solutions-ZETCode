//https://leetcode.com/problems/roman-to-integer/
public class Solution {
    public int RomanToInt(string s) {
     int result = 0;

    for (int i = 0; i < s.Length; i++)
    {
        if (i < s.Length - 1)
        {
            if (s[i] == 'I' && (s[i + 1] == 'V' || s[i + 1] == 'X'))
            {
                result += (s[i + 1] == 'V') ? 4 : 9;
                i++; 
                continue;
            }
            if (s[i] == 'X' && (s[i + 1] == 'L' || s[i + 1] == 'C'))
            {
                result += (s[i + 1] == 'L') ? 40 : 90;
                i++; 
                continue;
            }
            if (s[i] == 'C' && (s[i + 1] == 'D' || s[i + 1] == 'M'))
            {
                result += (s[i + 1] == 'D') ? 400 : 900;
                i++; 
                continue;
            }
        }

        
        switch (s[i])
        {
            case 'I':
                result += 1;
                break;
            case 'V':
                result += 5;
                break;
            case 'X':
                result += 10;
                break;
            case 'L':
                result += 50;
                break;
            case 'C':
                result += 100;
                break;
            case 'D':
                result += 500;
                break;
            case 'M':
                result += 1000;
                break;
        }
    }

    return result;   
    }
}
//1ms