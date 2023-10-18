namespace Currency
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Please choose the currency to convert");
            Console.WriteLine(" ____________________________________");
            Console.WriteLine("|     1.USD - US Dollar              |");
            Console.WriteLine("|     2.EUR - Euro                   |");
            Console.WriteLine("|     3.TRY - Turkish Lira           |");
            Console.WriteLine("|     4.RUB - Russian Ruble          |");
            Console.WriteLine("|____________________________________|");

            int choise;
            if (int.TryParse(Console.ReadLine(), out choise))
            {
                if (Enum.IsDefined(typeof(Currency), choise))
                {
                    Currency selectedCurrency = (Currency)choise;
                    Console.Write("Please enter the amount to convert : ");
                    decimal aznAmount;
                    if (decimal.TryParse(Console.ReadLine(), out aznAmount))
                    {
                        decimal Converted = Converter(selectedCurrency, aznAmount);
                        Console.WriteLine($"Converted amount : {Converted}");

                    }
                    else
                    {
                        Console.WriteLine("Invalid");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid choise");
                }
            }
            else
            {

                Console.WriteLine("Invalid Choise.");
            }

            static decimal Converter(Currency ConvertTo, decimal aznAmount)
            {
                decimal calculated = 0;
                decimal factor = 0;
                switch (ConvertTo)
                {
                    case Currency.USD:
                        factor = 0.6m;
                        break;
                    case Currency.EUR:
                        factor = 0.55m;
                        break;
                    case Currency.TRY:
                        factor = 16.5m;
                        break;
                    case Currency.RUB:
                        factor = 57.8m;
                        break;
                }
                calculated = factor*aznAmount;
                return calculated;
            }
        }
    }
}