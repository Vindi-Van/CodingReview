using System;

public static class Example{
    // Determine if robot is back to start....Direction "UDLR"...
    public static bool JudgeCircle(string direction) {
        int UD = 0;
        int LR = 0;
        for(int i = 0; i < direction.Length; i++){
            var currentMove = direction[i];
            switch (currentMove){
                case 'U':
                    UD++;
                    break;
                case 'D':
                    UD--;
                    break;
                case 'L':
                    LR++;
                    break;
                case 'R':
                    LR--;
                    break;
                default:
                    break;
            }
        }

        return (UD == 0 && LR == 0);
    }

    //Example of dynamic programing (given coins, find the number of combinations to get to the target $$)
    public static int CoinCombination(int amount, int[] coins){
        int[] dp = new int[amount + 1];
        dp[0] = 1;
        
        foreach(var coin in coins){
            for(int x = coin; x < amount + 1; ++x){
                dp[x] += dp[ x - coin];
            }
        }
        return dp[amount];
        
        /*
        int[,] dp = new int[coins.Length + 1, amount+1];
        dp[0,0] = 1;
        for (int c = 1; c <= coins.Length; ++c) {
            int coin = coins[c-1];
            for (int i = 0; i <= amount; ++i) {
                dp[c,i] = dp[c-1,i];
                if (i - coin < 0) continue;
                dp[c,i] += dp[c,i - coin];
            }
        }
        return dp[coins.Length,amount];
        */
    }
}
