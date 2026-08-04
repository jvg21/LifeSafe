using API.Data;
using API.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Repositories
{
    public class AuthorRepository
    {
        private readonly DBContext _context;
        private DbSet<Author> AuthorTable;

        public AuthorRepository(DBContext context)
        {
            _context = context;
            AuthorTable = _context.Authors;
        }

        public async Task<Author> Insert(Author Author)
        {
            var request = await AuthorTable.AddAsync(Author);
            await _context.SaveChangesAsync();
            return request.Entity;
        }

        public async Task<Author?> Get(int Id)
        {
            var request = await AuthorTable.FindAsync(Id);
            return request;

        }

        public async Task<Author?> Get(Author Author)
        {
            var request = AuthorTable.Where(a => a.Name == Author.Name).SingleOrDefault();
            return request;

        }

        public async Task<List<Author>> Get()
        {
            var request = await AuthorTable.AsNoTracking().ToListAsync();
            return request;
        }

        public async Task<Author> Update(Author Author)
        {
            var request = AuthorTable.Update(Author);
            await _context.SaveChangesAsync();

            return request.Entity;
        }
        public async Task<Author?> Delete(Author Author)
        {
            var request = AuthorTable.Remove(Author);
            await _context.SaveChangesAsync();
            return request.Entity;

        }
    }
}