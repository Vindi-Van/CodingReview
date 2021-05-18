using System;

class SelectionSort
{
    public static int[] selectionSort(int[] array)
    {
        int length = array.Length;
        for (int i = 0; i < length; i++)
        {
            int min = i;
            int temp = array[i];
            for (int j = i + 1; j < length; j++)
            {
                if (array[j] < array[min])
                { //Searching min value and it's index
                    min = j;
                }
            }
            
            array[i] = array[min];
            array[min] = temp;
        }
        return array;
    }
}