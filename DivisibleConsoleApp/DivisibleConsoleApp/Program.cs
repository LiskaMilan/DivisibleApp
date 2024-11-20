namespace DivisibleConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            var endNumber = 100;
            var divisibleBy2OutputDefault = "foo";
          

            Console.WriteLine("Prosím, napíšte koľko čísiel sa má vypísať.\nAk nezadáte nič, záporné číslo alebo slová, bude sa brať default ( 100 )");

            if (int.TryParse(Console.ReadLine(), out int endReadNumber) && endReadNumber > 0)
            {
                endNumber = endReadNumber;
            }

            var divisibleBy2Output = GetStringFromUser(
                 $"Prosím, napíšte čo sa má vypísať, ak je deliteľné číslom 2.\nAk nič nezadáte, tak sa berie default ({divisibleBy2OutputDefault}):",
                 divisibleBy2OutputDefault
             );

            var divisibleBy4OutputDefault = divisibleBy2Output + "fuu";

            var divisibleBy4Output = GetStringFromUser(
                $"Prosím, napíšte čo sa má vypísať, ak je deliteľné číslom 4.\nAk nič nezadáte, tak sa berie combinácia {divisibleBy2Output} a (fuu):",
                divisibleBy4OutputDefault
            );

            PrintNumbers(1, endNumber, divisibleBy2Output, divisibleBy4Output);

            // Keep the console open
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        static string GetStringFromUser(string message, string defaultValue)
        {
            Console.WriteLine(message);
            string input = Console.ReadLine();
            return string.IsNullOrEmpty(input) ? defaultValue : input;
        }

        /// <summary>
        /// Vypísanie čísiel
        /// </summary>
        /// <param name="start">Začiatočné číslo</param>
        /// <param name="end">Posledné číslo</param>
        static void PrintNumbers(int start, int end, string divisibleBy2Output = "foo", string divisibleBy4Output = "foofuu")
        {
            for (int i = start; i <= end; i++)
            {
                Console.WriteLine(GetOutput(i, divisibleBy2Output, divisibleBy4Output));
            }
        }

        /// <summary>
        /// Vracanie správneho stringu
        /// </summary>
        /// <param name="number"></param>
        /// <returns></returns>
        public static string GetOutput(int number, string divisibleBy2Output = "foo", string divisibleBy4Output = "foofuu")
        {
            if (number % 4 == 0)
                return divisibleBy2Output + divisibleBy4Output;
            if (number % 2 == 0)
                return divisibleBy2Output;

            return number.ToString();
        }
    }
}
