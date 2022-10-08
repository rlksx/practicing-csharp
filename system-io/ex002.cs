using System.IO;
class ex002
{
    public ex002() 
    {
        string[] lines = { "Linha um/string 0", "Linha dois/string 1" };
        File.WriteAllLines("/home/rlksx/Downloads/ex002.txt", lines);
    }
}