import java.util.*;

class Tictactoe {
    private static Grid mainGrid;
    private final AI ai;
    private final Machine machine;
    private Player player;
    private final Random rand = new Random();
    private int moveCount = 0;

    public Tictactoe(String AIRole, String compRole) {
        mainGrid = new Grid();
        ai = new AI(AIRole);
        machine = new Machine(compRole);
        player = XO.valueOf(AIRole) == XO.X ? ai : machine;
    }

    public XO play() {
        do {
            player.play();
            player = player.equals(ai) ? machine : ai;
            moveCount++;
        } while (!mainGrid.won());

        return mainGrid.winner;
    }

    private static abstract class Player {
        XO role;

        Player(String role) {
            this.role = XO.valueOf(role);
        }

        abstract void play();
    }

    /**
     * Игрок <code>Machine</code> играет по системе, основанной на правилах.
     * Наследутся от класса <code>Player</code>
     */
    private class Machine extends Player {
        Machine(String role) {
            super(role);
        }

        /**
         * Первые четыре раза игрок делает ход на строго определенные клетки.
         * В том случае, когда есть два подряд идущих символа на поле, делает ход в
         * свободную третью клетку.
         * В любом другом случае делает случайный ход.
         */
        void play() {
            int[] coords = new int[2];
            if (moveCount == 0) {
                coords[0] = 1;
                coords[1] = 3;
            } else if (moveCount == 1 && mainGrid.get(1, 1) == XO.E) {
                coords[0] = 2;
                coords[1] = 2;
            } else if (moveCount == 2) {
                if (mainGrid.get(0, 0) == XO.O || mainGrid.get(2, 2) == XO.O) {
                    coords[0] = 3;
                    coords[1] = 1;
                } else if (mainGrid.get(0, 1) == XO.O || mainGrid.get(1, 0) == XO.O || mainGrid.get(0, 2) == XO.O) {
                    coords[0] = 3;
                    coords[1] = 3;
                } else if (mainGrid.get(2, 1) == XO.O || mainGrid.get(1, 2) == XO.O) {
                    coords[0] = 1;
                    coords[1] = 1;
                } else {
                    coords = generateRandCoords();
                }
            } else if (moveCount == 4 && mainGrid.get(1, 1) == XO.E) {
                coords[0] = 2;
                coords[1] = 2;
            } else {
                coords = checkTwoInRow(role); // сначала проверяет нет ли двух подряд моих символов, чтобы сделать три
                if (coords[0] == -1) {
                    coords = checkTwoInRow(XO.opposite(role)); // если их нет, то проверяет противника, чтобы его
                                                              // заблокировать
                }
                if (coords[0] == -1) {
                    coords = generateRandCoords();
                }
            }

            mainGrid.update(coords, role);
        }

        int[] generateRandCoords() {
            int[][] moves = mainGrid.getEmptyCoords();
            return moves[rand.nextInt(moves.length)];
        }

        /**
         * Проверяет, есть ли на поле два идущих подряд символа
         * 
         * @param field символ для проверки (Х или О)
         * @return координаты хода. В случае отсутствия двух идущих подряд символов
         *         возвращает координаты [-1; -1]
         */
        int[] checkTwoInRow(XO field) {
            for (int i = 0; i < 3; i++) {
                // если в ряде два моих символа, то поставить один на пустую клетку
                if (containsCount(mainGrid.get(i)) == field && Arrays.asList(mainGrid.get(i)).contains(XO.E)) {
                    return new int[] { i + 1, Arrays.asList(mainGrid.get(i)).indexOf(XO.E) + 1 };
                }

                XO[] col = new XO[] { mainGrid.get(0, i), mainGrid.get(1, i), mainGrid.get(2, i) };
                // если в столбце два моих символа, то поставить один на пустую клетку
                if (containsCount(col) == field && Arrays.asList(col).contains(XO.E)) {
                    return new int[] { Arrays.asList(col).indexOf(XO.E) + 1, i + 1 };
                }
            }

            XO[] mainDiag = new XO[] { mainGrid.get(0, 0), mainGrid.get(1, 1), mainGrid.get(2, 2) };
            if (containsCount(mainDiag) == field && Arrays.asList(mainDiag).contains(XO.E)) {
                return new int[] { Arrays.asList(mainDiag).indexOf(XO.E) + 1,
                        Arrays.asList(mainDiag).indexOf(XO.E) + 1 };
            }

            XO[] secDiag = new XO[] { mainGrid.get(0, 2), mainGrid.get(1, 1), mainGrid.get(2, 0) };
            if (containsCount(secDiag) == field && Arrays.asList(secDiag).contains(XO.E)) {
                return new int[] {
                        Arrays.asList(secDiag).indexOf(XO.E) + 1,
                        3 - Arrays.asList(secDiag).indexOf(XO.E) };
            }

            return new int[] { -1, -1 };
        }

        /**
         * Считает сколько раз повторяется символ в диагонали, ряде или колонке.
         * Вспомогательный метод для метода <code>checkTwoInRow</code>
         * 
         * @param arr ряд, колонка или диагональ в виде массива
         * @return символ, который повторяется два раза. Если таких нет, возвращает
         *         пустую клетку
         */
        XO containsCount(XO[] arr) {
            int xCount = 0;
            int oCount = 0;

            for (XO xo : arr) {
                if (xo == XO.X) {
                    xCount++;
                } else if (xo == XO.O) {
                    oCount++;
                }
            }

            if (xCount == 2) {
                return XO.X;
            } else if (oCount == 2) {
                return XO.O;
            }

            return XO.E;
        }
    }

    /**
     * Играет, используя алгоритм минимакс
     */
    class AI extends Player {
        private AI(String aiPlayer) {
            super(aiPlayer);
        }

        void play() {
            mainGrid.update(minimax(mainGrid, role), role);
        }

        /**
         * Алгоритм минимакс
         * 
         * @param board    игровое поле
         * @param currRole текущий ход (Х или О)
         * @return         координаты и очки
         */
        int[] minimax(Grid board, XO currRole) {
            int[] best = { -1, -1, 0 };
            if (role == currRole)
                best[2] = -1000;
            else
                best[2] = 1000;

            if (board.won()) {
                if (board.winner == role)
                    return new int[] { 0, 0, 1 };
                else if (board.winner == XO.opposite(role))
                    return new int[] { 0, 0, -1 };
                else
                    return new int[] { 0, 0, 0 };
            }

            for (int[] coords : board.getEmptyCoords()) {
                board.update(coords, currRole);
                int[] score = minimax(board, XO.opposite(currRole));
                board.update(coords, XO.E);
                score[0] = coords[0];
                score[1] = coords[1];

                if (role == currRole) {
                    if (score[2] > best[2])
                        best = score;
                } else {
                    if (score[2] < best[2])
                        best = score;
                }
            }
            return best;
        }
    }
}