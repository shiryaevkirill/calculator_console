using System;

namespace task1_a
{
    class Program
    {
        static void PrintError()
        {
            Console.Clear();
            Console.WriteLine("error");
        }

        static void Main(string[] args)
        {
            double num = 0;
            string[] expr;
            
            double first, second;

            while (true)
            {

                expr = Console.ReadLine().Split(" ");

                if (expr.Length == 1 && expr[0] == "C")
                {
                    num = 0;
                    first = 0;
                    second = 0;
                    Console.Clear();
                }
                else
                {
                    try
                    {
                        second = second = Convert.ToDouble(expr[expr.Length - 1]);
                        if (expr.Length == 3)
                            first = Convert.ToDouble(expr[0]);
                        else first = num;


                        switch (expr[expr.Length - 2])
                        {

                            case "+":
                                num = first + second;
                                break;
                            case "-":
                                num = first - second;
                                break;
                            case "/":
                                if (second == 0)
                                {
                                    num = double.NaN;
                                    PrintError();
                                }
                                else num = first / second;
                                break;
                            case "*":
                                num = first * second;
                                break;

                            default:
                                num = double.NaN;
                                PrintError();
                                break;
                        }

                        if (!double.IsNaN(num))
                        {
                            Console.Clear();
                            Console.WriteLine(num);
                        }
                        else num = 0;
                    }
                    catch
                    {
                        num = 0;
                        PrintError();
                    }
                }
            }

            
        }
    }
}
