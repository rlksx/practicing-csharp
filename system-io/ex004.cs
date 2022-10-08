using System.IO;
class ex004
{
    public ex004(string file)
    {
        string text = File.ReadAllText(file);
        Console.WriteLine(text);
    }
}