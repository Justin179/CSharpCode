using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Delegate
{

    public delegate void MethodsDelegate();

    class MulticastDelegate
    {

        //public static void Main(string[] args)
        //{
        //    // use multiple instances (use +)
        //    MethodsDelegate stub1, stub2, stub3, stub4;
        //    stub1 = new MethodsDelegate(MethodOne);
        //    stub2 = new MethodsDelegate(MethodTwo);
        //    stub3 = new MethodsDelegate(MethodThree);

        //    stub4 = stub1 + stub2 + stub3;
        //    stub4();

        //    Console.WriteLine("==============");
        //    // another way of doing the same thing
        //    // use only one instance (use +=)
        //    var del = new MethodsDelegate(MethodOne);
        //    del += MethodTwo;
        //    del += MethodThree;
        //    del();
        //}

        public static void MethodOne()
        {
            Console.WriteLine("MethodOne Invoked");
        }
        public static void MethodTwo()
        {
            Console.WriteLine("MethodTwo Invoked");
        }
        public static void MethodThree()
        {
            Console.WriteLine("MethodThree Invoked");
        }



    }
}
