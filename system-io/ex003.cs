using System.IO;
using System.Text;
class ex003
{
    public ex003(string text)
    {
        byte[] bytes = Encoding.UTF8.GetBytes(text);
        File.WriteAllBytes("/home/rlksx/Downloads/ex003.txt", bytes);
    }
}