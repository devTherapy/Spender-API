using System;
using System.Collections.Generic;
using System.Text;

namespace Spendr.Domain.Entities
{
   public  class CardTransactionCategory : BaseEntity
    {
        public string CategoryName { get; set; }

        //navigational properties
        public CardTransaction CardTransaction { get; set; }
    }
}
