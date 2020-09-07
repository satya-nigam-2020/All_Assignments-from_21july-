using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCAppWithAuthentication.Models
{
    public class General
    {
        [Key]
        
        public int GenreId { get; set; }
        public string GName { get; set; }
    }
}