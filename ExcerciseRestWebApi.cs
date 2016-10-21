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

// GET: api/Second
public IEnumerable<Book> Get()
{
    return books;
}

// GET: api/Second/5
public Book Get(int id)
{
    return books.FirstOrDefault(b => b.ID == id);
}
