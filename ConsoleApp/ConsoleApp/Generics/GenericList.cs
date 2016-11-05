using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Generics
{
    public class GenericList<T>
    {
        public void Add(T value)
        {
            Console.WriteLine();
        }

        public T this[int index]
        {
            get { throw new NotImplementedException(); }
        }
    }
}
