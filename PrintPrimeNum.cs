class PrintPrimeNum
{
    public static void Main(String[] args)
    {
        Console.WriteLine("Printing Prime number .... !!!");

        Console.Write("Enter range for printing prime number : ");

        //taking input
        int PrimeNumRange = int.Parse(Console.ReadLine());

        //using for loop that execute till range
        for(int i = 2; i < PrimeNumRange; i++)
        {
            //creating bool variable that holds true or false if number is prime number
            bool isPrimeNum = true;

            //using loop to divide and check number 
            for(int j = 2; j < i; j++)
            {
                //here is condition to check if number is not prime number then break the loop
                if(i % j == 0)
                {
                    isPrimeNum = false;
                    break;
                }
            }

            if(isPrimeNum) Console.WriteLine($"{i} is prime number");
        }
    }
}
