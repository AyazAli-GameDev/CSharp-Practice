class SumTripleSum
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Sum of two numbers if both values are equal then add it in triple ....");

        Console.Write("Enter first value : ");

        //taking input for first number
        int firstNumber = int.Parse(Console.ReadLine());

        Console.Write("Enter second : ");
        //taking input for second number
        int secondNumber = int.Parse(Console.ReadLine());

        //performing sum
        Console.WriteLine(firstNumber == secondNumber ? ("If both values are equal : " + (firstNumber + secondNumber + firstNumber)) : ("If both values are not equal : " + (firstNumber + secondNumber)));
    }
}
