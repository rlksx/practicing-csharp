class MakeFile {
    public static void Start() {
        var datas = GetData.Start();

        string nome = datas[0];
        string email = datas[1];
        string phone = datas[2];
        string numRG = datas[3];

        string path = "/home/rlksx/Downloads/teste.txt";

        // o using fecha o objeto automaticamente após a execução do mesmo!
        using (var file = new StreamWriter(path) ) {
            file.WriteLine($"Nome Completo : {nome}");
            file.WriteLine($"E-mail        : {email}");
            file.WriteLine($"Telefone      : {phone}");
            file.WriteLine($"Número do RG  : {numRG}");
        }
    }
}