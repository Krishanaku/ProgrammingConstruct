using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
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

        //3. Write a C# Sharp program to read the age of a candidate and
        //determine whether it is eligible for casting his/her own vote.
        public void AgeEligible()
        {
            Console.WriteLine("Enter Your Age to Check Eligible Or Not : ");
            int firstInteger = Convert.ToInt32(Console.ReadLine());
            if (firstInteger >= 18)
                Console.WriteLine("Eligible");
            else
                Console.WriteLine("Not Eligible");
        }
        //#Write a C# Sharp program to find the largest of three numbers.
        public void LargestOfThree()
        {
            Console.WriteLine("Enter The 3 Integer Value to check Greatest Number: ");
            int firstValue = int.Parse(Console.ReadLine());
            int secondValue = int.Parse(Console.ReadLine());
            int thirdValue = int.Parse(Console.ReadLine());
            if (firstValue > secondValue && firstValue > thirdValue)
                Console.WriteLine($"First Value is greater : {firstValue}");
            else if (secondValue > firstValue && secondValue > thirdValue)
                Console.WriteLine($"Second Value is greater: {secondValue}");
            else if (firstValue == secondValue && firstValue == thirdValue && secondValue == firstValue && secondValue == thirdValue && thirdValue == secondValue && thirdValue == firstValue)
                Console.WriteLine($"All Value are Equals");
            else
                Console.WriteLine($"Third Value is greater : {thirdValue}");
        }
        //Write a C# Sharp program to find the eligibility of admission for a
        //professional course based on the following criteria:
        public void AdmissionEligibility()
        {
            Console.WriteLine("Admission Eligibility Check :-");
            Console.WriteLine("Enter the Marks of Maths : ");
            int maths = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Marks of Physic : ");
            int physic = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Marks of Chemistry : ");
            int chemistry = int.Parse(Console.ReadLine());
            int total = maths + physic + chemistry;
            if (total >= 180)
                Console.WriteLine("You are Eligible for admission");
            else if ((maths + chemistry) >= 140 || (maths + physic) >= 140)
                Console.WriteLine("Also Eligible for admission");
            else
                Console.WriteLine("You are not Eligible for admission");
        }



    }
}
