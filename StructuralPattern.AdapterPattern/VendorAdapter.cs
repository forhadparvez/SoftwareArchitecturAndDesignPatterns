using System.Collections.Generic;

namespace StructuralPattern.AdapterPattern
{
    public class VendorAdapter:ITerget
    {
        private readonly VendorAdaptee _adaptee;

        public VendorAdapter()
        {
            _adaptee=new VendorAdaptee();
        }
        
        public List<Product> GetProducts()
        {
            var products = _adaptee.GetAllProducts();

            var productList=new List<Product>();

            foreach (var p in products)
            {
                var product=new Product(){Name = p};
                productList.Add(product);
            }

            return productList;
        }
    }
}