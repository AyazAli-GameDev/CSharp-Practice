class PrintOddNum
{
    public static void Main(String[] args)
    {
        Console.WriteLine("Printing odd number .... !!!");

        Console.Write("Enter range for printing odd number : ");

        //taking input
        int OddNumRange = int.Parse(Console.ReadLine());

        //using for loop that execute till range
        for(int i = 0; i < OddNumRange; i++)
        {
            //checking if value in i divide by 2 and remainder will not equal to 0 then print number
            if(i % 2 != 0)
            {
                Console.WriteLine($"{i} is odd number.");
            }
        }
    }
}
