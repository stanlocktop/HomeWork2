namespace SwappingValues
{
    // Поміняти місцями значення двох змінних? Чи можна це зробити без ще однієї тимчасової змінної.
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine("Введіть перше число:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введіть друге число:");
            int b = Convert.ToInt32(Console.ReadLine());

            a = a * b;
            b = a / b;
            a = a / b;

            Console.WriteLine("Значення першої змінної після обміну: " + a);
            Console.WriteLine("Значення другої змінної після обміну: " + b);
            Console.ReadKey();
        }
    }
}
