using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegation
{
    class Program
    {
        class Book
        {
            public void FileNext(string str)
            {
                Console.WriteLine("Поиск строки:" + str);
            }

        }

        static class FindAndReplaceManager
        {
            static public void FileNext(string str)
            {
                Book a = new Book();
                a.FileNext(str); 
            }
        }

        static void Main(string[] args)
        {
            FindAndReplaceManager.FileNext("Hello");

            Console.ReadKey();
        }
    }
}
