﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasketLogic.BasketItems
{
    public class BreadItem: BasketItem
    {
        public override decimal Cost
        {
            get
            {
                return 1.0m;
            }
        }
    }
}
