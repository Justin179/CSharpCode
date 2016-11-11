using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Linq
{
    public class BookRepository
    {
        public IEnumerable<Book> GetBooks()
        {

            return new List<Book>()
            {
                new Book() {Title = "A", Price = 10.0F},
                new Book() {Title = "B", Price = 11.0F},
                new Book() {Title = "C", Price = 12.0F},
                new Book() {Title = "D", Price = 13.0F},
                new Book() {Title = "E", Price = 14.0F}
            };


        }
    }
}
