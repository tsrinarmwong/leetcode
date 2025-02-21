public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {    
        Dictionary<int,int> occurance = new Dictionary<int,int>();
        // <number, occurance>

        foreach(int num in nums){
            if(occurance.ContainsKey(num)){ // already have in dict
                occurance[num]++; // incr occurance
            } else { // doesn't have in dict
                occurance[num] = 1; // add to dict
            }
        }

        PriorityQueue<int,int> minHeap = new PriorityQueue<int,int>();

        foreach(var pair in occurance) {
            minHeap.Enqueue(pair.Key, pair.Value); //add pair to heap
            if(minHeap.Count > k){
                minHeap.Dequeue(); //remove least frequent element
            }
        }

        int[] result = new int[k];
        for (int i = 0; i < k;i++){
            result[i] = minHeap.Dequeue(); // store only key
        }

        return result;
    }
}