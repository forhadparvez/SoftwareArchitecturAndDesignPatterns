using System.Collections.Generic;

namespace StructuralPattern.AdapterPattern
{
    public interface ITerget
    {
        List<Product> GetProducts();
    }
}