using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FirstMvc.Controllers
{
    public class BooksController : ApiController
    {

        private List<Book> books = new List<Book>()
        {
            new Book
            {
                ID = 1,
                Title = "SOA for Enterprise",
                Author = "Shaun Wildermuth",
            },
            new Book
            {
                ID = 2,
                Title = "WCF in a Nutshell",
                Author = "Scott Guthree",
            },
            new Book
            {
                ID = 3,
                Title = "Advanced C#",
                Author = "John Skeet",
            },
        };

        // GET: api/Books
        public IEnumerable<Book> Get()
        {
            return books;
        }

        // GET: api/Books/5
        public Book Get(int id)
        {
            return books.FirstOrDefault(b => b.ID == id);
        }

        public Book Post(Book book)
        {
            return book;
        }
    }
}
