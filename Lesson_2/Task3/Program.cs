namespace Distance
{
    //3) Дано тризначне число.Знайти число, отримане під час перестановки першої та другої цифр заданого числа.
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.Write("Введіть трьохзначне число: ");
            int num = int.Parse(Console.ReadLine());

            if (num >= 100 && num <= 999)
            {
                // Отримати останню цифру
                int lastNum = num % 10;

                // Отримати другу цифру
                int secondNum = (num / 10) % 10;

                // Отримати першу цифру
                int firstNum = (num / 100) % 10;

                // Перестановка перших двох цифр
                int newNum = lastNum * 100 + secondNum * 10 + firstNum;

                Console.WriteLine("Число з перестановкою перших двох цифр: " + newNum);
                Console.ReadKey();
            }
        }
    }
}
    