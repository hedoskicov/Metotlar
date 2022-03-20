using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    // encapsulation //
    internal class ProductManager
    {

        public void Add( Product product )
        {
            Console.WriteLine(product.ProductName + " : eklendi");

        }
        // void : yap emri //
        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " : güncellendi ");
        }

    }
}
