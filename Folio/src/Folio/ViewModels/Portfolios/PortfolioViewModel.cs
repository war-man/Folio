﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Folio.ViewModels
{
    public class PortfolioViewModel
    {
        public int ID { get; set; }
        public string Name { get; set; }

        [Display(Name = "Date Created")]
        public DateTime DateCreated { get; set; }

        public decimal ExpectedReturn { get; set; }
        public decimal Variance { get; set; }
        public decimal DollarValue { get; set; }
        public IEnumerable<StockViewModel> Stocks { get; set; }
    }
}
