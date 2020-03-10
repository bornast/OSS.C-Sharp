using System;

namespace Solution2
{
    class Program
    {
        static void Main(string[] args)
        {
            var longValue = long.MaxValue;

            int intValue;

            try
            {
                // checks if there is a overflow and in that case, throws an exception 
                checked
                {
                    intValue = (int)longValue;
                }
                
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
