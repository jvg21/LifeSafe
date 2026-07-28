using API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorController : ControllerBase
    {
        private readonly AuthorService _authorService;
        public AuthorController(AuthorService authorService)
        {   
            _authorService = authorService;
        }

        [HttpGet]
        public Author Insert([FromBody]Author author)
        {
            var response = _authorService.Insert(new Author("JK"));
            return author;
        }
    }
}
