using Books.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Books.Controllers
{
    public class BooksController : ApiController
    {
        // GET api/values
        public HttpResponseMessage Get()
        {
            List<Book> books = new List<Book>();
            try
            {
                books = Repo.GetBooks();
            }
            catch (WebException ex)
            {
                throw ex.InnerException;
            }
            if (books == null)
            {
                var message = string.Format("Books count = {0} found", books.Count);
                HttpError err = new HttpError(message);
                return Request.CreateResponse(HttpStatusCode.NotFound, err);
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.OK, books);
            }
        }

        // GET api/values/5
        public HttpResponseMessage Get(int id)
        {
            List<Book> books = new List<Book>();
            Book book = new Book();
            try
            {
                books = Repo.GetBooks();
                book = books.Where(b => b.Id == id.ToString()).FirstOrDefault();
            }
            catch(WebException ex)
            {
                throw ex.InnerException;
            }

            if (book == null)
            {
                var message = string.Format("Book with id = {0} not found", id);
                HttpError err = new HttpError(message);
                return Request.CreateResponse(HttpStatusCode.NotFound, err);
            }
            else
            {
                return Request.CreateResponse(HttpStatusCode.OK, book);
            }
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
