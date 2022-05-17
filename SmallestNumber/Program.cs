using System;
using System.Collections.Generic;
using System.Linq;

/* 
* The problem description could be found in SMALLEST_NUMBER.md file
* SMALLEST_NUMBER.md is located in the root directory of the project
* Link to the description - https://github.com/kamenminkovcom/recursion-unibit/blob/master/SMALLEST-NUMBER.md
*/

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
                throw new ArgumentException("The list of should contain at least one element");
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
