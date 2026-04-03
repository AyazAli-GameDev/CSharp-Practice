class SwapNumber
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

        //declaring third variable for swapping number
        int thirdNumber;
        
        //assign secondNumber's value to thirdNumber
        thirdNumber = secondNumber;

        //now assign firstNumber's value to secondNumber
        secondNumber = firstNumber;

        //in the last assign thirdNumber's value to firstNumber 
        firstNumber = thirdNumber;

        //now print again value of both number
        Console.WriteLine($"First number is : {firstNumber}. \nSecond number is : {secondNumber}.");

    }
}
