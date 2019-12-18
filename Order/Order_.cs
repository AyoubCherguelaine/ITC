using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Itc
{
    public class Order_ 
    {
        public string ORderDsc;
        public DateTime Date;
        public bool check;

        public Order_(string description, DateTime date)
        {
            this.Date = date;
            ORderDsc = description;
        } 
    }
}