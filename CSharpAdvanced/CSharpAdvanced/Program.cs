using System;
using System.Collections.Generic;

namespace GenericsExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // bool e = Calculator.AreEqual(1, 2);  ---------- Regular

            bool e = Calculator.areEqual<string>("Bhavya", "Divyanshi"); // ---------- Type independent and yet strongly typed
           // bool  = Calculator.areEqual<int>("Bhavya", "Divyanshi"); -------- will throw error

            if (e==false)
            {
                Console.WriteLine("Not equal");
            }
            else
            {
                Console.WriteLine("Equal");
            }
        }
    }

    class Calculator
    {
        //Object and Datatype restriction
        //public static bool AreEqual(int a, int b)
        //{
        //    return a == b;
        //}

        //Using object would lead to boxing and unboxing(performance issues) and removes the concept of having strongly types fucntion

        public static bool areEqual<T>(T a, T b)
        {
            return a.Equals(b);
        }
    }
     // Class generic
    class GenericClassExample<Ty>
    {
        public static bool equalss(int x, int y)
        {
            return x.Equals(y);
        }
    }
}
