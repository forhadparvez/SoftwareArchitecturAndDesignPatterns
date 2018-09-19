using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPattern.AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Shopping Protal Client
            ITerget adapter=new VendorAdapter();
            foreach (var product in adapter.GetProducts())
            {
                Console.WriteLine(product.Name);
            }

            Console.ReadKey();
        }
    }
}
