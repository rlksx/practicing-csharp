public static class Menu {
    // "static" => não podem ser instânciadas! 
    // void => sem retorno.

    public static void Show() {
        Console.Clear();
        // Console.BackgroundColor = ConsoleColor.Blue;  || Muda a cor de fundo do console.
        // Console.ForegroundColor = ConsoleColor.Black; || Muda a cor das letras.

        DrawScreen();
        WriteOptions();

        var option = short.Parse( Console.ReadLine() );

        HandleMenuOption(option);
    }

    public static void DrawScreen() {

        var borderLength = 45;

        Console.Write("+");
        for (int column = 0; column <=borderLength; column++) {
            Console.Write("-");
        }
        Console.Write("+\n");

        for (int row = 0; row <= 10; row++) {
            Console.Write("|");
            for (int i = 0; i <=borderLength; i++) {
                Console.Write(" ");
            }
            Console.Write("|\n");
        }

        Console.Write("+");
        for (int column = 0; column <=borderLength; column++) {
            Console.Write("-");
        }
        Console.Write("+\n");

    }

    public static void WriteOptions() {

        Console.SetCursorPosition(18,2); // coluna, linha
        Console.WriteLine("Editor HTML");

        Console.SetCursorPosition(16,3);
        Console.WriteLine("===============");

        Console.SetCursorPosition(4,5);
        Console.WriteLine("Selecione uma opção abaixo:");

        Console.SetCursorPosition(4,6);
        Console.WriteLine("1 - Criar Novo arquivo");

        Console.SetCursorPosition(4,7);
        Console.WriteLine("2 - Abrir arquivo existente");

        Console.SetCursorPosition(4,8);
        Console.WriteLine("0 - Parar execução");
        Console.SetCursorPosition(4,10);
        Console.Write("Selecionar >>> ");
    }

    public static void HandleMenuOption(short option) {

        switch (option) {
            case 1: Editor.Show(); break;
            case 2: Console.WriteLine("View"); break;
            case 0: {
                Console.Clear();
                Environment.Exit(0);
                break;
            }
            default: Show(); break;
        }
    }
}