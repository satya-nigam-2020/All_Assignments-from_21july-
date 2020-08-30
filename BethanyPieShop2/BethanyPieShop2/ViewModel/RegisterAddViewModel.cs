using BethanyPieShop2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BethanyPieShop2.ViewModel
{
    public class RegisterAddViewModel
    {
        public IEnumerable<Register> Registers  { get; set; }
        public Address Address { get; set; }
    }
}