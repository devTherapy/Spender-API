using System;
using System.Collections.Generic;
using System.Text;

namespace Spendr.Domain.Entities
{
   public class UserContact : BaseEntity
    {
        public string CountryCode { get; set; }
        public string AreaCode { get; set; }
        public string UserId { get; set; }
        //navigationa; property
        public User User { get; set; }
    }
}
