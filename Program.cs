using System;

namespace Problem
{
    public class Program
    {
        static void Main(string[] args)
        {
           var book=new Book("My Grade");
            book.AddGrade(51);
            book.AddGrade(50);
            book.AddGrade(49);

            var stats=book.GetStatistics();

            Console.WriteLine("Average is {stats.Average:N1}");
            Console.WriteLine("Higher is {stats.High:N1}");
            Console.WriteLine("Lower is {stats.Low:N1}");
        }
    }
}
