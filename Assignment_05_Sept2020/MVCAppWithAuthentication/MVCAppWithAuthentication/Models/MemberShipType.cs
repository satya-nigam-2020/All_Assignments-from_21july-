using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCAppWithAuthentication.Models
{
    public class MemberShipType
    {
        public int MemberShipTypeId { get; set; }
        public string Name { get; set; }
        public short SignUpFree { get; set; }
        public byte DurationInMonths { get; set; }
        public byte DisCountRate { get; set; }
    }
}