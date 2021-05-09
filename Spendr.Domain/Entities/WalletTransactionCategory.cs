using System;
using System.Collections.Generic;
using System.Text;

namespace Spendr.Domain.Entities
{
    class WalletTransactionCategory : BaseEntity
    {
        public string Name { get; set; }

        //navigational property
        public Wallet Wallet { get; set; }
    }
}
