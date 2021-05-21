using System;

namespace test0518
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Test!");
            try
            {
                Console.WriteLine("input test num!");
                string inputData = Console.ReadLine();
                int testNum = Convert.ToInt32(inputData);
                Divide testDivide = new Divide();
                testDivide.TestNum = testNum;
                for (int i = 1; i <= testDivide.TestNum; i++)
                {
                    Console.WriteLine("Test num {0}: input x and y!", i.ToString());
                    inputData = Console.ReadLine();
                    double testDataX = Convert.ToDouble(inputData);
                    inputData = Console.ReadLine();
                    double testDataY = Convert.ToDouble(inputData);
                    testDivide.setData(testDataX, testDataY);
                    double testResult = testDivide.getResult();
                    Console.WriteLine("output divide result: {0}", testResult.ToString());
                }
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
