partial class Solution {
    public int CountBattleships(char[,] board) {
        if (board.Length == 0)
        {
            return 0;
        }
        int row = board.GetLength(0);
        int column = board.GetLength(1);
        int num = 0;
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < column; j++)
            {
                if (board[i, j] == 'X'
                && (i == 0 || board[i-1, j] == '.')
                && (j == 0 || board[i, j-1] == '.'))
                {
                    num++;
                }
            }
        }
        return num;
    }
}
///这个通过找床头解决的问题
///另外可以通过DFS解决不过空间复杂度会超标