using System;
using System.Collections.Generic;
using System.Text;

namespace Spendr.Domain.Entities
{
    public class Card : BaseEntity
    {
        public decimal Value { get; set; }
        public bool isActive { get; set; }
        public string UserId { get; set; }

        //navigational properties
       public  ICollection<CardTransaction>CardTransactions{get; set;}
    }
}
