using System;

namespace Wrox.ProCSharp.Delegates
{
    delegate double DoubleOp(double x);

    class Program
    {
        static void Main()
        {
            //实例化了一个委托数组DoubleOp
            DoubleOp[] operations =
            {
               MathOperations.MultiplyByTwo,
               MathOperations.Square
            };

            for (int i = 0; i < operations.Length; i++)
            {
                Console.WriteLine("Using operations[{0}]:", i);
                ProcessAndDisplayNumber(operations[i], 2.0);
                ProcessAndDisplayNumber(operations[i], 7.94);
                ProcessAndDisplayNumber(operations[i], 1.414);
                Console.WriteLine();
            }
        }

        static void ProcessAndDisplayNumber(DoubleOp action, double value)
        {
            double result = action(value);  //调用action委托实例封装的方法，返回结果存储在result中
            Console.WriteLine(
               "Value is {0}, result of operation is {1}", value, result);
        }
    }

}
