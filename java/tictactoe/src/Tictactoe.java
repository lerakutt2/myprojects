import java.util.Arrays;
import java.util.Scanner;
import java.util.Random;

public class Tictactoe {

    public Tictactoe(String humanRole, String compRole) {
        grid = new Grid();
        input = new Scanner(System.in);
        human = new Human(humanRole);
        machine = new Machine(compRole);
        player = XO.valueOf(humanRole) == XO.X ? human : machine;
        moveCount = 0;
    }

    public void play() {
        do {
            player.play();
            player = player.equals(human) ? machine : human;
            grid.draw();
            moveCount++;
        } while (!grid.won());
    }

    private static Grid grid;
    private Scanner input;
    private final Human human;
    private final Machine machine;
    private Player player;
    private final Random rand = new Random();
    private int moveCount;

    private abstract class Player {
        XO role;

        Player(String role) {
            this.role = XO.valueOf(role);
        }

        abstract void play();
    }

    private class Human extends Player {
        Human(String role) {
            super(role);
        }

        /**
         * Принимает и обрабатывает ввод координат от пользователя.
         * Обновляет сетку в соответствии с вводом, или выдает сообщение о неправильном
         * вводе и запрашивает его снова.
         */
        void play() {
            do {
                System.out.print("Введите координаты: ");
                String s = input.nextLine();
                try {
                    int[] coords = Arrays.stream(s.split(" ")).mapToInt(Integer::parseInt).toArray();
                    if (coords.length == 2) {
                        if (coords[0] <= 3 && coords[0] > 0 && coords[1] <= 3 && coords[1] > 0) {
                            if (grid.get(coords[0] - 1, coords[1] - 1) == XO.E) {
                                grid.update(coords, role);
                                break;
                            } else {
                                System.out.println("Это место занято");
                            }
                        } else {
                            System.out.println("Координаты должны быть числами от 1 до 3");
                        }
                    } else {
                        System.out.println("Координаты должны состоять из двух чисел");
                    }
                } catch (NumberFormatException ex) {
                    System.out.println("Координаты должны быть двумя числами");
                }
            } while (true);
        }
    }

    /**
     * Игрок <code>Machine</code> играет по системе, основанной на правилах.
     * Наследутся от класса <code>Player</code>
     */
    private class Machine extends Player {
        Machine(String role) {
            super(role);
        }

        /***
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
            } else if (moveCount == 1 && grid.get(1, 1) == XO.E) {
                coords[0] = 2;
                coords[1] = 2;
            } else if (moveCount == 2) {
                if (grid.get(0, 0) == XO.O || grid.get(2, 2) == XO.O) {
                    coords[0] = 3;
                    coords[1] = 1;
                } else if (grid.get(0, 1) == XO.O || grid.get(1, 0) == XO.O || grid.get(0, 2) == XO.O) {
                    coords[0] = 3;
                    coords[1] = 3;
                } else if (grid.get(2, 1) == XO.O || grid.get(1, 2) == XO.O) {
                    coords[0] = 1;
                    coords[1] = 1;
                } else {
                    coords = generateRandCoords();
                }
            } else if (moveCount == 4 && grid.get(1, 1) == XO.E) {
                coords[0] = 2;
                coords[1] = 2;
            } else {
                coords = checkTwoInRow(role); // сначала проверяет нет ли двух подряд моих символов, чтобы сделать три
                if (coords[0] == -1) {
                    // если их нет, то проверяет противника, чтобы его заблокировать
                    coords = checkTwoInRow(XO.opposite(role));
                }
                if (coords[0] == -1) {
                    coords = generateRandCoords();
                }
            }

            grid.update(coords, role);
        }

        int[] generateRandCoords() {
            int[][] moves = grid.getEmptyCoords();
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
                if (containsCount(grid.get(i)) == field && Arrays.asList(grid.get(i)).contains(XO.E)) {
                    return new int[] { i + 1, Arrays.asList(grid.get(i)).indexOf(XO.E) + 1 };
                }

                XO[] col = new XO[] { grid.get(0, i), grid.get(1, i), grid.get(2, i) };
                // если в столбце два моих символа, то поставить один на пустую клетку
                if (containsCount(col) == field && Arrays.asList(col).contains(XO.E)) {
                    return new int[] { Arrays.asList(col).indexOf(XO.E) + 1, i + 1 };
                }
            }

            XO[] mainDiag = new XO[] { grid.get(0, 0), grid.get(1, 1), grid.get(2, 2) };
            if (containsCount(mainDiag) == field && Arrays.asList(mainDiag).contains(XO.E)) {
                return new int[] { Arrays.asList(mainDiag).indexOf(XO.E) + 1,
                        Arrays.asList(mainDiag).indexOf(XO.E) + 1 };
            }

            XO[] secDiag = new XO[] { grid.get(0, 2), grid.get(1, 1), grid.get(2, 0) };
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
}
