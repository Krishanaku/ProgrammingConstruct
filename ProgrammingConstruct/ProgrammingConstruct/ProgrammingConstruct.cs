using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammingConstruct
{
    public class ProgrammingConstruct
    {
        //If and Else Statement.
        //1.Write a C# Sharp program to accept two integers and check whether they are equal or not.
        public void AcceptInteger()
        {
            Console.WriteLine("Enter the First Value : ");
            int firstInteger = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Second Value : ");
            int secondInteger = Convert.ToInt32(Console.ReadLine());
            if (firstInteger == secondInteger)
                Console.WriteLine("Both are Equal");
            else
                Console.WriteLine("Both are Different");
        }

        //Even Odd
        //2. Write a C# Sharp program to check whether a given number is even or
        //odd.
        public void EvenOdd()
        {
            Console.WriteLine("Enter the value to check Even Odd : ");
            int firstInteger = Convert.ToInt32(Console.ReadLine());
            if (firstInteger % 2 == 0)
                Console.WriteLine("Even Number");
            else
                Console.WriteLine("Odd Number");
        }
    }
}
