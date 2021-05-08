using System;

namespace Examples
{
    public static class Program
    {
        static void Main(string[] args)
        {
            //Group Audible Questions
            int[][] Group = new int[][]{ 
                new int[] {1,1,0,0},
                new int[] {1,1,1,0},
                new int[] {0,1,1,1},
                new int[] {0,0,1,1}};
            var distinctGroup = Amazon.FindGroupAudible(Group);
            Console.WriteLine("Distinct Group: " + distinctGroup);
            // Circle Robot
            Console.WriteLine("Robot Bound Circle: " + Amazon.RobotBoundInCircle("GLL"));

            //JudgeCircle
            Console.WriteLine("Judge Circle: " + Example.JudgeCircle("UUDLLDDRR"));
        }
    }
}
