/*https://leetcode.com/problems/palindrome-linked-list/*/
public class Solution
{
    public bool IsPalindrome(ListNode head)
    {
        List<int> values = new List<int>();
        ListNode current = head;

        // Преобразуем список в массив
        while (current != null)
        {
            values.Add(current.val);
            current = current.next;
        }

        // Проверяем массив на палиндром
        int left = 0;
        int right = values.Count - 1;

        while (left < right)
        {
            if (values[left] != values[right])
            {
                return false;
            }
            left++;
            right--;
        }

        return true;
    }
}