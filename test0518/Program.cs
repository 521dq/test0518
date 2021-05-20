using System;

namespace test0518
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test 2!");
            try
            {
                string testData1 = Console.ReadLine();
                char[] x = testData1.ToCharArray();
                Console.WriteLine("input string length: {0}", x.Length);
            }
            catch(Exception err)
            {
                Console.WriteLine("error: {0}", err);
            }
            finally
            {
                Console.WriteLine("finally");
            }
            Console.ReadKey();
        }
    }
}
