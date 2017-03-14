// You are given a map in form of a two-dimensional integer grid where 1 represents land and 0 represents water. Grid cells are connected horizontally/vertically (not diagonally). The grid is completely surrounded by water, and there is exactly one island (i.e., one or more connected land cells). The island doesn't have "lakes" (water inside that isn't connected to the water around the island). One cell is a square with side length 1. The grid is rectangular, width and height don't exceed 100. Determine the perimeter of the island.

// Example:

// [[0,1,0,0],
//  [1,1,1,0],
//  [0,1,0,0],
//  [1,1,0,0]]

// Answer: 16
// Explanation: The perimeter is the 16 yellow stripes in the image below:

// Subscribe to see which companies asked this question.
partial class Solution {
    public int IslandPerimeter(int[,] grid) {
        int result = 0;
        int width = grid.GetLength(0);
        int height = grid.GetLength(1);
        for(int i = 0;  i < width; ++i)
        {
            for (int j = 0; j < height;  ++j)
            {
                if(grid[i, j] == 1)
                {
                    result += 4;
                    //周围有几个邻居
                    //4个领取的话0个周长
                    if (i != 0 && grid[i-1, j] == 1)
                        result--;
                    if (i != (width - 1) && grid[i+1, j] == 1)
                        result--;
                    if (j != 0 && grid[i, j-1] == 1)
                        result--;
                    if (j != (height - 1) && grid[i, j+1] == 1)
                        result--;
                }
            }
        }
        return result;
        // return (maxx-minx+1)*(maxy-miny+1);
        // return result;
    }
}