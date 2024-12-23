public class Solution {
    public string AddBinary(string a, string b) {
    int maxLength = Math.Max(a.Length, b.Length);
    a = a.PadLeft(maxLength, '0');
    b = b.PadLeft(maxLength, '0');

    string result = "";
    int carry = 0;

    
    for (int i = maxLength - 1; i >= 0; i--) {
        int sum = (a[i] - '0') + (b[i] - '0') + carry;
        result = (sum % 2) + result; 
        carry = sum / 2; 
    }

    
    if (carry > 0) {
        result = carry + result;
    }

    return result;
    }
}