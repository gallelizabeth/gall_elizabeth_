// Implementing a calculator in
// C# using switch statement.
using System;
using System.Text;
using System.Threading.Tasks;
namespace calculator_c_sharp
{
    class Program
    {
    static void Main(string[] args)
        {
            string value;
            do
            {
                int res;
                Console.Write("Enter first number:");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter second number:");
                int num2 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Choose operation(/, +, -, *, -/, ^, %):");
                string symbol = Console.ReadLine();
                List<str> operations = new List<str> { "/", "+", "-", "*", "-/", "^", "%"};
                if (!operations.Contains(symbol))
                    {
                        Console.WriteLine("WARNING!\n Unknown operation.\n Please choose from given list\n");
                    }
                else
                {
                    switch (symbol)
                    {
                        case "+":
                        if (num1.Length > (10 ** 10))
                        {
                            Console.WriteLine("WARNING!\n This number is too long.\n Please choose another\n");
                        }
                        else
                        {
                            if (num2.Length > (10 ** 10))
                            {
                                Console.WriteLine("WARNING!\n This number is too long.\n Please choose another\n");
                            }
                            else
                            {
                            res = num1 + num2;
                            Console.WriteLine("Addition:" + res);
                            break;
                            }
                        }

                        case "-":
                        if (num1.Length > (10 ** 10))
                        {
                            Console.WriteLine("WARNING!\n This number is too long.\n Please choose another\n");
                        }
                        else
                        {
                            if (num2.Length > (10 ** 10))
                            {
                                Console.WriteLine("WARNING!\n This number is too long.\n Please choose another\n");
                            }
                            else
                            {
                                res = num1 - num2;
                                Console.WriteLine("Subtraction:" + res);
                                break;
                            }
                        }

                        case "*":
                        if (num1.Length > (10 ** 10))
                        {
                            Console.WriteLine("WARNING!\n This number is too long.\n Please choose another\n");
                        }
                        else
                        {
                            if (num2.Length > (10 ** 10))
                            {
                                Console.WriteLine("WARNING!\n This number is too long.\n Please choose another\n");
                            }
                            else
                            {
                                res = num1 * num2;
                                Console.WriteLine("Multiplication:" + res);
                                break;
                            }
                        }

                        case "/":
                        if (num2 == 0)
                            {
                                Console.WriteLine("WARNING!\n This operation can not be appeared.\n Please choose another number or operation\n");
                            }
                            else
                            {
                                res = num1 / num2
                                Console.WriteLine("Division:" + res);
                                break;
                            }

                        case "%":
                        if (num1.Length > (10 ** 10))
                        {
                            Console.WriteLine("WARNING!\n This number is too long.\n Please choose another\n");
                        }
                        else
                        {
                            if (num2.Length > (10 ** 10))
                            {
                                Console.WriteLine("WARNING!\n This number is too long.\n Please choose another\n");
                            }
                            else
                            {
                                if (num2 == 0)
                                {
                                    Console.WriteLine("WARNING!\n This operation can not be appeared.\n Please choose another number or operation\n");
                                }
                                else
                                {
                                    res = num1 % num2
                                    Console.WriteLine("Division:" + res);
                                    break;
                                }
                            }
                        }
                            

                        case "^":
                        if (num1.Length > (10 ** 10))
                        {
                            Console.WriteLine("WARNING!\n This number is too long.\n Please choose another\n");
                        }
                        else
                        {
                            if (num2.Length > (10 ** 10))
                            {
                                Console.WriteLine("WARNING!\n This number is too long.\n Please choose another\n");
                            }
                            else
                            {
                            res = num1 ** num2;
                            Console.WriteLine("Raising to a degree:" + res);
                            break;
                            }
                        }
                        case "-/":
                        if (num1.Length > (10 ** 10))
                        {
                            Console.WriteLine("WARNING!\n This number is too long.\n Please choose another\n");
                        }
                        else
                        {
                            if (num2.Length > (10 ** 10))
                            {
                                Console.WriteLine("WARNING!\n This number is too long.\n Please choose another\n");
                            }
                            else
                            {
                                if (num2 == 0)
                                    {
                                    Console.WriteLine("WARNING!\n This operation can not be appeared.\n Please choose another number or operation\n");
                                    }
                                else
                                {
                                    if (num2 < 0)
                                        {
                                        Console.WriteLine("WARNING!\n This operation can not be appeared.\n Please choose another number or operation\n");
                                        }
                                }
                                    else
                                    {
                                        res = num1 ** (1/num2);
                                        Console.WriteLine("Addition:" + res);
                                        break;
                                    }
                            }
                        }
                        default:
                            Console.WriteLine("Wrong input");
                            break;
                    }
                    Console.ReadLine();
                    Console.Write("Do you want to continue(y/n):");
                    value = Console.ReadLine();
                }
            }
            while (value=="y" || value=="Y");
        }
    }
}