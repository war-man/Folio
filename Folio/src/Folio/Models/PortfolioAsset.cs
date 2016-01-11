﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Folio.Models
{
    public class PortfolioAsset
    {
        int ID { get; set; }

        [ForeignKey("Portfolio")]
        int PortfolioID { get; set; }

        [ForeignKey("Asset")]
        string AssetSymbol { get; set; }

        //stock, bond, etc.
        string AssetType { get; set; }
        public virtual Portfolio Portfolio { get; set; }

    }
}