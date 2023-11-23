using System;

namespace Zadanie2
{
    public class UniqueTable
    {
        public double[] Numbers { get; set; }
        
        public UniqueTable(double[] numbers)
        {
            Numbers = numbers;
        }
        
        public void addItem(double newItem)
        {
            foreach (var number in Numbers)
            {
                if (newItem == number)
                {
                    Console.WriteLine("Wprowadzony element już istnieje w tej tablicy!");
                    return;
                }
            }
            
            double[] newNumbers = new double[Numbers.Length + 1];
            
            for (int i = 0; i < Numbers.Length; i++)
            {
                newNumbers[i] = Numbers[i];
            }
            
            newNumbers[newNumbers.Length - 1] = newItem;
            Numbers = newNumbers;
        }

        public string toString()
        {
            string numbersString = String.Join(", ", Numbers);
            return numbersString;
        }
        
        public void deleteItem(int element)
        {
            // if not exists print error
            bool exists = false;
            foreach (var number in Numbers)
            {
                if (element == number)
                {
                    exists = true;
                }
            }
            
            if (!exists)
            {
                Console.WriteLine("Wprowadzony element nie istnieje w tej tablicy!");
                return;
            }
            
            double[] newNumbers = new double[Numbers.Length - 1];
            int newNumbersIndex = 0;
            
            for (int i = 0; i < Numbers.Length; i++)
            {
                if (Numbers[i] == element)
                {
                    continue;
                }
                
                newNumbers[newNumbersIndex] = Numbers[i];
                newNumbersIndex++;
            }
            
            Numbers = newNumbers;
        }
    }
}