/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        ListNode dummy = new ListNode(0);
        ListNode current = dummy;
        int carry = 0;
        ListNode lime1 = l1;
        ListNode lime2 = l2;
        while(lime1 != null || lime2 != null || carry>0){
            var x = (lime1 == null) ? 0 : lime1.val;
            var y = (lime2 == null) ? 0 : lime2.val;
            int sum = x+y+carry;
            int digit = sum %10;
            carry = sum/10;
            current.next = new ListNode(digit);
            current = current.next;
            if (lime1 != null) lime1 = lime1.next;
            if (lime2 != null) lime2 = lime2.next;
        }
        return dummy.next;
    }
}