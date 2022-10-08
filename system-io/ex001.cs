class ex001
{
    public ex001(string path, string text) {
        File.WriteAllText(path, text);
    }
}