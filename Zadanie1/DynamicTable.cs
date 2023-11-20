using System;

namespace PS_ZadanieTablice
{
    public class DynamicTable
    {
        private double[] Numbers { get; set; }

        public DynamicTable(double[] numbers) {
            this.Numbers = numbers;
        }

        public void DisplayItems()
        {
            string numbersString = String.Join(", ", Numbers);
            Console.WriteLine(numbersString);
        }
        
        public void AddItem(double newItem)
        {
            double[] newNumbers = new double[Numbers.Length + 1];
            
            for (int i = 0; i < Numbers.Length; i++)
            {
                newNumbers[i] = Numbers[i];
            }
            
            newNumbers[newNumbers.Length - 1] = newItem;
            Numbers = newNumbers;
        }

        public void DeleteItem(int index)
        {
            if (index < 0 || index > Numbers.Length - 1)
            {
                Console.WriteLine("Podano index spoza zakresu. Pominięto.");
                return;
            }
            
            double[] newNumbers = new double[Numbers.Length - 1];
            int newNumbersIndex = 0;
            
            for (int i = 0; i < Numbers.Length; i++)
            {
                if (i == index)
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