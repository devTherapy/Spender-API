using System;
using System.Collections.Generic;
using System.Text;

namespace Spendr.Domain.Entities
{
   public class Role : BaseEntity
    {
        public string Name { get; set; }

        //navigational property
        public User User { get; set; }
    }
}
