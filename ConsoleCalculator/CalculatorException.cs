using System;

namespace ConsoleCalculator
{
    class CalculatorException : Exception
    {
        private static readonly string DefaultErrorMessage = "A calculation error has occured. Make sure that" +
            "operation is supported and values are within required ranges.";

        public CalculatorException() : base (DefaultErrorMessage)
        {
            
        }

        public CalculatorException(string message) : base (message)
        {

        }
        /// <summary>
        /// Creates CalculatorException with default error messsage
        /// </summary>
        public CalculatorException(Exception innerException) : base (DefaultErrorMessage, innerException)
        {
            
        }
        /// <summary>
        /// Creates CalculatorException with user defined message
        /// </summary>
        public CalculatorException(string message, Exception innerExecption) : base (message, innerExecption)
        {

        }
    }
}
