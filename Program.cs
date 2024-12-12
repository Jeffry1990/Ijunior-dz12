namespace ObmennikValut
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string ExchangeRubToUsd = "1";
            const string ExchangeRubToEuro = "2";
            const string ExchangeUsdToRub = "3";
            const string ExchangeUsdToEuro = "4";
            const string ExchangeEuroToUsd = "5";
            const string ExchangeEuroToRub = "6";
            const string CommandExit = "7";

            float rublesInWallet, dollarsInWallet, euroInWallet;
            int courseRubToUsd = 105, courseRubToEuro = 120, courseUsdToRub = 5, 
                courseUsdToEuro = 7, courseEuroToRub = 3, courseEuroToUsd = 2;
            float exchangeCurrencyCount;
            string desiredOperation;
            bool isWork = true;

            Console.WriteLine("Добро пожаловать в обменник валют!");

                while (isWork)
                {
                Console.Write("\nВведите баланс рублей: ");
                rublesInWallet = Convert.ToSingle(Console.ReadLine());
                Console.Write("Введите баланс долларов: ");
                dollarsInWallet = Convert.ToSingle(Console.ReadLine());
                Console.Write("Введите баланс евро: ");
                euroInWallet = Convert.ToSingle(Console.ReadLine());

                Console.WriteLine($"\nВыберете необходимую операцию:\n{ExchangeRubToUsd} - Обменять рубли на доллары" +
                        $"\n{ExchangeRubToEuro} - Обменять рубли на евро \n{ExchangeUsdToRub} - Обменять доллары на рубли" +
                        $"\n{ExchangeUsdToEuro} - Обменять доллары на евро\n{ExchangeEuroToUsd} - Обменять евро на " +
                        $"доллары\n{ExchangeEuroToRub} - Обменять евро на рубли\n{CommandExit} - выход из программы");
                Console.Write("\nВаш выбор: ");
                desiredOperation = Console.ReadLine();

                switch (desiredOperation)
                {
                    case ExchangeRubToUsd:
                        Console.Write($"\nОбмен рубли на доллары\nСколько вы хотите обменять? ");
                        exchangeCurrencyCount = Convert.ToSingle(Console.ReadLine());
                        if (rublesInWallet >= exchangeCurrencyCount)
                        {
                            rublesInWallet -= exchangeCurrencyCount;
                            dollarsInWallet += exchangeCurrencyCount / courseRubToEuro;
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Не хватает рублей!");
                        }
                        break;

                    case ExchangeRubToEuro:
                        Console.Write($"\nОбмен рубли на евро\nСколько вы хотите обменять? ");
                        exchangeCurrencyCount = Convert.ToSingle(Console.ReadLine());
                        if (rublesInWallet >= exchangeCurrencyCount)
                        {
                            rublesInWallet -= exchangeCurrencyCount;
                            euroInWallet += exchangeCurrencyCount / courseRubToUsd;
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Не хватает рублей!");
                        }
                        break;

                    case ExchangeUsdToRub:
                        Console.Write($"\nОбмен доллары на рубли\nСколько вы хотите обменять? ");
                        exchangeCurrencyCount = Convert.ToSingle(Console.ReadLine());
                        if (dollarsInWallet >= exchangeCurrencyCount)
                        {
                            dollarsInWallet -= exchangeCurrencyCount;
                            rublesInWallet += exchangeCurrencyCount * courseUsdToRub;
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Не хватает долларов!");
                        }
                        break;

                    case ExchangeUsdToEuro:
                        Console.Write($"\nОбмен доллары на евро\nСколько вы хотите обменять? ");
                        exchangeCurrencyCount = Convert.ToSingle(Console.ReadLine());
                        if (dollarsInWallet >= exchangeCurrencyCount)
                        {
                            dollarsInWallet -= exchangeCurrencyCount;
                            euroInWallet += exchangeCurrencyCount / courseUsdToEuro;
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Не хватает долларов!");
                        }
                        break;

                    case ExchangeEuroToUsd:
                        Console.Write($"\nОбмен евро на доллары\nСколько вы хотите обменять? ");
                        exchangeCurrencyCount = Convert.ToSingle(Console.ReadLine());
                        if (euroInWallet >= exchangeCurrencyCount)
                        {
                            euroInWallet -= exchangeCurrencyCount;
                            dollarsInWallet += exchangeCurrencyCount * courseEuroToUsd;
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Не хватает евро!");
                        }
                        break;

                    case ExchangeEuroToRub:
                        Console.Write($"\nОбмен евро на рубли\nСколько вы хотите обменять? ");
                        exchangeCurrencyCount = Convert.ToSingle(Console.ReadLine());
                        if (euroInWallet >= exchangeCurrencyCount)
                        {
                            euroInWallet -= exchangeCurrencyCount;
                            rublesInWallet += exchangeCurrencyCount * courseEuroToRub;
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Не хватает евро!");
                        }
                        break;

                    case CommandExit:
                        Console.Clear();
                        Console.Write($"\n{CommandExit}");
                        isWork = false;
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("выбрана неверная команда!");
                        break;
                }
                Console.WriteLine($"\nВаш баланс:\n{rublesInWallet} рублей\n{dollarsInWallet} долларов\n{euroInWallet} евро");
            }
        }
    }
}