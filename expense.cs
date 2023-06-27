using System;
using System.Collections.Generic;

namespace ExpenseTracker
{
    class Expense
    {
        public string Category { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
    }
}