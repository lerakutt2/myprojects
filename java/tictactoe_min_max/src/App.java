public class App {
    public static void main(String[] args) {
        Tictactoe t;
        int winCount1 = 0;
        int winCount2 = 0;
        for (int i = 0; i < 100; i++) {
            t = new Tictactoe("X", "O");
            XO winner = t.play();
            if (winner == XO.E) {
                winCount1++;
            }
        }
        System.out.println("Количество ничьих, если алгоритм минимакс играет за Х: " + winCount1);
        for (int i = 0; i < 100; i++) {
            t = new Tictactoe("O", "X");
            XO winner = t.play();
            if (winner == XO.E) {
                winCount2++;
            }
        }
        
        System.out.println("Количество ничьих, если алгоритм минимакс играет за О: " + winCount2);
    }
}
