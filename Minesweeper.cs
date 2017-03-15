// 529. Minesweeper
// Let's play the minesweeper game (Wikipedia, online game)!

// You are given a 2D char matrix representing the game board. 'M' represents an unrevealed mine, 'E' represents an unrevealed empty square, 'B' represents a revealed blank square that has no adjacent (above, below, left, right, and all 4 diagonals) mines, digit ('1' to '8') represents how many mines are adjacent to this revealed square, and finally 'X' represents a revealed mine.

// Now given the next click position (row and column indices) among all the unrevealed squares ('M' or 'E'), return the board after revealing this position according to the following rules:

// If a mine ('M') is revealed, then the game is over - change it to 'X'.
// If an empty square ('E') with no adjacent mines is revealed, then change it to revealed blank ('B') and all of its adjacent unrevealed squares should be revealed recursively.
// If an empty square ('E') with at least one adjacent mine is revealed, then change it to a digit ('1' to '8') representing the number of adjacent mines.
// Return the board when no more squares will be revealed.
// Example 1:
// Input: 

// [['E', 'E', 'E', 'E', 'E'],
//  ['E', 'E', 'M', 'E', 'E'],
//  ['E', 'E', 'E', 'E', 'E'],
//  ['E', 'E', 'E', 'E', 'E']]

// Click : [3,0]

// Output: 

// [['B', '1', 'E', '1', 'B'],
//  ['B', '1', 'M', '1', 'B'],
//  ['B', '1', '1', '1', 'B'],
//  ['B', 'B', 'B', 'B', 'B']]

// Explanation:

// Example 2:
// Input: 

// [['B', '1', 'E', '1', 'B'],
//  ['B', '1', 'M', '1', 'B'],
//  ['B', '1', '1', '1', 'B'],
//  ['B', 'B', 'B', 'B', 'B']]

// Click : [1,2]

// Output: 

// [['B', '1', 'E', '1', 'B'],
//  ['B', '1', 'X', '1', 'B'],
//  ['B', '1', '1', '1', 'B'],
//  ['B', 'B', 'B', 'B', 'B']]

// Explanation:

// Note:
// The range of the input matrix's height and width is [1,50].
// The click position will only be an unrevealed square ('M' or 'E'), which also means the input board contains at least one clickable square.
// The input board won't be a stage when game is over (some mines have been revealed).
// For simplicity, not mentioned rules should be ignored in this problem. For example, you don't need to reveal all the unrevealed mines when the game is over, consider any cases that you will win the game or flag any squares.
partial class Solution {
    public char[,] UpdateBoard(char[,] board, int[] click) {
        char[,] result = board.Clone() as char[,];
        int posx = click[0];
        int posy = click[1];
        if(result[posx, posy] == 'M')
        {
            result[posx, posy] = 'X';
        }
        else if(result[posx, posy] == 'E')
        {
            DFS(result,click[0], click[1]);
        }
        return result;
    }

    public void DFS(char[,] board, int posx, int posy)
    {
        int maxx = board.GetLength(0) - 1;
        int maxy = board.GetLength(1) - 1;
        if(posx < 0 || posx > maxx || posy < 0 || posy > maxy)
        {
            return;
        }
        if(board[posx, posy] != 'E')
        {
            return;
        }
        board[posx, posy] = GetDigit(board, posx, posy);
        if(board[posx, posy] != 'B')
        {
            return;
        }
        DFS(board, posx-1, posy-1);
        DFS(board, posx, posy-1);
        DFS(board, posx+1, posy-1);
        DFS(board, posx-1, posy);
        DFS(board, posx+1, posy);
        DFS(board, posx-1, posy+1);
        DFS(board, posx, posy+1);
        DFS(board, posx+1, posy+1);
    }
    public char GetDigit(char[,] board, int posx, int posy)
    {
        int maxx = board.GetLength(0) - 1;
        int maxy = board.GetLength(1) - 1;
        int result = 0;
        char[] resultchar = new char[9]{'B', '1', '2', '3', '4', '5', '6','7', '8'};
        if(posx != 0 && posy != 0 && board[posx-1, posy - 1] == 'M') result++;
        if(posx != 0  && board[posx-1, posy] == 'M') result++;
        if(posx != 0 && posy != maxy && board[posx-1, posy + 1] == 'M') result++;
        if(posy != 0 && board[posx, posy - 1] == 'M') result++;
        if(posy != maxy && board[posx, posy + 1] == 'M') result++;
        if(posx != maxx && posy != 0 && board[posx+1, posy - 1] == 'M') result++;
        if(posx != maxx && board[posx+1, posy] == 'M') result++;
        if(posx != maxx && posy != maxy && board[posx+1, posy + 1] == 'M') result++;
        return resultchar[result];
    }
}