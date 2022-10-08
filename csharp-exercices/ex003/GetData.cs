class GetData {
    public static string[] Start() {
        string[] datas =  new string[4];

        Console.SetCursorPosition(20, 2);
        datas[0] = Console.ReadLine(); // nome

        Console.SetCursorPosition(20, 3);
        datas[1] = Console.ReadLine(); // email

        Console.SetCursorPosition(20, 4);
        datas[2] = Console.ReadLine(); // telefone

        Console.SetCursorPosition(20, 5);
        datas[3] = Console.ReadLine(); // numero do rg

        return datas;
    }
}