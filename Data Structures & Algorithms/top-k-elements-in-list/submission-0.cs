public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        //Initializing hash map
        Dictionary<int, int> count = new Dictionary<int, int>();

        foreach (int num in nums)
        {
            if(count.ContainsKey(num))
            {
                count[num]++;
            } else
            {
                count[num] = 1;
            }
        }

        int[] numbers = new int[count.Count];

        int index = 0;

        foreach(int num in count.Keys)
        {
            numbers[index] = num;
            index++;
        }

        for(int i = 0; i < numbers.Length; i++)
        {
            for(int j = i + 1; j < numbers.Length; j++)
            {
                if(count[numbers[j]] > count[numbers[i]])
                {
                    int temp = numbers[i];
                    numbers[i] = numbers[j];
                    numbers[j] = temp;
                }
            }
        }

        int[] result = new int[k];
        for(int i = 0; i < k; i++)
        {
            result[i] = numbers[i];
        }

        return result;

    }
}
