using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Spendr.Domain.Entities
{
   public  class User: IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string isActive  { get; set; }
        public string isProfileCompleted { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime LastModifiedDate { get; set; }

        //navigational properties
        public ICollection<Card> Cards { get; set;}
        public Wallet Wallet { get; set;}
        public UserAddress UserAddress { get; set; }
        public UserContact UserContact { get; set; }

    }
}
