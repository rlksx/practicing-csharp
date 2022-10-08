// void => quando não retorna nada, não possí o "return()"
// static => quando não tem valor para ser instânciado, usando quando 
// não é um projeto POO e não possuí instâncias.
public class Menu {

    public static void Start(int row, int column) {

        Console.Clear();
        DrawScreen(row, column); // 32 linha e 6 colunas
        DrawMenu();
    }

    public static void DrawScreen(int row, int column) {

        Console.Write("* ");
        for (int i = 0; i <= row; i++) {
            Console.Write("=");
        }
        Console.Write(" *\n");

        for (int j = 0; j <= column; j++) {
            Console.Write("| ");

            for (int x = 0; x <= row; x++) {
                Console.Write(" ");
            }
            Console.Write(" |\n");
        }

        Console.Write("* ");
        for (int i = 0; i <= row; i++) {
            Console.Write("=");
        }
        Console.Write(" *");
    }

    public static void DrawMenu() {
        // linha, coluna

        Console.SetCursorPosition(7, 2);
        Console.Write("Sequencia de Fibonacci"); 
        
        Console.SetCursorPosition(5,3);
        Console.Write("==========================");

        Console.SetCursorPosition(2, 5);
        Console.Write(">> Até Posição: ");
    }
}