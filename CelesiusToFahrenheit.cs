using System.Security.Cryptography.X509Certificates;

class CelesiusToFahrenheit
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter C for Celesius conversion and F for Fahrenheit conversion .....");
        
        //taking conversion character 
        char conversionSymbol = char.ToLower(Console.ReadKey().KeyChar);

        Console.WriteLine("\nEnter temperature : ");
        float temperatureInput = float.Parse(Console.ReadLine());

        //checks if user input c then perform celesius conversion
        if(conversionSymbol == 'c') Console.WriteLine("Celesius to Fahrenheit : " + ((temperatureInput * (9.0f / 5.0f)) + 32));
        else if(conversionSymbol == 'f') Console.WriteLine("Fahrenheit to Celesius : " + ((temperatureInput - 32) * (5.0f / 9.0f)));
        else Console.WriteLine("Enter correct value ");
    }
}
