using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp.Repository;

namespace ConsoleApp.Lambda
{
    class LambdaSample1
    {

        //public static void Main(string[] args)
        //{
            // () => ...
            // x => ...
            // (x,y) => ...
            //Func<int, int> squareDelegate = number => number*number;
            //int squaredNumber = squareDelegate(5);
            //Console.WriteLine(squaredNumber); // 25

            //const int factor = 8;
            //Func<int, int> multiplerDelegate = n => n*factor;
            //int returnValue = multiplerDelegate(5);
            //Console.WriteLine(returnValue); // 40
            
            // pass in Predicate
            //var books = new BookRepository().GetBooks();
            //var cheaperBooks = books.FindAll(IsCheaperThan200);
            //foreach (var cheapBook in cheaperBooks)
            //{
            //    Console.WriteLine(cheapBook.Name);
            //}
            //Console.WriteLine("============");
            //// do the same thing with Lambda expression
            //var expensiveBooks = books.FindAll(book => book.Price > 200);
            //foreach (var expensiveBook in expensiveBooks)
            //{
            //    Console.WriteLine(expensiveBook.Name);
            //}
        //}

        static bool IsCheaperThan200(Book book)
        {
            if (book.Price<=200)
                return true;
            return false;
        }

    }
}
