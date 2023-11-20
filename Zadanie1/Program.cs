using System;

namespace PS_ZadanieTablice
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            DynamicTable numbers = new DynamicTable(new double[3] { 1, 2, 3 });
            Console.WriteLine("Liczby sprzed edycji");
            Console.WriteLine(numbers.toString());
            
            Console.WriteLine("Tablica po dodaniu liczby 5 i usunięciu elementu o indeksie 1");
            numbers.addItem(5);
            numbers.deleteItem(1);
            Console.WriteLine(numbers.toString());
        }
    }
}