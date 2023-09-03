namespace Task2

{
    //2) Написати програму, яка обчислює квадрат будь-якого введеного числа.
    public class Example
    {
        public static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.WriteLine("Введіть число, яке хочете обчислити під квадратом: ");
            double num = double.Parse(Console.ReadLine());
            double pow = Math.Pow(num, 2);
            Console.WriteLine("Результат: ");
            Console.WriteLine(pow);
            Console.ReadKey();
        }
    }
}
