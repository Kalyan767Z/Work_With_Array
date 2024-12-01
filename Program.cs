using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Globalization;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace Uroks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("The length of the array: ");
            int.TryParse(Console.ReadLine(), out int arrayLength);
            if (arrayLength <= 0)
            {
                Console.WriteLine("\nInvalid array length");
                return;
            }

            int[] myArray = new int[arrayLength];

            for (int i = 0; i < arrayLength; i++)
            {
                Console.Write(i + " element of array: ");
                
                if(!int.TryParse(Console.ReadLine(), out myArray[i]))
                {
                    Console.WriteLine("I can't write an array number");
                    return;
                }
            }

            Console.Write("\nYour array is in the opposite direction: ");

            for (int i = arrayLength - 1; i >= 0; i--)
            {
                Console.Write(myArray[i] + "  ");
            }

            int sumCount = 0;

            for (int i = 0; i < arrayLength; i++)
            {

                if (myArray[i] % 2 == 0)
                {
                    sumCount = sumCount + myArray[i];
                }
            }
            Console.WriteLine("\nThe sum of the even numbers of the array = " + sumCount);

            int smallerNum = myArray[0], biggestNum = myArray[0];

            for (int i = 1; i < arrayLength; i++)
            {
                if (myArray[i] < smallerNum)
                {
                    smallerNum = myArray[i];
                }
                if (myArray[i] > biggestNum)
                {
                    biggestNum = myArray[i];
                }
            }

            Console.WriteLine("The smallest number of the array = " + smallerNum);
            Console.WriteLine("The biggest number of the array = " + biggestNum);
        }
    }
}