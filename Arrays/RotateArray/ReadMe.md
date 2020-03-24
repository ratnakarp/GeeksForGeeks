# Problem #
Given an unsorted array arr[] of size N, rotate it by D elements (clockwise). 

## Input1: ##
5 2
1 2 3 4 5

## Output2: ##
3 4 5 1 2

## Input2: ##
10 3
2 4 6 8 10 12 14 16 18 20

## Output3:##
8 10 12 14 16 18 20 2 4 6

### Time Complexity ###
#### O(n) ####

```C#
 for (int i = 0; i < initialArray.Length; i++)
    {
        if (i < numberOfElementsToBeRotated)
        {
            copiedArray[i] = initialArray[i];
        }
        if (numberOfElementsToBeRotated + i < initialArray.Length)
        {
            initialArray[i] = initialArray[numberOfElementsToBeRotated + i];
        }
    }
    for (int i = 0; i < numberOfElementsToBeRotated; i++)
    {
        initialArray[(initialArray.Length -  numberOfElementsToBeRotated) + i] = copiedArray[i];
    }
```
