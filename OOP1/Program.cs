using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.PrductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;


            Product product2 = new Product {Id =2,CategoryId=5,
                UnitsInStock=5,PrductName="Kalem",UnitPrice=35};

            ProductManager productManager  = new ProductManager();
            productManager.Add(product1);
            Console.WriteLine(product1.PrductName);

           
        }
    }
}
//int sayi = 100;
//productManager.BiseyYap(sayi);
//Console.WriteLine(sayi);==100


//string isim = "Engin";
//int,double,bool= değer tip
//diziler,class,abstract class,interface = referans tip
