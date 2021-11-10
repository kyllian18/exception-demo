using System;

namespace exceptiondemo
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Index out of range
            try
            {
                int[] numbers = new int[2];

                numbers[0] = 0;
                numbers[1] = 1;
                numbers[2] = 2;

                foreach (int i in numbers)
                {
                    Console.WriteLine(i);
                }
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine($"IndexOutOfRangeException: {e.Message}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Exception: {e.Message}");
            }
            finally
            {
                Console.WriteLine("Finished process, exception thrown");
            }

            // Divide by zero
            try
            {

            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine($"DivideByZeroException: {e.Message}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Exception: {e.Message}");
            }
            finally
            {

            }

            // Argument exception
            try
            {
                Show(null, 59);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine($"ArgumentException: {e.Message}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Exception: {e.Message}");
            }
            finally
            { }

        }

        private static void Divide(int a, int b, string s)
        {
            int result = a / b;

            Console.WriteLine($"{s.ToUpper()}: {result}");
        }

        private static void Show(string fname, int age)
        {
            if (fname == null)
                throw new ArgumentException("Parameter cannot be null", nameof(fname));

            Console.WriteLine($"{fname} is {age} years old");
        }
    }
}