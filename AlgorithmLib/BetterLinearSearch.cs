namespace AlgorithmLib;

public static class BetterLinearSearch
{
    public static int Search(List<IComparable> data, IComparable target)
    {
        for (int i = 0; i< data.Count; i++){
            // Check if the data at the specific index is the target value
            if (data[i].CompareTo(target) == 0){
                // Return the index
                return i;
            }
        }
        // No valid values were found in the list, so return -1 to indicate target not found
        return -1;
    }
}