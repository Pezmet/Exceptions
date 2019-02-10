using System;

namespace ConsoleCalculator
{
    public class CalculatorOperationNotSupportedException : CalculatorException
    {
        public string Operation { get; }

        public CalculatorOperationNotSupportedException() : base ("Operation out of range.")
        {

        }

        public CalculatorOperationNotSupportedException(string operation) : this()
        {
            Operation = operation;
        }

        public CalculatorOperationNotSupportedException(string message, Exception innerException) : base (message, innerException)  
        {

        }

        public CalculatorOperationNotSupportedException(string operation, string message) : base (message)
        {
            Operation = operation;
        }

        public override string Message
        {
            get
            {
                string message = base.Message;

                if (Operation != null)
                {
                    return Message + Environment.NewLine + $"Unsupported operation: {Operation}";
                }

                return message;
            }
        }
    }
}
