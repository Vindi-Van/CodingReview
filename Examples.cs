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
}
