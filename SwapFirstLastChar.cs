class SwapFirstLastChar
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Swapping first character to last and last character to first .... !!!\n");

        Console.Write("Enter text : ");

        //taking string input
        string swappingText = Console.ReadLine();

        //here condition is that length of text should be equal or greater 2 
        if (swappingText.Length >= 2)
        {
            //assign new text,  character at last index of text + take text between first and last character then + first character
            // Example : varaible = o + ell + H
            swappingText = swappingText[swappingText.Length -1] + swappingText.Substring(1, swappingText.Length -2) + swappingText[0];
        }

        //printing text in console after swapping
        Console.WriteLine($"After swapping : {swappingText}");
    }
}
