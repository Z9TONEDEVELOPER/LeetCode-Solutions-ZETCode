//https://leetcode.com/problems/count-the-number-of-incremovable-subarrays-i/description/
public class Solution {
    public int IncremovableSubarrayCount(int[] nums) {
        int rs = 0;
        for (int i = 0; i < nums.Length; i++) {
            for (int j = i; j < nums.Length; j++) {
                if (CheckArr(i, j, nums)) {
                    rs++;
                }
            }
        }
        return rs;
    }

    private bool CheckArr(int index0, int index1, int[] nums) {
        // Проверка левой части массива до index0
        for (int i = 1; i < index0; i++) {
            if (nums[i - 1] >= nums[i]) {
                return false;
            }
        }

        // Проверка правой части массива после index1
        for (int i = index1 + 2; i < nums.Length; i++) {
            if (nums[i - 1] >= nums[i]) {
                return false;
            }
        }

        // Проверка соединения левой и правой частей
        if (index0 > 0 && index1 < nums.Length - 1 && nums[index0 - 1] >= nums[index1 + 1]) {
            return false;
        }

        return true;
    }
}
//7ms 33% top