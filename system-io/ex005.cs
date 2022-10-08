using System.IO;
class ex005
{
    public ex005(string file)
    {
        string[] lines = File.ReadAllLines(file);
        foreach (var item in lines)
        {
            Console.WriteLine(item);
        }
    }
}