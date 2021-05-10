using System;
using System.Collections.Generic;
using System.Text;

namespace Spendr.Domain.Entities
{
    public class CardTransaction : BaseEntity
    {
        public string CardId { get; set; }

        public string CardTransactionCategoryId { get; set; }
        //navigational property
        public CardTransactionCategory CardTransactionCategory { get; set; }
        public Card Card { get; set; }
    }
}
