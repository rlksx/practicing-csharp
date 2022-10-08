class Checking {
    public static void Check() {
        var number = short.Parse( Console.ReadLine() );
        Console.SetCursorPosition(3, 8);
        Console.Write("> ");

        switch(number % 2) {
            case 0: Console.Write($"O número {number} é par! "); break;
            default: Console.Write($"O número {number} é impar!"); break;
        }
    }
}