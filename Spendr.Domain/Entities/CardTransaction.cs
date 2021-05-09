using System;
using System.Collections.Generic;
using System.Text;

namespace Spendr.Domain.Entities
{
    public class CardTransaction : BaseEntity
    {

        //navigational property
        public CardTransactionCategory CardTransactionCategory { get; set; }
        public Card Card { get; set; }
    }
}
