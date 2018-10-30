using System;
using System.Collections.Generic;
using System.Text;

namespace TestCSharp
{
    class StringClass
    {
        public StringClass(string str)
        {
            str1 = str;
        }
        public void PrintString()
        {
            Console.WriteLine($"TestString = {str1}");
        }
        public void AddString(string addStr)
        {
            str1 += addStr;
        }
        public bool IsStringEqual(string compare)
        {
            return str1.Equals(compare);
        }
        private string str1;
    }
}
