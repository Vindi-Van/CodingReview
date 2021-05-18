﻿using System;

namespace Examples
{
    public static class Program
    {
        static void Main(string[] args)
        {

            ///////////////////////////////////////////////////////////////////////////////////////////////
            ///// Udemy Coding Course (one with map)
            ///////////////////////////////////////////////////////////////////////////////////////////////
            
            //// Sample of using timer to see how long a function takes
            //StopWatchEx.StopWatchTest();

            //// Compares 2 arrays to see if there is any common items
            //var stg1 = new string[]{"a", "b", "c", "x"};
            //var stg2 = new string[]{"z", "y","x"};
            //Console.WriteLine(ArrayEx.ContainsCommonType(stg1, stg2));

            //// Check if array has pair with sum
            //var numset = new int[]{6,4,3,2,1,7};
            //Console.WriteLine(ArrayEx.HasPairWithSum(numset, 10));

            //// ArraySamples and MyArray
            //ArrayEx.ArraySamples();

            //MyArray myArray = new MyArray();
            //myArray.push("Hello");
            //myArray.push("World");
            //myArray.push("!");
            //for (int i = 0; i < myArray.length; i++)
            //{
            //    Console.WriteLine(myArray.get(i));
            //}





            ///////////////////////////////////////////////////////////////////////////////////////////////
            /////Amzaon Questions
            ///////////////////////////////////////////////////////////////////////////////////////////////
            //Group Audible Questions
            /*
            int[][] Group = new int[][]{ 
                new int[] {1,1,0,0},
                new int[] {1,1,1,0},
                new int[] {0,1,1,1},
                new int[] {0,0,1,1}};
            var distinctGroup = Amazon.FindGroupAudible(Group);
            Console.WriteLine("Distinct Group: " + distinctGroup);
            */

            //Circle Robot
            /* 
            Console.WriteLine("Robot Bound Circle: " + Amazon.RobotBoundInCircle("GLL"));
            */

            //Optimizing Box
            /* 
            int[] arr1 = new int[] {4,2,3,35,7,13,13,11,12,5,1,6};
            Console.WriteLine("Optimizing Box: ");
            Console.WriteLine( String.Join(" ", Amazon.OptimizeBox(arr1)));
            printArray(Amazon.OptimizeBox(arr1));
            */

            //ShoppingOptions
            //Console.WriteLine("Shopping Option : " + Amazon.ShoppingOptions());

            ////////////////////////////////////////////////////////////
            //JudgeCircle
            /*
            Console.WriteLine("Judge Circle: " + Example.JudgeCircle("UUDLLDDRR"));
            */

            //Coin Combination (Dynamic Programming)
            //int[] coins = new int[] {1,2,5};
            //Console.WriteLine("Coin Combination: " + Example.CoinCombination(10, coins));

            
        }

        public static void printArray(int[] arr){
            for(int i = 0; i < arr.Length; i++){
                Console.WriteLine(arr[i]);
            }
        }
    }
}
