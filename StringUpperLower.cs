class StringUpperLower
{
    public static void Main(String[] args)
    {
        Console.WriteLine("Convert string to upper and lower case : ");

        //Showing console message to user that choose one option from below
        Console.WriteLine("Choose option : \n1. UPPER CASE \n2. lower case ");

        //taking choice through input and store in sbyte datatype
        sbyte optionChoosen = sbyte.Parse(Console.ReadLine());

        Console.Write("Enter string : ");

        //taking string input
        string text = Console.ReadLine();

        //here i have used Ternary operator, if user input 1 then string will convert in upper case if user input 2 then string will convert in lower
        Console.WriteLine(optionChoosen == 1 ? text.ToUpper() : optionChoosen == 2 ? text.ToLower() : "INVALID INPUT ...!!");
    }
}
