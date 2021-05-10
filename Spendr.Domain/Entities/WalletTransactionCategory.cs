using System;
using System.Collections.Generic;
using System.Text;

namespace Spendr.Domain.Entities
{
    public class WalletTransactionCategory : BaseEntity
    {
        public string Name { get; set; }

        //navigational property
        public ICollection<WalletTransaction> WalletTransactions { get; set; }
    }
}
