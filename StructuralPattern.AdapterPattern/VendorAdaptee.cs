using System;
using System.Collections.Generic;

namespace StructuralPattern.AdapterPattern
{
    public class VendorAdaptee
    {
        public string[] GetAllProducts()
        {
            string[] product=new string[5];
            product[0] = "Laptop";
            product[1] = "Mobile";
            product[2] = "Headphone";
            product[3] = "Modem";
            product[4] = "Pendrive";
            return product;
        }
    }
}