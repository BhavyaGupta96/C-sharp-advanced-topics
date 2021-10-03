using System;

namespace DelegatesEventsExample
{
    class Program
    {
        public delegate void HelloDelegate(string Message);
        static void Main(string[] args)
        {
            HelloDelegate hd = new HelloDelegate(Hello);
            hd("Bhavya");
            hd.Invoke("Invoke Bhavya delegate");
        }

        public static void Hello(string strMessage)
        {
            Console.WriteLine(strMessage);
        }

    }
}
