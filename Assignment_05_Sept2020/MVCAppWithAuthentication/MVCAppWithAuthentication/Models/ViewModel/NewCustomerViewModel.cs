﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCAppWithAuthentication.Models.ViewModel
{
    public class NewCustomerViewModel
    {
      public IEnumerable<MemberShipType> memberShipTypes { get; set; }
    
      public Customers Customer { get; set; }
    }
}