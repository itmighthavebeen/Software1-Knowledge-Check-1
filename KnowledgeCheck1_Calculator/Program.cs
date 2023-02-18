using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeCheck1_Calculator
{
    class Program
/* Program to call the calculator and perform function based on user input                */
/* Program will Add, Subtract, Multiply and Divide                                        */
/* Modified program 2.18.23 by adding Method and Looping to Continue unless asked to stop */
/* Program will continue until a 5 is entered.                                            */
/* Uses a Method or function called InTestMeth to read input from screen                  */
/*  Knowledge Check c ramsey                                                              */
    {
        static void Main(string[] args)
        {
            bool Continue = true;
            while (Continue)
            {
                Console.WriteLine("Hello. Press 1 for addition, 2 for subtraction, 3 for multiplication, 4 for division and 5 to STOP");
                var input = Console.ReadLine();
                var calculator = new Calculator();

                /*check for what is entered */
                switch (input)
                {
                    case "1":
                        /* Call function to get input, validate and Output */
                        InTestMeth("Add", calculator);
                        break;

                    case "2":
                        /* Call function to get input, validate and Output */
                        InTestMeth("Subtract", calculator);                       
                        break;

                    case "3":
                        /* Call function to get input, validate and Output */
                        InTestMeth("Multiply", calculator);                                            
                        break;

                    case "4":
                        /* Call function to get input, validate and Output */
                        InTestMeth("Divide", calculator);
                        break;
                    case "5":
                        /* User entered 5 so time to stop */
                        Console.WriteLine("GoodBye, Isn't Math Grand!");
                        Continue = false;
                        break;
                    default:
                        Console.WriteLine("Unknow Input");
                        break;
                }
                static void InTestMeth(string funct_type, Calculator calculator)
                {
                    string text = "Enter 2 integers to " + funct_type;
                    Console.WriteLine(text);
                    var Number1 = Console.ReadLine();
                    var Number2 = Console.ReadLine();

                    if (int.TryParse(Number1, out int NumOne) && int.TryParse(Number2, out int NumTwo))
                    {

                        if (funct_type == "Add")
                        {
                            Console.Write($"{Number1} + {Number2} = ");
                            Console.Write(calculator.Add(NumOne, NumTwo));
                            Console.WriteLine();
                        }
                        else
                        if (funct_type == "Subtract")
                        {
                            Console.Write($"{Number1} - {Number2} = ");
                            Console.Write(calculator.Subtract(NumOne, NumTwo));
                            Console.WriteLine();

                        }
                        else
                        if (funct_type == "Multiply")
                        {
                            Console.Write($"{Number1} * {Number2} = ");
                            Console.Write(calculator.Multiply(NumOne, NumTwo));
                            Console.WriteLine();
                        }
                        else
                        if (funct_type == "Divide")
                        {
                            Console.Write($"{Number1} / {Number2} = ");
                            Console.Write(calculator.Divide(NumOne, NumTwo));
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.WriteLine("One or more of the numbers is not an int");
                        }
                    }
                }
            }
        }
    }
}