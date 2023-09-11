namespace MyFirstProgram
{
    internal class Program
    {
        static void Main(string[] args) // Frida Eriksson .NET23
        {
            int Number = 6; // Number I have decided to save

            if (Number > 10) // Check to see if number is higher than 10
            {
                Console.WriteLine("Talet är stort!");
            }
            else
            {
                Console.WriteLine("Oj. Lågt tal!");
            }

            Console.WriteLine("Vad heter du?"); // Asking for users name and then uses that name
            string Name = Console.ReadLine();
            Console.WriteLine($"Hej {Name}!");

            for (int i = 0; i <=Number; i++) // Loop that writes all numbers untill my saved number
            {
                Console.WriteLine(i);
            }
        }
    }
}