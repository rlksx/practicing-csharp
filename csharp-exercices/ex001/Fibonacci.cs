class Fibonacci {
    public static void Start() {
        short lenghtFibonacci = short.Parse( Console.ReadLine() );
        Console.Clear();

        // Menu.DrawScreen(lenghtFibonacci + 2, 2);
        Console.SetCursorPosition(3, 2);
        Calculation(lenghtFibonacci); 
        Console.ReadKey();  
        }
        public static void Calculation(int lenght) { //10
            int b = 1;
            int a = 0;
            int aux = 0;

            for (int i = 0; i < lenght; i++) {
                aux = a + b;
                b = a;
                a = aux;
                Console.Write(aux + " ");
            }
    }
}