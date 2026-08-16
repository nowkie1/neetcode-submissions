public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        //Initializing hash map <Tkey, Tvalue>
        Dictionary<int, int> count = new Dictionary<int, int>();
        //Count how many times each number appears
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

        //Creating buckets
        List<int>[] buckets = new List<int>[nums.Length + 1];

        foreach(int num in count.Keys)
        {
            int frequency = count[num];

            if(buckets[frequency] == null)
                buckets[frequency] = new List<int>();

            buckets[frequency].Add(num);
        }

        int[] result = new int[k];
        int resultIndex = 0;

        for(int frequency = buckets.Length - 1; frequency >= 0; frequency --)
        {
            if(buckets[frequency] != null)
            {
                foreach(int num in buckets[frequency])
                {
                    result[resultIndex] = num;
                    resultIndex++;

                    if (resultIndex == k)
                        return result;
                }
            }
        }

                    return result;
                }
            }
        

    

