using System;
using System.Collections.Generic;
using System.Linq;

namespace SmallestNumber
{
    internal class Program
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();
            Console.WriteLine(GetSmallest(numbers));
        }

        public static int GetSmallest(List<int> numbers)
        {
            if (numbers.Count == 0)
            {
                throw new ArgumentException("The list of should contain at list one element");
            }

            int possibleMin1 = numbers.First();

            if (numbers.Count == 1)
            {
                return possibleMin1;
            }

            int possibleMin2 = GetSmallest(numbers.Skip(1).ToList());

            return possibleMin1 < possibleMin2 ? possibleMin1 : possibleMin2;
        }
    }
}
