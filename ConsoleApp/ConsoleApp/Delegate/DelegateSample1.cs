using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Delegate
{
    


    public delegate void SayHelloDelegate(string word);
    
    public class DelegateSample1
    {
        public static void Main(string[] args)
        {
            var stub = new SayHelloDelegate(SayHello);
            stub("Hello :)");

        }

        public static void SayHello(string word)
        {
            Console.WriteLine(word);
        }
    }
}
