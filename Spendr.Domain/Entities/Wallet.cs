using System;
using System.Collections.Generic;
using System.Text;

namespace Spendr.Domain.Entities
{
   public  class Wallet : BaseEntity
    {
        public string Address { get; set; }
        public decimal Balance { get; set; }

        //navigational property
        public ICollection<WalletTransaction> WalletTransactions { get; set; }
    }
}
