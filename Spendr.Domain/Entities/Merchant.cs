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
      public ICollection<MerchantAddress> MerchantAddress { get; set; }
      public ICollection<MerchantContact> MerchantContact { get; set; }

    }
}
