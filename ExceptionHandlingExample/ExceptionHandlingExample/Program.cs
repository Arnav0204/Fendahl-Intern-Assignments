using System;


namespace ExceptionHandlingExample
{
    
    class UserDefinedException : Exception
    {
        public UserDefinedException(string message) : base(message)
        {
        }
    }

    
    class ExceptionHandler
    {
        public void HandleSystemException()
        {
            try
            {
                Console.WriteLine("---------------------------- System Exception ----------------------------");
                int a = 10;
                a /= 0; 
            }
            catch (Exception ex)
            {
                Console.WriteLine("System Exception Caught: " + ex.Message);
            }
        }

        public void HandleApplicationException()
        {
            try
            {
                Console.WriteLine("---------------------------- Application Exception ----------------------------");
                int num = 0;
                if (num < 1)
                {
                    throw new UserDefinedException("Custom Exception: Value is less than 1");
                }
            }
            catch (UserDefinedException ex)
            {
                Console.WriteLine("Application Exception Caught: " + ex.Message);
            }
        }

        public void HandleExceptionPropagation()
        {
            try
            {
                Console.WriteLine("---------------------------- Exception Propagation ----------------------------");
                PerformCalculation();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Top-Level Exception Handler Caught: " + ex.Message);
            }
        }

        private void PerformCalculation()
        {
            try
            {
                Console.WriteLine("Inside PerformCalculation method.");
                ComputeResult();
            }
            catch (UserDefinedException ex)
            {
                Console.WriteLine("Exception Caught in PerformCalculation: " + ex.Message);
                throw; 
            }
        }

        private void ComputeResult()
        {
            Console.WriteLine("Inside ComputeResult method.");
            throw new UserDefinedException("Custom Exception: Error occurred in ComputeResult.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ExceptionHandler exceptionHandler = new ExceptionHandler();

            exceptionHandler.HandleSystemException();
            exceptionHandler.HandleApplicationException();
            exceptionHandler.HandleExceptionPropagation();
        }
    }
}