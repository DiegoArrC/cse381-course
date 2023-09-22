# Algorithm Description Document

Author: Diego Arroyo Castaneda

Date: 9/20/2023

## 1. Name

Binary Search

## 2. Abstract

The Binary Search will search a sorted list of numbers until either the target is found or each midpoint of the list, narrowed down each time, has been checked.

## 3. Methodology

The Binary Search is a basic search of sorted data $\lang c_1, c_2, c_3, ... c_n \rang$ for a target $t$. Since the data is already sorted, we start our search directly in the middle $(c_1 +c_n)/2$ and compare its value to the target. If the midpoint is less than the target value, we know that it can exist in the greater half of the list, or in the lower half if the midpoint is greater. We continually compare these midpoints to the target value until a matching value has been found or the size of the observable part of the list becomes 0. When a matching value is found, the algorithm will immediately return the index of the matching value. If the size of the observable sublist becomes 0, the value is not found, and then -1 will be returned.

## 4. Pseudocode

```
BINARY-SEARCH(data, target)
    SET left_index to 1
    SET right_index to size of data
    WHILE left_index <= right_index
        SET index to (left_index + right_index) / 2, rounded down
        IF data[index] == target
            RETURN index
        ELSE IF data[index] > target
            SET right_index to index - 1
        ELSE
            SET left_index to index + 1
    RETURN -1

```

## 5. Inputs & Outputs

Inputs:

* data - list of values that can be compared with each other
* target - item to search for that is the same type as items in data

Outputs:

* index of data that contains the target. If not found, then -1 is returned.

## 6. Analysis Results

* Worst Case: $O(lgn)$

* Best Case: $\Omega(1)$

