using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    class ProductManager
    {
        public void Add(Product product)
        {
            Console.WriteLine(product.PrductName+"eklendi.");
        }
        public void Update(Product product)
        {
            Console.WriteLine(product.PrductName + "güncellendi.");
        }

      
    }
}
//public void BiseyYap(int  sayi)
//{
//  sayi = 99;
//}
