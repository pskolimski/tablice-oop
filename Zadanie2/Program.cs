using System;

namespace Zadanie2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            StaticTable numbers = new StaticTable(new double[3] { 1, 2, 3 });
            
            Console.WriteLine("Tablica przed zmianami:");
            Console.WriteLine(numbers.toString());
            
            Console.WriteLine("Tablica po dodaniu elementu 4:");
            numbers.addItem(4);
            Console.WriteLine(numbers.toString());
            
            Console.WriteLine("Tablica po usunięciu elementu 2:");
            numbers.deleteItem(2);
            Console.WriteLine(numbers.toString());
        }
    }
}