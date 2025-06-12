import java.util.ArrayList;

/**
* Сетка игрового поля
*/
public class Grid {
    private final XO[][] grid;
    XO winner;

    public Grid() {
        grid = new XO[3][];
        create();
    }
    
    public XO get(int i, int j) {
        return grid[i][j];
    }

    public XO[] get(int i) {
        return grid[i];
    }

    public int[][] getEmptyCoords() {
        ArrayList<int[]> moves = new ArrayList<>();
        for (int i = 0; i < 3; i++) {       
            for (int j = 0; j < 3; j++) {
                if (grid[i][j] == XO.E) {
                    moves.add(new int[] {i + 1, j + 1});
                }
            }
        }
        return moves.toArray(new int[moves.size()][]);
    }

    private void create() {
        for (int i = 0; i < 3; i++)
        {
            grid[i] = new XO[3];
            for (int j = 0; j < 3; j++) {
                grid[i][j] = XO.E;
            }
        }
    }
    
    void draw() {
        for (int i = 0; i < 3; i++) {
            for (int j = 0; j < 3; j++) {
                switch(grid[i][j]) {
                    case X: System.out.print("  X  "); break;
                    case O: System.out.print("  O  "); break;
                    case E: System.out.print("     "); break;
                    default: break;
                }
                if (j != 2) {
                    System.out.print("|");
                }
            }
            if(i != 2) {
                System.out.println();
                System.out.println("-----------------");
            }
        }
        System.out.println("\n");

    }

    void update(int[] coords, XO player) {
        grid[coords[0] - 1][coords[1] - 1] = player;
    }

    boolean won() {
        for (int j = 0; j < 3; j++) {
            boolean victory = true;
            if (grid[0][j] != XO.E) {
                XO field = grid[0][j];
                for (int i = 1; i < 3; i++) {
                    if (field != grid[i][j]) {
                        victory = false;
                        break;
                    }
                }
            
                if (victory) {
                    winner = field;
                    return true;
                }
            }
            
            if (grid[j][0] != XO.E) {
                victory = true;
                XO vert = grid[j][0];
                for (int i = 1; i < 3; i++) {
                    if (vert != grid[j][i]) {
                        victory = false;
                        break;
                    }
                }
            
                if (victory) {
                    winner = vert;
                    return true;
                }
            }
        }

        if(grid[0][0] != XO.E && grid[0][0] == grid[1][1] && grid[0][0] == grid[2][2]){
            winner = grid[1][1];
            return true;
        }
        if (grid[1][1] != XO.E && grid[0][2] == grid[1][1] && grid[2][0] == grid[1][1]) {
            winner = grid[1][1];
            return true;
        }

        if (!XO.contains(grid, XO.E)) {
            winner = XO.E;
            return true;
        }
        return false;
    }
}
