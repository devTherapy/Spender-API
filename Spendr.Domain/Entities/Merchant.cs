using System;
using System.Collections.Generic;
using System.Text;

namespace Spendr.Domain.Entities
{
   public  class Merchant : BaseEntity
    {
        public string Name { get; set; }
        public string CompanyLogo { get; set; }

        //navigational properties
      public  ICollection<MerchantAddress> MerchantAddresses {get; set;}
    }
}
