using System;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton fromTeachaer = Singleton.GetInstance();
            fromTeachaer.PrintDetails("From Teacher");
            Singleton fromStudent = Singleton.GetInstance();
            fromStudent.PrintDetails("From Student");

            Console.WriteLine("********************************\n");
            Console.WriteLine("Thread Safe");
            Console.WriteLine("********************************\n");

            Parallel.Invoke(
                () => PrintTeacherDetails(),
                () => PrintStudentdetails()
                );



            Console.WriteLine("********************************\n");
            Console.WriteLine("Lazy Load");
            Console.WriteLine("********************************\n");

            /// lazy singleton
            Parallel.Invoke(
               () => LazyPrintTeacherDetails(),
               () => LazyPrintStudentdetails()
               );
            Console.ReadLine();

        }

        private static void LazyPrintStudentdetails()
        {
            LazySingleton fromStudent = LazySingleton.GetInstance;
            fromStudent.PrintDetails("From Student");
        }

        private static void LazyPrintTeacherDetails()
        {
            LazySingleton fromTeacher = LazySingleton.GetInstance;
            fromTeacher.PrintDetails("From Teacher");
        }

        private static void PrintTeacherDetails()
        {
            ThreadSafeSingleton fromTeacher = ThreadSafeSingleton.GetInstance;
            fromTeacher.PrintDetails("From Teacher");
        }
        private static void PrintStudentdetails()
        {
            ThreadSafeSingleton fromStudent = ThreadSafeSingleton.GetInstance;
            fromStudent.PrintDetails("From Student");
        }

    }
}
