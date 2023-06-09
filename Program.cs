namespace DATE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter a date in the format dd.MM.yyyy:");
                string userInput = Console.ReadLine();

                DateTime date = DateTime.ParseExact(userInput, "dd.MM.yyyy", null);
                Console.WriteLine("Converted date: " + date);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

        }
    }
}