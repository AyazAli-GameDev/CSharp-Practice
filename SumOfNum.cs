class SumOfNum
{
    public static void Main(string[] args)
    {
        Console.Write("Enter first number : ");

        //Taking first input from user and converting it in integer
        int firstNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter second number : ");

        //Taking second input from user and converting it in integer
        int secondNumber = int.Parse(Console.ReadLine());

        //Printing sum of both number through Console
        Console.WriteLine("Sum of two numbers is : " + (firstNumber + secondNumber));
    }
}
