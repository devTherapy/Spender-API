using System;
using System.Collections.Generic;
using System.Text;

namespace Spendr.Domain.Entities
{
    public class MerchantAddress : BaseEntity
    {
        public string StreetNumber { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public int PostalCode { get; set; }
        public string MerchantId { get; set; }
        //public string MerchantId { get; set; }

        //navigational properties
        public Merchant Merchant { get; set; }
    }
}
