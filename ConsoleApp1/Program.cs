using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task1
            //string sentence = "salam salam salam";
            //char letter = 'a';
            //int result = sentence.CustomLastIndexOf(letter);
            //Console.WriteLine(result);
            #endregion


            #region Task2
            //string text = "Azerbaycan";
            //int result = text.CustomVowelCounter();
            //Console.WriteLine(result);
            #endregion

            static void AreaOfTriangle(double a, double b, double c)
            {
                double P = (a + b + c) / 2;
                double area = Math.Sqrt(P * (P - a) * (P - b) * (P - c));
                Console.WriteLine(area);
            }


            #region Task3
            //AreaOfTriangle(6, 8, 10);
            #endregion

            #region Task4
            string text = "  Hello World ";
            Console.WriteLine(text.CustomTrim());
            //Console.WriteLine(text.CustomOldTrim());

            #endregion
        }
    }
}
