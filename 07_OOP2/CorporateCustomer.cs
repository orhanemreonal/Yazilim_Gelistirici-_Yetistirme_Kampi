﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_OOP2
{
    //Miras - Inheritance
    internal class CorporateCustomer:Customer
    {
        public string CompanyName { get; set; }
        public string TaxNo { get; set; }
    }
}
