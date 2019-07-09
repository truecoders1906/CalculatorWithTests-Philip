using System;

namespace CalculatorWithTests
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(question);
            string response = Console.ReadLine();
            decimal answer = decimal.Parse(response);
            return answer;
        }
    }
}
