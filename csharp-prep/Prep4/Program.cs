using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        // Ask for a list lets do 6 vals
        List<int> numberList = new List<int>();

        for (int i = 0; i <= 5; i++){
            System.Console.WriteLine("Enter a number: ");
            int number = int.Parse(Console.ReadLine());
            numberList.Add(number);
        }


        // get the sum of the list
        int sum = 0;
        foreach(int num in numberList){
            sum += num;
        }
        System.Console.WriteLine($"The sum of the list is: {sum}");
        // Get the avg of the list
        int average;
        average = sum / numberList.Count;
        System.Console.WriteLine($"The average for the list is: {average}");

        // Get the max of the list
        int max = numberList.Max();
        System.Console.WriteLine($"The largest number in the list is: {max}");

        // Get the smallest positive number
        int posMin;
        List<int> posNumberList = new List<int>();
        foreach (int num in numberList){
            if (num > 0){
                posNumberList.Add(num);
            }
        }
        posMin = posNumberList.Min();
        System.Console.WriteLine($"The smallest positive number is: {posMin}");

        // Sorted list be smallest to highest
        List<int> sortedList = numberList.OrderBy(num => num).ToList();
        System.Console.WriteLine("This is the list sorted in ascending order:");
        System.Console.WriteLine(string.Join(",", sortedList));
        
        System.Console.WriteLine("This is the list sorted in descending order:");
        System.Console.WriteLine(string.Join(",",numberList.OrderByDescending(num => num).ToList()));
    
    }
}