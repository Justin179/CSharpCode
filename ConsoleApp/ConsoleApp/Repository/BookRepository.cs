using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Repository
{
    class BookRepository
    {
        public List<Book> GetBooks()
        {
            return new List<Book>()
            {
                new Book(){Name="自卑與超越",Price=180},
                new Book(){Name = "驚人習慣力",Price=190},
                new Book(){Name = "網站開發美學",Price=350}
            };
        }
    }
}
