class PrintAgeMessage
{
    public static void Main(string[] args)
    {
        Console.Write("Enter your age : ");
        
        //taking input age and converting it in integer from string
        int userAge = int.Parse(Console.ReadLine());

        if(userAge <= 0) Console.WriteLine("Kindly enter correct age ... !!!");

        //checking if user's age is greater than o and less than 10
        else if(userAge < 10) Console.WriteLine("You are child ... ");

        //checking if user's age is greater than 10 and less than 18 
        else if(userAge < 18) Console.WriteLine("You are teen ager ...");

        //checking if user's age is greater than 18 and less than 28
        else if(userAge < 28) Console.WriteLine("Your are adult ... ");

        //putting last condition
        else if(userAge < 100) Console.WriteLine("You are old man ... ");

        //if user put age greater than 100
        else Console.WriteLine("Age is not in record .... !!!!");
    }
}
