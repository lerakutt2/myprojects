import java.util.Scanner;

public class App {
    public static void main(String[] args) {
        Tictactoe t;
        Scanner in = new Scanner(System.in);
        do {
            do {
                System.out.print("За кого вы хотите играть? (O/X) ");
                String s = in.nextLine();
                if ("X".equals(s)) {
                    t = new Tictactoe("X", "O");
                    break;
                }
                else if ("O".equals(s)) {
                    t = new Tictactoe("O", "X");
                    break;
                }
                else {
                    System.out.println("Некорректный ввод");
                }
            } while (true);
            String again;
            t.play();
            do {
                System.out.print("Еще раз? (y/n) ");
                again = in.nextLine();
            }
            while (!"y".equals(again) && !"n".equals(again));
            if ("n".equals(again)) { break; }
        } while (true);
    }
}
