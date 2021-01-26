using System;

namespace Syntax_Sugar_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            ////for the exercise, write the following with proper syntax sugar
            //int answer = 4;
            //string response;
            //if (answer<9)
            //{
            //    response = answer + "is less than nine";
            //}
            //else
            //{
            //    response = answer + "greater than or equal to nine";
            //}
            //write code below
            var answer = 4;
            var response = (answer < 9) ? $"{answer} is less than nine" : $"{answer} is greater than or equal to nine";

            Console.WriteLine(response);
        }
           
    }
}
