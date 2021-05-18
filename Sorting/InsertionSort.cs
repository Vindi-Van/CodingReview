using System;

class InsertionSort
{
    public static int[] insertionSort(int[] array)
    {
        int length = array.Length;
        for (int i = 1; i < length; ++i)
        {
            int key = array[i];
            int j = i - 1;

            // Move elements of array[0..i-1], 
            // that are greater than key, 
            // to one position ahead of 
            // their current position 
            while (j >= 0 && array[j] > key)
            {
                array[j + 1] = array[j];
                j = j - 1;
            }
            array[j + 1] = key;
        }
        return array;
    }
    }
