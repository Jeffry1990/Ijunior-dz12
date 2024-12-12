namespace ObmennikValut
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string CommandExchangeRubToUsd = "1";
            const string CommandExchangeRubToEuro = "2";
            const string CommandExchangeUsdToRub = "3";
            const string CommandExchangeUsdToEuro = "4";
            const string CommandExchangeEuroToUsd = "5";
            const string CommandExchangeEuroToRub = "6";
            const string CommandExit = "7";

            float rublesInWallet;
            float dollarsInWallet;
            float euroInWallet;
            float exchangeCurrencyCount;

            int courseRubToUsd = 105;
            int courseRubToEuro = 120;
            int courseUsdToRub = 5;
            int courseUsdToEuro = 7;
            int courseEuroToRub = 3;    
            int courseEuroToUsd = 2;

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

                Console.WriteLine($"\nВыберете необходимую операцию:\n{CommandExchangeRubToUsd} - Обменять рубли на доллары" +
                        $"\n{CommandExchangeRubToEuro} - Обменять рубли на евро \n{CommandExchangeUsdToRub} - Обменять доллары на рубли" +
                        $"\n{CommandExchangeUsdToEuro} - Обменять доллары на евро\n{CommandExchangeEuroToUsd} - Обменять евро на " +
                        $"доллары\n{CommandExchangeEuroToRub} - Обменять евро на рубли\n{CommandExit} - выход из программы");
                
                Console.Write("\nВаш выбор: ");
                desiredOperation = Console.ReadLine();

                switch (desiredOperation)
                {
                    case CommandExchangeRubToUsd:
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

                    case CommandExchangeRubToEuro:
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

                    case CommandExchangeUsdToRub:
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

                    case CommandExchangeUsdToEuro:
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

                    case CommandExchangeEuroToUsd:
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

                    case CommandExchangeEuroToRub:
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