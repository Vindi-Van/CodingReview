using System;
using System.Linq;
using System.Collections.Generic;
public static class ArrayEx
{
    public static bool ContainsCommonType(string[] arr1, string[] arr2)
    {
        // You can also use the method intersect. ex. arr1.Intersect(arr2);

        /*
        // O(a*b)
        // O(1) - SpaceComplexity
        for(int i = 0; i < arr1.Length; i++){
            if(arr2.Contains(arr1[i])){
                return true;
            }
        }
        return false;
        */

        // O(a + b)
        // O(a) - Space Complexity
        HashSet<string> dict = new HashSet<string>();
        foreach( var itm in arr1){
            if(!dict.Contains(itm)){
                dict.Add(itm);
            }else{
                //dict[itm]++;
            }
        }
        for(int i = 0; i < arr2.Length; i++){
            if(dict.Contains(arr2[i])){
                return true;
            }
        }
        return false;
    }

    public static bool HasPairWithSum(int[] arr, int sum){
        // O(n)
        // O(n) space - complexity
        var dict = new HashSet<int>();
        for(int i = 0; i < arr.Length; i++){
            if(dict.Contains(arr[i]))
                return true;
            dict.Add( sum - arr[i]);
        }
        return false;
    }

    public static void ArraySamples(){
        var sample = new List<string>{"a", "b"};
        sample.Add("e");
        Console.WriteLine( String.Join(", ", sample));

        // add to beginning of array or end
        sample.Insert(0, "p");
        sample.Insert(sample.Count, "z");
        Console.WriteLine( String.Join(", ", sample));
        
    }
}