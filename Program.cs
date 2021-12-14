using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanNumberal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Solution("MMMCMXCIX"));
            Console.ReadLine();
        }

        static int Solution(string roman)
        {
            char[] numerals = roman.ToArray();
            int[] convertedNumberArray = new int[roman.Length];
            int finalNumber = 0;

            for (int i = 0; i < roman.Length; i++)
            {
                if (numerals[i].ToString() == "M")
                {
                    convertedNumberArray[i] = 1000;
                }
                else if (numerals[i].ToString() == "D")
                {
                    convertedNumberArray[i] = 500;
                }
                else if (numerals[i].ToString() == "C")
                {
                    convertedNumberArray[i] = 100;
                }
                else if (numerals[i].ToString() == "L")
                {
                    convertedNumberArray[i] = 50;
                }
                else if (numerals[i].ToString() == "X")
                {
                    convertedNumberArray[i] = 10;
                }
                else if (numerals[i].ToString() == "V")
                {
                    convertedNumberArray[i] = 5;
                }
                else if (numerals[i].ToString() == "I")
                {
                    convertedNumberArray[i] = 1;
                }
            }

            int nextNumberal = 1;

            for (int x = 0; x < roman.Length - 1; x++)
            {
                if (convertedNumberArray[x] == 1000)
                {
                    finalNumber = finalNumber + 1000;
                }
                else if (convertedNumberArray[x] == 500)
                {
                    if (convertedNumberArray[x] >= convertedNumberArray[nextNumberal])
                    {
                        finalNumber = finalNumber + 500;
                    }
                    else
                        finalNumber = finalNumber - 500;
                }
                else if (convertedNumberArray[x] == 100)
                {
                    if (convertedNumberArray[x] >= convertedNumberArray[nextNumberal])
                    {
                        finalNumber = finalNumber + 100;
                    }
                    else
                        finalNumber = finalNumber - 100;
                }
                else if (convertedNumberArray[x] == 50)
                {
                    if (convertedNumberArray[x] >= convertedNumberArray[nextNumberal])
                    {
                        finalNumber = finalNumber + 50;
                    }
                    else
                        finalNumber = finalNumber - 50;
                }
                else if (convertedNumberArray[x] == 10)
                {
                    if (convertedNumberArray[x] >= convertedNumberArray[nextNumberal])
                    {
                        finalNumber = finalNumber + 10;
                    }
                    else
                        finalNumber = finalNumber - 10;
                }
                else if (convertedNumberArray[x] == 5)
                {
                    if (convertedNumberArray[x] >= convertedNumberArray[nextNumberal])
                    {
                        finalNumber = finalNumber + 5;
                    }
                    else
                        finalNumber = finalNumber - 5;
                }
                else if (convertedNumberArray[x] == 1)
                {
                    if (convertedNumberArray[x] == convertedNumberArray[nextNumberal])
                    {
                        finalNumber = finalNumber + 1;
                    }
                    else
                        finalNumber = finalNumber - 1;
                }
                nextNumberal++;
            }
            finalNumber = finalNumber + convertedNumberArray[roman.Length - 1];
            return finalNumber;
        
        }
    }
}

