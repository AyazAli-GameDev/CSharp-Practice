class BasicCalculator
{
    public static void Main(string[] args)
    {
        Console.Write("Enter first value : ");
        int firstNumber = int.Parse(Console.ReadLine());

        Console.Write("Enter operator symbol ( + - x / ) : ");
        char operatorSymbol = Console.ReadKey().KeyChar;

        Console.Write("\nEnter second value : ");
        int secondNumber = int.Parse(Console.ReadLine());

        if(operatorSymbol == '+') Console.WriteLine($"Addition performed : {firstNumber + secondNumber}");
        else if(operatorSymbol == '-') Console.WriteLine($"Subtraction performed : {firstNumber - secondNumber}");
        else if(operatorSymbol == 'x') Console.WriteLine($"Multiplication performed : {firstNumber * secondNumber}");
        else if(operatorSymbol == '/') Console.WriteLine($"Division performed : {firstNumber / secondNumber}");
        else Console.WriteLine("INVALID CALCULATION .... !!!");
    }
}
