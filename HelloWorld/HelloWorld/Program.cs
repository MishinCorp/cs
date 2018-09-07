using System;
namespace HelloWorld
{
    /// <summary>
    /// Класс Program.
    /// Основной класс программы, выводящей текст на экран.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Метод Main() является входной точкой работы программы.
        /// </summary>
        /// <param name="args">Аргумент метода Main()</param>
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.Write("Как тебя зовут? ");
            string name = Console.ReadLine();
            Console.WriteLine($"Привет, {name}");
            Console.WriteLine("{0} - изучает CSharp!", name);
            
            Console.ReadKey();
        }
    }
}
