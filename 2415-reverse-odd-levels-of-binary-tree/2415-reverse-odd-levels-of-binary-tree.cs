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
    public TreeNode ReverseOddLevels(TreeNode root) {
       if (root == null) return null;

        // Словарь для хранения значений узлов на каждом уровне
        var levelValues = new Dictionary<int, List<int>>();

        // Сохранение значений узлов на нечетных уровнях
        CollectValues(root, 0, levelValues);

        // Разворачиваем значения на нечетных уровнях
        foreach (var level in levelValues.Keys) {
            if (level % 2 != 0) {
                levelValues[level].Reverse();
            }
        }

        // Замена значений узлов на нечетных уровнях
        ReplaceValues(root, 0, levelValues);

        return root; 
    }
    private void CollectValues(TreeNode node, int level, Dictionary<int, List<int>> levelValues) {
        if (node == null) return;

        // Добавляем значение узла в словарь
        if (!levelValues.ContainsKey(level)) {
            levelValues[level] = new List<int>();
        }
        levelValues[level].Add(node.val);

        // Рекурсивный обход дочерних узлов
        CollectValues(node.left, level + 1, levelValues);
        CollectValues(node.right, level + 1, levelValues);
    }

    private void ReplaceValues(TreeNode node, int level, Dictionary<int, List<int>> levelValues) {
        if (node == null) return;

        // Замена значений узлов на нечетных уровнях
        if (level % 2 != 0) {
            node.val = levelValues[level][0];
            levelValues[level].RemoveAt(0);
        }

        // Рекурсивный обход дочерних узлов
        ReplaceValues(node.left, level + 1, levelValues);
        ReplaceValues(node.right, level + 1, levelValues);
    }
}