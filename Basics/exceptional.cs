namespace MyNameSpace.exception
{
    class ExceptionExample
    {

        public void exceptionExample()
        {

            {
                int d = 0;
                int div = 0;
                try
                {
                    div = 5 / d;
                    // System.Console.WriteLine("This line is not executed...");
                    throw new DivideByZeroException("Invalid division");
                }
                catch (DivideByZeroException)
                {
                    System.Console.WriteLine($"Exceptional occurred... number cannot be divisible by {div}");
                }
                finally
                {
                    System.Console.WriteLine($"Result is {div}");
                }

                try
                {
                    div = 100 / d;
                    System.Console.WriteLine("This line is not executed...");
                    // catching all exceptions
                }
                catch (Exception)
                {
                    System.Console.WriteLine("Exceptional Occurred!!!");
                }
                finally
                {
                    System.Console.WriteLine("finally block!!!");
                }
            }
        }
    }
}