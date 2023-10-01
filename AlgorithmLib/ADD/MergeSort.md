# Algorithm Description Document

Author: Diego Arroyo Castaneda

Date: 9/30/23

## 1. Name

Merge Sort

## 2. Abstract

A sorting algorithm that uses the concept of divide and conquer to break apart and rebuild a list in order.

## 3. Methodology

Merge Sort is a particular type of sorting algorithm that uses recursion to split a list into continuously smaller sublists. These sublists are then compared to each other, iterating through their values. Based on the comparison requirements, the lesser (or greater) value are placed, in order, in the original list, and the original list is updated through each recursion. This keeps occuring until all values have been visited, and the list has been sorted.

## 4. Pseudocode

```
MERGE(data, first, mid, last)

IF first > last:
    RETURN
LET n1 = mid - first + 1
LET n2 = last - mid

LET left_data = [], length(n1)
LET left_data = [], length(n2)

SET left_data = data[0:mid]
SET right_data = data[mid + 1:last]

LET i and j = 0

FOR k=first to last:
    IF left_data[i] <= right_data[j]:
        SET data[k] = left_data[i]
        INCREMENT i + 1
    ELSE:
        SET data[k] = right_data[j]
        INCREMENT j + 1

SORT(data, first, last)

IF first >= last:
    RETURN
LET mid = (first + last) / 2, rounded down
call SORT(data,first,mid)
call SORT(data,mid + 1,last)
call MERGE(data, first mid, last)
```

## 5. Inputs & Outputs

List only inputs and outputs for the SORT function.

Inputs:

* data - a list of sortable values
* first - an integer representing the first index of a list
* last - an integer representing the last index of a list

Outputs:

## 6. Analysis Results

* Worst Case: $O(nlogn)$

* Best Case: $\Omega(nlogn)$

