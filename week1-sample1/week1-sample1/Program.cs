using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace week1_sample1
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            //Defining variables:strings, ints, and double
            String strFirst, strOperand, strNum1, strNum2;
            Double intNum1 = 0, intNum2 = 0, intResult = 0;
            Double dblResult; //double is similar to a float

            //output hello to the console
            Console.WriteLine("Hello There!");

            //ask for firstname and collect data
            Console.Write("Please enter your first name: ");
            strFirst = Console.ReadLine();

            //return first name with a message
            Console.WriteLine("Hello, " + strFirst + "! Let's do some math!");

            //collect first number
            Console.Write("Please enter the first number: ");
            strNum1 = Console.ReadLine();

            //collect operator
            Console.WriteLine("Please enter the math operation (PLUS, MINUS, MULTIPLY, DIVIDE): ");
            strOperand = Console.ReadLine().ToUpper();

            //collect second number
            Console.Write("Please enter the second number: ");
            strNum2 = Console.ReadLine();

            //convert string entries into int so we can use math operations
            intNum1 = double.Parse(strNum1);
            //another way to convert
            intNum2 = Convert.ToDouble(strNum2);

            //type of if statement, does different actions based on the value of the string passed in the parenthesis
            switch (strOperand)
            {   //if strOperand == "PLUS":
                case "PLUS":
                    intResult = intNum1 + intNum2;
                    break; //add the 2 numbers and leave the statement
                //if strOperand == "MINUS":
                case "MINUS":
                    intResult = intNum1 - intNum2;
                    break;
                case "DIVIDE":
                    intResult = intNum1 / intNum2;
                    break;
                case "MULTIPLY":
                    intResult = intNum1 * intNum2;
                    break;
            }
            dblResult = (Double)intResult; //cast intresult to a double

            //conditional outputs based on operation chosen
            if (strOperand == "PLUS")
            {
                Console.WriteLine("\n\nThe sum of " + intNum1 + " and " + intNum2 + " equals: " + dblResult);
            }
            else if (strOperand == "MINUS")
            {
                Console.WriteLine($"\n\nThe sum of {intNum1} and {intNum2} equals: {dblResult}");
            }
            else if (strOperand == "DIVIDE")
            {
                Console.WriteLine($"\n\nthe quotient of {intNum1} and {intNum2} equals: {dblResult}");
            }
            else if (strOperand == "MULTIPLY")
            {
                Console.WriteLine($"\n\nThe product of {intNum1} and {intNum2} equals: {dblResult}");
            }
            else
            {
                Console.WriteLine("Error, please try again");
            }

                Console.WriteLine("\n\nPress any key to continue"); //so program doesnt end abruptly
            Console.ReadKey();
        }
    }
}
