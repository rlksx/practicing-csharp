// using System.IO;
class Prgram {
    static void Main(string[] args) {
        Menu();
    }

    static void Menu() {
        Console.Clear();
        Console.WriteLine("*===========================================*");
        Console.WriteLine(" 1 - Abrir um arquivo existente."              );
        Console.WriteLine(" 2 - Criar novo arquivo para edição."         );
        Console.WriteLine(" 0 - Sair da aplicação."                      );
        Console.WriteLine("*===========================================*");

        short option = short.Parse( Console.ReadLine() );

        switch ( option ) {
            case 0: System.Environment.Exit(0); break;
            case 1: OpenFile(); break;
            case 2: CreateFile(); break;
            default: Menu(); break;
        }
    }

    static void OpenFile() {
        Console.Clear();
        Console.Write("Diretorio do arquivo >> ");
        string path = Console.ReadLine();

        Console.WriteLine("");

        using( var file = new StreamReader(path) ) {
            string text = file.ReadToEnd();
            Console.WriteLine(text);
        }
        Console.WriteLine("");
        Console.ReadLine();
        Menu();
    }

    static void CreateFile() {
        Console.Clear();
        Console.WriteLine("MANUAL: ESC = Sair;");
        Console.WriteLine("*=============================================================================*");
        string text = "";
        
        do{
            text += Console.ReadLine();
            text += Environment.NewLine; // Quebrando linha no final de cada leitura.
        } while (Console.ReadKey().Key != ConsoleKey.Escape);
        // enquando o usuário não precionar o 'esc' faça...
        // Console.ReadKey().Key => lendo teclas precionadas.
        // ConsoleKey.Escape => tecla 'ESC' do teclado.
        Console.WriteLine("\n*=============================================================================*\n");
        SaveFile(text);
    }

    static void SaveFile(string text) {
        Console.Clear();
        Console.WriteLine("Qual local que deseja salvar o arquivo?");
        var path = Console.ReadLine();

        // manipulando arquivo no dotnet
        using ( var file = new StreamWriter(path) ) {
         // todo obj passado para o using sera fechado após a execução do mesmo.
         // Stream.Writer(LocalSave + namefile.extension) => abrir um arquivo para inserir dados.
         // path => variavel onde está o local para salvar o arquivo.
         file.Write(text);
        }
        Console.Clear();
        Console.Write($"Arquivo {path} salvo com sucesso.");
        Thread.Sleep(4000);
        Menu();
    }
}