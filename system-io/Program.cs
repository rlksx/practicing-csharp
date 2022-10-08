using System.IO; // biblioteca do file.write
using System.Text; // biblioteca do Encoding.UTF8 e outros


class Program 
{
    public static void Main(string[] args)
    {
        // Writing...
        var FileWrite = new ex001("/home/rlksx/Downloads/ex001.txt", "File.WriteAllText();");
        Console.WriteLine("ex001 escrito");

        var FileWrite2 = new ex002();
        Console.WriteLine("ex002 escrito");
        // File.WriteAllLines => excreve array em um arquivo e cada linha é um valor desse array

        var FileWrite3 = new ex003("File.WriteAllBytes();");
        Console.WriteLine("ex003 escrito");
        // escreve bits no arquivo, precisa transfirmar string difetamenta para bits

        // Reading...
        var FileRead = new ex004("/home/rlksx/Downloads/ex001.txt"); // emprime o conteudo feito por ex001
        Console.WriteLine("||ex001 impresso||\n");
        
        var FileRead2 = new ex005("/home/rlksx/Downloads/ex002.txt"); // imprime o arquivo feito por ex002
        Console.WriteLine("||ex002 impresso||\n");

        var FileRead3 = new ex006("/home/rlksx/Downloads/ex003.txt");
    }
}