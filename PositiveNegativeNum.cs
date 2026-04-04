class PositiveNegativeNum
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Printing positive or negative integer ....!!!\n");

        Console.Write("Enter number : ");

        //taking input from user
        int number = int.Parse(Console.ReadLine());

        //checking number is positive or negative
        //if number is less 0 means it is negative
        if(number < 0) Console.WriteLine($"Number is negative : {number}");

        //other condition is if number is greater than 0 means it positive
        else if(number > 0) Console.WriteLine($"Number is positive : {number}");

        //if user enter 0 or string value then this message will show to the user
        else Console.WriteLine("INVALID INPUT ... !!!");
    }
}
