namespace SwappingValues
{
    // Поміняти місцями значення двох змінних? Чи можна це зробити без ще однієї тимчасової змінної.
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.Write("Введіть перше число: ");
            int number1 = int.Parse(Console.ReadLine());
            Console.Write("Введіть друге число: ");
            int number2 = int.Parse(Console.ReadLine());
            Console.WriteLine("До обміну:");
            Console.WriteLine("Перше число: " + number1);
            Console.WriteLine("Друге число: " + number2);
            number1 = number1 + number2;
            number2 = number1 - number2;
            number1 = number1 - number2;
            Console.WriteLine("Результат:");
            Console.WriteLine("Перше число: " + number1);
            Console.WriteLine("Друге число: " + number2);
            Console.ReadKey();
        }
    }
}
