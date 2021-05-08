using System;

public static class Amazon{
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
            new int[] {-1,0},
            new int[] {0,1},
            new int[] {1,0},
            new int[] {0,-1},
        };
        var currentDir = 0;
        int[] currentPosition = new int[]{0,1};

        foreach (char a in direction)
        {
            switch(a){
                case 'G':
                    var x = currentPosition[0];
                    var y = currentPosition[1];

                    var d = dir[currentDir];
                    var new_x = d[0];
                    var new_y = d[1];
                    currentPosition[0] = new_x;
                    currentPosition[1] = new_y;
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
}
