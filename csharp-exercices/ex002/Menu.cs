// void => não possuí retorno/tipo
// static método não instânciavel
class Menu {
    public static void Start() {
        Console.Clear();

        DrawScreen(38, 8);
        DrawMenu();
    }

    public static void DrawScreen(int row, int column) {
        
        // row
        Console.Write("* ");
        for (int j = 0; j < row; j++) {
            Console.Write("=");
        }
        Console.Write(" *\n");

        // columns
        for (int j = 0; j < column; j++) {
            Console.Write("| ");
            for (int f = 0; f < row; f++) {
                Console.Write(" ");
            }
            Console.Write(" |\n");
        }

        Console.Write("* ");
        for (int x = 0; x < row; x++) {
            Console.Write("=");
        }
        Console.Write(" *");
    }   

    public static void DrawMenu() {
        Console.SetCursorPosition(13, 2); // linha("=") , coluna("|")
        Console.Write("È par ou impar?");

        Console.SetCursorPosition(11, 3);
        Console.Write("===================");

        Console.SetCursorPosition(0, 7);
        Console.Write("* ");
        for (int i = 0; i <= 37; i++) {
            Console.Write("=");
        }
        Console.Write(" *");

        Console.SetCursorPosition(3, 5);
        Console.Write("> Insira um Número: ");
    }
}