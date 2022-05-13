namespace Arrays.Problems;

public class RemoveDuplicatesFromSortedArray
{
    public int RemoveDuplicates(int[] nums) {
        var hashSet = new HashSet<int>();
        
        foreach(var item in nums){
            if(!hashSet.Contains(item))
                hashSet.Add(item);
        }
        
        int length = 0;
        
        foreach(var item in hashSet){
            nums[length] = item;
            length++;
        }
        
        return length;
    }
}