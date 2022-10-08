using System.IO;
using System.Text;
class ex006
{
    public ex006(string file) 
    {
        byte[] datas = File.ReadAllBytes(file);
        Console.WriteLine(datas);
    }
}