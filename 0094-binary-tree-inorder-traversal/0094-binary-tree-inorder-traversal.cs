/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public IList<int> InorderTraversal(TreeNode root) {
        var ans = new List<int>();
        Dfs(root, ans);
        return ans;
    }
    private void Dfs(TreeNode node, List<int> acc) {
        if (node == null) return;
        Dfs(node.left, acc);
        acc.Add(node.val);
        Dfs(node.right, acc);
    }
}