using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public static class Amazon{
    //https://algo.monster/problems/amazon_online_assessment_questions
    //https://leetcode.com/discuss/interview-question/1183360/Amazon-Online-Assesment-Questions

    // Find groups of users that or connected or cities that are connected
    public static int FindGroupAudible(int[][] isConnected) {
        int result = 0;
        int[] visited = new int[isConnected.Length];

        for(int i = 0; i < isConnected.Length; i++) {
            if(visited[i] == 0){
                GroupHelper(isConnected, visited, i);
                result++;
            }
            
        }

        return result;
    }
    public static void GroupHelper(int[][] isConnected, int[] visited, int i){
        for(int j = 0; j < isConnected[i].Length; j++){
            if(isConnected[i][j] == 1 && visited[j] == 0){
                visited[j] = 1;
                GroupHelper(isConnected, visited, j);
            }
        }
    }

    // Find if Robot return to ORIGIN
    public static bool RobotBoundInCircle(string direction) {
        int[][] dir = new int[][] {
            new int[] {0,1},
            new int[] {1,0},
            new int[] {0,-1},
            new int[] {-1,0},
        };
        var currentDir = 0;
        int[] currentPosition = new int[]{0,0};

        foreach (char a in direction)
        {
            switch(a){
                case 'G':
                    currentPosition[0] += dir[currentDir][0];
                    currentPosition[1] += dir[currentDir][1];
                    break;
                case 'L':
                    currentDir = (currentDir + 3) % 4;
                    break;
                case 'R':
                    currentDir = (currentDir + 1) % 4;
                    break;
                default:
                    break;
            }
        }
        return (currentDir != 0) || ( currentPosition[0] == 0 && currentPosition[1] == 0);
    }

    // Optimizing Box Weights
    public static List<int> OptimizeBox(int[] nums){
        Array.Sort(nums);
        List<int> newNums = new List<int>(nums);
        
        int i = nums.Length - 1;
        List<int> temp = new List<int>();
        while( i >= 0 ){
            int targetNumber = newNums[i];

            List<int> tempChecker = new List<int>(newNums);
            tempChecker.RemoveAt(i);
            if( tempChecker.Contains( targetNumber )){
                // skip
                i--;
            }else {
                newNums.RemoveAt(i);
                //Console.WriteLine(String.Join(" ", nums));
                int tempTotal =  temp.Sum() + targetNumber;
                if(tempTotal < newNums.Sum()){
                    temp.Add(targetNumber);
                    i--;
                } else {
                    temp.Add(targetNumber);
                    break;
                }
            }
            
        }
        temp.Sort();
        return temp;
    }

    //Shopping Options
    public static int ShoppingOptions(){
        int[] priceOfJean = new int[]{2,3};
        int[] priceOfShoes = new int[]{4};
        int[] priceOfSkirts = new int[]{2,3};
        int[] priceofTops = new int[]{1,2};
    
        int budget = 10;
        //Already 6 dollars since Shoe is just one. will compare with the remaining 3 arrays.
        budget = 4;
        return budget;
    
    }

    public static List<string> TopNumCompetitors(int numCompetitors,
        int topNCompetitors,
        List<string> competitors,
        int numReviews, List<string> reviews)
    {
        if (competitors == null || reviews == null) return null;
        competitors = competitors.ConvertAll(d => d.ToLower());// to handle case in-sensitive
        Dictionary<string, int> competitorsFreqMap = competitors.ToDictionary(k => k, v => 0);
        for (int i = 0; i < numReviews; i++)
        {
            string currentReview = reviews[i].ToLower();
            foreach (string competitor in competitors.Where(comp => currentReview.Contains(comp)))
            {
                competitorsFreqMap[competitor]++; //increase freq count if present in review
            }
        }

        List<string> result = competitorsFreqMap.OrderByDescending(descKv => descKv.Value)
            .Take(topNCompetitors)
            .Select(kv => kv.Key)
            .ToList();

        return result;
    }
}
