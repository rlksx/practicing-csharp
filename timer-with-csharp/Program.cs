// using Sistem.Threading => necessario para rodar em versões anteriores.
class Program {
    static void Main(string[] args) {
        Menu();
    }
    
    static void Menu() {
        Console.Clear();
        Console.WriteLine("Insira um tempo para o timer e indique se é segundos ou minutos"         ); 
        Console.WriteLine("utilizando 's' após o tempo para indicar segundos e 'm' para minutos.\n" );
        Console.WriteLine("Exemplos: '10s' = 10 segundos, '10m' = 10 minutos, '32m' = 32 minutos."  );
        Console.WriteLine("Para sair digite como tempo '0s'!\n");
        Console.Write(">> ");

        string data = Console.ReadLine().ToLower();
        // ToLower => Transforma valor da string para minusculo.

        // separando valores
        char type = char.Parse( data.Substring(data.Length - 1, 1) ); // extraindo o ultimo caracter.
        // Substring(posiçãoDoCaracter, QuantidadeDeCaracter) => extrai um valor de uma string.
        int time = int.Parse( data.Substring(0, data.Length - 1) ); // extraindo os números inteiros.

        int multiplier = 1;
        if (type == 'm') multiplier = 60;
        if (time == 0) System.Environment.Exit(0); // => encerra execução do terminal.
        Console.WriteLine(time);
        Start(time * multiplier);
    }
    
    static void Start(int time) {

        int currentTime = 0;

        while (currentTime != time) {
            Console.Clear();
            currentTime++;
            Console.Write(currentTime);
            Thread.Sleep(1000); // => suspende uma execução por um tempo solicitado.
        }
        Console.Clear();
        Console.WriteLine("Temporizador finalizado.");
        Thread.Sleep(1000);
        Menu();
    }
}