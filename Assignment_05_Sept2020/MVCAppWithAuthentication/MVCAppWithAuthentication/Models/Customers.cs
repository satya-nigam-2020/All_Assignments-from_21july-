using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCAppWithAuthentication.Models
{
    public class Customers
    {
        public int Id { get; set; }
        [Required]
        [StringLength(30)]
        public string Name { get; set; }
        public bool IsSubscribedToNewsLetter { get; set; }
        public MemberShipType MemberShipType { get; set; }

        public int MembershipTypeId { get; set; }

        [Min18YrsIfMember]
        public DateTime DateOfBirth { get; set; }

    }
}