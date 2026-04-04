class LargestWord
{
    public static void Main(String[] args)
    {
        Console.WriteLine("Finding largest word in sentence .... !!!");

        Console.Write("Enter text : ");

        //taking string input means taking text from user
        string text = Console.ReadLine();

        //splilting word which have space of ending and creating an array
        string[] textArray = text.Split(' ');

        //here i have initialized string variable with empty string
        string LargestWord = "";

        //using foreach loop that run on each element or array
        foreach (string word in textArray)
        {
            //here is condition if length of word is greater than largestWord length then 
            if(word.Length > LargestWord.Length)
            {
                //assign word to largestWord
                LargestWord = word;
            }
        }

        //printing largest word in console
        Console.WriteLine($"Largest word : {LargestWord}");
    }
}
