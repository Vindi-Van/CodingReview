using System;
using System.Linq;
using System.Collections.Generic;
public static class ArrayEx
{
    public static bool ContainsCommonType(string[] arr1, string[] arr2)
    {
        /*
        for(int i = 0; i < arr1.Length; i++){
            if(arr2.Contains(arr1[i])){
                return true;
            }
        }
        return false;
        */
        Dictionary<string, int> dict = new Dictionary<string, int>();
        foreach( var itm in arr1){
            if(!dict.ContainsKey(itm)){
                dict.Add(itm, 1);
            }else{
                dict[itm]++;
            }
        }
        for(int i = 0; i < arr2.Length; i++){
            if(dict.ContainsKey(arr2[i])){
                return true;
            }
        }
        return false;
    }
}