using System;
using System.Collections.Generic;
using System.Text;

namespace Spendr.Domain.Entities
{
    public class WalletTransaction : BaseEntity
    {
        public decimal Balance { get; set; }
        public decimal TransactionAmount { get; set; }
        public string WalletId { get; set; }
        public string WalletTransactionCategoryId { get; set; }
        //navigational property
        public Wallet Wallet { get; set; }
        public WalletTransactionCategory walletTransactionCategory { get; set; }
    }
}
