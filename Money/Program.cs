namespace Money
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Money money1 = new Money(10, 50);
            Money money2 = new Money(5, 25);
            Console.WriteLine($"Первая сумма: {money1}");
            Console.WriteLine($"Вторая сумма: {money2}");

            Console.WriteLine($"Сумма: {money1} + {money2} = {money1 + money2}");

            Console.WriteLine($"Разность: {money1} - {money2} = {money1 - money2}");

            Console.WriteLine($"Деление: {money1} / 2 = {money1 / 2}");

            Console.WriteLine($"Умножение: {money2} * 3 = {money2 * 3}");

            Money incremented = money1++;
            Console.WriteLine($"Увеличение: {money1}++ (до увеличения: {money1}, после: {incremented})");

            Money decremented = money2--;
            Console.WriteLine($"Уменьшение: {money2}-- (до уменьшения: {money2} , после:  {decremented})");

            Console.WriteLine("\nДемонстрация сравнения:");
            Console.WriteLine($"{money1} > {money2}: {money1 > money2}");
            Console.WriteLine($"{money1} < {money2}: {money1 < money2}");
            Console.WriteLine($"{money1} == {money2}: {money1 == money2}");
            Console.WriteLine($"{money1} != {money2}: {money1 != money2}");

            Console.WriteLine("\nДемонстрация исключительной ситуации 'Банкрот' при вычитании:");
            try
            {
                Money negativeDiff = money2 - money1;
                Console.WriteLine($"Разность: {money2} - {money1} = {negativeDiff}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }

            Console.WriteLine("\nДемонстрация исключительной ситуации 'Банкрот' при уменьшении:");
            Money zeroMoney = new Money(0, 0);
            try
            {
                zeroMoney--;
                Console.WriteLine($"Уменьшение: {zeroMoney}-- = {zeroMoney}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
            }
        }
    }
}
