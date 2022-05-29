using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class ThreadSafeSingleton
    {
        private static int counter = 0;
        private static readonly object InstanceLock = new object();
        private ThreadSafeSingleton()
        {
            counter++;
            Console.WriteLine("Counter Value " + counter.ToString());
        }
        private static ThreadSafeSingleton instance=null;
        public static ThreadSafeSingleton GetInstance
        {
            get
            {
                lock (InstanceLock)
                {
                    if (instance == null)
                    {
                        instance = new ThreadSafeSingleton();
                    }
                    return instance;
                }
            }
        }

        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
    }
}
