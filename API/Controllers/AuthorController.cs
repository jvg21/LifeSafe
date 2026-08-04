using API.Models;
using API.Services;
using Azure;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
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

        [HttpPost]
        public async Task<IActionResult> Insert([FromBody] Author author)
        {
            try
            {
            
                var response = await _authorService.Insert(author);
                return StatusCode(response.Status, response);
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }

        }

        [HttpGet]

        [Route("/get")]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                //validar inputs
                //MANDAR PARA O SERVICE
                var response = await _authorService.GetAll();
                return StatusCode(response.Status, response);
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }

        [HttpGet]
        [Route("/get/{id?}")]
        public async Task<IActionResult> GetById(int Id)
        {
            try
            {
                //validar inputs
                //MANDAR PARA O SERVICE
                var response = await _authorService.GetById(Id);
                return StatusCode(response.Status, response);
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }

        [HttpPut]
        [Route("/put/{id?}")]
        public async Task<IActionResult> Update(int Id,[FromBody] Author Author)
        {
            try
            {
                var response = await _authorService.Update(Id,Author);
                return StatusCode(response.Status, response);
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }

        [HttpDelete]
        [Route("/delete/{id?}")]
        public async Task<IActionResult> Delete(int Id)
        {
            try
            {
                var response = await _authorService.Delete(Id);
                return StatusCode(response.Status, response);
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }


    }
}
