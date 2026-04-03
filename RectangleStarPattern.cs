class RectangleStarPattern
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Printing rectangle star pattern ... !!!");

        //print message for user
        Console.Write("Enter number of rows for rectangle : ");

        //taking input for rows
        int numberRows = int.Parse(Console.ReadLine());
        //print message for user
        Console.Write("\nEnter number of columns for rectangle : ");

        //taking input for columns
        int numberColumns = int.Parse(Console.ReadLine());

        for (int i = 0; i < numberRows; i++)
        {
            for (int j = 0; j < numberColumns; j++)
            {
                Console.Write(" * ");
            }
            Console.WriteLine();
        }
    }
}
