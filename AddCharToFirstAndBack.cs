class AddCharToFirstAndBack
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Adding character to the front of text and the back of text .... !!!\n");

        Console.Write("Enter text : ");

        //taking input text
        string text = Console.ReadLine();

        Console.Write("Enter character : ");
        
        //taking character input
        char characterInput = Console.ReadKey().KeyChar;
        Console.WriteLine();

        //printing text in console
        Console.WriteLine(characterInput + text + characterInput);
    }
}
