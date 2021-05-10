using System;
using System.Collections.Generic;
using System.Text;

namespace Spendr.Domain.Entities
{
   public  class CardTransactionCategory : BaseEntity
    {
        public string CategoryName { get; set; }

        //navigational properties
        public ICollection<CardTransaction> CardTransaction { get; set; }
    }
}
