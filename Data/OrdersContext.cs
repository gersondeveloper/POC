﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POCOi.Data
{
    public class OrdersContext : DbContext
    {
        public OrdersContext():base()
        {

        }
    }
}
