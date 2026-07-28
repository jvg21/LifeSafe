using API.Data;
using Microsoft.EntityFrameworkCore;

namespace API.Repositories
{
    public class AuthorRepository
    {
        private readonly DBContext  _context;
        private DbSet<Author> AuthorTable;

        public AuthorRepository(DBContext context)
        {
            _context = context;
            AuthorTable = _context.Authors;
        }

        public Author Insert(Author Author) {
            AuthorTable.Add(Author);
            _context.SaveChanges();
            return Author;
        }



    }
}
