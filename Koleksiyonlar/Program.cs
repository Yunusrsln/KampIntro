using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] { "Yunus","Yusuf","Rabia","Musavet"};
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);

            //isimler = new string[5];
            //isimler[4] = "Aile";
            //Console.WriteLine(isimler[4]);

            List<string> isimler2 = new List<string> { "Yunus", "Yusuf", "Rabia", "Musavet" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            //isimler2.Add("Aile");
            Console.WriteLine(isimler2[4]);
            //buraya writeline içine yukarıdaki array değerlerinden birini tekrar girdiğinde
            //öncesinde okunduğu için okumuş olacak ama panelde en alt satırda bir boşluk olacak
            //değer tekrar yazılmayacak

        }
    }
}
