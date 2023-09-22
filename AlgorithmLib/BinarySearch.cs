namespace AlgorithmLib;

public static class BinarySearch
{
    public static int Search(List<IComparable> data, IComparable target)
    {
        var left = 0;
        var right = data.Count - 1;

        // Edge case where the list is empty, in which case the target cannot be found
        if (right == 0){
            return -1;
        }
        // Reiterate a search through the sublist as long as its size is at least 1
        while (left <= right){
            // find the midpoint of the sublist between the left and right indices
            var mid =  (left + right) / 2;
            // target value has been found at the midpoint
            if (data[mid].CompareTo(target) == 0){
                return mid;
            }
            // target value could be in the greater half of the sublist
            else if (data[mid].CompareTo(target) < 0){
                left = mid + 1;
            }
            // target value could be in the lower half of the sublist
            else{
                right = mid - 1;
            }
        }

        // target value could not be found in the list, so return -1 indicating not found
        return -1;
    }
}