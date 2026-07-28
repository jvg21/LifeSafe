//aplicar regras de negócio na request e tratar dados


using API.Repositories;

namespace API.Services
{
    public class AuthorService
    {
        private readonly AuthorRepository _authorRepository;
        public AuthorService(AuthorRepository authorRepository)
        {
            _authorRepository = authorRepository;
        }

        public Author Insert(Author author)
        {
            return _authorRepository.Insert(author);
        }
    }
}
