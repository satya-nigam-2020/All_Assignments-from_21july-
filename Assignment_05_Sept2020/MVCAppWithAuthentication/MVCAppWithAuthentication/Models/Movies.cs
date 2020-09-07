using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCAppWithAuthentication.Models
{
    public class Movies
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string MovieType { get; set; }

        public DateTime ReleaseDate { get; set; }
        [Range(1, 20, ErrorMessage = "Field Number should be between from 1 to 20")]
        public int NoOfStock { get; set; }
   
        
        [Required(ErrorMessage = "Genre Field is Mandatory")]
      
        public General General { get; set; }
        public int GenreId { get; set; }

    }
}