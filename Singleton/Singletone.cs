using System;

namespace Singleton
{
    public sealed class Singleton
    {
        private static int counter = 0;
        private static Singleton instance = null;
        private Singleton()
        {
            counter++;
            Console.WriteLine("Counter Value " + counter.ToString());
        }
        public static Singleton GetInstance()
        {
            if (instance == null)
                instance = new Singleton();
            return instance;
        }

        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
    }
}
