using MVCAppWithAuthentication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MVCAppWithAuthentication.Controllers.API
{
    public class MoviesController : ApiController
    {
        private ApplicationDbContext _context;
        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }
        //GET /api/customers
        public IEnumerable<Movies> GetCustomers()
        {
            return _context.movies.ToList();
        }
        public void DeleteMovie(int id)
        {
            var movieInDb = _context.movies.SingleOrDefault(c => c.Id == id);
            if (movieInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);
            _context.movies.Remove(movieInDb);
            _context.SaveChanges();
        }
    }
}
