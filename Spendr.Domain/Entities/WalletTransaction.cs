using System;
using System.Collections.Generic;
using System.Text;

namespace Spendr.Domain.Entities
{
    public class WalletTransaction : BaseEntity
    {
        public decimal Balance { get; set; }
        public decimal TransactionAmount { get; set; }

        //navigational property
        public Wallet Wallet { get; set; }
    }
}
