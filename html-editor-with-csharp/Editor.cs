using System.Text;
class Editor {
    
    public static void Show() {

        Console.Clear();
        Console.WriteLine("  Modo Editor  ");
        Console.WriteLine("===============");
        Start();
    }

    public static void Start() {
        
        var file = new StringBuilder();

        do {
            file.Append( Console.ReadLine() ); // inserindo no file
            file.Append(Environment.NewLine); // nova linha
        } while (Console.ReadKey().Key != ConsoleKey.Escape);
        // Console.ReadKey().Key => lendo/verificando caracteres apertados do teclado.
        // ConsoleKey.Escape => tecla ESC do teclado.
        // enquando o usuário não apertar ESC faça...

        Console.WriteLine(" ================");
        Console.Write("Deseja Salvar o Arquivo? (S/N) >> ");
        var answer = Console.ReadLine();

        switch(answer) {
            case "S": SaveFile(); break;
            case "s": SaveFile(); break;
            case "Y": SaveFile(); break;
            case "y": SaveFile(); break;

            case "N": Menu.Show(); break;
            case "n": Menu.Show(); break;

            default: Menu.Show(); break;
        }
    }

    public static void SaveFile() {
        Console.Clear();
        Console.WriteLine("Salvando...");
    }
}