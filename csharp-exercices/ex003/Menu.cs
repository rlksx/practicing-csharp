// void => método sem retorno!
// static => método que não depende de uma variavel instânciada!
class Menu {
    public static void Start() {
        Console.Clear();

        DrawScreen(48, 6);
        DrawMenu();
    }

    public static void DrawScreen(int row, int column) {

        // 1° row
        Console.Write("* ");
        for (int i = 0; i < row; i++) {
            Console.Write("=");
        }
        Console.Write(" *\n");

        // meio
        for (int j = 0; j < column; j++) {
            Console.Write("| ");
            for (int d = 0; d < row; d++) {
                Console.Write(" ");
            }
            Console.Write(" |\n");
        }

        // ultima row
        Console.Write("* ");
        for (int i = 0; i < row; i++) {
            Console.Write("=");
        }
        Console.Write(" *\n");
    }

    public static void DrawMenu() {

        Console.SetCursorPosition(2, 2);
        Console.Write("> Nome Completo : ");

        Console.SetCursorPosition(2, 3);
        Console.Write("> E-mail        : ");

        Console.SetCursorPosition(2, 5);
        Console.Write("> Número do RG  : ");

        Console.SetCursorPosition(2, 4);
        Console.Write("> Telefone      : ");
        
    }
}