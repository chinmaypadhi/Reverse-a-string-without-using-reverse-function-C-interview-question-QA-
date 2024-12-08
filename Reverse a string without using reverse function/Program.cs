using System;

namespace Reverse_a_string_without_using_reverse_function_
{
    class Program
    {

         static void StrReverse(string str)
        {
            char[] arr = str.ToCharArray();
            String str1 = "";

            for(int i=arr.Length-1;i>=0;i--)
            {
                str1 += arr[i];
            }
            Console.WriteLine(str);
            Console.WriteLine(str1);
        }
        static void Main(string[] args)
        {
            StrReverse("Chinmay");
            Console.ReadLine();
        }
    }
}
