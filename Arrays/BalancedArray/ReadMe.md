# Problem #
Given an array of even size, task is to find minimum value that can be added to an element so that array become balanced. 

## Input1: ##
1. 1 2 3 4 5 6

## Output1: ##
9

### Time Complexity ###
#### O(n) ####

```C#
int[] arr = { 1, 2, 3, 4, 5, 6 };
var count1 = 0;
var count2 = 0;
for(int i=0; i < arr.Length; i++)
{
    if (i < arr.Length /2)
    {
        count1 += arr[i];
    }
    else
    {
        count2 += arr[i];
    }
}
if (count1 < count2) {
    Console.WriteLine(count2 - count1);
}
else
{
    Console.WriteLine(count1 - count2);
}
```
