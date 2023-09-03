namespace SwappingValues
{
    //4) Написати програму, яка обчислює середнє арифметичне двох чисел.
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine("Введіть перше число: ");
            double num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введіть друге число: ");
            double num2 = Convert.ToInt32(Console.ReadLine());
            double avg = (num1 + num2) / 2;
            Console.WriteLine("Середнє арифметичне двох чисел: " + avg);
            Console.ReadKey();

        }
    }
}