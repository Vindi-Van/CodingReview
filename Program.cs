using System;

namespace Examples
{
    public static class Program
    {
        static void Main(string[] args)
        {
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
            Console.log(Amazon.ShoppingOptions);

            ////////////////////////////////////////////////////////////
            //JudgeCircle
            /*
            Console.WriteLine("Judge Circle: " + Example.JudgeCircle("UUDLLDDRR"));
            */

            //Coin Combination (Dynamic Programming)
            int[] coins = new int[] {1,2,5};
            Console.WriteLine("Coin Combination: " + CoinCombination());

            
        }

        public static void printArray(int[] arr){
            for(int i = 0; i < arr.Length; i++){
                Console.WriteLine(arr[i]);
            }
        }
    }
}
