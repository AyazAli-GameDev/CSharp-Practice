class SwappedNumber
{
    public static void Main(string[] args)
    {
        Console.Write("Enter first number : ");

        //Taking first input from user and converting it in integer
        int firstNumber = int.Parse(Console.ReadLine());
        Console.Write("Enter second number : ");

        //Taking second input from user and converting it in integer
        int secondNumber = int.Parse(Console.ReadLine());

        //Print both number
        Console.WriteLine($"First number is : {firstNumber}. \nSecond number is : {secondNumber}.");

        //perform arithmetic operation
        firstNumber = firstNumber + secondNumber;
        Console.WriteLine($"first number is : {firstNumber} using a = a + b formula ....");

        secondNumber = firstNumber - secondNumber;
        Console.WriteLine($"second number is : {secondNumber} using b = a - b formula ....");

        firstNumber = firstNumber - secondNumber;
        Console.WriteLine($"now in last step first number is : {firstNumber} using a = a - b .....");

        //now print again value of both number
        Console.WriteLine("Value in varaibles after swapping ....");
        Console.WriteLine($"First number is : {firstNumber}. \nSecond number is : {secondNumber}.");

    }
}
