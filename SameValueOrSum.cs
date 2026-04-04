class SameValueOrSum
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Return true if one of the value is 20 or sum of both value is 20 ... !!!");

        Console.Write("Enter first number : ");

        //taking first number input
        int firstNumber = int.Parse(Console.ReadLine());

        Console.Write("Enter second number : ");

        //taking second number input
        int secondNumber = int.Parse(Console.ReadLine());

        Console.WriteLine(firstNumber == 20 || (firstNumber + secondNumber == 20));
    }
}
