public class Solution {
    public int CountUnguarded(int m, int n, int[][] guards, int[][] walls) {
        int unguardedTile = 0;
        
        // create the grid with m*n size
        // mark for tiles
        // 0 : unguarded
        // 1 : wall
        // 2 : guard
        // 3 : guarded
        int[,] grid = new int [m,n];

        // place walls then guards
        foreach (var wall in walls){
            grid[wall[0],wall[1]] = 1;
        }
        
        foreach (var guard in guards){
            grid[guard[0],guard[1]] = 2;
        }

        // Direction
        int[][] directions = new int[][] {
            new int[] {-1, 0},
            new int[] {1, 0},
            new int[] {0, -1},
            new int[] {0, 1}
        };
        
        // now iterate guard walks in 4 directions and mark as exposed tile
        foreach (var guard in guards) {
            int row = guard[0];
            int col = guard[1];
            foreach (var dir in directions) {
                int r = row + dir[0];
                int c = col + dir[1];
                // stop when 
                while ( r >= 0 && //1) hit the grid edge
                        r < m &&
                        c >= 0 &&
                        c < n &&
                        grid[r, c] != 1 && //2) hit wall
                        grid[r, c] != 2 )  //3) hit  guard                      
                        {
                        if (grid[r, c] == 0) {
                            grid[r, c] = 3; // mark guarded
                        }
                    r += dir[0];
                    c += dir[1];
                }
            }
        }

        //return count of un exposed tile
        for (int i = 0; i < m; i++) {
            for (int j = 0; j < n; j++) {
                if (grid[i, j] == 0) {
                    unguardedTile++;
                }
            }
        }
        return unguardedTile;
    }
}
