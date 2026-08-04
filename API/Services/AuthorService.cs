using API.Models;
using API.Repositories;
using API.RequestHandling;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Text.Json;

namespace API.Services
{
    public class AuthorService
    {
        private readonly AuthorRepository _authorRepository;
        public AuthorService(AuthorRepository authorRepository)
        {
            _authorRepository = authorRepository;
        }

        public async Task<RequestReturn<Author>> Insert(Author Author)
        {
            RequestReturn<Author> response = new RequestReturn<Author>();
            try
            {
                var author = await _authorRepository.Get(Author);

                if(author is not null)
                {
                    response.Update(400,Error:true,Message:"Author Already Exists");
                    return response;
                }
                var request = await _authorRepository.Insert(Author);

                response.Update(201, Message: "Successful Insert");
                response.Object = request;
            }
            catch (Exception exception){
                response.HandleException(exception);
            }

            return response;
            //catch (DbUpdateException e)
            //{
            //    throw new DbUpdateException("Fail to Insert Author", e.InnerException);
            //}
            //catch (Exception e)
            //{
            //    throw new Exception("Fail to Conect Database", e.InnerException);
            //}
        }

        public async Task<RequestReturn<Author>> GetById(int Id) {
            RequestReturn<Author> response = new RequestReturn<Author>();
            try { 
                var request = await _authorRepository.Get(Id);

                if(request == null)
                {
                    response.Update(404, Message: "Entity Not Found");
                    return response;
                }

                response.Update(200, Message: "Found");
                response.Object = request;
            }
            catch (Exception exception)
            {
                response.HandleException(exception);
            }
            return response;
        }

        public async Task<RequestReturn<List<Author>>> GetAll()
        {
            RequestReturn<List<Author>> response = new RequestReturn<List<Author>>();
            try
            {
                var request = await _authorRepository.Get();
                response.Update(200, Message: "Found");
                response.Object = request;
            }
            catch (Exception exception)
            {
                response.HandleException(exception);
            }
            return response;
        }

        public async Task<RequestReturn<Author>> Update (int Id,Author Author)
        {
            RequestReturn<Author> response = new RequestReturn<Author>();
            try
            {
                var author = await _authorRepository.Get(Id);

                if (author is null)
                {
                    response.Update(404, Message: "Entity Not Found");
                    return response;
                }

                author.Name = Author.Name;

                var request = await _authorRepository.Update(author);

                response.Update(200, Message: "Updated");
                response.Object = request;
            }
            catch (Exception exception)
            {
                response.HandleException(exception);
            }
            return response;
        }

        public async Task<RequestReturn<Author>> Delete(int Id)
        {
            RequestReturn<Author> response = new RequestReturn<Author>();
            try
            {
                var author = await _authorRepository.Get(Id);

                if(author is null)
                {
                    response.Update(404, Message: "Entity Not Found");
                    return response;
                }

                var request = await _authorRepository.Delete(author);

                response.Update(200, Message: "Deleted");
                response.Object = request;
            }
            catch (Exception exception)
            {
                response.HandleException(exception);
            }
            return response;
        }
    }
}
