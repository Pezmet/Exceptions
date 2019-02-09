﻿using System;

namespace ConsoleCalculator
{
    public class Calculator
    {
        public int Calculate(int number1, int number2, string operation)
        {
            //throw new ArgumentNullException(nameof(number1));

            string nonNullOperation = operation ??
                throw new ArgumentNullException(nameof(operation));
            
            //if (operation is null)
            //{
            //    throw new ArgumentNullException(nameof(operation));
            //}
            
            if (nonNullOperation == "/")
            {
                try
                {
                    return Divide(number1, number2);
                }
                catch (DivideByZeroException ex)
                {
                    //Log(ex)
                    //throw; to get the full call stack
                    throw new ArithmeticException("Math error.", ex); //wraping exception
                }
            }
            else
            {
                //Console.WriteLine("Unknown operation.");
                //return 0;
                throw new ArgumentOutOfRangeException(nameof(operation),
                    "Operation not suppoerted yet!");
            }
        }
        
        private int Divide(int number, int divisor)
        {
            return number / divisor;
        }
    }
}

