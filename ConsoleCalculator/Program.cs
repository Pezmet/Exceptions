using static System.Console;
using System;

namespace ConsoleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            AppDomain currentDomain = AppDomain.CurrentDomain;
            currentDomain.UnhandledException
                += new UnhandledExceptionEventHandler(HandleException);


            WriteLine("Enter first number");
            int number1 = int.Parse(ReadLine());

            WriteLine("Enter second number");
            int number2 = int.Parse(ReadLine());

            WriteLine("Enter operation");
            string operation = ReadLine().ToUpperInvariant();


            var calculator = new Calculator();

            try
            {
                int result = calculator.Calculate(number1, number2, operation);
                DisplayResult(result);
            }
            //catch (CalculatorOperationNotSupportedException ex)
            //{
            //    //Log.Error(ex);
            //    WriteLine(ex);
            //}
            catch (CalculatorException ex)
            {
                //Log.Error(ex);
                WriteLine(ex);
            }
            catch (Exception ex)
            {
                WriteLine($"We have a problem! {ex}");
            }
            finally
            {
                WriteLine("object dispose example.");
            }



            
            WriteLine("\nPress enter to exit.");
            ReadLine();
        }

        private static void HandleException(object sender, UnhandledExceptionEventArgs e)
        {
            WriteLine($"I will now close. {e.ExceptionObject}");
        }

        private static void DisplayResult(int result)
        {
            WriteLine($"Result is: {result}");
        }
    }
}
