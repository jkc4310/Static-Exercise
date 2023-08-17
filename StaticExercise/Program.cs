namespace StaticExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var celcisus = TempConverter.FahrenheitToCelsius(95);

            Console.WriteLine($"celsius {celcisus}");

            var fahrenheit = TempConverter.CelsiusToFahrenheit(40);

            Console.WriteLine($"Fahrenheit {fahrenheit}");
        }


    }
}
