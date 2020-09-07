using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCAppWithAuthentication.Models.ViewModel
{
    public class NewMoviesViewModel
    {
        public IEnumerable<General> VGenerals { get; set; }
        public Movies VMovies { get; set; }
        public int? Id { get; set; }
        public string Name { get; set; }
        public int ?GenreId { get; set; }
    }
}