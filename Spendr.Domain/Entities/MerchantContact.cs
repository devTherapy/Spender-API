using System;
using System.Collections.Generic;
using System.Text;

namespace Spendr.Domain.Entities
{
   public  class MerchantContact : BaseEntity
    {
        public string CountryCode { get; set; }
        public string AreaCode { get; set; }
        //public string MerchantId { get; set;}

        //navigatonal properties
        public Merchant Merchant { get; set; }
    }
}
