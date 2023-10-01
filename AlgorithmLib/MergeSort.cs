using System.Security.AccessControl;

namespace AlgorithmLib;

public static class MergeSort
{
    private static void Merge(List<IComparable> data, int first, int mid, int last)
    {
        // Split the current list in half into two sublists, with the first half including the midpoint of the list.
        List<IComparable> first_half = data.GetRange(first,mid - first + 1);
        List<IComparable> second_half = data.GetRange(mid + 1,last - mid);
        
        // Initialize two temporary index handlers, one for each sublist, for iterations.
        var (first_half_index, second_half_index) = (0,0);
        
        // Iterate through the main list from first to last and update the positions of values based on the sublists.
        for (int i = first; i <= last; i++)
        {
            // The first sublist still contains data.
            if (first_half_index < first_half.Count &&
            // The second list is empty or iterated through, or the first item in sublist one is not greater than in sublist two.
            (second_half_index >= second_half.Count||first_half[first_half_index].CompareTo(second_half[second_half_index]) <=0))
            {
                data[i] = first_half[first_half_index];
                first_half_index ++;
            }
            // The first sublist is empty/iterated through, or the value in sublist two was lesser.
            else
            {
                data[i] = second_half[second_half_index];
                second_half_index ++;
            }
        }

    }

    public static void Sort(List<IComparable> data)
    {
        // Call a helper function using default values of index 0 for "first" and the length of the list for "last"
        _Sort(data,0,data.Count-1);
    }
    // Helper function for Sort function
    public static void _Sort(List<IComparable> data, int first, int last)
    {
        // There is at most 1 item in the list
        if (first >= last)
        {
            return;
        }
        int mid = (first + last) / 2;
        // Recursively call the sort function on the first half of the list
        _Sort(data,first,mid);
        // Recursively call the sort function on the second half of the list
        _Sort(data,mid + 1,last);
        // Call the Merge function on the current sublist
        Merge(data,first,mid,last);
    }
    
}

