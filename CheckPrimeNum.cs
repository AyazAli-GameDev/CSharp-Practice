class CheckPrimeNum
{
    public static void Main(String[] args)
    {
        Console.WriteLine("Checking number is prime or not prime number ... !!!");
        
        Console.Write("Enter number : ");

        //taking prime number as input
        int primeNum = int.Parse(Console.ReadLine());

        //variable that store number of divisor
        int count = 0;

        //using loop for dividing with each number till input number
        for(int i = 1; i <= primeNum; i++)
        {
            //checking if given number is divide by number (that stores in i) and remainder will be 0
            if(primeNum % i == 0)
            {
                count++;
            }
        }

        //if divisor number is 2 then it is prime number
        if(count == 2) Console.WriteLine($"{primeNum} is prime");

        //if condition is not true then it is not prime number
        else Console.WriteLine($"{primeNum} is not prime ");
    }
}
