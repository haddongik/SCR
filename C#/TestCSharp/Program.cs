using System;

namespace TestCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 3;
            float b = 10.5f;
            double c = 10.123;
            char d = 'a';
            string e = "abc";
            Console.WriteLine("Hello World!");
            Console.WriteLine("TestLine2");
            Console.WriteLine("a={0}, b={1}, c={2}, d={3}, e={4}", a, b, c, d,e);
            Console.WriteLine("Test={0}", ++a + a++);

            int val1 = 10;
            int val2 = 20;
            float val3 = 1.5f;
            float val4 = 2.5f;
            Swap1(val1, val2);
            Console.WriteLine("val1 = {0}, val2 = {1}", val1, val2);
            Swap2(ref val1, ref val2);
            Console.WriteLine("val1 = {0}, val2 = {1}", val1, val2);
            Swap2(ref val3, ref val4);
            int result1 = FuncParams(10);
            int result2 = FuncParams(10,20,30);
            Console.WriteLine($"result = {result1}, result2 = {result2}");

            int[] arr = { 10, 20, 30, -10, 50 };
            //foreach(int test in arr)
            for(int i=0; i < arr.Length; ++i)
            {
                Console.WriteLine($"{arr[i]}");
            }

            StringClass strClass = new StringClass("Hello, My C# World.\n");
            strClass.PrintString();
            strClass.AddString("My Name is Ha.\n");
            strClass.PrintString();
            Console.WriteLine("StringisEqual? : {0}\n", strClass.IsStringEqual("asdqweasd"));
        }

        static void Swap1(int val1, int val2)
        {
            int temp = val1;
            val1 = val2;
            val2 = temp;
        }

        static void Swap2(ref int val1, ref int val2)
        {
            int temp = val1;
            val1 = val2;
            val2 = temp;
        }

        static void Swap2(ref float val1, ref float val2)
        {
            float temp = val1;
            val1 = val2;
            val2 = temp;
        }

        static int FuncParams(params int[] arr)
        {
            int result = 0;
            foreach(int a in arr)
            {
                result += a;
            }
            return result;
        }
    }
}
